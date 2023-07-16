using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Model
{
    public class Result
    {
        [Key]
        public string Id { get; set; }
        public string EE3305 { get; set; }
        public string EE3302 { get; set; }
        public string EE3301 { get; set; }
        public string IS3307 { get; set; }
        public string EE3250 { get; set; }
        public string IS3302 { get; set; }
        public string EE3203 { get; set; }
        public string EE3251 { get; set; } 
        

        public double GPA { get; set; } 

        public Result()
        {

        }

        public Result(string id, string ee3305, string ee3302, string ee3301, string is3307, string ee3250, string is3302, string ee3203, string ee3251, double gpa)
        {
            Id = id;
            EE3305 = ee3305;
            EE3302 = ee3302;
            EE3301 = ee3301;
            IS3307 = is3307;
            EE3250 = ee3250;
            IS3302 = is3302;
            EE3203 = ee3203;
            EE3251 = ee3251;
            GPA = gpa;
        }

        
    }

}
