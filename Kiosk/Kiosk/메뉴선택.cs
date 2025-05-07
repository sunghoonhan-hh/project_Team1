using System;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class 메뉴선택 : Form
    {
        public 메뉴선택()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();  // 메뉴선택 닫으면 매장포장이 다시 뜸 (FormClosed에서 연결됨)
        }
    }
}
