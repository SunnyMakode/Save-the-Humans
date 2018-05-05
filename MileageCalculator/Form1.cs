using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > numericUpDown1.Value)
            {
                label4.Text = "$" + Convert.ToString(((double)numericUpDown2.Value - (double)numericUpDown1.Value) * 0.39);
            }
            else
            {
                MessageBox.Show("The starting mileage needs to be less than ending mileage","Cannot Calculate Mileage");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Distance travelled "+ (numericUpDown2.Value - numericUpDown1.Value) + " miles");
        }
    }
}
