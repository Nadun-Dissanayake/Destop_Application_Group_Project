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


namespace Student_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindowMV();
            InitializeComponent();
        }

        private void btnLogin(object sender, RoutedEventArgs e)
        {
            
        }

        public static readonly DependencyProperty PasswordProperrt = DependencyProperty.Register("password", typeof(string), typeof(PasswordBox), new PropertyMetadata(string.Empty));
        

        public string Password
        {
            get { return (string)GetValue(PasswordProperrt);}
            set { SetValue(PasswordProperrt, value);}
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = passwordBox.Password;
        }

        
    }
}
