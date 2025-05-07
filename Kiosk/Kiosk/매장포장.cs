using System;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class 매장포장 : Form
    {
        public 매장포장()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();  // 메인 폼 닫히면 전체 종료
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            this.Hide();
            좌석배치도 seatForm = new 좌석배치도();
            seatForm.FormClosed += (s, args) => this.Show();  // 좌석배치도 닫히면 다시 보이기
            seatForm.Show();
        }

        private void btnTakeout_Click(object sender, EventArgs e)
        {
            this.Hide();
            메뉴선택 menuForm = new 메뉴선택();
            menuForm.FormClosed += (s, args) => this.Show();  // 메뉴선택 닫히면 다시 보이기
            menuForm.Show();
        }
    }
}
