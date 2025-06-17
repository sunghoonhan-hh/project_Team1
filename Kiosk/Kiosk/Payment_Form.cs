using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Form_payment : Form
    {
        int totalPrice; // 예시로 총 결제 금액을 10,000원으로 설정
        public Form_payment(int total)
        {
            InitializeComponent();
            btn_credit_payment.Image = new Bitmap(Properties.Resources.card,btn_credit_payment.Width,btn_credit_payment.Height);          
            btn_credit_payment.ImageAlign = ContentAlignment.MiddleCenter;
            btn_cuppon_payment.Image = new Bitmap(Properties.Resources.coupon,btn_cuppon_payment.Width, btn_cuppon_payment.Height);
            btn_cuppon_payment.ImageAlign = ContentAlignment.MiddleCenter;
            totalPrice = total;
        }

       



        private void btn_credit_payment_Click(object sender, EventArgs e)
        {
            Form_credit_payment form_Credit_Payment = new Form_credit_payment(totalPrice);
            form_Credit_Payment.Show();
            Close();
        }

        private void btn_cuppon_payment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현금결제는 카운터에서 부탁드립니다.");
        }

        private void Form_payment_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
