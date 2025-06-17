using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Kiosk
{
    public partial class SelectCoffee : Form
    {
        // 남은 시간
        private int leftTime = 120;

        // 마지막으로 누른 버튼 및 표시된 이미지와 라벨 정보들
        private Button lastClickedButton = null;
        private List<PictureBox> shownPictures = new List<PictureBox>();
        private List<Label> shownPriceLabels = new List<Label>();

        // 각 category의 실제 폴더명
        private Dictionary<string, string> categoryImageFolder = new Dictionary<string, string>()
        {
            { "에이드", "AdeJuice" },
            { "커피(HOT)", "Coffee(Hot)" },
            { "커피(ICE)", "Coffee(Ice)" },
            { "디카페인", "Decaffeine" },
            { "음료", "Drink" },
            { "에스프레소", "Espresso" },
            { "스무디프라페", "SmoothyFrappe" },
            { "티", "Tea" }
        };

        // 각 음료의 가격
        private Dictionary<string, int> menuPrices = new Dictionary<string, int>()
        {
            // 에이드 주스
            { "골드키위주스", 4000 },
            { "꿀수박주스", 3500 },
            { "딸기바나나주스", 4000 },
            { "딸기주스", 4000 },
            { "제로부스트에이드", 2700 },
            { "피치푸룬주스", 3700 },
            
            // 커피(HOT)
            { "콜드브루디카페인(HOT)", 4300 },
            { "콜드브루디카페인라떼(HOT)", 4800 },
            { "헛개리카노(HOT)", 2400 },

            // 커피(ICE)
            { "라이트바닐라아몬드라떼", 4700 },
            { "왕메가카페라떼", 4400 },
            { "왕메가헛개리카노", 4000 },
            { "왕할메가커피", 4000 },
            { "콜드브루디카페인", 4000 },
            { "콜드브루디카페인라떼", 4000 },
            { "할메가미숫커피", 4000 },
            { "할메가커피", 4000 },
            { "헛개리카노", 4000 },

            // 디카페인
            { "디카페인꿀아메리카노(ICE)", 4000 },
            { "디카페인꿀아메리카노", 4000 },
            { "디카페인라이트바닐라아몬드라떼", 4000 },
            { "디카페인메가리카노", 4000 },
            { "디카페인바닐라라떼(ICE)", 4000 },
            { "디카페인바닐라라떼", 4000 },
            { "디카페인바닐라아메리카노(ICE)", 4000 },
            { "디카페인바닐라아메리카노", 4000 },
            { "디카페인아메리카노(ICE)", 4000 },
            { "디카페인아메리카노", 4000 },
            { "디카페인연유라떼(ICE)", 4000 },
            { "디카페인연유라떼", 4000 },
            { "디카페인왕메가카페라떼", 4000 },
            { "디카페인왕메가헛개리카노", 4000 },
            { "디카페인카라멜마끼아또(ICE)", 4000 },
            { "디카페인카라멜마끼아또", 4000 },
            { "디카페인카페라떼(ICE)", 4000 },
            { "디카페인카페라떼", 4000 },
            { "디카페인카페모카(ICE)", 4000 },
            { "디카페인카페모카", 4000 },
            { "디카페인카푸치노(ICE)", 4000 },
            { "디카페인카푸치노", 4700 },
            { "디카페인헛개리카노(ICE)", 4000 },
            { "디카페인헛개리카노", 4000 },
            { "디카페인헤이즐넛(ICE)", 4000 },
            { "디카페인헤이즐넛", 4000 },
            { "디카페인헤이즐넛라떼(ICE)", 4000 },
            { "디카페인헤이즐넛라떼", 4000 },

            // 음료
            { "고구마라떼(HOT)", 4000 },
            { "고구마라떼(ICE)", 4000 },
            { "곡물라떼(HOT)", 4000 },
            { "곡물라떼(ICE)", 4000 },
            { "녹차라떼", 4000 },
            { "로얄밀크티라떼", 4000 },
            { "오레오초코라떼", 4000 },
            { "왕메가초코", 4000 },
            { "토피넛라떼(HOT)", 4000 },
            { "토피넛라떼", 4000 },
            { "핫초코", 4000 },
            { "흑당라떼", 4000 },
            { "흑당밀크티라떼", 4000 },
            { "흑당버블밀크티라떼", 4000 },

            // 에스프레소
            { "디카페인에스프레소", 4000 },
            { "에스프레소", 4000 },
            { "에스프레소도피오", 4000 },

            // 스무디&프라페
            { "골드망고스무디", 4000 },
            { "귤톡톡젤리스무디", 4000 },
            { "꿀복숭아스무디", 4000 },
            { "꿀수박화채스무디", 4000 },
            { "딸기쿠키프라페", 4000 },
            { "블루베리요거트스무디", 4000 },
            { "코코넛커피스무디", 4000 },
            { "쿠키프라페", 4000 },

            // 티
            { "상큼리치티(HOT)", 4000 },
            { "상큼리치티(ICE)", 4000 },
            { "왕메가아이스티", 4000 },
            { "저당POPPOP매실아이스티", 4000 },
            { "제로복숭아아이스티", 4000 }
        };

        private List<MenuInformation> menuLists = new List<MenuInformation>();

        public SelectCoffee()
        {
            InitializeComponent();
            InitializeTotalPrice();

            // 폼 크기 고정
            this.Size = new Size(525, 721);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            CreateRoundedButtons();
        }

        private void InitializeTotalPrice()
        {
            total.Controls.Clear(); // 기존 내용 지우기

            Label totalLabel = new Label();
            totalLabel.Text = $"총 합계: 0원";
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(5, 5);
            totalLabel.Font = new Font("Maplestory Bold", 12, FontStyle.Bold);
            totalLabel.ForeColor = Color.DarkBlue;

            total.Controls.Add(totalLabel);
        }

        // 카테고리 버튼 생성
        private void CreateRoundedButtons()
        {
            // 버튼 위치 및 이름
            int[] x = { 10, 110, 210, 310, 10, 110, 210, 310 };
            int[] y = { 20, 20, 20, 20, 65, 65, 65, 65 };
            string[] categories = { "에이드", "커피(ICE)", "커피(HOT)", "디카페인", "음료", "에스프레소", "스무디프라페", "티" };

            // 화면에 버튼 동적 생성
            for (int i = 0; i < categories.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(90, 40);
                btn.Location = new Point(50 + x[i], 40 + y[i]);
                btn.Text = categories[i];
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.Gold;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Maplestory Bold", 12, FontStyle.Bold);
                btn.Region = new Region(CreateRoundPath(btn.Width, btn.Height, 20));
                btn.Click += CategoryButton_Click;

                btn.Paint += (sender, e) =>
                {
                    using (GraphicsPath path = CreateRoundPath(btn.Width, btn.Height, 20))
                    using (Pen pen = new Pen(Color.DarkBlue, 3))
                    {
                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        e.Graphics.DrawPath(pen, path);
                    }
                };

                Controls.Add(btn);
            }
        }

        // 버튼의 클릭 이벤트 생성
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.Gold;
                lastClickedButton.ForeColor = Color.Black;
            }

            clickedButton.BackColor = Color.Black;
            clickedButton.ForeColor = Color.White;
            lastClickedButton = clickedButton;

            string category = clickedButton.Text;
            ShowCategoryImages(category);
        }

        MenuInformation tempMenu;

        // 버튼 클릭했을 때의 음료수 목록이 나오게 하는 함수
        private void ShowCategoryImages(string category)
        {
            // 이전에 표시된 이미지를 지우기
            foreach (PictureBox pic in shownPictures)
                Controls.Remove(pic);
            shownPictures.Clear();

            // 이전에 표시된 가격표 지우기
            foreach (Label label in shownPriceLabels)
                Controls.Remove(label);
            shownPriceLabels.Clear();

            if (!categoryImageFolder.ContainsKey(category)) return;

            // 이미지를 폴더 주소
            string baseImagePath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\Image"));
            string folderName = categoryImageFolder[category];
            string categoryPath = Path.Combine(baseImagePath, folderName);

            if (!Directory.Exists(categoryPath))
                return;
            

            // 이미지 가져오기
            string[] imageExtensions = new[] { "*.jpg" };
            List<string> imageFiles = new List<string>();

            foreach (var ext in imageExtensions)
            {
                imageFiles.AddRange(Directory.GetFiles(categoryPath, ext));
            }

            int count = Math.Min(12, imageFiles.Count);
    
            // 이미지 표시
            for (int i = 0; i < count; i++)
            {
                string fileName = Path.GetFileNameWithoutExtension(imageFiles[i]);
                string menuName = fileName;
                int price = menuPrices.ContainsKey(menuName) ? menuPrices[menuName] : 0;
                menuName = Path.GetFileNameWithoutExtension(imageFiles[i]);

                MenuInformation menuInfo = new MenuInformation(menuName, Image.FromFile(imageFiles[i]), price);

                // PictureBox 생성
                PictureBox picBox = new PictureBox();
                picBox.Size = new Size(100, 80);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Image = menuInfo.MenuImage;

                int row = i / 4;  // 가로 4
                int col = i % 4;  // 세로 3

                picBox.Location = new Point(40 + col * 110, 160 + row * 110); // 이미지 간 간격 조정

                // 메뉴 이름 8글자까지로 자르기
                if (menuName.Length > 8) menuName = menuName.Substring(0, 8);

                // Label을 사용하여 가격 정보 표시
                Label priceLabel = new Label();
                priceLabel.Text = $"{menuName} \n {menuInfo.Price}원";
                priceLabel.Font = new Font("Maplestory Bold", 7, FontStyle.Regular);
                priceLabel.TextAlign = ContentAlignment.MiddleCenter;
                priceLabel.ForeColor = Color.Black;
                priceLabel.Size = new Size(100, 25);
                priceLabel.BackColor = Color.White;

                // 글자를 가운데 정렬
                int centerX = 90 + col * 110;
                int topY = 130 + (row + 1) * 110;
                priceLabel.Location = new Point(centerX - priceLabel.Width / 2, topY);
                priceLabel.AutoSize = false;
                priceLabel.MaximumSize = priceLabel.Size;

                picBox.Click += (sender, e) =>
                {
                    tempMenu = menuInfo;
                    OptionView optionview = new OptionView(menuInfo);
                    optionview.FormClosed += Product_check_Form_FormClosed;
                    optionview.Show();
                };

                // 생성한 이미지와 가격표를 화면에 띄우기
                shownPictures.Add(picBox);
                Controls.Add(picBox);
                shownPriceLabels.Add(priceLabel);
                Controls.Add(priceLabel);
            }
        }

        private void Product_check_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!tempMenu.IsReturn)
            {
                AddMenu(tempMenu.MenuName, tempMenu.MenuImage, tempMenu.Price);
            }
        }

        private decimal totalPrice = 0;
        private int panelItemCount = 0;

        private void RefreshBucket()
        {
            bucket.Controls.Clear();

            int y = 5;
            foreach (var item in menuLists)
            {
                Label label = new Label();
                label.Text = $"{item.MenuName} | {item.Price}원";
                label.AutoSize = true;
                label.Location = new Point(5, y);
                label.Font = new Font("Maplestory Bold", 10, FontStyle.Regular);
                label.ForeColor = Color.Black;

                bucket.Controls.Add(label);

                y += 25;
            }
        }

        private void AddMenu(string menuName, Image image, int price)
        {
            // 항상 새로 추가
            menuLists.Add(new MenuInformation(menuName, image, price));

            // 총합 다시 계산
            totalPrice = menuLists.Sum(item => item.Price * item.Count);

            menuCount.Text = $"{menuLists.Count}개";

            // 화면 갱신
            RefreshBucket();
            UpdateTotalPriceLabel();
        }

        private void UpdateTotalPriceLabel()
        {
            total.Controls.Clear(); // 기존 내용 지우기

            Label totalLabel = new Label();
            totalLabel.Text = $"총 합계: {totalPrice}원";
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(5, 5);
            totalLabel.Font = new Font("Maplestory Bold", 12, FontStyle.Bold);
            totalLabel.ForeColor = Color.DarkBlue;

            total.Controls.Add(totalLabel);
        }

        // 둥근 경로를 그리는 함수
        private GraphicsPath CreateRoundPath(int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(width - radius - 1, height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        // 남은 시간 줄이는 함수
        private void timer1_Tick(object sender, EventArgs e)
        {
            leftTime--;

            if (leftTime <= 0)
            {
                leftTime = 987654321;
                timer1.Stop();
                매장포장 home = new 매장포장();
                home.Show();
                this.Hide();
            }
            else
            {
                label_Timer.Text = $"{leftTime}초";
            }
        }

        private void SelectCoffee_Load(object sender, EventArgs e)
        {
            label_Timer.Text = $"{leftTime}초";
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void picture_Home_Click(object sender, EventArgs e)
        {
            매장포장 home = new 매장포장(true);
            home.Show();
            this.Hide();
        }

        private void picture_Calculate_Click(object sender, EventArgs e)
        {
            Product_check_Form home = new Product_check_Form(menuLists, totalPrice);
            home.Show();
            this.Hide();
        }

        private void DeleteBucket(object sender, EventArgs e)
        {
            bucket.Controls.Clear();
            menuLists.Clear();
            menuCount.Text = $"0개";
            Label totalPriceLabel = total.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "totalPriceLabel");
            if (totalPriceLabel != null)
            {
                totalPriceLabel.Text = "총합: 0원";
            }
            totalPrice = 0;
            panelItemCount = 0;
            InitializeTotalPrice();
        }
    }
}
