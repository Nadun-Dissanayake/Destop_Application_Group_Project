
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Student_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Student_Management_System.ViewModel
{
    public partial class NewStudentVm : ObservableObject
    {
        
        [ObservableProperty]
        public string first_name;
        [ObservableProperty]
        public string last_name;
        [ObservableProperty]
        public string address;
        [ObservableProperty]
        public string regno;
        [ObservableProperty]
        public string telno;
        

        [RelayCommand]
        public void save()
        {
            using (UserDataContest context = new UserDataContest())
            {
                
                var Fname = first_name;
                var Lname = last_name;
                var Add = address;
                var RegNo = regno;
                var TelNo = telno;
                



                if(Fname !=null && RegNo != null  ) 
                {
                    context.users.Add(new User() { First_name = Fname, Last_name = Lname, Address = Add, Reg_No = RegNo, Telephone_Number = TelNo});
                    MessageBox.Show("Sucessfully Enter The Student Records");
                    context.SaveChanges();
                    
                }

            }
        }



    }
}
