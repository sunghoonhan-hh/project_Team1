using System.Windows.Forms;

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
            this.gbSize = new System.Windows.Forms.TableLayoutPanel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdoNoSize = new System.Windows.Forms.CheckBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rdoSizeUp = new System.Windows.Forms.RadioButton();
            this.gbShot = new System.Windows.Forms.TableLayoutPanel();
            this.gbShotOptions = new System.Windows.Forms.Panel();
            this.rdoDecaf2Shot = new System.Windows.Forms.RadioButton();
            this.rdo2Shot = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.rdoShot = new System.Windows.Forms.RadioButton();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdoNoShot = new System.Windows.Forms.CheckBox();
            this.gbSyrup = new System.Windows.Forms.TableLayoutPanel();
            this.gbSyrupOptions = new System.Windows.Forms.Panel();
            this.rdoSyrupCaramel = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdoSyrupHazelnut = new System.Windows.Forms.RadioButton();
            this.rdoSyrupVanilla = new System.Windows.Forms.RadioButton();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoNoSyrup = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdoSteviaSyrup = new System.Windows.Forms.RadioButton();
            this.gbFreeOptions = new System.Windows.Forms.TableLayoutPanel();
            this.gbSweetnessOptions = new System.Windows.Forms.Panel();
            this.rdoLessSweet = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdoSweet = new System.Windows.Forms.RadioButton();
            this.gbIceOptions = new System.Windows.Forms.Panel();
            this.rdoIceMore = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rdoIceLess = new System.Windows.Forms.RadioButton();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoNoFreeOption = new System.Windows.Forms.CheckBox();
            this.gbMilk = new System.Windows.Forms.TableLayoutPanel();
            this.gbMilkOptions = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.rdoMilkOat = new System.Windows.Forms.RadioButton();
            this.rdoMilkAlmond = new System.Windows.Forms.RadioButton();
            this.rdoMilkSoy = new System.Windows.Forms.RadioButton();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoNoMilk = new System.Windows.Forms.CheckBox();
            this.ChosenMenuImg = new System.Windows.Forms.PictureBox();
            this.ChooseAllOption = new System.Windows.Forms.RichTextBox();
            this.NamePriceOptions = new System.Windows.Forms.TableLayoutPanel();
            this.MenuOptionsView = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.MenuName = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.MenuPrice = new System.Windows.Forms.TextBox();
            this.gbAddOns = new System.Windows.Forms.TableLayoutPanel();
            this.gbDrizzleOptions = new System.Windows.Forms.Panel();
            this.rdoDrizzleCaramel = new System.Windows.Forms.RadioButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.rdoDrizzleChocolate = new System.Windows.Forms.RadioButton();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chkNoAddOns = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chkPearl = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.chkWhippedCream = new System.Windows.Forms.CheckBox();
            this.CancelAndOrder = new System.Windows.Forms.TableLayoutPanel();
            this.cancel = new System.Windows.Forms.Button();
            this.getMenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.gbShot.SuspendLayout();
            this.gbShotOptions.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbSyrup.SuspendLayout();
            this.gbSyrupOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbFreeOptions.SuspendLayout();
            this.gbSweetnessOptions.SuspendLayout();
            this.gbIceOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbMilk.SuspendLayout();
            this.gbMilkOptions.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChosenMenuImg)).BeginInit();
            this.NamePriceOptions.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.gbAddOns.SuspendLayout();
            this.gbDrizzleOptions.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.CancelAndOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.25852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.74149F));
            this.tableLayoutPanel1.Controls.Add(this.gbSize, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.gbShot, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.gbSyrup, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gbFreeOptions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbMilk, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ChosenMenuImg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChooseAllOption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NamePriceOptions, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbAddOns, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.CancelAndOrder, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00027F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66663F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.66662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 1060);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.White;
            this.gbSize.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.gbSize, 2);
            this.gbSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbSize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.gbSize.Controls.Add(this.textBox11, 0, 0);
            this.gbSize.Controls.Add(this.panel6, 1, 0);
            this.gbSize.Controls.Add(this.panel10, 2, 0);
            this.gbSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSize.Location = new System.Drawing.Point(4, 761);
            this.gbSize.Margin = new System.Windows.Forms.Padding(4);
            this.gbSize.Name = "gbSize";
            this.gbSize.RowCount = 1;
            this.gbSize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gbSize.Size = new System.Drawing.Size(925, 115);
            this.gbSize.TabIndex = 19;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Gold;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox11.Font = new System.Drawing.Font("Maplestory", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox11.ForeColor = System.Drawing.Color.Black;
            this.textBox11.Location = new System.Drawing.Point(4, 4);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(130, 107);
            this.textBox11.TabIndex = 3;
            this.textBox11.Text = "<사이즈>\r\n(필수, 단일 선택)";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Controls.Add(this.rdoNoSize);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(142, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(130, 107);
            this.panel6.TabIndex = 4;
            // 
            // rdoNoSize
            // 
            this.rdoNoSize.AutoSize = true;
            this.rdoNoSize.BackColor = System.Drawing.Color.OldLace;
            this.rdoNoSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoNoSize.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoNoSize.Location = new System.Drawing.Point(0, 0);
            this.rdoNoSize.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNoSize.Name = "rdoNoSize";
            this.rdoNoSize.Size = new System.Drawing.Size(130, 107);
            this.rdoNoSize.TabIndex = 2;
            this.rdoNoSize.Text = "선택안함 (+0)";
            this.rdoNoSize.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gold;
            this.panel10.Controls.Add(this.rdoSizeUp);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(280, 4);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(641, 107);
            this.panel10.TabIndex = 5;
            // 
            // rdoSizeUp
            // 
            this.rdoSizeUp.AutoSize = true;
            this.rdoSizeUp.BackColor = System.Drawing.Color.OldLace;
            this.rdoSizeUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoSizeUp.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoSizeUp.Location = new System.Drawing.Point(0, 0);
            this.rdoSizeUp.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSizeUp.Name = "rdoSizeUp";
            this.rdoSizeUp.Size = new System.Drawing.Size(641, 107);
            this.rdoSizeUp.TabIndex = 1;
            this.rdoSizeUp.TabStop = true;
            this.rdoSizeUp.Text = "컵 사이즈 업그레이드 (+1000)";
            this.rdoSizeUp.UseVisualStyleBackColor = false;
            this.rdoSizeUp.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // gbShot
            // 
            this.gbShot.BackColor = System.Drawing.Color.White;
            this.gbShot.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.gbShot, 2);
            this.gbShot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbShot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbShot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.gbShot.Controls.Add(this.gbShotOptions, 2, 0);
            this.gbShot.Controls.Add(this.textBox10, 0, 0);
            this.gbShot.Controls.Add(this.panel5, 1, 0);
            this.gbShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbShot.Location = new System.Drawing.Point(4, 638);
            this.gbShot.Margin = new System.Windows.Forms.Padding(4);
            this.gbShot.Name = "gbShot";
            this.gbShot.RowCount = 1;
            this.gbShot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gbShot.Size = new System.Drawing.Size(925, 115);
            this.gbShot.TabIndex = 17;
            // 
            // gbShotOptions
            // 
            this.gbShotOptions.BackColor = System.Drawing.Color.OldLace;
            this.gbShotOptions.Controls.Add(this.rdoDecaf2Shot);
            this.gbShotOptions.Controls.Add(this.rdo2Shot);
            this.gbShotOptions.Controls.Add(this.textBox5);
            this.gbShotOptions.Controls.Add(this.rdoShot);
            this.gbShotOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbShotOptions.Location = new System.Drawing.Point(280, 4);
            this.gbShotOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbShotOptions.Name = "gbShotOptions";
            this.gbShotOptions.Size = new System.Drawing.Size(641, 107);
            this.gbShotOptions.TabIndex = 2;
            // 
            // rdoDecaf2Shot
            // 
            this.rdoDecaf2Shot.AutoSize = true;
            this.rdoDecaf2Shot.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoDecaf2Shot.Location = new System.Drawing.Point(396, 39);
            this.rdoDecaf2Shot.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDecaf2Shot.Name = "rdoDecaf2Shot";
            this.rdoDecaf2Shot.Size = new System.Drawing.Size(225, 24);
            this.rdoDecaf2Shot.TabIndex = 2;
            this.rdoDecaf2Shot.TabStop = true;
            this.rdoDecaf2Shot.Text = "디카페인 2샷 추가 (+800)";
            this.rdoDecaf2Shot.UseVisualStyleBackColor = true;
            this.rdoDecaf2Shot.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdo2Shot
            // 
            this.rdo2Shot.AutoSize = true;
            this.rdo2Shot.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdo2Shot.Location = new System.Drawing.Point(221, 39);
            this.rdo2Shot.Margin = new System.Windows.Forms.Padding(4);
            this.rdo2Shot.Name = "rdo2Shot";
            this.rdo2Shot.Size = new System.Drawing.Size(156, 24);
            this.rdo2Shot.TabIndex = 1;
            this.rdo2Shot.TabStop = true;
            this.rdo2Shot.Text = "2샷 추가 (+500)";
            this.rdo2Shot.UseVisualStyleBackColor = true;
            this.rdo2Shot.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Gold;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox5.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5.Location = new System.Drawing.Point(0, 0);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(641, 21);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "샷 종류(선택)";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoShot
            // 
            this.rdoShot.AutoSize = true;
            this.rdoShot.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoShot.Location = new System.Drawing.Point(41, 39);
            this.rdoShot.Margin = new System.Windows.Forms.Padding(4);
            this.rdoShot.Name = "rdoShot";
            this.rdoShot.Size = new System.Drawing.Size(154, 24);
            this.rdoShot.TabIndex = 0;
            this.rdoShot.TabStop = true;
            this.rdoShot.Text = "1샷 추가 (+300)";
            this.rdoShot.UseVisualStyleBackColor = true;
            this.rdoShot.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.Gold;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.Font = new System.Drawing.Font("Maplestory", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox10.ForeColor = System.Drawing.Color.Black;
            this.textBox10.Location = new System.Drawing.Point(4, 4);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(130, 107);
            this.textBox10.TabIndex = 4;
            this.textBox10.Text = "<샷 추가>\r\n(필수, 단일선택)";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Controls.Add(this.rdoNoShot);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(142, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 107);
            this.panel5.TabIndex = 5;
            // 
            // rdoNoShot
            // 
            this.rdoNoShot.AutoSize = true;
            this.rdoNoShot.BackColor = System.Drawing.Color.OldLace;
            this.rdoNoShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoNoShot.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoNoShot.Location = new System.Drawing.Point(0, 0);
            this.rdoNoShot.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNoShot.Name = "rdoNoShot";
            this.rdoNoShot.Size = new System.Drawing.Size(130, 107);
            this.rdoNoShot.TabIndex = 3;
            this.rdoNoShot.Text = "선택안함 (+0)";
            this.rdoNoShot.UseVisualStyleBackColor = false;
            // 
            // gbSyrup
            // 
            this.gbSyrup.BackColor = System.Drawing.Color.White;
            this.gbSyrup.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.gbSyrup, 2);
            this.gbSyrup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbSyrup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gbSyrup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.gbSyrup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.gbSyrup.Controls.Add(this.gbSyrupOptions, 3, 0);
            this.gbSyrup.Controls.Add(this.textBox8, 0, 0);
            this.gbSyrup.Controls.Add(this.panel2, 1, 0);
            this.gbSyrup.Controls.Add(this.panel4, 2, 0);
            this.gbSyrup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSyrup.Location = new System.Drawing.Point(4, 392);
            this.gbSyrup.Margin = new System.Windows.Forms.Padding(4);
            this.gbSyrup.Name = "gbSyrup";
            this.gbSyrup.RowCount = 1;
            this.gbSyrup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gbSyrup.Size = new System.Drawing.Size(925, 115);
            this.gbSyrup.TabIndex = 14;
            // 
            // gbSyrupOptions
            // 
            this.gbSyrupOptions.BackColor = System.Drawing.Color.OldLace;
            this.gbSyrupOptions.Controls.Add(this.rdoSyrupCaramel);
            this.gbSyrupOptions.Controls.Add(this.textBox1);
            this.gbSyrupOptions.Controls.Add(this.rdoSyrupHazelnut);
            this.gbSyrupOptions.Controls.Add(this.rdoSyrupVanilla);
            this.gbSyrupOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSyrupOptions.Location = new System.Drawing.Point(391, 4);
            this.gbSyrupOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbSyrupOptions.Name = "gbSyrupOptions";
            this.gbSyrupOptions.Size = new System.Drawing.Size(530, 107);
            this.gbSyrupOptions.TabIndex = 3;
            // 
            // rdoSyrupCaramel
            // 
            this.rdoSyrupCaramel.AutoSize = true;
            this.rdoSyrupCaramel.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoSyrupCaramel.Location = new System.Drawing.Point(347, 28);
            this.rdoSyrupCaramel.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSyrupCaramel.Name = "rdoSyrupCaramel";
            this.rdoSyrupCaramel.Size = new System.Drawing.Size(152, 44);
            this.rdoSyrupCaramel.TabIndex = 2;
            this.rdoSyrupCaramel.TabStop = true;
            this.rdoSyrupCaramel.Text = "카라멜 시럽 추가\r\n(+500)";
            this.rdoSyrupCaramel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gold;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "시럽(+500, 택1)";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoSyrupHazelnut
            // 
            this.rdoSyrupHazelnut.AutoSize = true;
            this.rdoSyrupHazelnut.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoSyrupHazelnut.Location = new System.Drawing.Point(169, 30);
            this.rdoSyrupHazelnut.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSyrupHazelnut.Name = "rdoSyrupHazelnut";
            this.rdoSyrupHazelnut.Size = new System.Drawing.Size(169, 44);
            this.rdoSyrupHazelnut.TabIndex = 1;
            this.rdoSyrupHazelnut.TabStop = true;
            this.rdoSyrupHazelnut.Text = "헤이즐넛 시럽 추가\r\n(+500)";
            this.rdoSyrupHazelnut.UseVisualStyleBackColor = true;
            // 
            // rdoSyrupVanilla
            // 
            this.rdoSyrupVanilla.AutoSize = true;
            this.rdoSyrupVanilla.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoSyrupVanilla.Location = new System.Drawing.Point(4, 30);
            this.rdoSyrupVanilla.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSyrupVanilla.Name = "rdoSyrupVanilla";
            this.rdoSyrupVanilla.Size = new System.Drawing.Size(153, 44);
            this.rdoSyrupVanilla.TabIndex = 0;
            this.rdoSyrupVanilla.TabStop = true;
            this.rdoSyrupVanilla.Text = "바닐라 시럽 추가\r\n(+500)";
            this.rdoSyrupVanilla.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Gold;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Font = new System.Drawing.Font("Maplestory", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(4, 4);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(130, 107);
            this.textBox8.TabIndex = 5;
            this.textBox8.Text = "<시럽추가>\r\n(필수, 단일선택)";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.rdoNoSyrup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(142, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 107);
            this.panel2.TabIndex = 6;
            // 
            // rdoNoSyrup
            // 
            this.rdoNoSyrup.AutoSize = true;
            this.rdoNoSyrup.BackColor = System.Drawing.Color.OldLace;
            this.rdoNoSyrup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoNoSyrup.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoNoSyrup.Location = new System.Drawing.Point(0, 0);
            this.rdoNoSyrup.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNoSyrup.Name = "rdoNoSyrup";
            this.rdoNoSyrup.Size = new System.Drawing.Size(84, 107);
            this.rdoNoSyrup.TabIndex = 4;
            this.rdoNoSyrup.Text = "선택안함 (+0)";
            this.rdoNoSyrup.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Controls.Add(this.rdoSteviaSyrup);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(234, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 107);
            this.panel4.TabIndex = 7;
            // 
            // rdoSteviaSyrup
            // 
            this.rdoSteviaSyrup.AutoSize = true;
            this.rdoSteviaSyrup.BackColor = System.Drawing.Color.OldLace;
            this.rdoSteviaSyrup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoSteviaSyrup.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoSteviaSyrup.Location = new System.Drawing.Point(0, 0);
            this.rdoSteviaSyrup.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSteviaSyrup.Name = "rdoSteviaSyrup";
            this.rdoSteviaSyrup.Size = new System.Drawing.Size(149, 107);
            this.rdoSteviaSyrup.TabIndex = 1;
            this.rdoSteviaSyrup.TabStop = true;
            this.rdoSteviaSyrup.Text = "스테비아(저당)추가 (+500)";
            this.rdoSteviaSyrup.UseVisualStyleBackColor = false;
            // 
            // gbFreeOptions
            // 
            this.gbFreeOptions.BackColor = System.Drawing.Color.White;
            this.gbFreeOptions.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.gbFreeOptions, 2);
            this.gbFreeOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbFreeOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbFreeOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.gbFreeOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.gbFreeOptions.Controls.Add(this.gbSweetnessOptions, 3, 0);
            this.gbFreeOptions.Controls.Add(this.gbIceOptions, 2, 0);
            this.gbFreeOptions.Controls.Add(this.textBox7, 0, 0);
            this.gbFreeOptions.Controls.Add(this.panel1, 1, 0);
            this.gbFreeOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFreeOptions.Location = new System.Drawing.Point(4, 269);
            this.gbFreeOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbFreeOptions.Name = "gbFreeOptions";
            this.gbFreeOptions.RowCount = 1;
            this.gbFreeOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gbFreeOptions.Size = new System.Drawing.Size(925, 115);
            this.gbFreeOptions.TabIndex = 12;
            // 
            // gbSweetnessOptions
            // 
            this.gbSweetnessOptions.BackColor = System.Drawing.Color.OldLace;
            this.gbSweetnessOptions.Controls.Add(this.rdoLessSweet);
            this.gbSweetnessOptions.Controls.Add(this.textBox2);
            this.gbSweetnessOptions.Controls.Add(this.rdoSweet);
            this.gbSweetnessOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSweetnessOptions.Location = new System.Drawing.Point(603, 4);
            this.gbSweetnessOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbSweetnessOptions.Name = "gbSweetnessOptions";
            this.gbSweetnessOptions.Size = new System.Drawing.Size(318, 107);
            this.gbSweetnessOptions.TabIndex = 0;
            // 
            // rdoLessSweet
            // 
            this.rdoLessSweet.AutoSize = true;
            this.rdoLessSweet.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoLessSweet.Location = new System.Drawing.Point(156, 42);
            this.rdoLessSweet.Margin = new System.Windows.Forms.Padding(4);
            this.rdoLessSweet.Name = "rdoLessSweet";
            this.rdoLessSweet.Size = new System.Drawing.Size(121, 24);
            this.rdoLessSweet.TabIndex = 3;
            this.rdoLessSweet.TabStop = true;
            this.rdoLessSweet.Text = "덜달게 (+0)";
            this.rdoLessSweet.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gold;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 21);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "당도(선택)";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoSweet
            // 
            this.rdoSweet.AutoSize = true;
            this.rdoSweet.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoSweet.Location = new System.Drawing.Point(33, 42);
            this.rdoSweet.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSweet.Name = "rdoSweet";
            this.rdoSweet.Size = new System.Drawing.Size(105, 24);
            this.rdoSweet.TabIndex = 4;
            this.rdoSweet.TabStop = true;
            this.rdoSweet.Text = "달게 (+0)";
            this.rdoSweet.UseVisualStyleBackColor = true;
            // 
            // gbIceOptions
            // 
            this.gbIceOptions.BackColor = System.Drawing.Color.OldLace;
            this.gbIceOptions.Controls.Add(this.rdoIceMore);
            this.gbIceOptions.Controls.Add(this.textBox3);
            this.gbIceOptions.Controls.Add(this.rdoIceLess);
            this.gbIceOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIceOptions.Location = new System.Drawing.Point(280, 4);
            this.gbIceOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbIceOptions.Name = "gbIceOptions";
            this.gbIceOptions.Size = new System.Drawing.Size(315, 107);
            this.gbIceOptions.TabIndex = 0;
            // 
            // rdoIceMore
            // 
            this.rdoIceMore.AutoSize = true;
            this.rdoIceMore.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoIceMore.Location = new System.Drawing.Point(163, 42);
            this.rdoIceMore.Margin = new System.Windows.Forms.Padding(4);
            this.rdoIceMore.Name = "rdoIceMore";
            this.rdoIceMore.Size = new System.Drawing.Size(141, 24);
            this.rdoIceMore.TabIndex = 1;
            this.rdoIceMore.TabStop = true;
            this.rdoIceMore.Text = "얼음 많이 (+0)";
            this.rdoIceMore.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gold;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(315, 21);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "얼음(선택)";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoIceLess
            // 
            this.rdoIceLess.AutoSize = true;
            this.rdoIceLess.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoIceLess.Location = new System.Drawing.Point(10, 42);
            this.rdoIceLess.Margin = new System.Windows.Forms.Padding(4);
            this.rdoIceLess.Name = "rdoIceLess";
            this.rdoIceLess.Size = new System.Drawing.Size(141, 24);
            this.rdoIceLess.TabIndex = 2;
            this.rdoIceLess.TabStop = true;
            this.rdoIceLess.Text = "얼음 적게 (+0)";
            this.rdoIceLess.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.Color.Gold;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Maplestory", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(4, 4);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(130, 107);
            this.textBox7.TabIndex = 2;
            this.textBox7.Text = "<무료옵션>\r\n(필수, 단일선택)";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.rdoNoFreeOption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(142, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 107);
            this.panel1.TabIndex = 3;
            // 
            // rdoNoFreeOption
            // 
            this.rdoNoFreeOption.AutoSize = true;
            this.rdoNoFreeOption.BackColor = System.Drawing.Color.OldLace;
            this.rdoNoFreeOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoNoFreeOption.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoNoFreeOption.Location = new System.Drawing.Point(0, 0);
            this.rdoNoFreeOption.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNoFreeOption.Name = "rdoNoFreeOption";
            this.rdoNoFreeOption.Size = new System.Drawing.Size(130, 107);
            this.rdoNoFreeOption.TabIndex = 1;
            this.rdoNoFreeOption.Text = "선택안함 (+0)";
            this.rdoNoFreeOption.UseVisualStyleBackColor = false;
            // 
            // gbMilk
            // 
            this.gbMilk.BackColor = System.Drawing.Color.White;
            this.gbMilk.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.gbMilk, 2);
            this.gbMilk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbMilk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbMilk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.gbMilk.Controls.Add(this.gbMilkOptions, 2, 0);
            this.gbMilk.Controls.Add(this.textBox9, 0, 0);
            this.gbMilk.Controls.Add(this.panel3, 1, 0);
            this.gbMilk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMilk.Location = new System.Drawing.Point(4, 515);
            this.gbMilk.Margin = new System.Windows.Forms.Padding(4);
            this.gbMilk.Name = "gbMilk";
            this.gbMilk.RowCount = 1;
            this.gbMilk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gbMilk.Size = new System.Drawing.Size(925, 115);
            this.gbMilk.TabIndex = 15;
            // 
            // gbMilkOptions
            // 
            this.gbMilkOptions.BackColor = System.Drawing.Color.OldLace;
            this.gbMilkOptions.Controls.Add(this.textBox4);
            this.gbMilkOptions.Controls.Add(this.rdoMilkOat);
            this.gbMilkOptions.Controls.Add(this.rdoMilkAlmond);
            this.gbMilkOptions.Controls.Add(this.rdoMilkSoy);
            this.gbMilkOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMilkOptions.Location = new System.Drawing.Point(280, 4);
            this.gbMilkOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbMilkOptions.Name = "gbMilkOptions";
            this.gbMilkOptions.Size = new System.Drawing.Size(641, 107);
            this.gbMilkOptions.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Gold;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox4.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(641, 21);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "우유(+700, 택1)";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoMilkOat
            // 
            this.rdoMilkOat.AutoSize = true;
            this.rdoMilkOat.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoMilkOat.Location = new System.Drawing.Point(424, 39);
            this.rdoMilkOat.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMilkOat.Name = "rdoMilkOat";
            this.rdoMilkOat.Size = new System.Drawing.Size(192, 24);
            this.rdoMilkOat.TabIndex = 0;
            this.rdoMilkOat.TabStop = true;
            this.rdoMilkOat.Text = "오트 우유 변경 (+700)";
            this.rdoMilkOat.UseVisualStyleBackColor = true;
            this.rdoMilkOat.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoMilkAlmond
            // 
            this.rdoMilkAlmond.AutoSize = true;
            this.rdoMilkAlmond.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoMilkAlmond.Location = new System.Drawing.Point(189, 39);
            this.rdoMilkAlmond.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMilkAlmond.Name = "rdoMilkAlmond";
            this.rdoMilkAlmond.Size = new System.Drawing.Size(209, 24);
            this.rdoMilkAlmond.TabIndex = 1;
            this.rdoMilkAlmond.TabStop = true;
            this.rdoMilkAlmond.Text = "아몬드 우유 변경 (+700)";
            this.rdoMilkAlmond.UseVisualStyleBackColor = true;
            this.rdoMilkAlmond.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoMilkSoy
            // 
            this.rdoMilkSoy.AutoSize = true;
            this.rdoMilkSoy.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoMilkSoy.Location = new System.Drawing.Point(10, 39);
            this.rdoMilkSoy.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMilkSoy.Name = "rdoMilkSoy";
            this.rdoMilkSoy.Size = new System.Drawing.Size(159, 24);
            this.rdoMilkSoy.TabIndex = 2;
            this.rdoMilkSoy.TabStop = true;
            this.rdoMilkSoy.Text = "두유 변경 (+700)";
            this.rdoMilkSoy.UseVisualStyleBackColor = true;
            this.rdoMilkSoy.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Gold;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Font = new System.Drawing.Font("Maplestory", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(4, 4);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(130, 107);
            this.textBox9.TabIndex = 5;
            this.textBox9.Text = "<우유추가>\r\n(필수, 단일선택)";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.rdoNoMilk);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(142, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 107);
            this.panel3.TabIndex = 6;
            // 
            // rdoNoMilk
            // 
            this.rdoNoMilk.AutoSize = true;
            this.rdoNoMilk.BackColor = System.Drawing.Color.OldLace;
            this.rdoNoMilk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoNoMilk.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoNoMilk.Location = new System.Drawing.Point(0, 0);
            this.rdoNoMilk.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNoMilk.Name = "rdoNoMilk";
            this.rdoNoMilk.Size = new System.Drawing.Size(130, 107);
            this.rdoNoMilk.TabIndex = 4;
            this.rdoNoMilk.Text = "선택안함 (+0)";
            this.rdoNoMilk.UseVisualStyleBackColor = false;
            // 
            // ChosenMenuImg
            // 
            this.ChosenMenuImg.BackColor = System.Drawing.Color.OldLace;
            this.ChosenMenuImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChosenMenuImg.Location = new System.Drawing.Point(4, 57);
            this.ChosenMenuImg.Margin = new System.Windows.Forms.Padding(4);
            this.ChosenMenuImg.Name = "ChosenMenuImg";
            this.ChosenMenuImg.Size = new System.Drawing.Size(264, 204);
            this.ChosenMenuImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChosenMenuImg.TabIndex = 6;
            this.ChosenMenuImg.TabStop = false;
            // 
            // ChooseAllOption
            // 
            this.ChooseAllOption.BackColor = System.Drawing.Color.Gold;
            this.ChooseAllOption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.ChooseAllOption, 2);
            this.ChooseAllOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChooseAllOption.Font = new System.Drawing.Font("Maplestory", 14.95F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChooseAllOption.ForeColor = System.Drawing.Color.Black;
            this.ChooseAllOption.Location = new System.Drawing.Point(4, 4);
            this.ChooseAllOption.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseAllOption.Name = "ChooseAllOption";
            this.ChooseAllOption.ReadOnly = true;
            this.ChooseAllOption.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ChooseAllOption.Size = new System.Drawing.Size(925, 45);
            this.ChooseAllOption.TabIndex = 9;
            this.ChooseAllOption.Text = "선택하신 상품의 옵션을 모두 선택해주세요";
            // 
            // NamePriceOptions
            // 
            this.NamePriceOptions.ColumnCount = 2;
            this.NamePriceOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NamePriceOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NamePriceOptions.Controls.Add(this.MenuOptionsView, 0, 1);
            this.NamePriceOptions.Controls.Add(this.panel11, 0, 0);
            this.NamePriceOptions.Controls.Add(this.panel12, 1, 0);
            this.NamePriceOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NamePriceOptions.Location = new System.Drawing.Point(276, 57);
            this.NamePriceOptions.Margin = new System.Windows.Forms.Padding(4);
            this.NamePriceOptions.Name = "NamePriceOptions";
            this.NamePriceOptions.RowCount = 2;
            this.NamePriceOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NamePriceOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NamePriceOptions.Size = new System.Drawing.Size(653, 204);
            this.NamePriceOptions.TabIndex = 10;
            // 
            // MenuOptionsView
            // 
            this.MenuOptionsView.BackColor = System.Drawing.Color.OldLace;
            this.MenuOptionsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NamePriceOptions.SetColumnSpan(this.MenuOptionsView, 2);
            this.MenuOptionsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuOptionsView.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuOptionsView.Location = new System.Drawing.Point(4, 106);
            this.MenuOptionsView.Margin = new System.Windows.Forms.Padding(4);
            this.MenuOptionsView.Multiline = true;
            this.MenuOptionsView.Name = "MenuOptionsView";
            this.MenuOptionsView.Size = new System.Drawing.Size(645, 94);
            this.MenuOptionsView.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.OldLace;
            this.panel11.Controls.Add(this.MenuName);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(1, 2);
            this.panel11.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(4, 2, 1, 2);
            this.panel11.Size = new System.Drawing.Size(324, 98);
            this.panel11.TabIndex = 3;
            // 
            // MenuName
            // 
            this.MenuName.BackColor = System.Drawing.Color.OldLace;
            this.MenuName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuName.Font = new System.Drawing.Font("Maplestory", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuName.Location = new System.Drawing.Point(6, 18);
            this.MenuName.Margin = new System.Windows.Forms.Padding(4);
            this.MenuName.Multiline = true;
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(310, 64);
            this.MenuName.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.OldLace;
            this.panel12.Controls.Add(this.MenuPrice);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(330, 4);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(4, 2, 1, 2);
            this.panel12.Size = new System.Drawing.Size(319, 94);
            this.panel12.TabIndex = 4;
            // 
            // MenuPrice
            // 
            this.MenuPrice.BackColor = System.Drawing.Color.OldLace;
            this.MenuPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuPrice.Font = new System.Drawing.Font("Maplestory", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuPrice.Location = new System.Drawing.Point(9, 16);
            this.MenuPrice.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPrice.Multiline = true;
            this.MenuPrice.Name = "MenuPrice";
            this.MenuPrice.Size = new System.Drawing.Size(300, 64);
            this.MenuPrice.TabIndex = 0;
            this.MenuPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbAddOns
            // 
            this.gbAddOns.BackColor = System.Drawing.Color.White;
            this.gbAddOns.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.gbAddOns, 2);
            this.gbAddOns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbAddOns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbAddOns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbAddOns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.gbAddOns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.gbAddOns.Controls.Add(this.gbDrizzleOptions, 4, 0);
            this.gbAddOns.Controls.Add(this.textBox12, 0, 0);
            this.gbAddOns.Controls.Add(this.panel7, 1, 0);
            this.gbAddOns.Controls.Add(this.panel8, 2, 0);
            this.gbAddOns.Controls.Add(this.panel9, 3, 0);
            this.gbAddOns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddOns.Location = new System.Drawing.Point(4, 884);
            this.gbAddOns.Margin = new System.Windows.Forms.Padding(4);
            this.gbAddOns.Name = "gbAddOns";
            this.gbAddOns.RowCount = 1;
            this.gbAddOns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gbAddOns.Size = new System.Drawing.Size(925, 115);
            this.gbAddOns.TabIndex = 20;
            // 
            // gbDrizzleOptions
            // 
            this.gbDrizzleOptions.BackColor = System.Drawing.Color.OldLace;
            this.gbDrizzleOptions.Controls.Add(this.rdoDrizzleCaramel);
            this.gbDrizzleOptions.Controls.Add(this.textBox6);
            this.gbDrizzleOptions.Controls.Add(this.rdoDrizzleChocolate);
            this.gbDrizzleOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDrizzleOptions.Location = new System.Drawing.Point(556, 4);
            this.gbDrizzleOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbDrizzleOptions.Name = "gbDrizzleOptions";
            this.gbDrizzleOptions.Size = new System.Drawing.Size(365, 107);
            this.gbDrizzleOptions.TabIndex = 3;
            // 
            // rdoDrizzleCaramel
            // 
            this.rdoDrizzleCaramel.AutoSize = true;
            this.rdoDrizzleCaramel.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoDrizzleCaramel.Location = new System.Drawing.Point(203, 40);
            this.rdoDrizzleCaramel.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDrizzleCaramel.Name = "rdoDrizzleCaramel";
            this.rdoDrizzleCaramel.Size = new System.Drawing.Size(142, 24);
            this.rdoDrizzleCaramel.TabIndex = 1;
            this.rdoDrizzleCaramel.TabStop = true;
            this.rdoDrizzleCaramel.Text = "카라멜 (+500)";
            this.rdoDrizzleCaramel.UseVisualStyleBackColor = true;
            this.rdoDrizzleCaramel.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Gold;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(365, 21);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "드리즐 종류(+500, 택1)";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoDrizzleChocolate
            // 
            this.rdoDrizzleChocolate.AutoSize = true;
            this.rdoDrizzleChocolate.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoDrizzleChocolate.Location = new System.Drawing.Point(7, 40);
            this.rdoDrizzleChocolate.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDrizzleChocolate.Name = "rdoDrizzleChocolate";
            this.rdoDrizzleChocolate.Size = new System.Drawing.Size(140, 24);
            this.rdoDrizzleChocolate.TabIndex = 0;
            this.rdoDrizzleChocolate.TabStop = true;
            this.rdoDrizzleChocolate.Text = "초콜릿 (+500)";
            this.rdoDrizzleChocolate.UseVisualStyleBackColor = true;
            this.rdoDrizzleChocolate.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.Gold;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox12.Font = new System.Drawing.Font("Maplestory", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox12.ForeColor = System.Drawing.Color.Black;
            this.textBox12.Location = new System.Drawing.Point(4, 4);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(130, 107);
            this.textBox12.TabIndex = 4;
            this.textBox12.Text = "<부가요소>\r\n(필수, 복수 선택)";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gold;
            this.panel7.Controls.Add(this.chkNoAddOns);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(142, 4);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(130, 107);
            this.panel7.TabIndex = 5;
            // 
            // chkNoAddOns
            // 
            this.chkNoAddOns.AutoSize = true;
            this.chkNoAddOns.BackColor = System.Drawing.Color.OldLace;
            this.chkNoAddOns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkNoAddOns.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkNoAddOns.Location = new System.Drawing.Point(0, 0);
            this.chkNoAddOns.Margin = new System.Windows.Forms.Padding(4);
            this.chkNoAddOns.Name = "chkNoAddOns";
            this.chkNoAddOns.Size = new System.Drawing.Size(130, 107);
            this.chkNoAddOns.TabIndex = 0;
            this.chkNoAddOns.Text = "선택안함 (+0)";
            this.chkNoAddOns.UseVisualStyleBackColor = false;
            this.chkNoAddOns.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gold;
            this.panel8.Controls.Add(this.chkPearl);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(280, 4);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(130, 107);
            this.panel8.TabIndex = 6;
            // 
            // chkPearl
            // 
            this.chkPearl.AutoSize = true;
            this.chkPearl.BackColor = System.Drawing.Color.OldLace;
            this.chkPearl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPearl.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkPearl.Location = new System.Drawing.Point(0, 0);
            this.chkPearl.Margin = new System.Windows.Forms.Padding(4);
            this.chkPearl.Name = "chkPearl";
            this.chkPearl.Size = new System.Drawing.Size(130, 107);
            this.chkPearl.TabIndex = 1;
            this.chkPearl.Text = "펄 추가 (+500)";
            this.chkPearl.UseVisualStyleBackColor = false;
            this.chkPearl.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gold;
            this.panel9.Controls.Add(this.chkWhippedCream);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(418, 4);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(130, 107);
            this.panel9.TabIndex = 7;
            // 
            // chkWhippedCream
            // 
            this.chkWhippedCream.AutoSize = true;
            this.chkWhippedCream.BackColor = System.Drawing.Color.OldLace;
            this.chkWhippedCream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkWhippedCream.Font = new System.Drawing.Font("Maplestory", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkWhippedCream.Location = new System.Drawing.Point(0, 0);
            this.chkWhippedCream.Margin = new System.Windows.Forms.Padding(4);
            this.chkWhippedCream.Name = "chkWhippedCream";
            this.chkWhippedCream.Size = new System.Drawing.Size(130, 107);
            this.chkWhippedCream.TabIndex = 2;
            this.chkWhippedCream.Text = "휘핑크림 추가 (+500)";
            this.chkWhippedCream.UseVisualStyleBackColor = false;
            this.chkWhippedCream.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // CancelAndOrder
            // 
            this.CancelAndOrder.BackColor = System.Drawing.Color.White;
            this.CancelAndOrder.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.CancelAndOrder, 2);
            this.CancelAndOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CancelAndOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CancelAndOrder.Controls.Add(this.cancel, 1, 0);
            this.CancelAndOrder.Controls.Add(this.getMenu, 0, 0);
            this.CancelAndOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelAndOrder.Location = new System.Drawing.Point(4, 1007);
            this.CancelAndOrder.Margin = new System.Windows.Forms.Padding(4);
            this.CancelAndOrder.Name = "CancelAndOrder";
            this.CancelAndOrder.RowCount = 1;
            this.CancelAndOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CancelAndOrder.Size = new System.Drawing.Size(925, 49);
            this.CancelAndOrder.TabIndex = 21;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.SaddleBrown;
            this.cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Maplestory", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel.ForeColor = System.Drawing.Color.Gold;
            this.cancel.Location = new System.Drawing.Point(466, 4);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(455, 41);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "돌아가기";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // getMenu
            // 
            this.getMenu.BackColor = System.Drawing.Color.SaddleBrown;
            this.getMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getMenu.FlatAppearance.BorderSize = 0;
            this.getMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getMenu.Font = new System.Drawing.Font("Maplestory", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.getMenu.ForeColor = System.Drawing.Color.Gold;
            this.getMenu.Location = new System.Drawing.Point(4, 4);
            this.getMenu.Margin = new System.Windows.Forms.Padding(4);
            this.getMenu.Name = "getMenu";
            this.getMenu.Size = new System.Drawing.Size(454, 41);
            this.getMenu.TabIndex = 0;
            this.getMenu.Text = "메뉴담기";
            this.getMenu.UseVisualStyleBackColor = false;
            this.getMenu.Click += new System.EventHandler(this.getMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(933, 1060);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.gbShot.ResumeLayout(false);
            this.gbShot.PerformLayout();
            this.gbShotOptions.ResumeLayout(false);
            this.gbShotOptions.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbSyrup.ResumeLayout(false);
            this.gbSyrup.PerformLayout();
            this.gbSyrupOptions.ResumeLayout(false);
            this.gbSyrupOptions.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbFreeOptions.ResumeLayout(false);
            this.gbFreeOptions.PerformLayout();
            this.gbSweetnessOptions.ResumeLayout(false);
            this.gbSweetnessOptions.PerformLayout();
            this.gbIceOptions.ResumeLayout(false);
            this.gbIceOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMilk.ResumeLayout(false);
            this.gbMilk.PerformLayout();
            this.gbMilkOptions.ResumeLayout(false);
            this.gbMilkOptions.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChosenMenuImg)).EndInit();
            this.NamePriceOptions.ResumeLayout(false);
            this.NamePriceOptions.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.gbAddOns.ResumeLayout(false);
            this.gbAddOns.PerformLayout();
            this.gbDrizzleOptions.ResumeLayout(false);
            this.gbDrizzleOptions.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.CancelAndOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ChosenMenuImg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox ChooseAllOption;
        private System.Windows.Forms.CheckBox chkNoAddOns;
        private System.Windows.Forms.RadioButton rdoMilkSoy;
        private System.Windows.Forms.RadioButton rdoMilkAlmond;
        private System.Windows.Forms.RadioButton rdoMilkOat;
        private System.Windows.Forms.RadioButton rdoDecaf2Shot;
        private System.Windows.Forms.RadioButton rdo2Shot;
        private System.Windows.Forms.RadioButton rdoShot;
        private System.Windows.Forms.RadioButton rdoSizeUp;
        private System.Windows.Forms.CheckBox chkWhippedCream;
        private System.Windows.Forms.CheckBox chkPearl;
        private System.Windows.Forms.RadioButton rdoDrizzleCaramel;
        private System.Windows.Forms.RadioButton rdoDrizzleChocolate;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button getMenu;
        private System.Windows.Forms.TableLayoutPanel NamePriceOptions;
        private System.Windows.Forms.TextBox MenuOptionsView;
        private System.Windows.Forms.TableLayoutPanel gbFreeOptions;
        private System.Windows.Forms.Panel gbSweetnessOptions;
        private System.Windows.Forms.RadioButton rdoLessSweet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdoSweet;
        private System.Windows.Forms.Panel gbIceOptions;
        private System.Windows.Forms.RadioButton rdoIceMore;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton rdoIceLess;
        private System.Windows.Forms.TableLayoutPanel gbSyrup;
        private System.Windows.Forms.RadioButton rdoSyrupCaramel;
        private System.Windows.Forms.RadioButton rdoSyrupHazelnut;
        private System.Windows.Forms.RadioButton rdoSyrupVanilla;
        private System.Windows.Forms.RadioButton rdoSteviaSyrup;
        private System.Windows.Forms.Panel gbSyrupOptions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel gbMilk;
        private System.Windows.Forms.TableLayoutPanel gbShot;
        private System.Windows.Forms.Panel gbShotOptions;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel gbMilkOptions;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TableLayoutPanel gbSize;
        private System.Windows.Forms.TableLayoutPanel gbAddOns;
        private System.Windows.Forms.Panel gbDrizzleOptions;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TableLayoutPanel CancelAndOrder;
        private System.Windows.Forms.CheckBox rdoNoSize;
        private System.Windows.Forms.CheckBox rdoNoShot;
        private System.Windows.Forms.CheckBox rdoNoSyrup;
        private System.Windows.Forms.CheckBox rdoNoFreeOption;
        private System.Windows.Forms.CheckBox rdoNoMilk;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private Panel panel11;
        private TextBox MenuName;
        private Panel panel12;
        private TextBox MenuPrice;
    }
}

