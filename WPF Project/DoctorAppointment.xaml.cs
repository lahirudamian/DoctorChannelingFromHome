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
    /// Interaction logic for DoctorAppointment.xaml
    /// </summary>
    public partial class DoctorAppointment : Window
    {

        Doctor Doctor;
        public DoctorAppointment()
        {
            InitializeComponent();
        }

        public DoctorAppointment(Doctor doctor)
        {
            Doctor = doctor;
            InitializeComponent();

            DisplayDocDetails();
        }


        private void DisplayDocDetails()
        {
            using(EDatabase eDatabase = new EDatabase())


            {
                Doctor newdoc = eDatabase.doctors.Find(Doctor.DoctorID);

                Reservation reservation = newdoc.reservations.ElementAt(newdoc.reservations.Count - 1);

                Reservation realreservation = eDatabase.reservations.Find(reservation.ReservationID);

                AvailableBox.Text = realreservation.ReservedTime.ToString();

                DocName.Content = Doctor.UserName;


            }
        }
    }
}
