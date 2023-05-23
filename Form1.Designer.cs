
namespace DBViewer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Build_btn = new System.Windows.Forms.Button();
            this.Reload_btn = new System.Windows.Forms.Button();
            this.Generate_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Build_btn
            // 
            this.Build_btn.Font = new System.Drawing.Font("HY헤드라인M", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Build_btn.Location = new System.Drawing.Point(56, 366);
            this.Build_btn.Name = "Build_btn";
            this.Build_btn.Size = new System.Drawing.Size(455, 60);
            this.Build_btn.TabIndex = 2;
            this.Build_btn.Text = "Build";
            this.Build_btn.UseVisualStyleBackColor = true;
            // 
            // Reload_btn
            // 
            this.Reload_btn.Font = new System.Drawing.Font("HY헤드라인M", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Reload_btn.Location = new System.Drawing.Point(56, 283);
            this.Reload_btn.Name = "Reload_btn";
            this.Reload_btn.Size = new System.Drawing.Size(455, 62);
            this.Reload_btn.TabIndex = 3;
            this.Reload_btn.Text = "HotReload";
            this.Reload_btn.UseVisualStyleBackColor = true;
            // 
            // Generate_btn
            // 
            this.Generate_btn.Font = new System.Drawing.Font("HY헤드라인M", 20F, System.Drawing.FontStyle.Bold);
            this.Generate_btn.Location = new System.Drawing.Point(56, 197);
            this.Generate_btn.Name = "Generate_btn";
            this.Generate_btn.Size = new System.Drawing.Size(455, 66);
            this.Generate_btn.TabIndex = 4;
            this.Generate_btn.Text = "GeneateProjectFiles";
            this.Generate_btn.UseVisualStyleBackColor = true;
            this.Generate_btn.Click += new System.EventHandler(this.Generate_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 159);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Generate_btn);
            this.Controls.Add(this.Reload_btn);
            this.Controls.Add(this.Build_btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Build_btn;
        private System.Windows.Forms.Button Reload_btn;
        private System.Windows.Forms.Button Generate_btn;
        private System.Windows.Forms.Panel panel1;
    }
}

