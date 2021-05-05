using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SchoolAdministratie.WPF.LoginPage
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        DoubleAnimation doubleanimation = new DoubleAnimation();
        private MainWindow MainWindow { get; set; }
        public Login()
        {
            InitializeComponent();
            doubleanimation.Completed += Doubleanimation_Completed;  
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            doubleanimation.From = 10;
            doubleanimation.To = 100;
            doubleanimation.Duration = new Duration(TimeSpan.FromSeconds(1));
            prgbLogin.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);
        }

        private void Doubleanimation_Completed(object sender, EventArgs e)
        {
            if (txtbUsername.Text.Trim() == "yalcin" && txtPasword.Password == "123")
            {
                //MessageBox.Show("Welkom Yalcin", "Perfect");
                prgbLogin.Value = 0;
                MainWindow = new MainWindow();
                txtbUsername.Text = null;
                txtPasword.Password = null;
                this.Close();
                MainWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password", "Warning");
                txtbUsername.Text = null;
                txtPasword.Password = null;
                prgbLogin.Value = 0;
                prgbLogin.Visibility = Visibility.Hidden;
                return;
            }
        }

        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            prgbLogin.Visibility = Visibility.Visible;
            timer_Tick(sender, e);
        }

        private void txtPasword_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                btnLogin_Click_1(sender, e);
            }
        }

        private void txtbUsername_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                btnLogin_Click_1(sender, e);
            }
        }
    }
}
