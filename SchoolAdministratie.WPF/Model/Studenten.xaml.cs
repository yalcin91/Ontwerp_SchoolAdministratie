using SchoolAdministratie.WPF.Toevoegen;

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

namespace SchoolAdministratie.WPF.Model
{
    /// <summary>
    /// Interaction logic for Studenten.xaml
    /// </summary>
    public partial class Studenten : Window
    {
        private StudentInschrijven _StudentInschrijven;
        public Studenten()
        {
            InitializeComponent();
            _StudentInschrijven = new StudentInschrijven();
            _StudentInschrijven.Closing += _Closing;
        }
        public  bool shutdown2 ;

        private void _Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (shutdown2 == true) { Hide(); }
            else { this.Show(); }
        }

        private void Student_Aanmaken_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void Overzicht_Studenten_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void Student_Aanmaken_Click(object sender, RoutedEventArgs e)
        {
            if(_StudentInschrijven != null) { this.Hide(); _StudentInschrijven.Show();}
        }

        private void Overzicht_Studenten_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
