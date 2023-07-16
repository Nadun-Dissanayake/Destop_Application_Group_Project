using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Model
{
    public partial class Head_Office
    {
        [Key]
        public string User_Name { get; set; }
        public string Pass { get; set; }

        public Head_Office()
        {

        }

    }
}
