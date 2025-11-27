using _8teden_pravajalnik_valut;

namespace _8teden_prevajalnik__valut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int count = Enum.GetValues(typeof(LengthUnit)).Length;
            for (int i = 0; i < count; i++)
            {
                unit_sel_1.Items.Add(Enum.GetValues(typeof(LengthUnit)).GetValue(i));
                this.Controls.Add(unit_sel_1);
                unit_sel_2.Items.Add(Enum.GetValues(typeof(LengthUnit)).GetValue(i));
                this.Controls.Add(unit_sel_2);
            }
        }

        private void value1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void value2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate()
        {
            if (!double.TryParse(value1.Text, out double inputValue))
                return;

            if(unit_sel_2.SelectedIndex == -1 || unit_sel_1.SelectedIndex == -1)
            {
                return;
            }

            LengthUnit item1 = (LengthUnit)unit_sel_1.SelectedItem;
            LengthUnit item2 = (LengthUnit)unit_sel_2.SelectedItem;

            double valueInMeters = Length.ToMeters(inputValue, item1);
            double convertedValue = Length.FromMeters(valueInMeters, item2);
            value2.Text = convertedValue.ToString();
        }

        private void unit_sel_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void unit_sel_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
