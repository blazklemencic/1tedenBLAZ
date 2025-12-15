using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZaposleniPlace
{
    /// <summary>
    /// Interaction logic for PlaceWindow.xaml
    /// </summary>
    public partial class PlaceWindow : Window
    {
        double? dodatek;
        double? prispevki;
        double? davek;

        public PlaceWindow()
        {
            InitializeComponent();
            DataContext = new ZaposlenViewModel();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void dodatek_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string dodatekProcentVString = dodatek_txt.Text;
            bool v = double.TryParse(dodatekProcentVString, out double d);
            Debug.WriteLine("hi2");
            if (v)
            {
                dodatek = d;
                Debug.WriteLine("ih2");
                Calculate();
            }
        }

        private void dodatek_txt_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void prispevki_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string prispevkiProcentVString = prispevki_txt.Text;
            bool v = double.TryParse(prispevkiProcentVString, out double d);
            Debug.WriteLine("hi3");
            if (v)
            {
                prispevki = d;
                Debug.WriteLine("ih3");
                Calculate();
            }
        }

        private void davek_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string davekProcentVString = davek_txt.Text;
            bool v = double.TryParse(davekProcentVString, out double d);
            Debug.WriteLine("hi4");
            if (v)
            {
                davek = d;
                Debug.WriteLine("ih4");
                Calculate();
            }
        }

        private void Calculate()
        {

            var vm = DataContext as ZaposlenViewModel;
            if (vm?.SelectedZaposlen == null) return;

            double salary = vm.SelectedZaposlen.Salary;

            Debug.WriteLine("im not here");
            if(dodatek == null || prispevki == null || davek == null)
            {
                return;
            }

            double dodatki = (double)(salary * (dodatek / 100));
            double _prispevki = (double)(salary * (prispevki / 100));
            double _davek = (double)(salary * (davek / 100));
            double neto = salary - dodatki - _prispevki - _davek;
            calc_bruto.Text = String.Format("{0:0.00}", salary);
            calc_dodatki.Text = String.Format("{0:0.00}", dodatki);
            calc_prispevki.Text = String.Format("{0:0.00}", _prispevki);
            calc_davek.Text = String.Format("{0:0.00}", _davek);
            calc_neto.Text = String.Format("{0:0.00}", neto);

            PlacilniZapisiManager.placilniZapisi.Add(vm.SelectedZaposlen, 
                new PlacilniZapis(bruto: salary, dodatki, _prispevki, _davek, neto));
        }
    }
}
