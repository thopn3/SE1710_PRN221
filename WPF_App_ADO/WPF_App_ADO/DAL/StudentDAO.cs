using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App_ADO.DAL
{
    internal class StudentDAO
    {
        // Sử dụng công nghệ ADO.NET để làm việc với DB theo phương pháp Connected
        // Khai báo các đối tượng làm việc với DB
        SqlConnection connection;
        SqlCommand command;
        string strConn = "Server=THOPN\\SQLEXPRESS; database=PRN211DB; uid=sa; pwd=123; TrustServerCertificate=true";

        public List<dynamic> GetAllStudents()
        {
            List<dynamic> students = new List<dynamic>();
            connection = new SqlConnection(strConn);
            string sql = "select * from Students s, Majors m WHERE s.MajorId = m.Id";
            command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    students.Add(new 
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        Gender = reader.GetString("Gender"),
                        Dob = reader.GetDateTime("Dob"),
                        Address = reader.GetString("Address"),
                        MajorId = reader.GetInt32("MajorId"),
                        Married = reader.GetBoolean("Married")?"Yes":"No",
                        Major = reader.GetString("Major")
                    });
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }finally { connection.Close(); }

            return students;
        }


        public List<dynamic> GetAllMajors()
        {
            List<dynamic> majors = new List<dynamic>();
            connection = new SqlConnection(strConn);
            string sql = "select * from Majors";
            command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    majors.Add(new
                    {
                        Id = reader.GetInt32("Id"),
                        Major = reader.GetString("Major")
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { connection.Close(); }

            return majors;
        }
    }
}
