using CommunityToolkit.Mvvm.ComponentModel;
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
    public partial class UpdateResultWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string regno;
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
        public UpdateResultWindowVM(Result result)
        {
            regno = result.Id; 
            ee3305 = result.EE3305;
            ee3302 = result.EE3302;
            ee3301 = result.EE3301;
            is3307 = result.IS3307;
            ee3250 = result.EE3250;
            is3302 = result.IS3302;
            ee3203 = result.EE3203;
            ee3251 = result.EE3251;
        }
        public UpdateResultWindowVM()
        {

        }

    }
}
