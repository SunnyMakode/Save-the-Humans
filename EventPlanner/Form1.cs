using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPlanner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty()
            { NumberOfPerson = 5  };
            dinnerParty.SetHealthyOption(false);
            dinnerParty.CalculatecostOfDecorations(true);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.calculateCost(beveragesCheckBox.Checked);
            costTextBox.Text = cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPerson = Convert.ToInt16(numericUpDown1.Value);
            DisplayDinnerPartyCost();
        }

        private void beveragesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(beveragesCheckBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void decorationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculatecostOfDecorations(decorationCheckBox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
