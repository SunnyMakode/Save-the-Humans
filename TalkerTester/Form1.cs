using System;
using System.Windows.Forms;

namespace TalkerTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Talker.BlahBlahBlah(textBox1.Text, Convert.ToInt16(textBox2.Text));
            MessageBox.Show(len.ToString());
        }
    }
}
