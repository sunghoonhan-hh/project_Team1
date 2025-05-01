using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

       

        private void btn_simple_payment_Click(object sender, EventArgs e)
        {
            Form_simple_payment form_Simple_Payment = new Form_simple_payment();
            this.listBox_goods.Items.Clear();
        }

        private void btn_credit_payment_Click(object sender, EventArgs e)
        {
            Form_credit_payment form_Credit_Payment = new Form_credit_payment();
        }

        private void btn_cuppon_payment_Click(object sender, EventArgs e)
        {
            Form_cuppon_payment form_Cuppon_Payment = new Form_cuppon_payment();
        }
    }
}
