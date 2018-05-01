using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkerTester
{
    class Talker
    {
        public static int BlahBlahBlah(string thingsToSay, int noOfTimes)
        {
            string finalString = string.Empty;
            for (int i = 0; i < noOfTimes && noOfTimes < 5; i++)
            {
                finalString += thingsToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
