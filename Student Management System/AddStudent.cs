using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Student_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Student_Management_System
{
    public partial class AddStudent : ObservableObject
    {
        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public double gpa = 0;

        [ObservableProperty]
        public BitmapImage selectedImage;

        [ObservableProperty]
        public String image;

        [ObservableProperty]
        public ObservableCollection<User> users;


        public AddStudent(AddStudent vm)
        {

        }

        public AddStudent(User s1)
        {
            firstname = s1.First_name;
            lastname = s1.Last_name;
            
        }
        public Action CloseAction { get; internal set; }
        public User S1 { get; private set; }

        [RelayCommand]
        public void Submit()
        {
            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA value must be between 0 and 4.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (S1 == null)
            {

                S1 = new User()
                {
                    First_name = firstname,

                    Last_name = lastname,

                };
            }
            else
            {
                S1.First_name = firstname;

                S1.Last_name = lastname;


            }

            if (S1.First_name != null)
            {
                CloseAction();
            }
            Application.Current.MainWindow.Show();



        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
