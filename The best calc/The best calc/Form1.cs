using System;
using System.Windows.Forms;
using The_best_calc.Multi;
using The_best_calc.Single;

namespace The_best_calc
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Action(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(textBox1.Text.Replace(".", ","));
                double second = Convert.ToDouble(textBox2.Text.Replace(".", ","));
                ICalculator calculator = Factory.Create(((Button) sender).Name);
                double answer = calculator.Action(first, second);
                textBox3.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionSingle(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(textBox1.Text.Replace(".", ","));
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
