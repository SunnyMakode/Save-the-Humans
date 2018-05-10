﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    class Elephant
    {
        public string Name;
        public double EarSize;

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall.", Name + " says...");             
        }

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " says: " + message);

        }

        public void SpeakTo(Elephant whoToTalkTo , string message)
        {
            whoToTalkTo.TellMe(message, this);
        }


    }
}
