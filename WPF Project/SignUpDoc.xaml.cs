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
    /// Interaction logic for SignUpDoc.xaml
    /// </summary>
    public partial class SignUpDoc : Window
    {
        public SignUpDoc()
        {
            InitializeComponent();


        }

        string UserName;

        string Specialization;

        string Address;

        string Email;

        string MobileNo;

        string Password;

        string RePassword;

        private void Button_Click(object sender, RoutedEventArgs e) { }

        private void Button_Click_1(object sender, RoutedEventArgs e) 
        {

            login login = new login();

            login.Show();

            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            UserName = UserNameBox.Text;
            Specialization = SpecializationBox.Text;
            Address = AddressBox.Text;
            Email = EmailBox.Text;
            MobileNo = MobileNOBox.Text;
            Password = PasswordBox.Password;
            RePassword = ConfirmBox.Password;

            if (IsPassEqual())
            {
                PassAreEqual();
            }
            else
            {
                PassAreNotEqual();
            }

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
            ConfirmBox.Password = "";
        }

        private void PassAreEqual()
        {
            if (checkExistance())
            {
                DocExists();
            }
            else
            {
                DocDoesntExist();
            }
        }

        private bool checkExistance()
        {
            bool extistance = false;

            using (EDatabase eDatabase = new EDatabase())
            {
                List<Doctor> doctors = eDatabase.doctors.ToList();

                foreach (var item in doctors)
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

        private void DocExists()
        {
            MessageBox.Show("An Account for this email already Exists");

            EmailBox.Text = "";

        }

        private void DocDoesntExist()
        {
            using (EDatabase eDatabase = new EDatabase())
            {
                Doctor doctor = new Doctor(UserName, MobileNo, Address, Specialization, Email, Password);

                eDatabase.doctors.Add(doctor);
                eDatabase.SaveChanges();

            }
        }
    }
}
