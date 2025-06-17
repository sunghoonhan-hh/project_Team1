using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Form_credit_payment : Form
    {
        int totalAmount; // 예시로 총 결제 금액을 10,000원으로 설정
        public Form_credit_payment(int totalprice)
        {
            InitializeComponent();
            totalAmount = totalprice;
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
            txtTotalPrice.Text = $"{totalAmount}원";
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (txtCardInput.Text.Length!=16)
            {
                txtCardInput.Text += btn.Text;
            }
        }

        private void custom_Button1_Click(object sender, EventArgs e)
        {
            string cardNumber = txtCardInput.Text;

            if (cardNumber.Length != 16)
            {
                MessageBox.Show("카드 번호는 16자리여야 합니다.");
                return;
            }

            int originalAmount = totalAmount;
            int currentPoints = LoadPointsFromCSV(cardNumber);
            int usedPoints = 0;

            if (currentPoints > 0)
            {
                DialogResult useAll = MessageBox.Show(
                    $"보유 포인트: {currentPoints}점\n전부 사용하시겠습니까?",
                    "포인트 사용", MessageBoxButtons.YesNo);

                if (useAll == DialogResult.Yes)
                {
                    usedPoints = Math.Min(currentPoints, originalAmount);  // 결제금액보다 많으면 결제금액까지만 사용
                }
            }

            int finalAmount = Math.Max(0, originalAmount - usedPoints);

            SavePaymentToCSV(cardNumber, finalAmount);
            UpdatePointsCSV(cardNumber, currentPoints - usedPoints, finalAmount);

            MessageBox.Show($"결제 완료!\n사용 포인트: {usedPoints}점\n적립된 포인트: {(int)(finalAmount * 0.05)}점");

            txtCardInput.Clear();
            this.Close();
            매장포장 newForm = new 매장포장();
            newForm.Show();
            this.Close();
        }
        

        private int LoadPointsFromCSV(string cardNumber)
        {
            string filePath = "points.csv";
            if (!File.Exists(filePath)) return 0;

            foreach (var line in File.ReadAllLines(filePath).Skip(1))
            {
                var tokens = line.Split(',');
                if (tokens.Length == 2 && tokens[0] == cardNumber)
                {
                    return int.Parse(tokens[1]);
                }
            }
            return 0;
        }
        private void UpdatePointsCSV(string cardNumber, int remainingPoints, int amountPaid)
        {
            string filePath = "points.csv";
            Dictionary<string, int> pointData = new Dictionary<string, int>();

            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath).Skip(1))
                {
                    var tokens = line.Split(',');
                    if (tokens.Length == 2)
                    {
                        pointData[tokens[0]] = int.Parse(tokens[1]);
                    }
                }
            }

            int earnedPoints = (int)(amountPaid * 0.05);
            pointData[cardNumber] = remainingPoints + earnedPoints;

            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                sw.WriteLine("CardNumber,Points");
                foreach (var kvp in pointData)
                {
                    sw.WriteLine($"{kvp.Key},{kvp.Value}");
                }
            }
        }

        private void SavePaymentToCSV(string cardNumber, int amount)
        {
            string filePath = "payments.csv";
            bool fileExists = File.Exists(filePath);

            string maskedCard = MaskCardNumber(cardNumber);
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string line = $"카드 결제,{maskedCard},{amount},{date}";

            using (StreamWriter sw = new StreamWriter(filePath, append: true, Encoding.UTF8))
            {
                if (!fileExists)
                {
                    sw.WriteLine("PaymentCategory,CardNumber,Amount,Date");
                }
                sw.WriteLine(line);
            }
        }

        private string MaskCardNumber(string cardNumber)
        {
            if (cardNumber.Length != 16) return cardNumber;
            return $"{cardNumber.Substring(0, 8)}-****-****-";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCardInput.Text = txtCardInput.Text.Length > 0 ?
                txtCardInput.Text.Substring(0, txtCardInput.Text.Length - 1) : "";
        }
    }
}
