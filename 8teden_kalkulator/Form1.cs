using System.Linq.Expressions;

namespace _8teden_kalkulator
{
    public partial class Form1 : Form
    {
        float prvoStevilo, rezultat;
        int operacija;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt_izpis.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt_izpis.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt_izpis.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt_izpis.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt_izpis.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt_izpis.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt_izpis.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt_izpis.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt_izpis.Text += 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt_izpis.Text += 0;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            //txt_izpis.Text += "+";
            prvoStevilo = float.Parse(txt_izpis.Text);
            txt_izpis.Clear();
            txt_izpis.Focus();
            operacija = 1;
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            //txt_izpis.Text += "-";
            prvoStevilo = float.Parse(txt_izpis.Text);
            txt_izpis.Clear();
            txt_izpis.Focus();
            operacija = 2;
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            //txt_izpis.Text += "*";
            prvoStevilo = float.Parse(txt_izpis.Text);
            txt_izpis.Clear();
            txt_izpis.Focus();
            operacija = 3;
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            //txt_izpis.Text += "/";
            prvoStevilo = float.Parse(txt_izpis.Text);
            txt_izpis.Clear();
            txt_izpis.Focus();
            operacija = 4;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_izpis.Clear();
        }

        private void btn_eq_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txt_izpis.Text))
            {
                Izracunaj(operacija);
            } else
            {
                MessageBox.Show("ni druge stevilke boo");
            }
        }

        private void Izracunaj(int operacija)
        {
            switch (operacija)
            {
                case 1:
                    rezultat = prvoStevilo + float.Parse(txt_izpis.Text);
                    txt_izpis.Text = rezultat.ToString();
                    break;
                case 2:
                    rezultat = prvoStevilo - float.Parse(txt_izpis.Text);
                    txt_izpis.Text = rezultat.ToString();
                    break;
                case 3:
                    rezultat = prvoStevilo * float.Parse(txt_izpis.Text);
                    txt_izpis.Text = rezultat.ToString();
                    break;
                case 4:
                    if(txt_izpis.Text != "0")
                    {
                        rezultat = prvoStevilo / float.Parse(txt_izpis.Text);
                    } else
                    {
                        MessageBox.Show("Deljenje z 0 ni dovoljeno");
                    }
                        txt_izpis.Text = rezultat.ToString();
                    break;
            }
        }
    }
}
