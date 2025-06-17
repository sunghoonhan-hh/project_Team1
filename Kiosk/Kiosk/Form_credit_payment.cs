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
    public partial class Form_credit_payment : Form
    {
        public Form_credit_payment()
        {
            InitializeComponent();
        }

        private void Form_credit_payment_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            label2.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            button1.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            button2.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            button3.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            button4.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            button5.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            button6.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            button7.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            button8.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            button9.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            custom_Button1.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text.Length!=16)
            {
                txtCardInput.Text += btn.Text;
            }
        }

        private void custom_Button1_Click(object sender, EventArgs e)
        {
            
            매장포장 newForm = new 매장포장();
            newForm.Show();
            this.Close();
        }
    }
}
