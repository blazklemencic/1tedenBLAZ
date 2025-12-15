using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZaposleniPlace
{
    public partial class MainWindow : Window
    {
        bool doneu;
        bool donep;

        public MainWindow()
        {
            InitializeComponent();
            ZaposlenViewModel.AddZaposlen(new Zaposlen(0, "blaz", 14, 2401.2));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username_txt.Text) || username_txt.Text.Length < 5)
            {
                MessageBox.Show("Uporabnisko ime ni vpisano ali pa je prekratko");
            }
            if (String.IsNullOrWhiteSpace(password_txt.Password) || password_txt.Password.Length < 8)
            {
                MessageBox.Show("geslo ni vpisano ali pa je prekratko");
            }

            if(username_txt.Text == "mitja" && password_txt.Password == "mitja123")
            {
                var reg = new Zaposleni();
                reg.Owner = this;
                reg.ShowDialog();
            }
        }

        private void username_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void password_txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void username_txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (doneu) return;
            username_txt.Text = String.Empty;
            doneu = true;
        }

        private void password_txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (donep) return;
            password_txt.Password = String.Empty;
            donep = true;
        }
    }
}