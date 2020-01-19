using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic
{
    public class TrafficLight : System.Windows.Forms.PictureBox
    {
        private int Color;

        public TrafficLight()
        {
            ImageLocation = "D:\\c#\\green.png";
        }
        public void ChangeColor()
        {
            switch (Color)
            {
                case 0:
                    ImageLocation = "D:\\c#\\yellow.png";
                    Color++;
                    break;
                case 1:
                    ImageLocation = "D:\\c#\\red.png";
                    Color++;
                    break;
                case 2:
                    ImageLocation = "D:\\c#\\green.png";
                    Color = 0;
                    break;
            }
        }

        public int GetColor()
        {
            return Color;
        }

        public void Yellow()
        {
            ImageLocation = "D:\\c#\\yellow.png";
            Color = 1;
        }
        public void Red()
        {
            ImageLocation = "D:\\c#\\red.png";
            Color = 2;
        }

        public void Green()
        {
            ImageLocation = "D:\\c#\\green.png";
            Color = 0;
        }
    }
}
