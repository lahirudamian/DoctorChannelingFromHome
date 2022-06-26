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
using System.Linq;
using WPF_Project.Database;


namespace WPF_Project
{


    /// <summary>
    /// Interaction logic for UserControlDateReservation.xaml
    /// </summary>
    public partial class UserControlDateReservation : UserControl
    {
        string date;
        string time;
        Doctor MainDoctor;
        public UserControlDateReservation()
        {
            InitializeComponent();
        }


        public UserControlDateReservation(Doctor doctor)
        {
            MainDoctor = doctor;

            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            date = CalenderBox.Text;

            ComboBoxItem comboBoxItem = cboTP.SelectedItem as ComboBoxItem;

            time = comboBoxItem.Content.ToString();

            if (comboBoxItem.Content != null)
            {
                createReservation();
            }
            else
            {
                noCorrectInput();
            }

        }

        private void noCorrectInput()
        {
            MessageBox.Show("No Correct Input");
        }

        private void createReservation()
        {
            DateTime dateTime = DateTime.Parse(date + " " + time);

            Reservation reservation = new Reservation() { ReservedTime = dateTime };

            using(EDatabase eDatabase = new EDatabase())
            {
                Doctor doctor = eDatabase.doctors.Find(MainDoctor.DoctorID);

                reservation.Doctor = doctor;

                doctor.reservations.Add(reservation);

                eDatabase.reservations.Add(reservation);

                eDatabase.Entry(doctor).State = System.Data.Entity.EntityState.Modified;

                eDatabase.SaveChanges();
            }
        }


    }
}
