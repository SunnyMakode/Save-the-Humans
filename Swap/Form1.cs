

namespace Swap
{
    using System;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        Elephant llyod = new Elephant()
        {
            Name = "Llyod",
            EarSize = 32
        };
        Elephant lucinda = new Elephant()
        {
            Name = "Lucinda",
            EarSize = 33
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void llyodBtn_Click(object sender, EventArgs e)
        {
            
            llyod.WhoAmI();
        }

        private void lucindaBtn_Click(object sender, EventArgs e)
        {
            
            lucinda.WhoAmI();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            //var temp1 = llyod;
            //var temp2 = lucinda;
            //llyod = llyod != temp2 ? temp2 : temp1;
            //lucinda = lucinda != temp1 ? temp1 : temp2;           

            Elephant holder;
            holder = llyod;
            llyod = lucinda;
            lucinda = holder;
            MessageBox.Show("Objects swapped");
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            llyod.TellMe("Hi" , lucinda);
            llyod.SpeakTo(llyod, "Hello");            

        }
    }
}
