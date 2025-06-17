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
    public partial class Form_cuppon_payment : Form
    {
        public Form_cuppon_payment()
        {
            InitializeComponent();
        }

        private void Form_cuppon_payment_Load(object sender, EventArgs e)
        {

        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                txtCuponInput.Text += btn.Text;
            }
        }
    }
}
