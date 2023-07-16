using Student_Management_System.Model;
using Student_Management_System.Views;
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
using System.Windows.Shapes;

namespace Student_Management_System
{
    /// <summary>
    /// Interaction logic for HeadWindow.xaml
    /// </summary>
    public partial class HeadWindow : Window
    {
        public List<Admin> DatabaseUsers { get; private set; }
        public HeadWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (UserDataContest context = new UserDataContest())
            {
                DatabaseUsers = context.admins.ToList();
                ItemList.ItemsSource = DatabaseUsers;
            }
        }

        private void Delete_User(object sender, RoutedEventArgs e)
        {
            using (UserDataContest context = new UserDataContest())
            {

                Admin selectedUser = ItemList.SelectedItem as Admin;

                if (selectedUser != null)
                {
                    Admin user = context.admins.Single(x => x.User_Name == selectedUser.User_Name);

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

        private void Add_Admin(object sender, RoutedEventArgs e)
        {
            AddAdminWindow a = new AddAdminWindow();
            a.Show();
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
