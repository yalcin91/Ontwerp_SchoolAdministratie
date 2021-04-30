using SchoolAdministratie.WPF.Model;

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
using System.Windows.Threading;

namespace SchoolAdministratie.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Docenten _Docenten;
        private Lessen _Lessen;
        private Vakken _Vakken;
        private Studenten _Studenten;
        private Resultaten _Resultaten;
        private Opleidingen _Opleidingen;

        public MainWindow()
        {
            InitializeComponent();
            _Docenten = new Docenten();
            _Lessen = new Lessen();
            _Vakken = new Vakken();
            _Studenten = new Studenten();
            _Resultaten = new Resultaten();
            _Opleidingen = new Opleidingen();
            Closing += MainWindow_Closing;
            _Docenten.Closing += _Closing;
            _Lessen.Closing += _Closing;
            _Vakken.Closing += _Closing;
            _Studenten.Closing += _Closing;
            _Resultaten.Closing += _Closing;
            _Opleidingen.Closing += _Closing;

        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void _Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, (DispatcherOperationCallback)delegate (object o)
            {
                ((Window)sender).Hide();
                return null;
            }, null);
            e.Cancel = true;
        }

        private void MenuItem_Sluiten_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void MenuItem_Opleidingen_Click(object sender, RoutedEventArgs e)
        {
            if (_Opleidingen != null) _Opleidingen.Show();
        }

        private void MenuItem_Vakken_Click(object sender, RoutedEventArgs e)
        {
            if (_Vakken != null) _Vakken.Show();
        }

        private void MenuItem_Lessen_Click(object sender, RoutedEventArgs e)
        {
            if (_Lessen != null) _Lessen.Show();
        }

        private void MenuItem_Docenten_Click(object sender, RoutedEventArgs e)
        {
            if (_Docenten != null) _Docenten.Show();
        }

        private void MenuItem_Studenten_Click(object sender, RoutedEventArgs e)
        {
            if (_Studenten != null) _Studenten.Show();
        }

        private void MenuItem_Resultaten_Click(object sender, RoutedEventArgs e)
        {
            if (_Resultaten != null) _Resultaten.Show();
        }
    }
}
