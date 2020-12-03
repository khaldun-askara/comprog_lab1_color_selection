using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorRGBPicker
{
    public partial class ColorRGBPicker : UserControl
    {
        public ColorRGBPicker()
        {
            InitializeComponent();
            colorChanged += UpdateCTBWhenColorChanged;
        }

        private void UpdateCTBWhenColorChanged(Color newColor)
        {
            cTB_red.Color = newColor.R;
            cTB_green.Color = newColor.G;
            cTB_blue.Color = newColor.B;
        }

        public Color Color
        {
            get
            {
                return pnl_ResultColor.BackColor;
            }

            set
            {
                pnl_ResultColor.BackColor = value;
                colorChanged(value);
            }
        }

        public delegate void ColorChanged(Color color);
        public event ColorChanged colorChanged;

        //private int GetColor(ColorTextBox.ColorTextBox cTB)
        //{
        //    bool is_input_decimal = cTB.Is_input_decimal;
        //    int x = 0;
        //    if (is_input_decimal)
        //        int.TryParse(cTB.Text, out x);
        //    else
        //        int.TryParse(cTB.Text, 
        //                    System.Globalization.NumberStyles.HexNumber,
        //                    System.Globalization.CultureInfo.InvariantCulture, 
        //                    out x);
        //    return x;
        //}

        private void UpdateColor()
        {
            int red = cTB_red.Color,
                green = cTB_green.Color,
                blue = cTB_blue.Color;

            pnl_ResultColor.BackColor = Color.FromArgb(red, green, blue);
        }

        private void rB_CheckedChanged(object sender, EventArgs e)
        {
            cTB_red.Is_input_decimal =
                cTB_green.Is_input_decimal =
                cTB_blue.Is_input_decimal = rB_dec.Checked;
        }

        private void cTB_TextChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void cTB_blue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
