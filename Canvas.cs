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
    public partial class DrawingApp : Form
    {
        Graphics graphics;
        Boolean cursorMoving = false;
        Pen cursorPen;
        int cursorX = -1 , cursorY = -1; //cursor location
        int width = 7;

        public DrawingApp()
        {
            InitializeComponent();
            graphics = panelCanvas.CreateGraphics();
            trackBarWidth.Minimum = 1;
            trackBarWidth.Maximum = 100;
            cursorPen = new Pen(Color.Black,width);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (trackBarWidth.Visible) trackBarWidth.Visible = false;
            if (panelColors.Visible) panelColors.Visible = false;
            else panelColors.Visible = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (panelColors.Visible) panelColors.Visible = false;
            if (trackBarWidth.Visible) trackBarWidth.Visible = false;
            else trackBarWidth.Visible = true;
        }

        private void trackBarWidth_Scroll(object sender, EventArgs e)
        {

            cursorPen.Width = (int)trackBarWidth.Value;
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            cursorMoving = true;
            cursorX = e.X;
            cursorY = e.Y;
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMoving = false;
            cursorX = -1;
            cursorY = -1;

        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && cursorMoving) 
            {
                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X;
                cursorY = e.Y;
            }
        }

        private void panelColors_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void blackPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = color.BackColor;
        }
    }
}
