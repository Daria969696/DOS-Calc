using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            double first = Convert.ToDouble(textBox1.Text);
            double second = Convert.ToDouble(textBox2.Text);
            double answer;
            ICalculator calculator = Factory.Create(((Button) sender).Name);
            answer = calculator.Action(first, second);
            textBox3.Text = answer.ToString();
        }

        private void ActionSingle(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            double answer;
            Isingle calculator = FactorySingle.Create(((Button)sender).Name);
            answer = calculator.Action(first);
            textBox3.Text = answer.ToString();
        }
    }
}
