using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Project.Database
{
    public class Disease
    {
        public int DiseaseID { get; set; }

        public string DiseaseName { get; set; }

        public string Symptoms { get; set; }

        public virtual Doctor Doctor { get; set; }

        public Disease()
        {
        }

        public Disease(string diseaseName, string symptoms)
        {
            DiseaseName = diseaseName;
            Symptoms = symptoms;
        }
    }
}
