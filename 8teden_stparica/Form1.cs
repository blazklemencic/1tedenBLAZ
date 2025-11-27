using System.Diagnostics;
using System.Threading.Tasks;

namespace _8teden_stparica
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();

            Reset();
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            if (sw.IsRunning) return;

            sw.Start();

            while (sw.IsRunning)
            {
                
                textBox1.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.fff");
                await Task.Delay(10);
            }

            sw.Stop();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            sw.Stop();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            sw.Reset();

            textBox1.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.fff");
        }
    }
}
