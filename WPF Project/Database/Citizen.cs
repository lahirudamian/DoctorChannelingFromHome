using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Project.Database
{
    public class Citizen
    {   
        public int CitizenID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string email { get; set; }

        public string Address { get; set; }

        public string MobileNo { get; set; }

        public string Condition { get; set; }

        public virtual ICollection<Comment> comments { get; set; }

        public Citizen()
        {

        }

        public Citizen(string firstName, string lastName, string password, string email, string address, string mobileNo)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            this.email = email;
            Address = address;
            MobileNo = mobileNo;
        }
    }
}
