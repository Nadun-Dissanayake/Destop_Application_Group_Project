using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Student_Management_System.Model
{
    public class Admin
    {

        [Key]
        public string User_Name { get; set; }
        public string Pass { get; set; }
    }
}
