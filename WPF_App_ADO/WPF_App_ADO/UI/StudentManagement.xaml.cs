using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
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

        StudentDAO studentDAO = new StudentDAO();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadStudents();
            LoadMajors();
        }

        private void LoadMajors()
        {
            try
            {
                cbMajor.ItemsSource = studentDAO.GetAllMajors();
                cbMajor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStudents()
        {
            try
            {
                lvStudents.ItemsSource = studentDAO.GetAllStudents();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
