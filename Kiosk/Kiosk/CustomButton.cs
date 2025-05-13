using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyButton
{
    class Custom_Button : Button
    {
        public int Radius { get; set; } //외부에서 크기를 받습니다.
        public bool IsMaximum { get; set; } //외부에서 최대 사이즈를 받습니다.

        public Custom_Button()
        {
            Radius = 20;
            IsMaximum = true;

            this.BackColor = Color.Yellow; //기본 색을 지정해줍니다.
            this.FlatStyle = FlatStyle.Flat; //버튼을 플랫하게 만들어줍니다.
            this.FlatAppearance.BorderSize = 0; //보더가 지저분해지기에 제거해줍니다.
        }

        protected override void OnPaint(PaintEventArgs p)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rectangle = ClientRectangle;

            int radius = Math.Min(this.Height, Radius); //Height를 넘어가면 모양이 이상해집니다!

            if (IsMaximum) //최대 사이즈인 경우는 Height로!
            {
                radius = this.Height;
            }

            int x = rectangle.X;
            int y = rectangle.Y;
            int width = rectangle.Width;
            int height = rectangle.Height;

            //그리는 순서가 굉장히 중요합니다!
            path.AddArc(x, y, radius, radius, 180, 90); //왼쪽 상단
            path.AddArc(x + width - radius, y, radius, radius, 270, 90); //오른쪽 상단
            path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90); //오른쪽 하단
            path.AddArc(x, y + height - radius, radius, radius, 90, 90); //왼쪽 하단

            path.CloseAllFigures();

            this.Region = new Region(path); //영역을 둥근형태로 만들어줍니다.

            base.OnPaint(p);
        }
    }
}