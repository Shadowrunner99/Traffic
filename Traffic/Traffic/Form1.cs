using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trafficLight.ChangeColor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                red.Interval = Int32.Parse(textBox2.Text + "000");
                yellow.Interval = Int32.Parse(textBox3.Text + "000");
                green.Interval = Int32.Parse(textBox1.Text + "000");
            } catch
            {
                MessageBox.Show("Incorrect input value! Please enter number in seconds for each color");
            }          
            switch(trafficLight.GetColor())
            {
                case 0:
                    yellow.Start();
                    break;
                case 1:
                    red.Start();
                    break;
                case 2:
                    green.Start();
                    break;
            }
        }

        private void red_Tick(object sender, EventArgs e)
        {
            trafficLight.ChangeColor();
            red.Stop();
            green.Start();
            /*label4.ForeColor = Color.Red;
            label4.Text = "Red! Hold on for a green light!";*/
        }

        private void yellow_Tick(object sender, EventArgs e)
        {
            trafficLight.ChangeColor();
            yellow.Stop();
            red.Start();
            /*label4.ForeColor = Color.Gold;
            label4.Text = "Yellow, you may proceed, but be ready for a red light!";*/
        }

        private void green_Tick(object sender, EventArgs e)
        {
            trafficLight.ChangeColor();
            green.Stop();
            yellow.Start();
            /*label4.ForeColor = Color.LimeGreen;
            label4.Text = "Green, feel free to pass!";*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cross cross = new Cross();
            cross.Show();
        }

        private void trafficLight_Click(object sender, EventArgs e)
        {
            red.Stop();
            yellow.Stop();
            green.Stop();
        }
    }
}
