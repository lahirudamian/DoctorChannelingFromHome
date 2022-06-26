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

namespace WPF_Project
{
    /// <summary>
    /// Interaction logic for DoctorLogin.xaml
    /// </summary>
    public partial class DoctorLogin : Window
    {

        Doctor MainDoctor;

        string Email;

        string Password;

        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Email = EmailBox.Text;

            Password = PasswordBox.Password;

            if (checkExistance() != null)
            {
                loginAsDoc();
            }
            else
            {
                noSuchDoctor();
            }
        }

        private void noSuchDoctor()
        {
            MessageBox.Show("Invalid Email or PassWord try again");

            EmailBox.Text = "";

            PasswordBox.Password = "";
        }


        private void loginAsDoc()
        {
            DoctorWindow doctorWindow = new DoctorWindow(MainDoctor);

            doctorWindow.Show();

            this.Close();
        }



        private Doctor checkExistance()
        {
            using(EDatabase eDatabase = new EDatabase())
            {
                List<Doctor> doctors = eDatabase.doctors.ToList();

                foreach(var item in doctors)
                {
                    if ((item.email == Email) && (item.Password == Password))
                    {
                        MainDoctor = item;
                        break;
                    }
                }
            }


            return MainDoctor;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Email = EmailBox.Text;

            Password = PasswordBox.Password;

            if ((Email == "admin") && (Password == "admin"))
            {
                LoginAsAdmin();
            }
        }


        private void LoginAsAdmin()
        {
            AdminWindow adminWindow = new AdminWindow();

            adminWindow.Show();

            this.Close();
        }
    }
}
