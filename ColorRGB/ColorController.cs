using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ColorRGB
{
    public class ColorController
    {
        public Color setMix(ColorSetter temp)
        {
            return Color.FromArgb(temp.red, temp.green, temp.blue);
        }

        public Color setRed(ColorSetter temp)
        {
            return Color.FromArgb(temp.red, 0, 0);
        }

        public Color setGreen(ColorSetter temp)
        {
            return Color.FromArgb(0, temp.green, 0);
        }

        public Color setBlue(ColorSetter temp)
        {
            return Color.FromArgb(0, 0, temp.blue);
        }
    }
}
