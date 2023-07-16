using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NewDataBase.ViewModel;
using Student_Management_System.Model;
using Student_Management_System.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Student_Management_System.ViewModel
{
    public partial class UpdateWindowVM : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<User> user;

        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public string address;

        [ObservableProperty]
        public string regno;

        private User _selectedUser;
      
        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged(nameof(SelectedUser));
            }
        }

        [RelayCommand]
        public void save()
        {
            
            using (UserDataContest context = new UserDataContest())
            {
                var sToUp = context.users.FirstOrDefault(s => s.Reg_No == SelectedUser.Reg_No);
                if (sToUp != null)
                {
                    
                    sToUp.First_name = SelectedUser.First_name;
                    sToUp.Last_name = SelectedUser.Last_name;
                    sToUp.Address = SelectedUser.Address;
                    sToUp.Telephone_Number = SelectedUser.Telephone_Number;
                    Window.GetWindow(Application.Current.MainWindow).Close();
                    context.SaveChanges();
                }
                else
                    MessageBox.Show("Error 10000");
                

            }
        }


        public UpdateWindowVM(User user)
        {
            
            SelectedUser = user;
        }

        public UpdateWindowVM()
        {
        }

        //[RelayCommand]
        //public void UpdateStudent()
        //{

        //    //index = user.IndexOf(p1);
        //    //user.RemoveAt(index);
        //    //user.Add(Editing.S1);

        //    if (SelectedUser != null)
        //    {
        //        var vm = new AddStudent(SelectedUser);
        //        var updatestudent = new AddStudent(vm);
        //        updatestudent.ShowDialog();

        //        {
        //            using (UserDataContest context = new UserDataContest())
        //            {
        //                var studentToUpdate = context.users.FirstOrDefault(u => u.Id == SelectedUser.Id);
        //                if (studentToUpdate != null)
        //                { 
        //                    P1.First_name = firstname;
        //                    studentToUpdate.Reg_No = SelectedUser.Reg_No;
        //                    studentToUpdate.First_name = vm.firstname;
        //                    studentToUpdate.Last_name = vm.lastname;

        //                    context.SaveChanges();
        //                }
        //            }
        //            //int index = user.IndexOf(SelectedUser);
        //            //user.RemoveAt(index);
        //            ////user.Insert(Index);
        //        }
        //    }
        //}


    }
}
