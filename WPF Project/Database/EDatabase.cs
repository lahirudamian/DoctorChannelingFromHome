
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace WPF_Project.Database
{
    public class EDatabase:DbContext 
    {
        public DbSet<Citizen> citizens { get; set; }

        public DbSet<Comment> comments { get; set; }

        public DbSet<Disease> diseases { get; set; }

        public DbSet<Doctor> doctors { get; set; }

        public DbSet<Reservation> reservations { get; set; }

    }
}
