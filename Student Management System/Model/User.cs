using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Model
{
    public class User
    {
        private string? studentID;
        private string? firstName;
        private string? lastName;
        private string gender;
        private int age;
        private string? dateOfBirth;

        [Key]
        public string Reg_No { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Address { get; set; }
           
        public string Telephone_Number { get; set; }

        

        public User()
        {

        }

        public User(string first_name, string last_name, string address, string reg_No, string telephone_Number)
        {
            
            First_name = first_name;
            Last_name = last_name;
            Address = address;
            Reg_No = reg_No;
            Telephone_Number = telephone_Number;
        }
        public User(string id, string pass, string first_name, string last_name, string address, string reg_No, string telephone_Number)
        {
            First_name = first_name;
            Last_name = last_name;
            Address = address;
            Reg_No = reg_No;
            Telephone_Number = telephone_Number;
        }

        
    }
}
