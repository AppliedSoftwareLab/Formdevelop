﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            string workingDirectory1 = @"C:\Users\user\Desktop\rere\FlappyBird2D";
            string batFilePath = @"C:\Users\user\Desktop\rere\FlappyBird2D\GenerateProjectFiles.bat";

        }

        private void Build_btn_Click(object sender, EventArgs e)
        {
            string workingDirectory = @"C:\Users\user\Desktop\rere\FlappyBird2D";
            string batFilePath = @"C:\Users\user\Desktop\rere\FlappyBird2D\GenerateProjectFiles.bat";
            string arguments = "vs2019";

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WorkingDirectory = workingDirectory;
                startInfo.FileName = "cmd.exe";
                startInfo.RedirectStandardInput = true;
                startInfo.UseShellExecute = false;

                Process process2 = new Process();
                process2.StartInfo = startInfo;
                process2.Start();
                // "cd" 명령 실행
                process2.StandardInput.WriteLine($"cd {workingDirectory}");
                // "GenerateProjectFiles.bat" 명령 실행
                process2.StandardInput.WriteLine($"{batFilePath} {arguments}");
                process2.StandardInput.Flush();
                process2.StandardInput.Close();

                process2.WaitForExit();
                // 성공적으로 실행되었을 경우
                if (process2.ExitCode == 0)
                {
                    MessageBox.Show("GenerateprojectFiles.bat 실행이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("GenerateprojectFiles.bat 실행 중 오류가 발생했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GenerateprojectFiles.bat 실행 중 예외가 발생했습니다: " + ex.Message);
            }



        }

    }
}
