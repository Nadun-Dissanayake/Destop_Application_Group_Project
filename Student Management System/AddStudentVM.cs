using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Student_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NewDataBase.ViewModel
{
    public partial class AddStudentVM : ObservableObject
    {
        [ObservableProperty]
        public string firstName;
        [ObservableProperty]
        public string lastName;
        
        [ObservableProperty]
        public string address;
        [ObservableProperty]
        public string regNo;
        [ObservableProperty]
        public string telNo;
        

        public AddStudentVM(User student)
        {
           firstName = student.First_name;
           lastName = student.Last_name;
           address = student.Address;
           regNo = student.Reg_No;
           telNo = student.Telephone_Number;
        }

        public AddStudentVM()
        {
        }

        public string Title { get; set; }


       
        
        public User newStudent { get; set; }
        public Action CloseAction2 { get; set; }
        public bool IsSaved = false;

        private RelayCommand saveCommand;
        public ICommand SaveCommand => saveCommand ??= new RelayCommand(Save);

        private void Save()
        {
            if (firstName != null || lastName != null || address != null  || telNo != null || regNo != null)
            {
                newStudent = new User(firstName, lastName,address, telNo, regNo);
                IsSaved = true;
                CloseAction2();
            }
            else if (regNo != null)
            {
                MessageBox.Show("Invalid StudentID");
            }
            else if (firstName != null)
            {
                MessageBox.Show("Invalid FirstName");
            }
            else if (lastName != null)
            {
                MessageBox.Show("Invalid LastName");
            }
            else if (telNo != null)
            {
                MessageBox.Show("Invalid Age");
            }
            
            else if (address != null)
            {
                MessageBox.Show("Invalid Address");
            }
            
        }
        //[RelayCommand]
        //public void Save()
        //{
        //    if (studentID != null || firstName != null || lastName != null|| age != null || address != null || dateOfBirth != null || gender!=null)
        //    {
        //        Student = new Student( studentID, firstName, lastName, gender, address, age, dateOfBirth);
        //        IsSaved = true;
        //        CloseAction1();
        //    }
        //    else if (studentID != null)
        //    {
        //        MessageBox.Show("Invalid StudentID");
        //    }
        //    else if (firstName != null)
        //    {
        //        MessageBox.Show("Invalid FirstName");
        //    }
        //    else if (lastName != null)
        //    {
        //        MessageBox.Show("Invalid LastName");
        //    }
        //    else if (age != null)
        //    {
        //        MessageBox.Show("Invalid Age");
        //    }
        //    else if (gender != null)
        //    {
        //        MessageBox.Show("Invalid Gender");
        //    }
        //    else if (address != null)
        //    {
        //        MessageBox.Show("Invalid Address");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid Date OF Birth");
        //    }
        //}



    }
}
