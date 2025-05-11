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
            this.gbDrizzleOptions = new System.Windows.Forms.GroupBox();
            this.rdoDrizzleCaramel = new System.Windows.Forms.RadioButton();
            this.rdoDrizzleChocolate = new System.Windows.Forms.RadioButton();
            this.chkWhippedCream = new System.Windows.Forms.CheckBox();
            this.chkPearl = new System.Windows.Forms.CheckBox();
            this.chkNoAddOns = new System.Windows.Forms.CheckBox();
            this.ChosenMenuImg = new System.Windows.Forms.PictureBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rdoSizeUp = new System.Windows.Forms.RadioButton();
            this.rdoNoSize = new System.Windows.Forms.RadioButton();
            this.gbMilk = new System.Windows.Forms.GroupBox();
            this.gbMilkOptions = new System.Windows.Forms.GroupBox();
            this.rdoMilkSoy = new System.Windows.Forms.RadioButton();
            this.rdoMilkAlmond = new System.Windows.Forms.RadioButton();
            this.rdoMilkOat = new System.Windows.Forms.RadioButton();
            this.rdoNoMilk = new System.Windows.Forms.RadioButton();
            this.gbFreeOptions = new System.Windows.Forms.GroupBox();
            this.gbSweetnessOptions = new System.Windows.Forms.GroupBox();
            this.rdoLessSweet = new System.Windows.Forms.RadioButton();
            this.rdoSweet = new System.Windows.Forms.RadioButton();
            this.gbIceOptions = new System.Windows.Forms.GroupBox();
            this.rdoIceMore = new System.Windows.Forms.RadioButton();
            this.rdoIceLess = new System.Windows.Forms.RadioButton();
            this.rdoNoFreeOption = new System.Windows.Forms.RadioButton();
            this.gbShot = new System.Windows.Forms.GroupBox();
            this.gbShotOptions = new System.Windows.Forms.GroupBox();
            this.rdoDecaf2Shot = new System.Windows.Forms.RadioButton();
            this.rdo2Shot = new System.Windows.Forms.RadioButton();
            this.rdoShot = new System.Windows.Forms.RadioButton();
            this.rdoNoShot = new System.Windows.Forms.RadioButton();
            this.gbSyrup = new System.Windows.Forms.GroupBox();
            this.gbSyrupOptions = new System.Windows.Forms.GroupBox();
            this.rdoSyrupCaramel = new System.Windows.Forms.RadioButton();
            this.rdoSyrupHazelnut = new System.Windows.Forms.RadioButton();
            this.rdoSyrupVanilla = new System.Windows.Forms.RadioButton();
            this.rdoSteviaSyrup = new System.Windows.Forms.RadioButton();
            this.rdoNoSyrup = new System.Windows.Forms.RadioButton();
            this.CancelAndOrder = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.getMenu = new System.Windows.Forms.Button();
            this.menuName = new System.Windows.Forms.RichTextBox();
            this.ChooseAllOption = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbAddOns.SuspendLayout();
            this.gbDrizzleOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChosenMenuImg)).BeginInit();
            this.gbSize.SuspendLayout();
            this.gbMilk.SuspendLayout();
            this.gbMilkOptions.SuspendLayout();
            this.gbFreeOptions.SuspendLayout();
            this.gbSweetnessOptions.SuspendLayout();
            this.gbIceOptions.SuspendLayout();
            this.gbShot.SuspendLayout();
            this.gbShotOptions.SuspendLayout();
            this.gbSyrup.SuspendLayout();
            this.gbSyrupOptions.SuspendLayout();
            this.CancelAndOrder.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(653, 803);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // gbAddOns
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbAddOns, 2);
            this.gbAddOns.Controls.Add(this.gbDrizzleOptions);
            this.gbAddOns.Controls.Add(this.chkWhippedCream);
            this.gbAddOns.Controls.Add(this.chkPearl);
            this.gbAddOns.Controls.Add(this.chkNoAddOns);
            this.gbAddOns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddOns.Location = new System.Drawing.Point(3, 652);
            this.gbAddOns.Name = "gbAddOns";
            this.gbAddOns.Size = new System.Drawing.Size(647, 87);
            this.gbAddOns.TabIndex = 5;
            this.gbAddOns.TabStop = false;
            this.gbAddOns.Text = "부가 요소(필수, 복수선택)";
            // 
            // gbDrizzleOptions
            // 
            this.gbDrizzleOptions.Controls.Add(this.rdoDrizzleCaramel);
            this.gbDrizzleOptions.Controls.Add(this.rdoDrizzleChocolate);
            this.gbDrizzleOptions.Location = new System.Drawing.Point(367, 21);
            this.gbDrizzleOptions.Name = "gbDrizzleOptions";
            this.gbDrizzleOptions.Size = new System.Drawing.Size(225, 44);
            this.gbDrizzleOptions.TabIndex = 3;
            this.gbDrizzleOptions.TabStop = false;
            this.gbDrizzleOptions.Text = "드리즐 종류(+500, 택 1)";
            // 
            // rdoDrizzleCaramel
            // 
            this.rdoDrizzleCaramel.AutoSize = true;
            this.rdoDrizzleCaramel.Location = new System.Drawing.Point(127, 17);
            this.rdoDrizzleCaramel.Name = "rdoDrizzleCaramel";
            this.rdoDrizzleCaramel.Size = new System.Drawing.Size(59, 16);
            this.rdoDrizzleCaramel.TabIndex = 1;
            this.rdoDrizzleCaramel.TabStop = true;
            this.rdoDrizzleCaramel.Text = "카라멜";
            this.rdoDrizzleCaramel.UseVisualStyleBackColor = true;
            this.rdoDrizzleCaramel.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoDrizzleChocolate
            // 
            this.rdoDrizzleChocolate.AutoSize = true;
            this.rdoDrizzleChocolate.Location = new System.Drawing.Point(0, 17);
            this.rdoDrizzleChocolate.Name = "rdoDrizzleChocolate";
            this.rdoDrizzleChocolate.Size = new System.Drawing.Size(59, 16);
            this.rdoDrizzleChocolate.TabIndex = 0;
            this.rdoDrizzleChocolate.TabStop = true;
            this.rdoDrizzleChocolate.Text = "초콜릿";
            this.rdoDrizzleChocolate.UseVisualStyleBackColor = true;
            this.rdoDrizzleChocolate.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // chkWhippedCream
            // 
            this.chkWhippedCream.AutoSize = true;
            this.chkWhippedCream.Location = new System.Drawing.Point(219, 39);
            this.chkWhippedCream.Name = "chkWhippedCream";
            this.chkWhippedCream.Size = new System.Drawing.Size(138, 16);
            this.chkWhippedCream.TabIndex = 2;
            this.chkWhippedCream.Text = "휘핑크림 추가 (+500)";
            this.chkWhippedCream.UseVisualStyleBackColor = true;
            this.chkWhippedCream.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // chkPearl
            // 
            this.chkPearl.AutoSize = true;
            this.chkPearl.Location = new System.Drawing.Point(111, 39);
            this.chkPearl.Name = "chkPearl";
            this.chkPearl.Size = new System.Drawing.Size(102, 16);
            this.chkPearl.TabIndex = 1;
            this.chkPearl.Text = "펄 추가 (+500)";
            this.chkPearl.UseVisualStyleBackColor = true;
            this.chkPearl.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // chkNoAddOns
            // 
            this.chkNoAddOns.AutoSize = true;
            this.chkNoAddOns.Location = new System.Drawing.Point(7, 41);
            this.chkNoAddOns.Name = "chkNoAddOns";
            this.chkNoAddOns.Size = new System.Drawing.Size(98, 16);
            this.chkNoAddOns.TabIndex = 0;
            this.chkNoAddOns.Text = "선택안함 (+0)";
            this.chkNoAddOns.UseVisualStyleBackColor = true;
            this.chkNoAddOns.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // ChosenMenuImg
            // 
            this.ChosenMenuImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChosenMenuImg.Location = new System.Drawing.Point(3, 27);
            this.ChosenMenuImg.Name = "ChosenMenuImg";
            this.ChosenMenuImg.Size = new System.Drawing.Size(185, 154);
            this.ChosenMenuImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChosenMenuImg.TabIndex = 6;
            this.ChosenMenuImg.TabStop = false;
            // 
            // gbSize
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbSize, 2);
            this.gbSize.Controls.Add(this.rdoSizeUp);
            this.gbSize.Controls.Add(this.rdoNoSize);
            this.gbSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSize.Location = new System.Drawing.Point(3, 559);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(647, 87);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "사이즈(필수, 단일선택)";
            // 
            // rdoSizeUp
            // 
            this.rdoSizeUp.AutoSize = true;
            this.rdoSizeUp.Location = new System.Drawing.Point(140, 38);
            this.rdoSizeUp.Name = "rdoSizeUp";
            this.rdoSizeUp.Size = new System.Drawing.Size(183, 16);
            this.rdoSizeUp.TabIndex = 1;
            this.rdoSizeUp.TabStop = true;
            this.rdoSizeUp.Text = "컵 사이즈 업그레이드 (+1000)";
            this.rdoSizeUp.UseVisualStyleBackColor = true;
            this.rdoSizeUp.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoNoSize
            // 
            this.rdoNoSize.AutoSize = true;
            this.rdoNoSize.Location = new System.Drawing.Point(9, 39);
            this.rdoNoSize.Name = "rdoNoSize";
            this.rdoNoSize.Size = new System.Drawing.Size(97, 16);
            this.rdoNoSize.TabIndex = 0;
            this.rdoNoSize.TabStop = true;
            this.rdoNoSize.Text = "선택안함 (+0)";
            this.rdoNoSize.UseVisualStyleBackColor = true;
            this.rdoNoSize.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // gbMilk
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbMilk, 2);
            this.gbMilk.Controls.Add(this.gbMilkOptions);
            this.gbMilk.Controls.Add(this.rdoNoMilk);
            this.gbMilk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMilk.Location = new System.Drawing.Point(3, 373);
            this.gbMilk.Name = "gbMilk";
            this.gbMilk.Size = new System.Drawing.Size(647, 87);
            this.gbMilk.TabIndex = 2;
            this.gbMilk.TabStop = false;
            this.gbMilk.Text = "우유 변경(필수, 단일선택)";
            // 
            // gbMilkOptions
            // 
            this.gbMilkOptions.Controls.Add(this.rdoMilkSoy);
            this.gbMilkOptions.Controls.Add(this.rdoMilkAlmond);
            this.gbMilkOptions.Controls.Add(this.rdoMilkOat);
            this.gbMilkOptions.Location = new System.Drawing.Point(140, 31);
            this.gbMilkOptions.Name = "gbMilkOptions";
            this.gbMilkOptions.Size = new System.Drawing.Size(316, 37);
            this.gbMilkOptions.TabIndex = 1;
            this.gbMilkOptions.TabStop = false;
            this.gbMilkOptions.Text = "우유(+700, 택 1)";
            // 
            // rdoMilkSoy
            // 
            this.rdoMilkSoy.AutoSize = true;
            this.rdoMilkSoy.Location = new System.Drawing.Point(240, 15);
            this.rdoMilkSoy.Name = "rdoMilkSoy";
            this.rdoMilkSoy.Size = new System.Drawing.Size(75, 16);
            this.rdoMilkSoy.TabIndex = 2;
            this.rdoMilkSoy.TabStop = true;
            this.rdoMilkSoy.Text = "두유 변경";
            this.rdoMilkSoy.UseVisualStyleBackColor = true;
            this.rdoMilkSoy.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoMilkAlmond
            // 
            this.rdoMilkAlmond.AutoSize = true;
            this.rdoMilkAlmond.Location = new System.Drawing.Point(112, 15);
            this.rdoMilkAlmond.Name = "rdoMilkAlmond";
            this.rdoMilkAlmond.Size = new System.Drawing.Size(115, 16);
            this.rdoMilkAlmond.TabIndex = 1;
            this.rdoMilkAlmond.TabStop = true;
            this.rdoMilkAlmond.Text = "아몬드 우유 변경";
            this.rdoMilkAlmond.UseVisualStyleBackColor = true;
            this.rdoMilkAlmond.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoMilkOat
            // 
            this.rdoMilkOat.AutoSize = true;
            this.rdoMilkOat.Location = new System.Drawing.Point(7, 15);
            this.rdoMilkOat.Name = "rdoMilkOat";
            this.rdoMilkOat.Size = new System.Drawing.Size(103, 16);
            this.rdoMilkOat.TabIndex = 0;
            this.rdoMilkOat.TabStop = true;
            this.rdoMilkOat.Text = "오트 우유 변경";
            this.rdoMilkOat.UseVisualStyleBackColor = true;
            this.rdoMilkOat.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoNoMilk
            // 
            this.rdoNoMilk.AutoSize = true;
            this.rdoNoMilk.Location = new System.Drawing.Point(10, 42);
            this.rdoNoMilk.Name = "rdoNoMilk";
            this.rdoNoMilk.Size = new System.Drawing.Size(97, 16);
            this.rdoNoMilk.TabIndex = 0;
            this.rdoNoMilk.TabStop = true;
            this.rdoNoMilk.Text = "선택안함 (+0)";
            this.rdoNoMilk.UseVisualStyleBackColor = true;
            this.rdoNoMilk.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // gbFreeOptions
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbFreeOptions, 2);
            this.gbFreeOptions.Controls.Add(this.gbSweetnessOptions);
            this.gbFreeOptions.Controls.Add(this.gbIceOptions);
            this.gbFreeOptions.Controls.Add(this.rdoNoFreeOption);
            this.gbFreeOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFreeOptions.Location = new System.Drawing.Point(3, 187);
            this.gbFreeOptions.Name = "gbFreeOptions";
            this.gbFreeOptions.Size = new System.Drawing.Size(647, 87);
            this.gbFreeOptions.TabIndex = 0;
            this.gbFreeOptions.TabStop = false;
            this.gbFreeOptions.Text = "-무료 옵션(필수, 단일선택)";
            // 
            // gbSweetnessOptions
            // 
            this.gbSweetnessOptions.Controls.Add(this.rdoLessSweet);
            this.gbSweetnessOptions.Controls.Add(this.rdoSweet);
            this.gbSweetnessOptions.Location = new System.Drawing.Point(361, 27);
            this.gbSweetnessOptions.Name = "gbSweetnessOptions";
            this.gbSweetnessOptions.Size = new System.Drawing.Size(177, 44);
            this.gbSweetnessOptions.TabIndex = 6;
            this.gbSweetnessOptions.TabStop = false;
            this.gbSweetnessOptions.Text = "당도(선택)";
            // 
            // rdoLessSweet
            // 
            this.rdoLessSweet.AutoSize = true;
            this.rdoLessSweet.Location = new System.Drawing.Point(6, 19);
            this.rdoLessSweet.Name = "rdoLessSweet";
            this.rdoLessSweet.Size = new System.Drawing.Size(85, 16);
            this.rdoLessSweet.TabIndex = 3;
            this.rdoLessSweet.TabStop = true;
            this.rdoLessSweet.Text = "덜달게 (+0)";
            this.rdoLessSweet.UseVisualStyleBackColor = true;
            this.rdoLessSweet.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoSweet
            // 
            this.rdoSweet.AutoSize = true;
            this.rdoSweet.Location = new System.Drawing.Point(97, 18);
            this.rdoSweet.Name = "rdoSweet";
            this.rdoSweet.Size = new System.Drawing.Size(73, 16);
            this.rdoSweet.TabIndex = 4;
            this.rdoSweet.TabStop = true;
            this.rdoSweet.Text = "달게 (+0)";
            this.rdoSweet.UseVisualStyleBackColor = true;
            this.rdoSweet.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // gbIceOptions
            // 
            this.gbIceOptions.Controls.Add(this.rdoIceMore);
            this.gbIceOptions.Controls.Add(this.rdoIceLess);
            this.gbIceOptions.Location = new System.Drawing.Point(122, 27);
            this.gbIceOptions.Name = "gbIceOptions";
            this.gbIceOptions.Size = new System.Drawing.Size(211, 37);
            this.gbIceOptions.TabIndex = 5;
            this.gbIceOptions.TabStop = false;
            this.gbIceOptions.Text = "얼음(선택)";
            // 
            // rdoIceMore
            // 
            this.rdoIceMore.AutoSize = true;
            this.rdoIceMore.Location = new System.Drawing.Point(6, 20);
            this.rdoIceMore.Name = "rdoIceMore";
            this.rdoIceMore.Size = new System.Drawing.Size(101, 16);
            this.rdoIceMore.TabIndex = 1;
            this.rdoIceMore.TabStop = true;
            this.rdoIceMore.Text = "얼음 많이 (+0)";
            this.rdoIceMore.UseVisualStyleBackColor = true;
            this.rdoIceMore.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoIceLess
            // 
            this.rdoIceLess.AutoSize = true;
            this.rdoIceLess.Location = new System.Drawing.Point(113, 20);
            this.rdoIceLess.Name = "rdoIceLess";
            this.rdoIceLess.Size = new System.Drawing.Size(101, 16);
            this.rdoIceLess.TabIndex = 2;
            this.rdoIceLess.TabStop = true;
            this.rdoIceLess.Text = "얼음 적게 (+0)";
            this.rdoIceLess.UseVisualStyleBackColor = true;
            this.rdoIceLess.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoNoFreeOption
            // 
            this.rdoNoFreeOption.AutoSize = true;
            this.rdoNoFreeOption.Location = new System.Drawing.Point(9, 40);
            this.rdoNoFreeOption.Name = "rdoNoFreeOption";
            this.rdoNoFreeOption.Size = new System.Drawing.Size(97, 16);
            this.rdoNoFreeOption.TabIndex = 0;
            this.rdoNoFreeOption.TabStop = true;
            this.rdoNoFreeOption.Text = "선택안함 (+0)";
            this.rdoNoFreeOption.UseVisualStyleBackColor = true;
            this.rdoNoFreeOption.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // gbShot
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbShot, 2);
            this.gbShot.Controls.Add(this.gbShotOptions);
            this.gbShot.Controls.Add(this.rdoNoShot);
            this.gbShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbShot.Location = new System.Drawing.Point(3, 466);
            this.gbShot.Name = "gbShot";
            this.gbShot.Size = new System.Drawing.Size(647, 87);
            this.gbShot.TabIndex = 3;
            this.gbShot.TabStop = false;
            this.gbShot.Text = "샷 추가(필수, 단일선택)";
            // 
            // gbShotOptions
            // 
            this.gbShotOptions.Controls.Add(this.rdoDecaf2Shot);
            this.gbShotOptions.Controls.Add(this.rdo2Shot);
            this.gbShotOptions.Controls.Add(this.rdoShot);
            this.gbShotOptions.Location = new System.Drawing.Point(140, 31);
            this.gbShotOptions.Name = "gbShotOptions";
            this.gbShotOptions.Size = new System.Drawing.Size(415, 37);
            this.gbShotOptions.TabIndex = 1;
            this.gbShotOptions.TabStop = false;
            this.gbShotOptions.Text = "샷 종류(선택)";
            // 
            // rdoDecaf2Shot
            // 
            this.rdoDecaf2Shot.AutoSize = true;
            this.rdoDecaf2Shot.Location = new System.Drawing.Point(240, 15);
            this.rdoDecaf2Shot.Name = "rdoDecaf2Shot";
            this.rdoDecaf2Shot.Size = new System.Drawing.Size(159, 16);
            this.rdoDecaf2Shot.TabIndex = 2;
            this.rdoDecaf2Shot.TabStop = true;
            this.rdoDecaf2Shot.Text = "디카페인 2샷 추가 (+800)";
            this.rdoDecaf2Shot.UseVisualStyleBackColor = true;
            this.rdoDecaf2Shot.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdo2Shot
            // 
            this.rdo2Shot.AutoSize = true;
            this.rdo2Shot.Location = new System.Drawing.Point(127, 15);
            this.rdo2Shot.Name = "rdo2Shot";
            this.rdo2Shot.Size = new System.Drawing.Size(107, 16);
            this.rdo2Shot.TabIndex = 1;
            this.rdo2Shot.TabStop = true;
            this.rdo2Shot.Text = "2샷 추가 (+500)";
            this.rdo2Shot.UseVisualStyleBackColor = true;
            this.rdo2Shot.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoShot
            // 
            this.rdoShot.AutoSize = true;
            this.rdoShot.Location = new System.Drawing.Point(7, 15);
            this.rdoShot.Name = "rdoShot";
            this.rdoShot.Size = new System.Drawing.Size(107, 16);
            this.rdoShot.TabIndex = 0;
            this.rdoShot.TabStop = true;
            this.rdoShot.Text = "1샷 추가 (+300)";
            this.rdoShot.UseVisualStyleBackColor = true;
            this.rdoShot.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoNoShot
            // 
            this.rdoNoShot.AutoSize = true;
            this.rdoNoShot.Location = new System.Drawing.Point(7, 43);
            this.rdoNoShot.Name = "rdoNoShot";
            this.rdoNoShot.Size = new System.Drawing.Size(97, 16);
            this.rdoNoShot.TabIndex = 0;
            this.rdoNoShot.TabStop = true;
            this.rdoNoShot.Text = "선택안함 (+0)";
            this.rdoNoShot.UseVisualStyleBackColor = true;
            this.rdoNoShot.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // gbSyrup
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbSyrup, 2);
            this.gbSyrup.Controls.Add(this.gbSyrupOptions);
            this.gbSyrup.Controls.Add(this.rdoSteviaSyrup);
            this.gbSyrup.Controls.Add(this.rdoNoSyrup);
            this.gbSyrup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSyrup.Location = new System.Drawing.Point(3, 280);
            this.gbSyrup.Name = "gbSyrup";
            this.gbSyrup.Size = new System.Drawing.Size(647, 87);
            this.gbSyrup.TabIndex = 1;
            this.gbSyrup.TabStop = false;
            this.gbSyrup.Text = "시럽 추가(필수, 단일선택)";
            // 
            // gbSyrupOptions
            // 
            this.gbSyrupOptions.Controls.Add(this.rdoSyrupCaramel);
            this.gbSyrupOptions.Controls.Add(this.rdoSyrupHazelnut);
            this.gbSyrupOptions.Controls.Add(this.rdoSyrupVanilla);
            this.gbSyrupOptions.Location = new System.Drawing.Point(273, 20);
            this.gbSyrupOptions.Name = "gbSyrupOptions";
            this.gbSyrupOptions.Size = new System.Drawing.Size(368, 41);
            this.gbSyrupOptions.TabIndex = 2;
            this.gbSyrupOptions.TabStop = false;
            this.gbSyrupOptions.Text = "시럽 (+500, 택 1)";
            // 
            // rdoSyrupCaramel
            // 
            this.rdoSyrupCaramel.AutoSize = true;
            this.rdoSyrupCaramel.Location = new System.Drawing.Point(253, 16);
            this.rdoSyrupCaramel.Name = "rdoSyrupCaramel";
            this.rdoSyrupCaramel.Size = new System.Drawing.Size(115, 16);
            this.rdoSyrupCaramel.TabIndex = 2;
            this.rdoSyrupCaramel.TabStop = true;
            this.rdoSyrupCaramel.Text = "카라멜 시럽 추가";
            this.rdoSyrupCaramel.UseVisualStyleBackColor = true;
            this.rdoSyrupCaramel.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoSyrupHazelnut
            // 
            this.rdoSyrupHazelnut.AutoSize = true;
            this.rdoSyrupHazelnut.Location = new System.Drawing.Point(128, 16);
            this.rdoSyrupHazelnut.Name = "rdoSyrupHazelnut";
            this.rdoSyrupHazelnut.Size = new System.Drawing.Size(127, 16);
            this.rdoSyrupHazelnut.TabIndex = 1;
            this.rdoSyrupHazelnut.TabStop = true;
            this.rdoSyrupHazelnut.Text = "헤이즐넛 시럽 추가";
            this.rdoSyrupHazelnut.UseVisualStyleBackColor = true;
            this.rdoSyrupHazelnut.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoSyrupVanilla
            // 
            this.rdoSyrupVanilla.AutoSize = true;
            this.rdoSyrupVanilla.Location = new System.Drawing.Point(7, 16);
            this.rdoSyrupVanilla.Name = "rdoSyrupVanilla";
            this.rdoSyrupVanilla.Size = new System.Drawing.Size(115, 16);
            this.rdoSyrupVanilla.TabIndex = 0;
            this.rdoSyrupVanilla.TabStop = true;
            this.rdoSyrupVanilla.Text = "바닐라 시럽 추가";
            this.rdoSyrupVanilla.UseVisualStyleBackColor = true;
            this.rdoSyrupVanilla.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoSteviaSyrup
            // 
            this.rdoSteviaSyrup.AutoSize = true;
            this.rdoSteviaSyrup.Location = new System.Drawing.Point(108, 41);
            this.rdoSteviaSyrup.Name = "rdoSteviaSyrup";
            this.rdoSteviaSyrup.Size = new System.Drawing.Size(167, 16);
            this.rdoSteviaSyrup.TabIndex = 1;
            this.rdoSteviaSyrup.TabStop = true;
            this.rdoSteviaSyrup.Text = "스테비아(저당)추가 (+500)";
            this.rdoSteviaSyrup.UseVisualStyleBackColor = true;
            this.rdoSteviaSyrup.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoNoSyrup
            // 
            this.rdoNoSyrup.AutoSize = true;
            this.rdoNoSyrup.Location = new System.Drawing.Point(10, 41);
            this.rdoNoSyrup.Name = "rdoNoSyrup";
            this.rdoNoSyrup.Size = new System.Drawing.Size(97, 16);
            this.rdoNoSyrup.TabIndex = 0;
            this.rdoNoSyrup.TabStop = true;
            this.rdoNoSyrup.Text = "선택안함 (+0)";
            this.rdoNoSyrup.UseVisualStyleBackColor = true;
            this.rdoNoSyrup.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // CancelAndOrder
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CancelAndOrder, 2);
            this.CancelAndOrder.Controls.Add(this.cancel);
            this.CancelAndOrder.Controls.Add(this.getMenu);
            this.CancelAndOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelAndOrder.Location = new System.Drawing.Point(3, 745);
            this.CancelAndOrder.Name = "CancelAndOrder";
            this.CancelAndOrder.Size = new System.Drawing.Size(647, 55);
            this.CancelAndOrder.TabIndex = 7;
            this.CancelAndOrder.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(391, 21);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(164, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "돌아가기";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // getMenu
            // 
            this.getMenu.Location = new System.Drawing.Point(31, 21);
            this.getMenu.Name = "getMenu";
            this.getMenu.Size = new System.Drawing.Size(182, 23);
            this.getMenu.TabIndex = 0;
            this.getMenu.Text = "메뉴담기";
            this.getMenu.UseVisualStyleBackColor = true;
            this.getMenu.Click += new System.EventHandler(this.getMenu_Click);
            // 
            // menuName
            // 
            this.menuName.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuName.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuName.Location = new System.Drawing.Point(194, 27);
            this.menuName.Name = "menuName";
            this.menuName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.menuName.Size = new System.Drawing.Size(456, 45);
            this.menuName.TabIndex = 8;
            this.menuName.Text = "";
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
            this.ChooseAllOption.Size = new System.Drawing.Size(647, 18);
            this.ChooseAllOption.TabIndex = 9;
            this.ChooseAllOption.Text = "선택하신 상품의 옵션상품을 모두 선택해주세요";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(653, 803);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbAddOns.ResumeLayout(false);
            this.gbAddOns.PerformLayout();
            this.gbDrizzleOptions.ResumeLayout(false);
            this.gbDrizzleOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChosenMenuImg)).EndInit();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbMilk.ResumeLayout(false);
            this.gbMilk.PerformLayout();
            this.gbMilkOptions.ResumeLayout(false);
            this.gbMilkOptions.PerformLayout();
            this.gbFreeOptions.ResumeLayout(false);
            this.gbFreeOptions.PerformLayout();
            this.gbSweetnessOptions.ResumeLayout(false);
            this.gbSweetnessOptions.PerformLayout();
            this.gbIceOptions.ResumeLayout(false);
            this.gbIceOptions.PerformLayout();
            this.gbShot.ResumeLayout(false);
            this.gbShot.PerformLayout();
            this.gbShotOptions.ResumeLayout(false);
            this.gbShotOptions.PerformLayout();
            this.gbSyrup.ResumeLayout(false);
            this.gbSyrup.PerformLayout();
            this.gbSyrupOptions.ResumeLayout(false);
            this.gbSyrupOptions.PerformLayout();
            this.CancelAndOrder.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton rdoIceLess;
        private System.Windows.Forms.RadioButton rdoIceMore;
        private System.Windows.Forms.RadioButton rdoNoFreeOption;
        private System.Windows.Forms.RadioButton rdoSweet;
        private System.Windows.Forms.RadioButton rdoLessSweet;
        private System.Windows.Forms.GroupBox gbIceOptions;
        private System.Windows.Forms.GroupBox gbSweetnessOptions;
        private System.Windows.Forms.CheckBox chkNoAddOns;
        private System.Windows.Forms.RadioButton rdoNoSize;
        private System.Windows.Forms.RadioButton rdoNoMilk;
        private System.Windows.Forms.RadioButton rdoNoShot;
        private System.Windows.Forms.RadioButton rdoNoSyrup;
        private System.Windows.Forms.GroupBox gbSyrupOptions;
        private System.Windows.Forms.RadioButton rdoSyrupCaramel;
        private System.Windows.Forms.RadioButton rdoSyrupHazelnut;
        private System.Windows.Forms.RadioButton rdoSyrupVanilla;
        private System.Windows.Forms.RadioButton rdoSteviaSyrup;
        private System.Windows.Forms.GroupBox gbMilkOptions;
        private System.Windows.Forms.RadioButton rdoMilkSoy;
        private System.Windows.Forms.RadioButton rdoMilkAlmond;
        private System.Windows.Forms.RadioButton rdoMilkOat;
        private System.Windows.Forms.GroupBox gbShotOptions;
        private System.Windows.Forms.RadioButton rdoDecaf2Shot;
        private System.Windows.Forms.RadioButton rdo2Shot;
        private System.Windows.Forms.RadioButton rdoShot;
        private System.Windows.Forms.RadioButton rdoSizeUp;
        private System.Windows.Forms.CheckBox chkWhippedCream;
        private System.Windows.Forms.CheckBox chkPearl;
        private System.Windows.Forms.GroupBox gbDrizzleOptions;
        private System.Windows.Forms.RadioButton rdoDrizzleCaramel;
        private System.Windows.Forms.RadioButton rdoDrizzleChocolate;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button getMenu;
    }
}

