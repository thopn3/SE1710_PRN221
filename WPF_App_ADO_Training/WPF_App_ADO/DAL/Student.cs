using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App_ADO.DAL
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Gender { get; set; }
        public string? Dob {  get; set; }
        public string? Address { get; set; }
        public string? Married { get; set; }

        public Student(int id, string name, string? gender, string? dob, string? address, string? married)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Dob = dob;
            Address = address;
            Married = married;
        }
    }
}
