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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        string FirstName;

        string Lastname;

        string Address;

        string Email;

        string MobileNo;

        string Password;

        string RePassword;



        private void Button_Click(object sender, RoutedEventArgs e) 
        {
            FirstName = FirstNameBox.Text;
            Lastname = LastNameBox.Text;
            Address = AddressBox.Text;
            Email = EmailBox.Text;
            MobileNo = MobileNumberBox.Text;
            Password = PasswordBox.Password;
            RePassword = ConformPassBox.Password;

            if (IsPassEqual())
            {
                PassAreEqual();
            }
            else
            {
                PassAreNotEqual();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) { }

        private void Button_Click_2(object sender, RoutedEventArgs e) 
        {
            login login = new login();

            login.Show();

            this.Close();
        }

        private bool IsPassEqual()
        {
            if (Password == RePassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PassAreNotEqual()
        {
            MessageBox.Show("Passwords are not equal");

            PasswordBox.Password = "";
            ConformPassBox.Password = "";
        }


        private void PassAreEqual()
        {
            if (checkExistance())
            {
                UserExists();
            }
            else
            {
                UserDoesntExist();
            }
        }

        private bool checkExistance()
        {
            bool extistance = false;

            using(EDatabase eDatabase = new EDatabase())
            {
                List<Citizen> citizens = eDatabase.citizens.ToList();

                foreach(var item in citizens)
                {
                    if (item.email == Email)
                    {
                        extistance = true;
                        break;
                    }
                }
            }

            return extistance;
        }

        private void UserExists()
        {
            MessageBox.Show("An Account for this email already Exists");

            EmailBox.Text = "";

        }

        private void UserDoesntExist()
        {
            using(EDatabase eDatabase = new EDatabase())
            {
                Citizen citizen = new Citizen(FirstName,Lastname,Password,Email,Address,MobileNo);

                eDatabase.citizens.Add(citizen);
                eDatabase.SaveChanges();

            }
        }



    }
}
