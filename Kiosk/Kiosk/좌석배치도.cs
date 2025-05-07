using System;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class 좌석배치도 : Form
    {
        public 좌석배치도()
        {
            InitializeComponent();

            // 좌석 버튼 이벤트 연결
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Tag != null)
                {
                    c.Click += SeatButton_Click;
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                clickedButton.BackColor = System.Drawing.Color.Gray;
                clickedButton.Enabled = false;

                this.Hide();
                메뉴선택 menuForm = new 메뉴선택();
                menuForm.FormClosed += (s, args) => this.Close();  // 메뉴선택 닫히면 좌석배치도도 같이 닫힘
                menuForm.Show();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();  // 좌석배치도 닫으면 매장포장이 다시 뜸 (FormClosed에서 연결됨)
        }
    }
}
