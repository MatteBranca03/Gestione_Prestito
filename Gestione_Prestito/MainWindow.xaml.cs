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
            ComboBox.Items.Add("perugia");
        } 

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            
            string Cognome = txtCognome.Text;
            string Nome = txtNome.Text;
            if (btnF.IsChecked == true)
            {
                N
            }
            else
            {
                btnF.IsChecked = false;
            }
            DatePicker DataTime = new DatePicker();
            double Importo = double.Parse(txtImporto.Text);
            double Rate = double.Parse(txtRate.Text);
            double Percentuale = double.Parse(txtPercentuale.Text);
            double DaRestituire = Importo * Percentuale / 100;
            txtRestituire.Text = 
            double ImportoRata = DaRestituire / Rate;
            txtImpRata
        }
    }
}
