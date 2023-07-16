using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Student_Management_System;
using Student_Management_System.Model;
using Student_Management_System.Views;
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

    public partial class StudentVM : ObservableObject
    {

        [ObservableProperty]
        private ObservableCollection<User> user;

        [ObservableProperty]
        int index = -1;

        [ObservableProperty]
        public User p1 = null;

        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;
        [RelayCommand]
        public void UpdateStudent()
        {
            if (p1 == null)
                MessageBox.Show("Please selecte an item");
            else
            {
                using (UserDataContest context = new UserDataContest())
                {
                    var Editing = new UpdateWindowVM(p1);
                    UpdateWindow Update = new UpdateWindow(Editing);
                    Update.Show();


                    //index = user.IndexOf(p1);
                    //user.RemoveAt(index);
                    //user.Add(Editing.S1); 
                }
                    
            }
        }
         
    }

    
}
