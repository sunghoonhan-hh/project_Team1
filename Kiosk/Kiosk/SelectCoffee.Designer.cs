﻿namespace Kiosk
{
    partial class SelectCoffee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bucket = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picture_Calculate = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picture_Home = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.total = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bucket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Calculate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kiosk.Properties.Resources.circle;
            this.pictureBox1.Location = new System.Drawing.Point(487, 640);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.DeleteBucket);
            // 
            // bucket
            // 
            this.bucket.AutoScroll = true;
            this.bucket.BackColor = System.Drawing.Color.White;
            this.bucket.Controls.Add(this.panel1);
            this.bucket.Location = new System.Drawing.Point(8, 639);
            this.bucket.Name = "bucket";
            this.bucket.Size = new System.Drawing.Size(339, 202);
            this.bucket.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 15);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("메이플스토리", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(357, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "남은시간";
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("메이플스토리", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Timer.ForeColor = System.Drawing.Color.Tomato;
            this.label_Timer.Location = new System.Drawing.Point(357, 688);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(89, 33);
            this.label_Timer.TabIndex = 3;
            this.label_Timer.Text = "120초";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(363, 729);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 2);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("메이플스토리", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(372, 738);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "선택한 상품";
            // 
            // menuCount
            // 
            this.menuCount.AutoSize = true;
            this.menuCount.Font = new System.Drawing.Font("메이플스토리", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuCount.Location = new System.Drawing.Point(507, 738);
            this.menuCount.Name = "menuCount";
            this.menuCount.Size = new System.Drawing.Size(49, 26);
            this.menuCount.TabIndex = 6;
            this.menuCount.Text = "0개";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(79)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("메이플스토리", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(503, 656);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 53);
            this.label5.TabIndex = 7;
            this.label5.Text = "전체삭제";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.DeleteBucket);
            // 
            // picture_Calculate
            // 
            this.picture_Calculate.Image = global::Kiosk.Properties.Resources.cards;
            this.picture_Calculate.Location = new System.Drawing.Point(363, 774);
            this.picture_Calculate.Name = "picture_Calculate";
            this.picture_Calculate.Size = new System.Drawing.Size(214, 83);
            this.picture_Calculate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Calculate.TabIndex = 8;
            this.picture_Calculate.TabStop = false;
            this.picture_Calculate.Click += new System.EventHandler(this.picture_Calculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("메이플스토리", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(181, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 41);
            this.label6.TabIndex = 9;
            this.label6.Text = "KW COFFEE";
            // 
            // picture_Home
            // 
            this.picture_Home.Image = global::Kiosk.Properties.Resources.pngegg;
            this.picture_Home.Location = new System.Drawing.Point(9, 9);
            this.picture_Home.Name = "picture_Home";
            this.picture_Home.Size = new System.Drawing.Size(41, 32);
            this.picture_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Home.TabIndex = 10;
            this.picture_Home.TabStop = false;
            this.picture_Home.Click += new System.EventHandler(this.picture_Home_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.White;
            this.total.Location = new System.Drawing.Point(8, 819);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(339, 38);
            this.total.TabIndex = 13;
            // 
            // SelectCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(582, 853);
            this.Controls.Add(this.total);
            this.Controls.Add(this.picture_Home);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picture_Calculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_Timer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bucket);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SelectCoffee";
            this.Text = "SelectCoffee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectCoffee_FormClosed);
            this.Load += new System.EventHandler(this.SelectCoffee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bucket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Calculate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel bucket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label menuCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picture_Calculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picture_Home;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel total;
    }
}