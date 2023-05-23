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
            try
            {
                string batFilePath1 = "GenerateprojectFiles.bat";
                // Process 객체 생성
                System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                // Process에 실행할 파일과 인수 설정
                process1.StartInfo.FileName = batFilePath1;
                process1.StartInfo.UseShellExecute = false;
                process1.StartInfo.CreateNoWindow = true;

                // Process 실행
                process1.Start();
                process1.WaitForExit();
                // 성공적으로 실행되었을 경우
                if (process1.ExitCode == 0)
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

        private void Build_btn_Click(object sender, EventArgs e)
        {
            string batFilePath2 = "FontAtlas.bat";
            // Process 객체 생성
            System.Diagnostics.Process process2 = new System.Diagnostics.Process();
            // Process에 실행할 파일과 인수 설정
            process2.StartInfo.FileName = batFilePath2;
            process2.StartInfo.UseShellExecute = false;
            process2.StartInfo.CreateNoWindow = true;

            // Process 실행
            process2.Start();
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
    }
}
