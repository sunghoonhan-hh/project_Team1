namespace Kiosk
{
    partial class 매장포장
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTakeout = new MyButton.Custom_Button();
            this.btnStore = new MyButton.Custom_Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("메이플스토리", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(126, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "KW Coffee";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTakeout
            // 
            this.btnTakeout.BackColor = System.Drawing.Color.White;
            this.btnTakeout.FlatAppearance.BorderSize = 0;
            this.btnTakeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeout.Font = new System.Drawing.Font("메이플스토리", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTakeout.IsMaximum = false;
            this.btnTakeout.Location = new System.Drawing.Point(320, 218);
            this.btnTakeout.Name = "btnTakeout";
            this.btnTakeout.Radius = 20;
            this.btnTakeout.Size = new System.Drawing.Size(220, 414);
            this.btnTakeout.TabIndex = 1;
            this.btnTakeout.Text = "포장";
            this.btnTakeout.UseVisualStyleBackColor = false;
            this.btnTakeout.Click += new System.EventHandler(this.btnTakeout_Click);
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.White;
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("메이플스토리", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStore.IsMaximum = false;
            this.btnStore.Location = new System.Drawing.Point(40, 218);
            this.btnStore.Name = "btnStore";
            this.btnStore.Radius = 20;
            this.btnStore.Size = new System.Drawing.Size(220, 414);
            this.btnStore.TabIndex = 0;
            this.btnStore.Text = "매장";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // 매장포장
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(582, 853);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTakeout);
            this.Controls.Add(this.btnStore);
            this.Name = "매장포장";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton.Custom_Button btnStore;
        private MyButton.Custom_Button btnTakeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

