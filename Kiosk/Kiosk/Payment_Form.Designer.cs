namespace Kiosk
{
    partial class Form_payment
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
            this.btn_cuppon_payment = new MyButton.CustomButton();
            this.btn_credit_payment = new MyButton.CustomButton();
            this.btn_cancel = new MyButton.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cuppon_payment
            // 
            this.btn_cuppon_payment.BackColor = System.Drawing.Color.White;
            this.btn_cuppon_payment.FlatAppearance.BorderSize = 0;
            this.btn_cuppon_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cuppon_payment.IsMaximum = false;
            this.btn_cuppon_payment.Location = new System.Drawing.Point(552, 156);
            this.btn_cuppon_payment.Name = "btn_cuppon_payment";
            this.btn_cuppon_payment.Radius = 40;
            this.btn_cuppon_payment.Size = new System.Drawing.Size(211, 200);
            this.btn_cuppon_payment.TabIndex = 1;
            this.btn_cuppon_payment.UseVisualStyleBackColor = false;
            this.btn_cuppon_payment.Click += new System.EventHandler(this.btn_cuppon_payment_Click);
            // 
            // btn_credit_payment
            // 
            this.btn_credit_payment.BackColor = System.Drawing.Color.White;
            this.btn_credit_payment.FlatAppearance.BorderSize = 0;
            this.btn_credit_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_credit_payment.IsMaximum = false;
            this.btn_credit_payment.Location = new System.Drawing.Point(230, 156);
            this.btn_credit_payment.Name = "btn_credit_payment";
            this.btn_credit_payment.Radius = 40;
            this.btn_credit_payment.Size = new System.Drawing.Size(211, 200);
            this.btn_credit_payment.TabIndex = 2;
            this.btn_credit_payment.UseVisualStyleBackColor = false;
            this.btn_credit_payment.Click += new System.EventHandler(this.btn_credit_payment_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Window;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.IsMaximum = true;
            this.btn_cancel.Location = new System.Drawing.Point(289, 433);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Radius = 20;
            this.btn_cancel.Size = new System.Drawing.Size(428, 61);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "결제 취소";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "카드 결제";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "현금결제";
            // 
            // Form_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1033, 580);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_credit_payment);
            this.Controls.Add(this.btn_cuppon_payment);
            this.Name = "Form_payment";
            this.Text = "결제";
            this.Load += new System.EventHandler(this.Form_payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyButton.CustomButton btn_cuppon_payment;
        private MyButton.CustomButton btn_credit_payment;
        private MyButton.CustomButton btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}