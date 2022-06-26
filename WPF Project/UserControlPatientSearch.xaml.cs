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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Project.Database;
using System.Linq;

namespace WPF_Project
{
    /// <summary>
    /// Interaction logic for UserControlPatientSearch.xaml
    /// </summary>
    public partial class UserControlPatientSearch : UserControl
    {
        string Email;

        string theCurrentCondition;

        string NewCondition;

        Citizen citizen;
        public UserControlPatientSearch()
        {
            InitializeComponent();

            citizen = null;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Email = EmailBox.Text;
            if (checkExistance()!=null)
            {
                PatientDataIsPresent();
            }
            else
            {
                PatientDataNotPresent();
            }
            
        }

        private void PatientDataNotPresent()
        {
            MessageBox.Show("The patient with the email does n't exists");

            EmailBox.Text = "";
        }

        private void PatientDataIsPresent()
        {
            FirstNameBox.Content = citizen.FirstName;

            LastNameBox.Content = citizen.LastName;

            PhoneNoBox.Content = citizen.MobileNo;

            AddressBox.Content = citizen.Address;

            ConditionBox.Content = citizen.Condition;

            IDBox.Content = citizen.CitizenID;
        }


        private Citizen checkExistance() {


            using (EDatabase eDatabase = new EDatabase())
            {
                List<Citizen> citizens = eDatabase.citizens.ToList();

                foreach (var item in citizens)
                {
                    if (item.email == Email)
                    {
                        citizen = item;
                    }
                }

            }
            return citizen;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(citizen != null)
            {
                addtheData();
            }
            else
            {
                MessageBox.Show("Enter a correct email Address");
            }

        }

        private void addtheData()
        {
            theCurrentCondition = NewValues.Text.ToString();

            string temp = citizen.Condition.ToString();

            NewCondition = theCurrentCondition + "," + temp;

            EDatabase eDatabase = new EDatabase();

            Citizen citizen1 = eDatabase.citizens.Find(citizen.CitizenID);

            citizen1.Condition = NewCondition;


            eDatabase.Entry(citizen1).State = System.Data.Entity.EntityState.Modified;

            eDatabase.SaveChanges();
        }


        private void testing()
        {
            EDatabase eDatabase = new EDatabase();

            Citizen citizen1 = eDatabase.citizens.Find(2);

            citizen1.Condition = "";

            eDatabase.Entry(citizen1).State = System.Data.Entity.EntityState.Modified;

            eDatabase.SaveChanges();
        }
    }
}
