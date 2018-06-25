using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorRGB
{
    public partial class FrmColor : Form
    {
        public FrmColor()
        {
            InitializeComponent();
        }

        private void ColorChange(object sender, ScrollEventArgs e)
        {
            ColorController ctrl = new ColorController();
            ColorSetter clr = new ColorSetter()
            {
                red = scrlBar_Red.Value,
                green = scrlBar_Green.Value,
                blue = scrlBar_Blue.Value,
            };

            pBox_Color.BackColor = ctrl.setMix(clr);
            txtLbl_Red.Text = clr.red.ToString();
            txtLbl_Green.Text = clr.green.ToString();
            txtLbl_Blue.Text = clr.blue.ToString();
            txtLbl_Red.ForeColor = ctrl.setRed(clr);
            txtLbl_Green.ForeColor = ctrl.setGreen(clr);
            txtLbl_Blue.ForeColor = ctrl.setBlue(clr);
        }
    }
}
