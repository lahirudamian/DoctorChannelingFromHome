using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_Project.Database;
using System.Linq;
using System.Threading.Tasks;

namespace WPF_Project
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {

            InitializeComponent();

            validCitizen = null;

        }

        string Email;

        string password;

        Citizen validCitizen;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignUp sU = new SignUp();
            sU.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Email = EmailBox.Text;
            password = PasswordBox.Password;

            List<Citizen> citizens;

            using (EDatabase eDatabase = new EDatabase())
            {
                citizens = eDatabase.citizens.ToList();
            }

            foreach(var item in citizens)
            {
                if ((item.email == Email) && (item.Password == password))
                {
                    validCitizen = item;
                    break;
                }
            }

            if(validCitizen == null)
            {
                UserDoesntExist();
            }
            else
            {
                UserIsPresent();
            }

            
        }

        private void UserDoesntExist()
        {
            
                MessageBox.Show("The Email or Password is Incorrect");

                EmailBox.Text = "";

                PasswordBox.Password = "";
            
        }

        private void UserIsPresent()
        {
            MainWindow mainWindow = new MainWindow(validCitizen);

            mainWindow.Show();

            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DoctorLogin doctorLogin = new DoctorLogin();

            doctorLogin.Show();

            this.Close();
        }
    }
}
