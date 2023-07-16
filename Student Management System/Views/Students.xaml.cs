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
    /// Interaction logic for Students.xaml
    /// </summary>
    public partial class Students : UserControl
    {
        public List<User> DatabaseUsers { get; private set; }
        public Students()
        {
            
            InitializeComponent();

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            using (UserDataContest context = new UserDataContest())
            {
                DatabaseUsers = context.users.ToList();
                ItemList.ItemsSource = DatabaseUsers;
            }

           
        }

        //public void Delete()
        //{
        //    
        //}

        private void Delete_User(object sender, RoutedEventArgs e)
        {
            using (UserDataContest context = new UserDataContest())
            {

                User selectedUser = ItemList.SelectedItem as User;

                if (selectedUser != null)
                {
                    User user = context.users.Single(x => x.Reg_No == selectedUser.Reg_No);

                    context.Remove(user);
                    context.SaveChanges();
                    MessageBox.Show("Record is Successfully Deleted! Refresh Now");
                }
                else
                {
                    MessageBox.Show("Please Select the Relavent Reg No");
                }
            }
        }

        private void Update_User(object sender, RoutedEventArgs e)
        {
            String FN;

            using (UserDataContest context = new UserDataContest())
            {
                User selectedUser = ItemList.SelectedItem as User;

                if (selectedUser != null)
                {
                    //UpdateWindow Update = new UpdateWindow();
                    //Update.Show();
                }
                else
                {
                    MessageBox.Show("Please Select the Relavent Reg No");
                }

            }
            
        }
    }
}
