namespace Kiosk
{
    partial class Product_check_Form
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
            this.btn_payment = new MyButton.CustomButton();
            this.btn_back = new MyButton.CustomButton();
            this.lvw_selected = new System.Windows.Forms.ListView();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_payment.FlatAppearance.BorderSize = 0;
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payment.IsMaximum = true;
            this.btn_payment.Location = new System.Drawing.Point(135, 598);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Radius = 20;
            this.btn_payment.Size = new System.Drawing.Size(346, 81);
            this.btn_payment.TabIndex = 0;
            this.btn_payment.Text = "결제하기";
            this.btn_payment.UseVisualStyleBackColor = false;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.IsMaximum = true;
            this.btn_back.Location = new System.Drawing.Point(549, 598);
            this.btn_back.Name = "btn_back";
            this.btn_back.Radius = 20;
            this.btn_back.Size = new System.Drawing.Size(346, 81);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "뒤로가기";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lvw_selected
            // 
            this.lvw_selected.HideSelection = false;
            this.lvw_selected.Location = new System.Drawing.Point(135, 26);
            this.lvw_selected.Name = "lvw_selected";
            this.lvw_selected.Size = new System.Drawing.Size(760, 425);
            this.lvw_selected.TabIndex = 2;
            this.lvw_selected.UseCompatibleStateImageBehavior = false;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(135, 507);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(760, 35);
            this.txt_total.TabIndex = 3;
            // 
            // Product_check_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1065, 752);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lvw_selected);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_payment);
            this.Name = "Product_check_Form";
            this.Text = "상품확인";
            this.Load += new System.EventHandler(this.Product_check_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton.CustomButton btn_payment;
        private MyButton.CustomButton btn_back;
        private System.Windows.Forms.ListView lvw_selected;
        private System.Windows.Forms.TextBox txt_total;
    }
}