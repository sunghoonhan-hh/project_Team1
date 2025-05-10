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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbAddOns = new System.Windows.Forms.GroupBox();
            this.ChosenMenuImg = new System.Windows.Forms.PictureBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbMilk = new System.Windows.Forms.GroupBox();
            this.gbFreeOptions = new System.Windows.Forms.GroupBox();
            this.gbShot = new System.Windows.Forms.GroupBox();
            this.gbSyrup = new System.Windows.Forms.GroupBox();
            this.CancelAndOrder = new System.Windows.Forms.GroupBox();
            this.ChooseAllOption = new System.Windows.Forms.RichTextBox();
            this.menuName = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChosenMenuImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.25852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.74149F));
            this.tableLayoutPanel1.Controls.Add(this.gbAddOns, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ChosenMenuImg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbSize, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.gbMilk, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.gbFreeOptions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbShot, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.gbSyrup, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CancelAndOrder, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.menuName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChooseAllOption, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.000001F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00027F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66663F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.000001F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 803);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // gbAddOns
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbAddOns, 2);
            this.gbAddOns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddOns.Location = new System.Drawing.Point(3, 652);
            this.gbAddOns.Name = "gbAddOns";
            this.gbAddOns.Size = new System.Drawing.Size(508, 87);
            this.gbAddOns.TabIndex = 5;
            this.gbAddOns.TabStop = false;
            this.gbAddOns.Text = "부가 요소(필수, 복수선택)";
            // 
            // ChosenMenuImg
            // 
            this.ChosenMenuImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChosenMenuImg.Location = new System.Drawing.Point(3, 27);
            this.ChosenMenuImg.Name = "ChosenMenuImg";
            this.ChosenMenuImg.Size = new System.Drawing.Size(144, 154);
            this.ChosenMenuImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChosenMenuImg.TabIndex = 6;
            this.ChosenMenuImg.TabStop = false;
            // 
            // gbSize
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbSize, 2);
            this.gbSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSize.Location = new System.Drawing.Point(3, 559);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(508, 87);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "사이즈(필수, 단일선택)";
            // 
            // gbMilk
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbMilk, 2);
            this.gbMilk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMilk.Location = new System.Drawing.Point(3, 373);
            this.gbMilk.Name = "gbMilk";
            this.gbMilk.Size = new System.Drawing.Size(508, 87);
            this.gbMilk.TabIndex = 2;
            this.gbMilk.TabStop = false;
            this.gbMilk.Text = "우유 변경(필수, 단일선택)";
            // 
            // gbFreeOptions
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbFreeOptions, 2);
            this.gbFreeOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFreeOptions.Location = new System.Drawing.Point(3, 187);
            this.gbFreeOptions.Name = "gbFreeOptions";
            this.gbFreeOptions.Size = new System.Drawing.Size(508, 87);
            this.gbFreeOptions.TabIndex = 0;
            this.gbFreeOptions.TabStop = false;
            this.gbFreeOptions.Text = "-무료 옵션(필수, 단일선택)";
            // 
            // gbShot
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbShot, 2);
            this.gbShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbShot.Location = new System.Drawing.Point(3, 466);
            this.gbShot.Name = "gbShot";
            this.gbShot.Size = new System.Drawing.Size(508, 87);
            this.gbShot.TabIndex = 3;
            this.gbShot.TabStop = false;
            this.gbShot.Text = "샷 추가(필수, 단일선택)";
            // 
            // gbSyrup
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbSyrup, 2);
            this.gbSyrup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSyrup.Location = new System.Drawing.Point(3, 280);
            this.gbSyrup.Name = "gbSyrup";
            this.gbSyrup.Size = new System.Drawing.Size(508, 87);
            this.gbSyrup.TabIndex = 1;
            this.gbSyrup.TabStop = false;
            this.gbSyrup.Text = "시럽 추가(필수, 단일선택)";
            // 
            // CancelAndOrder
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CancelAndOrder, 2);
            this.CancelAndOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelAndOrder.Location = new System.Drawing.Point(3, 745);
            this.CancelAndOrder.Name = "CancelAndOrder";
            this.CancelAndOrder.Size = new System.Drawing.Size(508, 55);
            this.CancelAndOrder.TabIndex = 7;
            this.CancelAndOrder.TabStop = false;
            // 
            // ChooseAllOption
            // 
            this.ChooseAllOption.BackColor = System.Drawing.Color.Gold;
            this.tableLayoutPanel1.SetColumnSpan(this.ChooseAllOption, 2);
            this.ChooseAllOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChooseAllOption.Font = new System.Drawing.Font("휴먼엑스포", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChooseAllOption.ForeColor = System.Drawing.Color.Black;
            this.ChooseAllOption.Location = new System.Drawing.Point(3, 3);
            this.ChooseAllOption.Name = "ChooseAllOption";
            this.ChooseAllOption.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ChooseAllOption.Size = new System.Drawing.Size(508, 18);
            this.ChooseAllOption.TabIndex = 9;
            this.ChooseAllOption.Text = "선택하신 상품의 옵션상품을 모두 선택해주세요";
            // 
            // menuName
            // 
            this.menuName.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuName.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuName.Location = new System.Drawing.Point(153, 27);
            this.menuName.Name = "menuName";
            this.menuName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.menuName.Size = new System.Drawing.Size(358, 45);
            this.menuName.TabIndex = 8;
            this.menuName.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 803);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChosenMenuImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddOns;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbShot;
        private System.Windows.Forms.GroupBox gbMilk;
        private System.Windows.Forms.GroupBox gbSyrup;
        private System.Windows.Forms.GroupBox gbFreeOptions;
        private System.Windows.Forms.PictureBox ChosenMenuImg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox CancelAndOrder;
        private System.Windows.Forms.RichTextBox ChooseAllOption;
        private System.Windows.Forms.RichTextBox menuName;
    }
}

