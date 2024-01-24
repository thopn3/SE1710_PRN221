using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_App_ADO.DAL;

namespace WPF_App_ADO.UI
{
    /// <summary>
    /// Interaction logic for StudentManagement.xaml
    /// </summary>
    public partial class StudentManagement : Window
    {
        public StudentManagement()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            lvStudents.ItemsSource = null;
            lvStudents.ItemsSource = students;
        }

        private void lvStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dynamic selectedItem = lvStudents.SelectedItem;
            if (selectedItem != null) 
            {
                var gender = selectedItem.Gender;
                if (gender == "Male")
                    rbMale.IsChecked = true;
                if (gender == "Female")
                    rbFemale.IsChecked = true;

                var isMarried = selectedItem.Married;
                if(isMarried=="Yes")
                    chkIsMarried.IsChecked = true;
                else
                    chkIsMarried.IsChecked = false;
            }
        }
        
        public bool CheckInputStudent()
        {
            bool status = true;
            string str = "";

            // Check StudentId
            if(txtId.Text.Length == 0)
            {
                str += "StudentId is required\n";
                status = false;
            }
            else
            {
                if (!int.TryParse(txtId.Text, out _))
                {
                    str += "Invalid format StudentId\n";
                    status = false;
                }
                else
                {
                    var student = students.SingleOrDefault(p => p.Id == int.Parse(txtId.Text));
                    if (student != null)
                    {
                        str += "This StudentId already exists\n";
                        status = false;
                    }
                }
            }
            
            // Check StudentName
            if(txtName.Text.Length == 0) 
            {
                str += "StudentName is required";
                status = false;
            }

            if(status==false && str.Length > 0)
            {
                System.Windows.MessageBox.Show(str);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(CheckInputStudent()==true)
            {
                int id = Convert.ToInt32(txtId.Text);
                string name = txtName.Text;
                string gender = rbMale.IsChecked == true ? "Male" : "Female";
                string dob = dpDob.Text;
                string address = txtAddress.Text;
                string married = chkIsMarried.IsChecked == true ? "Yes" : "No";
                var newStudent = new Student(id, name, gender, dob, address, married);

                students.Add(newStudent);
                System.Windows.MessageBox.Show("Add new success");
                LoadStudents();
            }
        }

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            // Tạo 1 thể hiện của OpenFileDialog
            OpenFileDialog fileDialog = new OpenFileDialog();
            // Thiết lập lọc định dạng file
            fileDialog.Filter = "JSON files|*.json";
            if(fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Lấy đường dẫn của File đã chọn
                var fileName = fileDialog.FileName;
                //System.Windows.MessageBox.Show(filePath);
                try
                {
                    if (File.Exists(fileName))
                    {
                        string jsonData = File.ReadAllText(fileName);
                        students = JsonSerializer.Deserialize<List<Student>>(jsonData);
                        LoadStudents();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files|*.json";
            saveFileDialog.Title = "Save a JSON file";

            if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                string extension = System.IO.Path.GetExtension(fileName);
                
                if(extension == ".json")
                {
                    try
                    {
                        string jsonData = JsonSerializer.Serialize<List<Student>>(students, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(fileName, jsonData);
                        System.Windows.MessageBox.Show("Save to file success.");
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var s = students.SingleOrDefault(s => s.Id == int.Parse(txtId.Text));
                if (s == null)
                    System.Windows.MessageBox.Show("This student did not exists");
                else
                {
                    s.Name = txtName.Text;
                    s.Gender = rbMale.IsChecked == true ? "Male" : "Female";
                    s.Dob = dpDob.Text;
                    s.Address = txtAddress.Text;
                    s.Married = chkIsMarried.IsChecked == true ? "Yes" : "No";

                    System.Windows.MessageBox.Show("Update success");
                    LoadStudents();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var s = students.SingleOrDefault(s => s.Id == int.Parse(txtId.Text));
                if (s == null)
                    System.Windows.MessageBox.Show("This student did not exists");
                else
                {
                    students.Remove(s);
                    System.Windows.MessageBox.Show("Delete success");
                    LoadStudents();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
