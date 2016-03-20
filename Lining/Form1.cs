using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.DrawLine(new Pen(new SolidBrush(Color.Red), 5), new Point(button1.Location.X - pictureBox1.Location.X,button1.Location.Y - pictureBox1.Location.Y),
                new Point(MousePosition.X - pictureBox1.Location.X - 6 - this.Location.X, MousePosition.Y - 31 - pictureBox1.Location.Y - this.Location.Y));
            Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height, pictureBox1.CreateGraphics());
            //button1.Text = Convert.ToString(btm.GetPixel(button1.Location.X - pictureBox1.Location.X, button1.Location.Y - pictureBox1.Location.Y).R);
            button1.Text = Convert.ToString(btm.GetPixel(button1.Location.X, button1.Location.Y).R);
        }
    }
}
