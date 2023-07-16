using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Student_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Student_Management_System.ViewModel
{
    public partial class AnalyticsVM : ObservableObject
    {
        [ObservableProperty]
        public string index;
        [ObservableProperty]
        public string ee3305;
        [ObservableProperty]
        public string ee3302;
        [ObservableProperty]
        public string ee3301;
        [ObservableProperty]
        public string is3307;
        [ObservableProperty]
        public string ee3250;
        [ObservableProperty]
        public string is3302;
        [ObservableProperty]
        public string ee3203;
        [ObservableProperty]
        public string ee3251;
        [ObservableProperty]
        public double gpa;

        [RelayCommand]
        public void save()
        {
            using (UserDataContest context = new UserDataContest())
            {
                var Index = index;
                var EE3305 = ee3305;
                var EE3302 = ee3302;
                var EE3301 = ee3301;
                var IS3307 = is3307;
                var EE3250 = ee3250;
                var IS3302 = is3302;
                var EE3203 = ee3203;
                var EE3251 = ee3251;
                var GPA = Math.Round(((moduelgpa(ee3305)*3 + moduelgpa(ee3302)*3 + moduelgpa(ee3301) * 3 + moduelgpa(is3307) * 3 + moduelgpa(ee3250) * 2 + moduelgpa(is3302) * 3 + moduelgpa(ee3203) * 2 + moduelgpa(ee3251) * 2) / 21),4) ;

                
                
                { 
                    context.results.Add(new Result() { Id = index, EE3305 = EE3305, EE3302 = EE3302, EE3301 = EE3301, IS3307 = IS3307, EE3250 = EE3250, IS3302 = IS3302, EE3203 = EE3203, EE3251 = EE3251, GPA = GPA});
                    MessageBox.Show("Sucessfully Enter The Student Records");
                    context.SaveChanges();

                }

            }
        }

        public double moduelgpa(string a)
        {
            double moduelgpa = 0;
            if (a == "A" || a == "A+")
                moduelgpa = 4;
            else if (a == "A-")
                moduelgpa = 3.7;
            else if (a == "B+")
                moduelgpa = 3.3;
            else if (a == "B")
                moduelgpa = 3;
            else if (a == "B-")
                moduelgpa = 2.7;
            else if (a == "C+")
                moduelgpa = 2.3;
            else if (a == "C")
                moduelgpa = 2;
            else if (a == "C-")
                moduelgpa = 1.7;
            else if (a == "E")
                moduelgpa = 0;
            return moduelgpa;
        }

        
        
    } 
}
