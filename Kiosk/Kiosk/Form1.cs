using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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

        private MenuInformation currentMenuInfo; //현재 메뉴
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 예를 들어 기본 메뉴 선택
            // SelectMenu("골드키위주스(ICE)");
        }

        // 메뉴 선택 시 호출 (예: 메뉴 버튼 클릭 이벤트에서 사용) //유완 코드에서 필요
        private void SelectMenu(string menuName)
        {
            // MenuInformation 객체 생성 (분류 자동 세팅)
            currentMenuInfo = new MenuInformation(menuName);

            // 분류 기반으로 옵션 표시/숨김 등 처리
            SetDrinkCategory(currentMenuInfo);

            // 기타 옵션 초기화, 이미지 로딩 등 추가 가능
        }

        // 무료옵션 "선택안함" 체크 시 다른 옵션 비활성화
        private void rdoNoFreeOption_CheckedChanged(object sender, EventArgs e)
        {
            if (currentMenuInfo == null) return;

            bool enabled = !rdoNoFreeOption.Checked;
            rdoIceMore.Enabled = enabled;
            rdoIceLess.Enabled = enabled;
            rdoLessSweet.Enabled = enabled && ShouldShowLessSweet(currentMenuInfo);
            rdoSweet.Enabled = enabled;
        }


        // 덜달게 옵션 표시 조건 (분류 기반)
        private bool ShouldShowLessSweet(MenuInformation menuInfo)
        {
            string[] exclude = { "커피(아이스)", "커피(핫)", "디카페인", "에스프레소" };
            return !exclude.Contains(menuInfo.MenuHead);
        }

        // 메뉴 선택 또는 분류 변경 시 호출
        public void SetDrinkCategory(MenuInformation menuInfo)
        {
            currentMenuInfo = menuInfo;
            rdoLessSweet.Visible = ShouldShowLessSweet(menuInfo);
        }

        /*아래는 선택안함 버튼 작동방식*/
        private void rdoIceMore_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoIceMore.Checked) rdoIceLess.Checked = false;
        }

        private void rdoIceLess_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoIceLess.Checked) rdoIceMore.Checked = false;
        }

        private void rdoLessSweet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLessSweet.Checked) rdoSweet.Checked = false;
        }

        private void rdoSweet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSweet.Checked) rdoLessSweet.Checked = false;
        }

        private void rdoNoSyrup_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = !rdoNoSyrup.Checked;
            rdoSteviaSyrup.Enabled = enabled;
            rdoSyrupVanilla.Enabled = enabled;
            rdoSyrupHazelnut.Enabled = enabled;
            rdoSyrupCaramel.Enabled = enabled;
        }

        private void rdoNoMilk_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = !rdoNoMilk.Checked;
            rdoMilkOat.Enabled = enabled;
            rdoMilkAlmond.Enabled = enabled;
            rdoMilkSoy.Enabled = enabled;
        }

        private void rdoNoShot_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = !rdoNoShot.Checked;
            rdoShot.Enabled = enabled;
            rdo2Shot.Enabled = enabled;
            rdoDecaf2Shot.Enabled = enabled;
        }

        private void rdoNoSize_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = !rdoNoSize.Checked;
            rdoSizeUp.Enabled = enabled;
        }

        private void chkNoAddOns_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = !chkNoAddOns.Checked;
            chkPearl.Enabled = enabled;
            chkWhippedCream.Enabled = enabled;
            gbDrizzleOptions.Enabled = enabled; // 드리즐 그룹 전체 활성/비활성

            if (!enabled)
            {
                chkPearl.Checked = false;
                chkWhippedCream.Checked = false;
                // 드리즐 그룹 내 라디오버튼 모두 해제
                foreach (Control ctrl in gbDrizzleOptions.Controls)
                {
                    if (ctrl is RadioButton rb) rb.Checked = false;
                }
            }
        }

        private void chkPearl_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPearl.Checked) chkNoAddOns.Checked = false;
        }

        private void chkWhippedCream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhippedCream.Checked) chkNoAddOns.Checked = false;
        }

        private void rdoDrizzleChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDrizzleChocolate.Checked) chkNoAddOns.Checked = false;
        }

        private void rdoDrizzleCaramel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDrizzleCaramel.Checked) chkNoAddOns.Checked = false;
        }



    }
}
