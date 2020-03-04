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

namespace Gestione_Prestito
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string nat = null;

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            
            string Cognome = txtCognome1.Text;
            string Nome = txtNome1.Text;
            if (btnF1.IsChecked == true)
            {
                nat = "nata";
            }
            else
            {
                nat = "nato";
                btnF1.IsChecked = false;
            }
            DatePicker DataTime = new DatePicker();
            double Importo = double.Parse(txtImporto1.Text);
            double Rate = double.Parse(txtRate1.Text);
            double Percentuale = double.Parse(txtPercentuale1.Text);
            double DaRestituire = (Importo * Percentuale / 100) + Importo; 
            txtDaRestituire.Text = DaRestituire.ToString();
            double ImportoRate = DaRestituire / Rate;
            txtImpRate.Text = ImportoRate.ToString();
            lblRisultato1.Content = ($"{txtCognome1.Text} {txtNome1.Text} residente in {ComboBox1.Text} {nat} il {DataTime1.Text}.\nPrestito di {txtImporto1.Text} ad un tasso del {txtPercentuale1.Text}% da restituire in {txtRate1.Text} rate da {txtImpRate.Text} ciascuna, per un totale si {txtDaRestituire.Text}");
        }

        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnNuovo1_Click(object sender, RoutedEventArgs e)
        {
            txtNome1.Clear();
            txtCognome1.Clear();
            txtImporto1.Clear();
            txtRate1.Clear();
            txtPercentuale1.Clear();
            txtDaRestituire.Clear();
            txtImpRate.Clear();
            DataTime1.SelectedDate = null;
            ComboBox1.SelectedItem = null;
            btnF1.IsChecked = false;
            btnM1.IsChecked = false;
            lblRisultato1.Content = null;
        }
    }
}
