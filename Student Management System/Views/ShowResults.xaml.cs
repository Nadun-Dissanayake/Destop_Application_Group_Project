using Student_Management_System.Model;
using Student_Management_System.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Student_Management_System.Views
{
    /// <summary>
    /// Interaction logic for ShowResults.xaml
    /// </summary>
    public partial class ShowResults : UserControl
    {
        public List<Result> DatabaseUsers { get; private set; }
        public ShowResults()
        {
            
            InitializeComponent();
            DataContext = new ShowResultsVM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (UserDataContest context = new UserDataContest())
            {
                DatabaseUsers = context.results.ToList();
                ItemList.ItemsSource = DatabaseUsers;
            }
        }

        public void Delete()
        {
            
        }

        private void Delete_User(object sender, RoutedEventArgs e)
        {
            using (UserDataContest context = new UserDataContest())
            {

                Result selectedResult = ItemList.SelectedItem as Result;

                if (selectedResult != null)
                {
                    Result result = context.results.Single(x => x.Id == selectedResult.Id);

                    context.Remove(result);
                    context.SaveChanges();
                    MessageBox.Show("Record is Successfully Deleted");

                }
                else
                {
                    MessageBox.Show("Please Select the Relavent Reg No");
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //User selectedUser = ItemList.SelectedItem as User;

            //var name = 
        }
    }
}
