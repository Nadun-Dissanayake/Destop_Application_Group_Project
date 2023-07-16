using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Student_Management_System.Utilities;
using Student_Management_System;
//using Student_Management_System.Model;


namespace Student_Management_System.ViewModel
{
    class NavigationVM : ViewModelBase
    {
       // public User user;
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand DashboardCommand { get; set; }
        public ICommand StudentCommand { get; set; }
        public ICommand AnalyticsCommand { get; set; }
        public ICommand NewStudentCommand { get; set; }
        public ICommand ShowResultCommand { get; set; }
        public ICommand PersonalDetailCommand { get; set; }






        private void Dashboard(object obj) => CurrentView = new DashboardVM();
        private void Student(object obj) => CurrentView = new StudentVM();
        private void Analytics(object obj) => CurrentView = new AnalyticsVM();

        private void NewStudent(object obj) => CurrentView = new NewStudentVm();
        private void ShowResult(object obj) => CurrentView = new ShowResultsVM();
       // private void PersonalDetail(object obj) => CurrentView = new PersonalDetailsVM(user);

        public NavigationVM()
        {
            DashboardCommand = new RelayCommand(Dashboard);
            StudentCommand = new RelayCommand(Student);
            AnalyticsCommand = new RelayCommand(Analytics);
            NewStudentCommand = new RelayCommand(NewStudent);
            ShowResultCommand = new RelayCommand(ShowResult);
          //  PersonalDetailCommand = new RelayCommand(PersonalDetail);


            // Startup Page
            CurrentView = new DashboardVM();
        }
    }
}
