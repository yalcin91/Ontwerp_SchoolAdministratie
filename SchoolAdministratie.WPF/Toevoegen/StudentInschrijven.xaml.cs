using SchoolAdministratie.WPF.Model;

using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace SchoolAdministratie.WPF.Toevoegen
{
    /// <summary>
    /// Interaction logic for StudentInschrijven.xaml
    /// </summary>
    public partial class StudentInschrijven : Window
    {
        public StudentInschrijven()
        {
            InitializeComponent();
            Closing += StudentInschrijven_Closing;
        }

        private void StudentInschrijven_Closing(object sender, CancelEventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, (DispatcherOperationCallback)delegate (object o)
            {
                ((Window)sender).Hide();
                return null;
            }, null);
            e.Cancel = true;
            this.Hide(); 
        }

        private void Button_Bevestig_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaam.Text)) txtBlNaam.Visibility = Visibility.Visible; else txtBlNaam.Visibility = Visibility.Hidden;
            if (string.IsNullOrEmpty(txtVoornaam.Text)) txtBlVoornaam.Visibility = Visibility.Visible; else txtBlVoornaam.Visibility = Visibility.Hidden;
            if (string.IsNullOrEmpty(txtGeboortedatum.Text)) txtBlGeboortedatum.Visibility = Visibility.Visible; else txtBlGeboortedatum.Visibility = Visibility.Hidden;
            if (string.IsNullOrEmpty(txtStraat.Text)) txtBlStraat.Visibility = Visibility.Visible; else txtBlStraat.Visibility = Visibility.Hidden;
            if (string.IsNullOrEmpty(txtHuisnummer.Text)) txtBlHuisnummer.Visibility = Visibility.Visible; else txtBlHuisnummer.Visibility = Visibility.Hidden;
            if (string.IsNullOrEmpty(txtPostcode.Text)) txtBlPostcode.Visibility = Visibility.Visible; else txtBlPostcode.Visibility = Visibility.Hidden;
            if (string.IsNullOrEmpty(txtWoonplaats.Text)) txtBlWoonplaats.Visibility = Visibility.Visible; else txtBlWoonplaats.Visibility = Visibility.Hidden;
            if (string.IsNullOrEmpty(txtEmailAdres.Text)) txtBlEmailadres.Visibility = Visibility.Visible; else txtBlEmailadres.Visibility = Visibility.Hidden;
        }
    }
}
