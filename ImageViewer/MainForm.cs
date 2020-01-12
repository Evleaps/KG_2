using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class MainForm : Form
    {
        Bitmap map;
        int x1 = -1;
        int y1 = -1;
        Color color = Color.Black;

        public MainForm()  {
            InitializeComponent();
            map = new Bitmap(1000, 1000);
        }
        private void MenuItemExit_Click(object sender, EventArgs e) {
            Close();
        }
        private void MenuItemAboutProgram_Click(object sender, EventArgs e) {
            AboutForm about = new AboutForm();

            about.Show();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e) {
            Pen pen = new Pen(color, trackBar.Value);
            Graphics graph = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            if (e.Button == MouseButtons.Left)
            {
                graph.DrawLine(pen, x1, y1, e.X, e.Y);
                pictureBox.Image = map;
            }
            x1 = e.X;
            y1 = e.Y;
        }

        private void button1_Click(object sender, EventArgs e) {
            color = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e) {
            color = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e) {
            color = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e) {
            color = Color.Lime;
        }

        private void trackBar_Scroll(object sender, EventArgs e){

        }
    }
}
