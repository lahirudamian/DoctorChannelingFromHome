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
    /// Interaction logic for UserControlBook.xaml
    /// </summary>
    public partial class UserControlBook : UserControl
    {

        List<Doctor> doctors;
        public UserControlBook()
        {
            InitializeComponent();

            using (EDatabase eDatabase=new EDatabase()) {
                doctors = eDatabase.doctors.ToList();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) 
        {
            OpenReservation(11);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            OpenReservation(12);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            OpenReservation(2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            OpenReservation(3);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            OpenReservation(4);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            OpenReservation(5);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            OpenReservation(6);
        }

        private void OpenReservation(int x)
        {
            DoctorAppointment doctorAppointment = new DoctorAppointment(doctors.ElementAt(x-1));
            doctorAppointment.Show();
        }
    }
}
