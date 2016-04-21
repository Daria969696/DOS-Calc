using System;
using System.Windows.Forms;
using The_best_calc.Multi;
using The_best_calc.Single;

namespace The_best_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Action(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(textBox1.Text);
                double second = Convert.ToDouble(textBox2.Text);
                ICalculator calculator = Factory.Create(((Button) sender).Name);
                double answer = calculator.Action(first, second);
                textBox3.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void ActionSingle(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(textBox1.Text);
                ISingle calculator = FactorySingle.Create(((Button)sender).Name);
                double answer = calculator.Action(first);
                textBox3.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
            
        }
    }
}
