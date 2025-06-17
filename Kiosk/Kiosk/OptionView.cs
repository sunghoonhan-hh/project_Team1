using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{


    public partial class OptionView : Form
    {

        #region 메뉴-분류 매핑 딕셔너리
        
        Dictionary<string, string> menuCategoryMap = new Dictionary<string, string>()
{
    // 1. 에이드/주스
    { "골드키위주스(ICE)", "에이드/주스" },
    { "꿀수박주스(ICE)", "에이드/주스" },
    { "딸기바나나주스(ICE)", "에이드/주스" },
    { "딸기주스(ICE)", "에이드/주스" },
    { "제로부스트에이드(ICE)", "에이드/주스" },
    { "피치 푸룬주스(ICE)", "에이드/주스" },

    // 2. 커피(아이스)
    { "라이트바닐라아몬드라떼", "커피(아이스)" },
    { "왕메가카페라떼", "커피(아이스)" },
    { "왕메가헛개리카노", "커피(아이스)" },
    { "왕할메가커피", "커피(아이스)" },
    { "콜드브루디카페인(ICE)", "커피(아이스)" },
    { "콜드브루디카페인라떼(ICE)", "커피(아이스)" },
    { "할메가미숫커피", "커피(아이스)" },
    { "할메가커피", "커피(아이스)" },
    { "헛개리카노(ICE)", "커피(아이스)" },

    // 3. 커피(핫)
    { "콜드브루디카페인(HOT)", "커피(핫)" },
    { "콜드브루디카페인라떼(HOT)", "커피(핫)" },
    { "헛개리카노(HOT)", "커피(핫)" },

    // 4. 디카페인
    { "디카페인꿀아메리카노(ICE)", "디카페인" },
    { "디카페인꿀아메리카노(HOT)", "디카페인" },
    { "디카페인라이트바닐라아몬드라떼(ICE)", "디카페인" },
    { "디카페인메가리카노(ICE)", "디카페인" },
    { "디카페인바닐라라떼(ICE)", "디카페인" },
    { "디카페인바닐라라떼(HOT)", "디카페인" },
    { "디카페인바닐라아메리카노(ICE)", "디카페인" },
    { "디카페인바닐라아메리카노(HOT)", "디카페인" },
    { "디카페인아메리카노(ICE)", "디카페인" },
    { "디카페인아메리카노(HOT)", "디카페인" },
    { "디카페인연유라떼(ICE)", "디카페인" },
    { "디카페인연유라떼(HOT)", "디카페인" },
    { "디카페인왕메가카페라떼(ICE)", "디카페인" },
    { "디카페인왕메가헛개리카노(ICE)", "디카페인" },
    { "디카페인카라멜마끼아또(ICE)", "디카페인" },
    { "디카페인카라멜마끼아또(HOT)", "디카페인" },
    { "디카페인카페라떼(ICE)", "디카페인" },
    { "디카페인카페라떼(HOT)", "디카페인" },
    { "디카페인카페모카(ICE)", "디카페인" },
    { "디카페인카페모카(HOT)", "디카페인" },
    { "디카페인카푸치노(ICE)", "디카페인" },
    { "디카페인카푸치노(HOT)", "디카페인" },
    { "디카페인헛개리카노(ICE)", "디카페인" },
    { "디카페인헛개리카노(HOT)", "디카페인" },
    { "디카페인헤이즐넛(ICE)", "디카페인" },
    { "디카페인헤이즐넛(HOT)", "디카페인" },
    { "디카페인헤이즐넛라떼(ICE)", "디카페인" },
    { "디카페인헤이즐넛라떼(HOT)", "디카페인" },

    // 5. 드링크
    { "고구마라떼(HOT)", "드링크" },
    { "고구마라떼(ICE)", "드링크" },
    { "곡물라떼(HOT)", "드링크" },
    { "곡물라떼(ICE)", "드링크" },
    { "녹차라떼(HOT)", "드링크" },
    { "로얄밀크티라떼(HOT)", "드링크" },
    { "오레오초코라떼(ICE)", "드링크" },
    { "왕메가초코(ICE)", "드링크" },
    { "토피넛라떼(HOT)", "드링크" },
    { "토피넛라떼(ICE)", "드링크" },
    { "핫초코(HOT)", "드링크" },
    { "흑당라떼(ICE)", "드링크" },
    { "흑당밀크티라떼(ICE)", "드링크" },
    { "흑당버블밀크티라떼(ICE)", "드링크" },

    // 6. 에스프레소
    { "디카페인에스프레소", "에스프레소" },
    { "에스프레소", "에스프레소" },
    { "에스프레소도피오", "에스프레소" },

    // 7. 스무디/프라페
    { "골드망고스무디", "스무디/프라페" },
    { "귤톡톡젤리스무디", "스무디/프라페" },
    { "꿀복숭아스무디", "스무디/프라페" },
    { "꿀수박화채스무디", "스무디/프라페" },
    { "딸기쿠키프라페", "스무디/프라페" },
    { "블루베리요거트스무디", "스무디/프라페" },
    { "코코넛커피스무디", "스무디/프라페" },
    { "쿠키프라페", "스무디/프라페" },

    // 8. 티
    { "상큼리치티(HOT)", "티" },
    { "상큼리치티(ICE)", "티" },
    { "왕메가아이스티(ICE)", "티" },
    { "저당POPPOP매실아이스티(ICE)", "티" },
    { "제로복숭아아이스티(ICE)", "티" },

};
        #endregion

        // 현재 선택된 메뉴의 정보(참조로 넘어옴, 옵션 선택 결과도 이 객체에 저장)
        private MenuInformation currentMenuInfo;

        private int _tempPrice = 0;
        private int _basePrice;

        public OptionView()
        {
            InitializeComponent();

            MakeAllControlsRound(this, 15);
            // 모든 "선택안함" 체크박스 이벤트 연결
            rdoNoFreeOption.CheckedChanged += Option_CheckedChanged;
            rdoNoSyrup.CheckedChanged += Option_CheckedChanged;
            rdoNoMilk.CheckedChanged += Option_CheckedChanged;
            rdoNoShot.CheckedChanged += Option_CheckedChanged;
            rdoNoSize.CheckedChanged += Option_CheckedChanged;
            chkNoAddOns.CheckedChanged += Option_CheckedChanged;

            SetCurrentMenu(currentMenuInfo);
            UpdateTempPriceDisplay();
            SubscribeToCheckedChangedEvents(this);
        }

        public OptionView(MenuInformation menuInformation)
        {
            InitializeComponent();

            this.currentMenuInfo = menuInformation;

            ChosenMenuImg.Image = currentMenuInfo.MenuImage;

            MakeAllControlsRound(this, 15);
            // 모든 "선택안함" 체크박스 이벤트 연결
            rdoNoFreeOption.CheckedChanged += Option_CheckedChanged;
            rdoNoSyrup.CheckedChanged += Option_CheckedChanged;
            rdoNoMilk.CheckedChanged += Option_CheckedChanged;
            rdoNoShot.CheckedChanged += Option_CheckedChanged;
            rdoNoSize.CheckedChanged += Option_CheckedChanged;
            chkNoAddOns.CheckedChanged += Option_CheckedChanged;

            SetCurrentMenu(currentMenuInfo);
            UpdateTempPriceDisplay();
            SubscribeToCheckedChangedEvents(this);
        }

        private void SubscribeToCheckedChangedEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // 기존 구독 해제 후 재구독
                if (control is RadioButton rb && !rb.Text.Contains("선택안함"))
                {
                    rb.CheckedChanged -= Option_CheckedChanged; // 구독 해제
                    rb.CheckedChanged += Option_CheckedChanged;
                }
                else if (control is CheckBox cb && !cb.Text.Contains("선택안함"))
                {
                    cb.CheckedChanged -= Option_CheckedChanged; // 구독 해제
                    cb.CheckedChanged += Option_CheckedChanged;
                }

                if (control.HasChildren)
                {
                    SubscribeToCheckedChangedEvents(control);
                }
            }
        }


        private void NamePriceOptions_Resize(object sender, EventArgs e)
        {
            int padding = 5; // 텍스트박스 사이 여백
            int totalWidth = NamePriceOptions.ClientSize.Width;

            int menuNameWidth = (int)(totalWidth * 0.7) - padding;
            int menuPriceWidth = totalWidth - menuNameWidth - padding;

            int height = MenuName.Height; // 기존 높이 유지

            MenuName.Location = new Point(0, 0);
            MenuName.Size = new Size(menuNameWidth, height);

            MenuPrice.Location = new Point(menuNameWidth + padding, 0);
            MenuPrice.Size = new Size(menuPriceWidth, height);
        }


        // GDI+ API 선언
        [DllImport("gdi32.dll")]
    private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);

        // 컨트롤에 둥근 모서리 적용
        private void MakeAllControlsRound(Control parent, int radius)
        {
            foreach (Control child in parent.Controls)
            {
                // 모든 컨트롤 타입에 적용
                if (child is Panel || child is Button ||
                    child is TextBox || child is Label ||
                    child is GroupBox || child is PictureBox || child is Button)
                {
                    ApplyRoundedCorners(child, radius);
                }

                // 자식 컨트롤 재귀 처리
                if (child.HasChildren)
                {
                    MakeAllControlsRound(child, radius);
                }
            }
        }

        private void ApplyRoundedCorners(Control ctrl, int radius)
        {
            ctrl.Region?.Dispose(); // 기존 Region 메모리 해제
            ctrl.Region = Region.FromHrgn(CreateRoundRectRgn(
                0, 0, ctrl.Width + 1, ctrl.Height + 1, radius, radius));

            // 리사이즈 이벤트 핸들러 추가
            ctrl.SizeChanged += (sender, e) =>
            {
                var control = sender as Control;
                control.Region?.Dispose();
                control.Region = Region.FromHrgn(CreateRoundRectRgn(
                    0, 0, control.Width + 1, control.Height + 1, radius, radius));
            };
        }

        /// <summary>
        /// 외부에서 MenuInformation 객체(참조)를 넘겨줄 때 호출
        /// - currentMenuInfo에 참조 저장
        /// - 옵션 컨트롤 상태를 해당 객체 값으로 동기화
        /// - 분류에 따라 옵션 가시성 제어
        /// - 옵션 패널(tableLayoutPanel1) 표시
        /// </summary>
        /// 유완이와 합칠 코드
        public void SetCurrentMenu(MenuInformation menuInfo)
        {
            currentMenuInfo = menuInfo;
            _basePrice = currentMenuInfo.Price;
            _tempPrice = 0;

            MenuName.Text = currentMenuInfo.MenuName;

            SetDrinkCategory(currentMenuInfo);


            UpdateTempPriceDisplay(); // UI 갱신

            // 옵션 컨트롤 상태를 MenuInformation 객체 값으로 동기화
            rdoIceMore.Checked = currentMenuInfo.Option_IceMore;
            rdoIceLess.Checked = currentMenuInfo.Option_IceLess;
            rdoLessSweet.Checked = currentMenuInfo.Option_LessSweet;
            rdoSweet.Checked = currentMenuInfo.Option_Sweet;
            rdoNoFreeOption.Checked = !(currentMenuInfo.Option_IceMore || currentMenuInfo.Option_IceLess ||
                                       currentMenuInfo.Option_LessSweet || currentMenuInfo.Option_Sweet);

            rdoNoSyrup.Checked = !(currentMenuInfo.Option_SteviaSugar || currentMenuInfo.Option_Syrup_Vanilla ||
                                   currentMenuInfo.Option_Syrup_Hazelnut || currentMenuInfo.Option_Syrup_Caramel);
            rdoSteviaSyrup.Checked = currentMenuInfo.Option_SteviaSugar;
            rdoSyrupVanilla.Checked = currentMenuInfo.Option_Syrup_Vanilla;
            rdoSyrupHazelnut.Checked = currentMenuInfo.Option_Syrup_Hazelnut;
            rdoSyrupCaramel.Checked = currentMenuInfo.Option_Syrup_Caramel;

            rdoNoMilk.Checked = !(currentMenuInfo.Option_Milk_Oat || currentMenuInfo.Option_Milk_Almond || currentMenuInfo.Option_Milk_Soy);
            rdoMilkOat.Checked = currentMenuInfo.Option_Milk_Oat;
            rdoMilkAlmond.Checked = currentMenuInfo.Option_Milk_Almond;
            rdoMilkSoy.Checked = currentMenuInfo.Option_Milk_Soy;

            rdoNoShot.Checked = !(currentMenuInfo.Option_Shot || currentMenuInfo.Option_2Shot || currentMenuInfo.Option_Decaf2Shot > 0);
            rdoShot.Checked = currentMenuInfo.Option_Shot;
            rdo2Shot.Checked = currentMenuInfo.Option_2Shot;
            rdoDecaf2Shot.Checked = currentMenuInfo.Option_Decaf2Shot > 0;

            rdoNoSize.Checked = !currentMenuInfo.Option_CupSizeUp;
            rdoSizeUp.Checked = currentMenuInfo.Option_CupSizeUp;

            chkNoAddOns.Checked = !(currentMenuInfo.Option_Pearl || currentMenuInfo.Option_WhippedCream ||
                                   currentMenuInfo.Option_Drizzle_Chocolate || currentMenuInfo.Option_Drizzle_Caramel);
            chkPearl.Checked = currentMenuInfo.Option_Pearl;
            chkWhippedCream.Checked = currentMenuInfo.Option_WhippedCream;
            rdoDrizzleChocolate.Checked = currentMenuInfo.Option_Drizzle_Chocolate;
            rdoDrizzleCaramel.Checked = currentMenuInfo.Option_Drizzle_Caramel;

            // 분류에 따라 덜달게 옵션 가시성 제어
            rdoLessSweet.Visible = ShouldShowLessSweet(currentMenuInfo);

            // 옵션 패널(tableLayoutPanel1) 표시
            tableLayoutPanel1.Visible = true;
        }

        // Form1 클래스 내부에 추가
        private void UpdateTempPriceDisplay()
        {
            if (MenuPrice.InvokeRequired)
            {
                MenuPrice.Invoke(new Action(UpdateTempPriceDisplay));
            }
            else
            {
                MenuPrice.Text = $"{_basePrice + _tempPrice:#,##0}원";
                MenuPrice.Refresh();
            }
        }

        // 테이블 레이아웃 내 모든 컨트롤을 재귀적으로 탐색
        private void UpdateSelectedOptionsText()
        {
            List<string> selectedOptions = new List<string>();

            // 테이블 레이아웃 패널 내 모든 컨트롤 탐색
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                FindCheckedControls(control, selectedOptions);
            }

            // 텍스트 박스 업데이트
            if (selectedOptions.Count > 0)
                MenuOptionsView.Text = Environment.NewLine + string.Join(" / ", selectedOptions);
            else
                MenuOptionsView.Text = string.Empty;
        }

        // 재귀적 컨트롤 탐색 메서드
        private void FindCheckedControls(Control parent, List<string> options)
        {
            foreach (Control child in parent.Controls)
            {
                if (child is RadioButton rb && rb.Checked && !rb.Text.Contains("선택안함"))
                {
                    options.Add(rb.Text);
                }
                else if (child is CheckBox cb && cb.Checked && !cb.Text.Contains("선택안함"))
                {
                    options.Add(cb.Text);
                }

                // 그룹박스/패널 내부 컨트롤 재귀 탐색
                if (child.HasChildren)
                {
                    FindCheckedControls(child, options);
                }
            }
        }


        /// <summary>
        /// 무료옵션 그룹에서 "선택안함" 체크 시 다른 옵션 비활성화
        /// (로직은 Option_CheckedChanged에서 통합 처리)
        /// </summary>

        /// <summary>
        /// 덜달게 옵션 표시 조건 (분류 기반)
        /// 특정 분류(커피, 디카페인, 에스프레소)에서는 덜달게 옵션 숨김
        /// </summary>
        private bool ShouldShowLessSweet(MenuInformation menuInfo)
        {
            string[] exclude = { "커피(아이스)", "커피(핫)", "디카페인", "에스프레소" };
            return !exclude.Contains(menuInfo.MenuHead);
        }

        /// <summary>
        /// 얼음 옵션 & 사이즈 업그레이드 숨김 조건 판단
        /// </summary>
        private bool ShouldHideIceAndSize(MenuInformation menuInfo)
        {
            string[] excludeCategories = { "에스프레소", "커피(핫)" };
            bool isHotInName = menuInfo.MenuName.Contains("(HOT)");
            return excludeCategories.Contains(menuInfo.MenuHead) || isHotInName;
        }


        /// <summary>
        /// 메뉴 선택 또는 분류 변경 시 호출
        /// 들어온 메뉴에 따라 덜달게,얼음, 사이즈 옵션은 특정 분류 항목들에게만 적용한다.
        /// </summary>
        public void SetDrinkCategory(MenuInformation menuInfo)
        {
            currentMenuInfo = menuInfo;
            rdoLessSweet.Visible = ShouldShowLessSweet(menuInfo);

            bool hideIceAndSize = ShouldHideIceAndSize(menuInfo);
            gbIceOptions.Visible = !hideIceAndSize;
            gbSize.Visible = !hideIceAndSize;

            if (hideIceAndSize)
            {
                // 이벤트 핸들러 일시 해제
                rdoNoSize.CheckedChanged -= Option_CheckedChanged;

                rdoNoSize.Checked = true;
                currentMenuInfo.Option_CupSizeUp = false; // 데이터 모델 직접 업데이트

                // 이벤트 핸들러 재구독
                rdoNoSize.CheckedChanged += Option_CheckedChanged;
            }
        }



        /// <summary>
        /// 모든 옵션 컨트롤의 CheckedChanged 이벤트가 이 메서드에 연결됨
        /// - 옵션 변경 시 currentMenuInfo 객체에 값 저장
        /// - 선택안함 체크 시 그룹 내 다른 옵션 비활성화/초기화
        /// - 메뉴담기 버튼 활성화 상태 갱신
        /// </summary>

        private TableLayoutPanel FindParentTableLayoutPanel(Control control)
        {
            Control parent = control.Parent;
            while (parent != null && !(parent is TableLayoutPanel))
            {
                parent = parent.Parent;
            }
            return parent as TableLayoutPanel;
        }

        private void Option_CheckedChanged(object sender, EventArgs e)
        {

            if (sender == rdoNoSize || sender == rdoSizeUp)
            {
                currentMenuInfo.Option_CupSizeUp = rdoSizeUp.Checked;
            }

            if (sender is CheckBox checkBox && checkBox.Text.Contains("선택안함"))
            {
                // 부모 TableLayoutPanel 찾기 (재귀적)
                var parentPanel = FindParentTableLayoutPanel(checkBox);
                if (parentPanel == null) return;

                if (checkBox.Checked)
                {
                    DisableAndUncheckControl(parentPanel, checkBox);
                }
                else
                {
                    EnableControl(parentPanel, checkBox);
                }
            }
            if (sender is CheckBox cb)
            {
                string optionText = cb.Text;
                ProcessOptionPrice(cb.Checked, optionText);
            }
            else if (sender is RadioButton rb)
            {
                string optionText = rb.Text;
                ProcessOptionPrice(rb.Checked, optionText);
            }

            UpdateSelectedOptionsText();
            UpdateOrderButtonState();
        }

        private void ProcessOptionPrice(bool isChecked, string optionText)
        {
            // 수정된 정규식: "+500" 또는 "(+500)" 형식 정확히 추출
            var match = Regex.Match(optionText, @"(?:\+|\()(\d+)(?:\))?");
            if (match.Success && int.TryParse(match.Groups[1].Value, out int optionPrice))
            {
                _tempPrice += isChecked ? optionPrice : -optionPrice;
                _tempPrice = Math.Max(_tempPrice, 0);
                UpdateTempPriceDisplay();
            }
        }



        private void DisableAndUncheckControl(Control parent, Control excludeControl)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl == excludeControl) continue;

                if (ctrl is CheckBox cb)
                {
                    if (cb.Checked)
                    {
                        // 이벤트 핸들러 일시 해제
                        cb.CheckedChanged -= Option_CheckedChanged;
                        ProcessOptionPrice(false, cb.Text);
                        cb.Checked = false;
                        cb.CheckedChanged += Option_CheckedChanged;
                    }
                    cb.Enabled = false;
                }
                else if (ctrl is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        // 이벤트 핸들러 일시 해제
                        rb.CheckedChanged -= Option_CheckedChanged;
                        ProcessOptionPrice(false, rb.Text);
                        rb.Checked = false;
                        rb.CheckedChanged += Option_CheckedChanged;
                    }
                    rb.Enabled = false;
                }

                if (ctrl.HasChildren)
                    DisableAndUncheckControl(ctrl, excludeControl);
            }
        }


        private void EnableControl(Control parent, Control excludeControl)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl == excludeControl) continue;

                ctrl.Enabled = true;

                // 재귀 호출로 모든 하위 컨트롤 처리
                if (ctrl.HasChildren)
                    EnableControl(ctrl, excludeControl);
            }
        }


        ///////////////////////////메뉴 담기 코드/////////////////////////////////////////

        /// <summary>
        /// 모든 필수 옵션이 선택되었는지 확인
        /// 각 그룹별로 반드시 하나 이상 선택되어야 메뉴담기 버튼 활성화
        /// </summary>
        private bool CheckAllOptionsSelected()
        {
            // 무료옵션 체크
            bool isFreeOptionValid = rdoNoFreeOption.Checked ||
                                   (rdoIceMore.Checked || rdoIceLess.Checked ||
                                    rdoLessSweet.Checked || rdoSweet.Checked);

            // 시럽추가 체크
            bool isSyrupValid = rdoNoSyrup.Checked ||
                               (rdoSteviaSyrup.Checked || rdoSyrupVanilla.Checked ||
                                rdoSyrupHazelnut.Checked || rdoSyrupCaramel.Checked);

            // 우유변경 체크
            bool isMilkValid = rdoNoMilk.Checked ||
                              (rdoMilkOat.Checked || rdoMilkAlmond.Checked || rdoMilkSoy.Checked);

            // 샷추가 체크
            bool isShotValid = rdoNoShot.Checked ||
                              (rdoShot.Checked || rdo2Shot.Checked || rdoDecaf2Shot.Checked);

            // 사이즈 체크
            bool isSizeValid = (gbSize.Visible && (rdoNoSize.Checked || rdoSizeUp.Checked))
                       || !gbSize.Visible; // 그룹 숨김 시 자동 유효

            // 부가요소 체크 (선택안함 체크 시 다른 옵션 모두 해제됨)
            bool isAddOnValid = chkNoAddOns.Checked ||
                               (chkPearl.Checked || chkWhippedCream.Checked ||
                                rdoDrizzleChocolate.Checked || rdoDrizzleCaramel.Checked);

            // 모든 그룹이 유효해야 메뉴담기 버튼 활성화
            return isFreeOptionValid && isSyrupValid && isMilkValid &&
                   isShotValid && isSizeValid && isAddOnValid;
        }

        /// <summary>
        /// 옵션 변경 시마다 호출
        /// 메뉴담기 버튼 활성화/비활성화 상태 갱신
        /// </summary>
        private void UpdateOrderButtonState()
        {
            getMenu.Enabled = CheckAllOptionsSelected();
        }

        /// <summary>
        /// 메뉴담기 버튼 클릭 시 호출
        /// - 옵션 패널(tableLayoutPanel1) 숨김
        /// - 실제 주문 처리 로직은 외부에서 currentMenuInfo 객체 사용
        /// </summary>
        private void getMenu_Click(object sender, EventArgs e)
        {
            currentMenuInfo.Price = _basePrice + _tempPrice;
            _tempPrice = 0; // 임시 변수 초기화
            tableLayoutPanel1.Visible = false; // 옵션 패널 숨김
            currentMenuInfo.IsReturn = false;  // 메뉴담기 시에는 false로 명시
            this.Close();
            // 여기에 실제 주문 처리 로직 추가 가능
        }

        /// <summary>
        /// 돌아가기 버튼 클릭 시 호출
        /// - 변경사항 무시하고 currentMenuInfo 객체를 새로 생성(초기화)
        /// - 옵션 컨트롤 상태도 초기화
        /// - 옵션 패널(tableLayoutPanel1) 숨김
        /// </summary>
        private void cancel_Click(object sender, EventArgs e)
        {
            if (currentMenuInfo != null)
            {
                currentMenuInfo.IsReturn = true; // 기존 참조 객체의 IsReturn만 true로!
                                                 // 옵션 컨트롤 초기화 필요하면 직접 컨트롤들만 리셋
                                                 // SetDrinkCategory(currentMenuInfo); // 이 줄은 제거하거나, 컨트롤만 리셋
            }
            tableLayoutPanel1.Visible = false; // 옵션 패널 숨김
            this.Close();
        }


        private void OptionView_Load(object sender, EventArgs e)
        {
            // 초기 "선택안함" 상태 강제 적용
            if (rdoNoFreeOption.Checked) Option_CheckedChanged(rdoNoFreeOption, EventArgs.Empty);
            if (rdoNoSyrup.Checked) Option_CheckedChanged(rdoNoSyrup, EventArgs.Empty);
            if (rdoNoMilk.Checked) Option_CheckedChanged(rdoNoMilk, EventArgs.Empty);
            if (rdoNoShot.Checked) Option_CheckedChanged(rdoNoShot, EventArgs.Empty);
            if (rdoNoSize.Checked) Option_CheckedChanged(rdoNoSize, EventArgs.Empty);
            if (chkNoAddOns.Checked) Option_CheckedChanged(chkNoAddOns, EventArgs.Empty);
        }


        private void OptionView_Shown_1(object sender, EventArgs e)
        {
            rdoNoFreeOption.Checked = false;
            rdoNoSyrup.Checked = false;
            rdoNoMilk.Checked = false;
            rdoNoShot.Checked = false;
            rdoNoSize.Checked = false;
            chkNoAddOns.Checked = false;
            // ... 모든 "선택안함" 라디오버튼에 적용
        }
    }
}