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
using System.Windows.Threading;

namespace SchoolAdministratie.WPF.LoginPage
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        DispatcherTimer timer;
        private MainWindow MainWindow { get; set; }
        public Login()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            prgbLogin.Minimum = 0;
            prgbLogin.Maximum = 100;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            prgbLogin.Value = prgbLogin.Value + 5;

            if (prgbLogin.Value >= 100) timer.IsEnabled = false;
            if (txtbUsername.Text.Trim() == "yalcin" && txtPasword.Password == "123")
            {
                MessageBox.Show("Welkom Yalcin", "Perfect");
                prgbLogin.Value = 0;
                MainWindow = new MainWindow();
                this.Hide();
                //MainWindow.Show();
                MainWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password", "Warning");
                txtbUsername.Text = null;
                txtPasword.Password = null;
                prgbLogin.Value = 0;
                prgbLogin.Visibility = Visibility.Hidden;
                timer.Stop();
                return;
            }
        }

        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            prgbLogin.Visibility = Visibility;
            timer.IsEnabled = true;
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
