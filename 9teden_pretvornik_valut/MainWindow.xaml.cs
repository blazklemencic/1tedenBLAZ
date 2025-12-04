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

namespace _9teden_pretvornik_valut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Dictionary<string, double> _valute = new Dictionary<string, double>
        {
            { "USD", 1.1 },
            { "EUR", 2 }
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPretvori_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}