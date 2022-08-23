using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class ColorDialog : Form
    {
        public Pen cursorPen;
        public ColorDialog()
        {
            InitializeComponent();
        }

        private void blackPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = color.BackColor;
        }

        private void ColorDialog_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
