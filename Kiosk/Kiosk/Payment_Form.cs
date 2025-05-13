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
        public Form_payment()
        {
            InitializeComponent();
            btn_credit_payment.Image = new Bitmap(Properties.Resources.card,btn_credit_payment.Width,btn_credit_payment.Height);          
            btn_credit_payment.ImageAlign = ContentAlignment.MiddleCenter;
            btn_simple_payment.Image = new Bitmap(Properties.Resources.simple,btn_simple_payment.Width,btn_simple_payment.Height);
            btn_simple_payment.ImageAlign = ContentAlignment.MiddleCenter;
            btn_cuppon_payment.Image = new Bitmap(Properties.Resources.coupon,btn_cuppon_payment.Width, btn_cuppon_payment.Height);
            btn_cuppon_payment.ImageAlign = ContentAlignment.MiddleCenter;
            
        }

       

        private void btn_simple_payment_Click(object sender, EventArgs e)
        {
            Form_simple_payment form_Simple_Payment = new Form_simple_payment();
            form_Simple_Payment.Show();
        }

        private void btn_credit_payment_Click(object sender, EventArgs e)
        {
            Form_credit_payment form_Credit_Payment = new Form_credit_payment();
            form_Credit_Payment.Show();
        }

        private void btn_cuppon_payment_Click(object sender, EventArgs e)
        {
            Form_cuppon_payment form_Cuppon_Payment = new Form_cuppon_payment();
            form_Cuppon_Payment.Show();
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
