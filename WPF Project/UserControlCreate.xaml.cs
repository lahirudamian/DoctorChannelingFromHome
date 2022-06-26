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
    /// Interaction logic for UserControlCreate.xaml
    /// </summary>
    public partial class UserControlCreate : UserControl
    {
        string inputext;

        public UserControlCreate()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e) { }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            inputext = DieseaseBox.Text;

            List<string> conditions = inputext.Split(',').ToList();

            List<Disease> patientDiseases = new List<Disease>();

            List<Doctor> doctors = new List<Doctor>();

            using (EDatabase eDatabase = new EDatabase())
            {
                List<Disease> diseases = eDatabase.diseases.ToList();

                foreach(var item in diseases)
                {
                    if (WordContains(item,conditions))
                    {
                        if (!checkedIsInList(item,patientDiseases))
                        {
                            patientDiseases.Add(item);
                        }
                    }
                }

                foreach (var disease in patientDiseases)
                {
                    Doctor localDoc = disease.Doctor;

                    if (!doctors.Contains(localDoc))
                    {

                        doctors.Add(eDatabase.doctors.Find(localDoc.DoctorID));

                    }
                }


                foreach(var Doc in doctors)
                {
                    DoctorAppointment doctorAppointment = new DoctorAppointment(Doc);

                    doctorAppointment.Show();
                }
            }


            

            
        }

        private bool WordContains(Disease item,List<string> sysmptoms)
        {
            bool present = false;

            if (sysmptoms.Contains(item.DiseaseName))
            {
                present = true;
            }

            List<string> dieseasesymptoms = item.Symptoms.Split(",").ToList();
            foreach(var symptom in dieseasesymptoms)
            {
                if (sysmptoms.Contains(symptom))
                {
                    present = true;
                }
            }

            return present;
        }

        private bool checkedIsInList(Disease disease, List<Disease> diseases)
        {

            return diseases.Contains(disease);

        }
    }
}
