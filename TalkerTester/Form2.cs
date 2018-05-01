using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkerTester
{
    public partial class Form2 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form2()
        {
            InitializeComponent();
            joe = new Guy() { Name = "Joe" , Cash = 50 };
            bob = new Guy() { Name = "Bob", Cash = 100 };
            UpdateForm();
        }

        public void UpdateForm()
        {
            JoeCashlabel.Text = joe.Name + " has $" + joe.Cash;
            bobCashlabel.Text = bob.Name + " has $" + bob.Cash;
            BankCashlabel.Text = "The bank has $" + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReturnCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("No money in the bank");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void giveToBob_Click(object sender, EventArgs e)
        {
           
            bob.ReturnCash(joe.GiveCash(10));
            bank -= bob.ReturnCash(joe.GiveCash(10));
            UpdateForm();
                
        }

        private void bobGivesJoe_Click(object sender, EventArgs e)
        {
            joe.ReturnCash(bob.GiveCash(5));
            bank -= joe.ReturnCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}
