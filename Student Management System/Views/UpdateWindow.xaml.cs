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
using System.Windows.Shapes;

namespace Student_Management_System.Views
{
    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        public UpdateWindow(UpdateWindowVM updateWindowVM)
        {

            InitializeComponent();
            DataContext = updateWindowVM;

        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}
