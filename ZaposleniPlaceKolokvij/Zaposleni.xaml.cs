using System;
using System.Collections.Generic;
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
    public partial class Zaposleni : Window
    {
        public Zaposleni()
        {
            InitializeComponent();
            ZaposlenViewModel viewModel = new ZaposlenViewModel();
            DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void obrplac_btn_Click(object sender, RoutedEventArgs e)
        {
            var reg = new PlaceWindow();
            reg.Owner = this;
            reg.Show();
        }
    }
}
