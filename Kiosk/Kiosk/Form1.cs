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
    public partial class Form1 : Form
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
    { "콜드브루디카페인", "커피(아이스)" },
    { "콜드브루디카페인라떼", "커피(아이스)" },
    { "할메가미숫커피", "커피(아이스)" },
    { "할메가커피", "커피(아이스)" },
    { "헛개리카노", "커피(아이스)" },

    // 3. 커피(핫)
    { "콜드브루디카페인", "커피(핫)" },
    { "콜드브루디카페인라떼", "커피(핫)" },
    { "헛개리카노", "커피(핫)" },

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

        public Form1()
        {
            InitializeComponent();
            UpdateOrderButtonState(); // 폼 로드시 메뉴담기 버튼 상태 초기화
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
            SetDrinkCategory(currentMenuInfo);

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
            gbIceOptions.Visible = !hideIceAndSize;  // 얼음 옵션 그룹
            gbSize.Visible = !hideIceAndSize;        // 사이즈 업그레이드 그룹
        }

        /// <summary>
        /// 모든 옵션 컨트롤의 CheckedChanged 이벤트가 이 메서드에 연결됨
        /// - 옵션 변경 시 currentMenuInfo 객체에 값 저장
        /// - 선택안함 체크 시 그룹 내 다른 옵션 비활성화/초기화
        /// - 메뉴담기 버튼 활성화 상태 갱신
        /// </summary>
        private void Option_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderButtonState(); // 메뉴담기 버튼 활성화 상태 갱신

            if (sender is RadioButton rb)
            {
                switch (rb.Name)
                {
                    // 무료옵션 - 선택안함
                    case "rdoNoFreeOption":
                        bool enabled = !rdoNoFreeOption.Checked;
                        rdoIceMore.Enabled = enabled;
                        rdoIceLess.Enabled = enabled;
                        rdoLessSweet.Enabled = enabled && ShouldShowLessSweet(currentMenuInfo);
                        rdoSweet.Enabled = enabled;

                        if (rdoNoFreeOption.Checked)
                        {
                            // 다른 옵션 해제 및 객체 값 초기화
                            rdoIceMore.Checked = false;
                            rdoIceLess.Checked = false;
                            rdoLessSweet.Checked = false;
                            rdoSweet.Checked = false;
                            currentMenuInfo.Option_IceMore = false;
                            currentMenuInfo.Option_IceLess = false;
                            currentMenuInfo.Option_LessSweet = false;
                            currentMenuInfo.Option_Sweet = false;
                        }
                        break;

                    // 무료옵션 - 얼음/당도
                    case "rdoIceMore":
                        currentMenuInfo.Option_IceMore = rb.Checked;
                        rdoIceLess.Enabled = !rb.Checked;
                        break;

                    case "rdoIceLess":
                        currentMenuInfo.Option_IceLess = rb.Checked;
                        rdoIceMore.Enabled = !rb.Checked;
                        break;

                    // 당도 옵션 상호배타적 비활성화
                    case "rdoLessSweet":
                        currentMenuInfo.Option_LessSweet = rb.Checked;
                        rdoSweet.Enabled = !rb.Checked;
                        break;

                    case "rdoSweet":
                        currentMenuInfo.Option_Sweet = rb.Checked;
                        rdoLessSweet.Enabled = !rb.Checked;
                        break;

                    // 시럽추가 - 선택안함
                    case "rdoNoSyrup":
                        bool syrupEnabled = !rdoNoSyrup.Checked;
                        rdoSteviaSyrup.Enabled = syrupEnabled;
                        rdoSyrupVanilla.Enabled = syrupEnabled;
                        rdoSyrupHazelnut.Enabled = syrupEnabled;
                        rdoSyrupCaramel.Enabled = syrupEnabled;

                        if (rdoNoSyrup.Checked)
                        {
                            currentMenuInfo.Option_SteviaSugar = false;
                            currentMenuInfo.Option_Syrup_Vanilla = false;
                            currentMenuInfo.Option_Syrup_Hazelnut = false;
                            currentMenuInfo.Option_Syrup_Caramel = false;
                        }
                        break;
                    case "rdoSteviaSyrup":
                        currentMenuInfo.Option_SteviaSugar = rb.Checked;
                        break;
                    case "rdoSyrupVanilla":
                        currentMenuInfo.Option_Syrup_Vanilla = rb.Checked;
                        break;
                    case "rdoSyrupHazelnut":
                        currentMenuInfo.Option_Syrup_Hazelnut = rb.Checked;
                        break;
                    case "rdoSyrupCaramel":
                        currentMenuInfo.Option_Syrup_Caramel = rb.Checked;
                        break;

                    // 우유변경 - 선택안함
                    case "rdoNoMilk":
                        bool milkEnabled = !rdoNoMilk.Checked;
                        rdoMilkOat.Enabled = milkEnabled;
                        rdoMilkAlmond.Enabled = milkEnabled;
                        rdoMilkSoy.Enabled = milkEnabled;

                        if (rdoNoMilk.Checked)
                        {
                            currentMenuInfo.Option_Milk_Oat = false;
                            currentMenuInfo.Option_Milk_Almond = false;
                            currentMenuInfo.Option_Milk_Soy = false;
                        }
                        break;
                    case "rdoMilkOat":
                        currentMenuInfo.Option_Milk_Oat = rb.Checked;
                        break;
                    case "rdoMilkAlmond":
                        currentMenuInfo.Option_Milk_Almond = rb.Checked;
                        break;
                    case "rdoMilkSoy":
                        currentMenuInfo.Option_Milk_Soy = rb.Checked;
                        break;

                    // 샷추가 - 선택안함
                    case "rdoNoShot":
                        bool shotEnabled = !rdoNoShot.Checked;
                        rdoShot.Enabled = shotEnabled;
                        rdo2Shot.Enabled = shotEnabled;
                        rdoDecaf2Shot.Enabled = shotEnabled;

                        if (rdoNoShot.Checked)
                        {
                            currentMenuInfo.Option_Shot = false;
                            currentMenuInfo.Option_2Shot = false;
                            currentMenuInfo.Option_Decaf2Shot = 0;
                        }
                        break;
                    case "rdoShot":
                        currentMenuInfo.Option_Shot = rb.Checked;
                        break;
                    case "rdo2Shot":
                        currentMenuInfo.Option_2Shot = rb.Checked;
                        break;
                    case "rdoDecaf2Shot":
                        currentMenuInfo.Option_Decaf2Shot = rb.Checked ? 1 : 0;
                        break;

                    // 사이즈 - 선택안함
                    case "rdoNoSize":
                        bool sizeEnabled = !rdoNoSize.Checked;
                        rdoSizeUp.Enabled = sizeEnabled;
                        if (rdoNoSize.Checked)
                            currentMenuInfo.Option_CupSizeUp = false;
                        break;
                    case "rdoSizeUp":
                        currentMenuInfo.Option_CupSizeUp = rb.Checked;
                        break;

                    // 부가요소 - 드리즐(라디오)
                    case "rdoDrizzleChocolate":
                        if (rdoDrizzleChocolate.Checked) chkNoAddOns.Checked = false;
                        currentMenuInfo.Option_Drizzle_Chocolate = rb.Checked;
                        break;
                    case "rdoDrizzleCaramel":
                        if (rdoDrizzleCaramel.Checked) chkNoAddOns.Checked = false;
                        currentMenuInfo.Option_Drizzle_Caramel = rb.Checked;
                        break;
                }
            }
            else if (sender is CheckBox cb)
            {
                switch (cb.Name)
                {
                    // 부가요소 - 선택안함
                    case "chkNoAddOns":
                        bool addOnEnabled = !chkNoAddOns.Checked;
                        chkPearl.Enabled = addOnEnabled;
                        chkWhippedCream.Enabled = addOnEnabled;
                        gbDrizzleOptions.Enabled = addOnEnabled;

                        if (!addOnEnabled)
                        {
                            chkPearl.Checked = false;
                            chkWhippedCream.Checked = false;
                            foreach (Control ctrl in gbDrizzleOptions.Controls)
                            {
                                if (ctrl is RadioButton drizzleRb)
                                    drizzleRb.Checked = false;
                            }
                            currentMenuInfo.Option_Pearl = false;
                            currentMenuInfo.Option_WhippedCream = false;
                            currentMenuInfo.Option_Drizzle_Chocolate = false;
                            currentMenuInfo.Option_Drizzle_Caramel = false;
                        }
                        break;

                    // 부가요소 - 펄
                    case "chkPearl":
                        if (chkPearl.Checked) chkNoAddOns.Checked = false;
                        currentMenuInfo.Option_Pearl = chkPearl.Checked;
                        break;

                    // 부가요소 - 휘핑크림
                    case "chkWhippedCream":
                        if (chkWhippedCream.Checked) chkNoAddOns.Checked = false;
                        currentMenuInfo.Option_WhippedCream = chkWhippedCream.Checked;
                        break;
                }
            }

            if (!rdoIceMore.Checked && !rdoIceLess.Checked)
            {
                rdoIceMore.Enabled = true;
                rdoIceLess.Enabled = true;
            }
            // 당도 옵션 둘 다 해제 시 다시 활성화
            if (!rdoLessSweet.Checked && !rdoSweet.Checked)
            {
                rdoLessSweet.Enabled = true;
                rdoSweet.Enabled = true;
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
            bool isSizeValid = rdoNoSize.Checked || rdoSizeUp.Checked;

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
            tableLayoutPanel1.Visible = false; // 옵션 패널 숨김
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
                // 현재 메뉴명으로 새 객체 생성(옵션 초기화)
                currentMenuInfo = new MenuInformation(currentMenuInfo.MenuName);
                SetDrinkCategory(currentMenuInfo); // UI 동기화
            }
            tableLayoutPanel1.Visible = false; // 옵션 패널 숨김
        }
    }
}