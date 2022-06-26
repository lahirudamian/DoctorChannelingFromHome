using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Project.Database
{
    public class Doctor
    {
        public int DoctorID { get; set; }

        public string UserName { get; set; }

        public string MobileNo { get; set; }

        public string Address { get; set; }

        public string Specialization { get; set; }

        public string email { get; set; }

        public string Password { get; set; }

        public virtual ICollection<Disease> Diseases { get; set; }

        public virtual ICollection<Reservation> reservations { get; set; }

        public Doctor(string userName, string mobileNo, string address, string specialization, string email, string password)
        {
            UserName = userName;
            MobileNo = mobileNo;
            Address = address;
            Specialization = specialization;
            this.email = email;
            Password = password;
        }

        public Doctor()
        {
        }
    }
}
