using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    public partial class ShowResultsVM : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Result> result;

        [ObservableProperty]
        int index = -1;

        [ObservableProperty]
        public Result r1 = null;

        [RelayCommand]
        public void updateResult()
        {
            if (r1 == null)
                MessageBox.Show("Please selecte an item");
            else
            {
                using (UserDataContest context = new UserDataContest())
                {
                    var Editing = new UpdateResultWindowVM(r1);
                    UpdateResultWindow Update = new UpdateResultWindow(Editing);
                    Update.Show();


                    //index = user.IndexOf(p1);
                    //user.RemoveAt(index);
                    //user.Add(Editing.S1);
                }

            }
            //UpdateResultWindow a = new UpdateResultWindow();
            //a.Show();
        }

        
    }
}
