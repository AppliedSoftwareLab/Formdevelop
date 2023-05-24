using System;
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
            try
            {
                string batFilePath1 = "asd.bat";//폰트아틀라스or gereateProject의 path
                // Process 객체 생성
                System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                // Process에 실행할 파일과 인수 설정
                process1.StartInfo.FileName = batFilePath1;
                process1.StartInfo.UseShellExecute = false;// 운영체제의 shell를 사용하여 열건지에 대한것 false시 사용안함
                process1.StartInfo.CreateNoWindow = false;//프로그램 실행시 윈도우창이 열리는 지에대함 true시 윈도우 창이 표시안됨 

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
            string workingDirectory = @"C:\Users\user\Desktop\rere\FlappyBird2D";
            string batFilePath = @"C:\Users\user\Desktop\rere\FlappyBird2D\GenerateProjectFiles.bat";
            string arguments = "vs2019";

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();

        }
    }
}
