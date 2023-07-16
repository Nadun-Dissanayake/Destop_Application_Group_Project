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
    public partial class AddAdminWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string user;
        
        [ObservableProperty]
        public string pass;

        [RelayCommand]
        public void save()
        {
            using (UserDataContest context = new UserDataContest())
            {

                
                var User = user;
                var PassWord = pass;



                if (User != null && pass != null)
                {
                    context.admins.Add(new Admin() {  Pass = PassWord, User_Name = User });
                    MessageBox.Show("Sucessfully Enter The Student Records");
                    context.SaveChanges();
                    Window.GetWindow(Application.Current.MainWindow).Close();
                }

            }
        }
    }
}
