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
    public partial class Cross : Form
    {
        public Cross()
        {
            InitializeComponent();
        }

        private void red1_Tick(object sender, EventArgs e)
        {
            trafficLight1.ChangeColor();
            red1.Stop();
            green1.Start();
        }

        private void yellow1_Tick(object sender, EventArgs e)
        {
            trafficLight1.ChangeColor();
            yellow1.Stop();
            red1.Start();
        }

        private void green1_Tick(object sender, EventArgs e)
        {
            trafficLight1.ChangeColor();
            green1.Stop();
            yellow1.Start();
            trafficLight2.Red();
        }

        private void red2_Tick(object sender, EventArgs e)
        {
            trafficLight2.ChangeColor();
            red2.Stop();
            green2.Start();
        }

        private void yellow2_Tick(object sender, EventArgs e)
        {
            trafficLight2.ChangeColor();
            yellow2.Stop();
            red2.Start();
        }

        private void green2_Tick(object sender, EventArgs e)
        {
            trafficLight2.ChangeColor();
            green2.Stop();
            yellow2.Start();
            trafficLight1.Red();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (trafficLight1.GetColor())
            {
                case 0:
                    yellow1.Start();
                    green2.Start();
                    break;
                case 1:
                    red1.Start();
                    yellow2.Start();
                    break;
                case 2:
                    green1.Start();
                    red2.Start();
                    break;
            }
        }
    }
}
