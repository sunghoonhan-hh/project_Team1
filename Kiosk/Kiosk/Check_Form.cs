using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosk
{
    public partial class Product_check_Form : Form
    {
        private List<MenuInformation> menuInformation;
        private decimal totalPrice;
        public Product_check_Form(List<MenuInformation> select,decimal price)
        {
            InitializeComponent();
            this.menuInformation = select;
            lvw_selected.View = View.Details;
            lvw_selected.OwnerDraw = true;
            lvw_selected.FullRowSelect = true;
            lvw_selected.GridLines = false;

            // 컬럼 추가
            lvw_selected.Columns.Add("음료", 100);
            lvw_selected.Columns.Add("옵션", 120);
            lvw_selected.Columns.Add("수량", 60);
            lvw_selected.Columns.Add("금액", 80);

            // 이벤트 연결
            lvw_selected.DrawColumnHeader += ListView1_DrawColumnHeader;
            lvw_selected.DrawItem += ListView1_DrawItem;
            lvw_selected.DrawSubItem += ListView1_DrawSubItem;
        }
        private void ListView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (SolidBrush backBrush = new SolidBrush(Color.Beige))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            using (Pen borderPen = new Pen(Color.SaddleBrown))
            {
                e.Graphics.DrawRectangle(borderPen, e.Bounds);
            }

            using (StringFormat sf = new StringFormat())
            using (Font headerFont = new Font("Maplestory Bold", 10, FontStyle.Bold))
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.SaddleBrown, e.Bounds, sf);
            }
        }

        private void ListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawBackground();
        }

        private void ListView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Rectangle rect = e.SubItem.Bounds;
            bool selected = (e.ItemState & ListViewItemStates.Selected) != 0;

            // 배경 색상
            using (SolidBrush backgroundBrush = new SolidBrush(selected ? Color.MistyRose : Color.Linen))
            {
                e.Graphics.FillRectangle(backgroundBrush, rect);
            }

            // 텍스트 그리기
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis;
            using (Font subItemFont = new Font("맑은 고딕", 9))
            {
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, subItemFont, rect, Color.SaddleBrown, flags);
            }

            // 선택 항목 테두리 강조 (선택사항)
            if (selected)
            {
                using (Pen borderPen = new Pen(Color.SaddleBrown))
                {
                    e.Graphics.DrawRectangle(borderPen, rect);
                }
            }
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            // 좌상단
            path.AddArc(arc, 180, 90);

            // 우상단
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // 우하단
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // 좌하단
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
        private void btn_payment_Click(object sender, EventArgs e)
        {
            Form_payment payment = new Form_payment((int)totalPrice, menuInformation);
            payment.ShowDialog();
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            SelectCoffee newForm = new SelectCoffee(menuInformation);
            newForm.Show();
            this.Close();
        }

        private void Product_check_Form_Load(object sender, EventArgs e)
        {
            show_Item();

            txt_total.Text = "총 금액 : " + totalPrice.ToString() + "원";
            txt_total.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            btn_back.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            btn_payment.Font = new Font("Maplestory Bold", 10, FontStyle.Bold);
            //MessageBox.Show("선택된 항목 수: " + menuInformation.Count);
        }

        private void show_Item()
        {
            foreach(MenuInformation m in menuInformation)
            {
                string[] row = new string[4];
                row[0] = m.MenuName;
                row[1] = "  ";
                if (m.Option_IceMore == true) { row[1] += "얼음 많이"; }
                if (m.Option_IceLess == true) { row[1] += "얼음 적게"; }
                if (m.Option_LessSweet == true) { row[1] += "덜 달게"; }
                if (m.Option_SteviaSugar == true) { row[1] += "스테비아 추가"; }
                if (m.Option_CupSizeUp == true) { row[1] += "사이즈 업"; }
                if (m.Option_Decaf2Shot != 0) { row[1] += "디 카페인"; }
                if (m.Option_Drizzle_Caramel == true) { row[1] += "카라멜"; }
                if (m.Option_Drizzle_Chocolate == true) { row[1] += "초콜릿"; }
                if (m.Option_Pearl == true) { row[1] += "펄 추가"; }
                if (m.Option_Shot == true) { row[1] += "샷 추가"; }
                if (m.Option_2Shot == true) { row[1] += "2샷 추가"; }
                if (m.Option_Syrup_Caramel == true) { row[1] += "캐러맬 시럽 추가"; }
                if (m.Option_Syrup_Hazelnut == true) { row[1] += "헤이즐넛 시럽 추가"; }
                if (m.Option_Syrup_Vanilla == true) { row[1] += "바닐라 시럽 추가"; }
                if (m.Option_Milk_Almond == true) { row[1] += "아몬드 밀크"; }
                if (m.Option_Milk_Oat == true) { row[1] += "오트 밀크"; }
                if (m.Option_Milk_Soy == true) { row[1] += "소이 밀크"; }
                if (m.Option_WhippedCream == true) { row[1] += "휘핑 크림 추가"; }
                row[2] = m.Count.ToString();
                row[3] = m.Price.ToString();
                lvw_selected.Items.Add(new ListViewItem(row));
                totalPrice += m.Price;
            }
        }
    }
}
