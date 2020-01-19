using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    public class Crossroads : System.Windows.Forms.PictureBox
    {
        private TrafficLight Vertical;
        private TrafficLight Horizontal;
        public Crossroads()
        {
            Size = new System.Drawing.Size(500, 500);
            Location = new System.Drawing.Point(20, 30);
            ImageLocation = "D:\\c#\\cross.png";
        }
        public Crossroads(TrafficLight tf1,TrafficLight tf2)
        {
            Vertical = tf1;
            Horizontal = tf2;
            Size = new System.Drawing.Size(500, 500);
            Location = new System.Drawing.Point(20, 30);
            ImageLocation = "D:\\c#\\cross.png";
        }
    }
}
