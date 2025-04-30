namespace Kiosk
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
            this.customButton1 = new MyButton.CustomButton();
            this.customButton2 = new MyButton.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.White;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("메이플스토리", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton1.IsMaximum = false;
            this.customButton1.Location = new System.Drawing.Point(40, 218);
            this.customButton1.Name = "customButton1";
            this.customButton1.Radius = 20;
            this.customButton1.Size = new System.Drawing.Size(220, 414);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "매장";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.White;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("메이플스토리", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customButton2.IsMaximum = false;
            this.customButton2.Location = new System.Drawing.Point(320, 218);
            this.customButton2.Name = "customButton2";
            this.customButton2.Radius = 20;
            this.customButton2.Size = new System.Drawing.Size(220, 414);
            this.customButton2.TabIndex = 1;
            this.customButton2.Text = "포장";
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("메이플스토리", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(118, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "KW Coffee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(582, 853);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton.CustomButton customButton1;
        private MyButton.CustomButton customButton2;
        private System.Windows.Forms.Label label1;
    }
}

