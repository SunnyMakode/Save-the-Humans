using System;
using System.Windows;

namespace GroundUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 17 * 3;
            double d = Math.PI / 2;
            myLabel.Text =  "name is " + name + "\n x is "+ x + "\n d is " + d;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 45;
            string name = "Chintu";

            if (someValue == 45 || name == "Chiman")
            {
                myLabel.Text = "someValue : " + someValue + "\n name : " + name;
                return;
            }
            myLabel.Text = "This line runs no matter what";
        }

        //if else
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 10;
            int y = 5;
            x = y;
            myLabel.Text = x == y ?  "value of declared variable x must be equal to " + y :  "value of declared variable x isn't equals " + y ;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            //while (count < 10)
            //{
            //    count += 1;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    count -= 1;
            //}

            int p = 2;
            for (int q = 2; q < 32; q = q*2)
            {
                while (p < q)
                {
                    p = p * 2;
                }
                q = p - q;
                count += 1;
            }
            myLabel.Text = "after looping the value of count variable is " + count;
        }
    }
}
