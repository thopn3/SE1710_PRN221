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

namespace WPF_FirstApp
{
    /// <summary>
    /// Interaction logic for LoginUI.xaml
    /// </summary>
    public partial class LoginUI : Window
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Check input
            string msg = string.Empty;
            if(txtEmail.Text == string.Empty) 
            {
                msg += "Email is required.\n";
            }
            if(txtPassword.Password == string.Empty)
            {
                msg += "Password is required.";
            }
            if(msg.Length != 0) 
            {
                MessageBox.Show(msg);
            }
        }
    }
}
