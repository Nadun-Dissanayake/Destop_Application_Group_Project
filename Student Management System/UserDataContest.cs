using Microsoft.EntityFrameworkCore;
using Student_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class UserDataContest : DbContext 
    {

        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = UserDetail.db");
        }

        public DbSet<User> users { get; set; }
        public DbSet<Head_Office> heads { get; set; }

        public DbSet<Result> results { get; set; }
       
        public DbSet<Admin> admins { get; set; }

        

    }
}
