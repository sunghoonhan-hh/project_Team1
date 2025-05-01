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
            this.btn_simple_payment = new MyButton.CustomButton();
            this.btn_cuppon_payment = new MyButton.CustomButton();
            this.btn_credit_payment = new MyButton.CustomButton();
            this.listBox_goods = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_simple_payment
            // 
            this.btn_simple_payment.BackColor = System.Drawing.Color.White;
            this.btn_simple_payment.FlatAppearance.BorderSize = 0;
            this.btn_simple_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simple_payment.IsMaximum = false;
            this.btn_simple_payment.Location = new System.Drawing.Point(68, 101);
            this.btn_simple_payment.Name = "btn_simple_payment";
            this.btn_simple_payment.Radius = 40;
            this.btn_simple_payment.Size = new System.Drawing.Size(211, 93);
            this.btn_simple_payment.TabIndex = 0;
            this.btn_simple_payment.Text = "간편결제";
            this.btn_simple_payment.UseVisualStyleBackColor = false;
            this.btn_simple_payment.Click += new System.EventHandler(this.btn_simple_payment_Click);
            // 
            // btn_cuppon_payment
            // 
            this.btn_cuppon_payment.BackColor = System.Drawing.Color.White;
            this.btn_cuppon_payment.FlatAppearance.BorderSize = 0;
            this.btn_cuppon_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cuppon_payment.IsMaximum = false;
            this.btn_cuppon_payment.Location = new System.Drawing.Point(68, 341);
            this.btn_cuppon_payment.Name = "btn_cuppon_payment";
            this.btn_cuppon_payment.Radius = 40;
            this.btn_cuppon_payment.Size = new System.Drawing.Size(211, 93);
            this.btn_cuppon_payment.TabIndex = 1;
            this.btn_cuppon_payment.Text = "쿠폰결제";
            this.btn_cuppon_payment.UseVisualStyleBackColor = false;
            this.btn_cuppon_payment.Click += new System.EventHandler(this.btn_cuppon_payment_Click);
            // 
            // btn_credit_payment
            // 
            this.btn_credit_payment.BackColor = System.Drawing.Color.White;
            this.btn_credit_payment.FlatAppearance.BorderSize = 0;
            this.btn_credit_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_credit_payment.IsMaximum = false;
            this.btn_credit_payment.Location = new System.Drawing.Point(68, 219);
            this.btn_credit_payment.Name = "btn_credit_payment";
            this.btn_credit_payment.Radius = 40;
            this.btn_credit_payment.Size = new System.Drawing.Size(211, 93);
            this.btn_credit_payment.TabIndex = 2;
            this.btn_credit_payment.Text = "신용카드";
            this.btn_credit_payment.UseVisualStyleBackColor = false;
            this.btn_credit_payment.Click += new System.EventHandler(this.btn_credit_payment_Click);
            // 
            // listBox_goods
            // 
            this.listBox_goods.FormattingEnabled = true;
            this.listBox_goods.ItemHeight = 24;
            this.listBox_goods.Location = new System.Drawing.Point(351, 111);
            this.listBox_goods.Name = "listBox_goods";
            this.listBox_goods.Size = new System.Drawing.Size(507, 172);
            this.listBox_goods.TabIndex = 3;
            // 
            // Form_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(906, 660);
            this.Controls.Add(this.listBox_goods);
            this.Controls.Add(this.btn_credit_payment);
            this.Controls.Add(this.btn_cuppon_payment);
            this.Controls.Add(this.btn_simple_payment);
            this.Name = "Form_payment";
            this.Text = "결제";
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton.CustomButton btn_simple_payment;
        private MyButton.CustomButton btn_cuppon_payment;
        private MyButton.CustomButton btn_credit_payment;
        private System.Windows.Forms.ListBox listBox_goods;
    }
}