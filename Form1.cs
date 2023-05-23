using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        Bitmap bit;

        protected override void OnLoad(EventArgs e)

        {

            bit = new Bitmap("bird3.gif");

            ImageAnimator.Animate(bit, new EventHandler(this.OnFrameChanged));

            base.OnLoad(e);

        }

        protected override void OnPaint(PaintEventArgs e)

        {

            ImageAnimator.UpdateFrames();

            Graphics g = pictureBox.CreateGraphics();

            g.DrawImage(this.bit, new Point(0, 0));

            base.OnPaint(e);

        }

        private void OnFrameChanged(object sender, EventArgs e)

        {

            this.Invalidate();

        }

        private void Generate_btn_Click(object sender, EventArgs e)
        {
            string batFilePath = "GenerateprojectFiles.bat";
        }
    }
}
