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
            InitializePictureBox();
        }

        private void Generate_btn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializePictureBox()
        {
            pictureBox = new PictureBox();
            pictureBox.Location = new Point(0, 0);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.ImageLocation = "bird.gif";
            pictureBox.LoadCompleted += PictureBox_LoadCompleted;
            Controls.Add(pictureBox);
        }
        private void PictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }
    }
}
