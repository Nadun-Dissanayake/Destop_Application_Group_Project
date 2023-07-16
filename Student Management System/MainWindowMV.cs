using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;
using Student_Management_System.Model;
using Student_Management_System.ViewModel;

namespace Student_Management_System
{
    public partial class MainWindowMV : ObservableObject
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

        [ObservableProperty]
        public string userName;

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        public User p1;

       
        
        [RelayCommand]
        public void Login1()
        {
            bool userfound_2;
            
            using (UserDataContest context2 = new UserDataContest())
            {
                userfound_2 = context2.admins.Any(admin => admin.User_Name == userName && admin.Pass == password);
            }

            

            if (userfound_2)
            {
                AdminWindow Admin = new AdminWindow();
                Admin.Show();
                Window.GetWindow(Application.Current.MainWindow).Close();
            }
            
            else
            {
                MessageBox.Show("Invalid UserName or Password");
            }
        }

        [RelayCommand]
        public void Login2()
        {
            bool userfound_3;
            using (UserDataContest context3 = new UserDataContest())
            {
                userfound_3 = context3.heads.Any(head => head.User_Name == userName && head.Pass == password);
            }

            if (userfound_3)
            {
                HeadWindow Head = new HeadWindow();
                Head.Show();
                Window.GetWindow(Application.Current.MainWindow).Close();
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password");
            }
        }
    }   
}
