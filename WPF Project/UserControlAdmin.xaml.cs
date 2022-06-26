using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPF_Project
{
    /// <summary>
    /// Interaction logic for UserControlAdmin.xaml
    /// </summary>
    public partial class UserControlAdmin : UserControl
    {
        string DoctorName;

        string Symptoms;

        string DiseaseName;

        public UserControlAdmin()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoctorName = DocNameBox.Text;
            Symptoms = SymptomsBox.Text;
            DiseaseName = DiseaseNameBox.Text;

            using(EDatabase eDatabase = new EDatabase())
            {
                Disease disease = new Disease() { DiseaseName = DiseaseName, Symptoms = Symptoms };

                List<Doctor> doctors = eDatabase.doctors.ToList();

                Doctor doctor = null;

                foreach(var doc in doctors)
                {
                    if (DoctorName == doc.UserName)
                    {
                        doctor = doc;
                    }
                }

                if (doctor != null)
                {
                    Doctor doctor1 = eDatabase.doctors.Find(doctor.DoctorID);

                    disease.Doctor = doctor1;

                    doctor1.Diseases.Add(disease);

                    eDatabase.diseases.Add(disease);

                    eDatabase.Entry(doctor1).State = System.Data.Entity.EntityState.Modified;

                    eDatabase.SaveChanges();
                }
            }
        }
    }
}
