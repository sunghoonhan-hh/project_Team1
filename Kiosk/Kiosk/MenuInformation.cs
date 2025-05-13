using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public class MenuInformation
    {

        private static readonly Dictionary<string, string> MenuCategoryMap = new Dictionary<string, string>()
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
            { "제로복숭아아이스티(ICE)", "티" }
        };
        public string MenuHead { get; private set; }
        public string MenuName { get; set; }
        public int Count { get; set; }

        // 1. 얼음 옵션
        public bool Option_IceMore { get; set; }      // 얼음 많이
        public bool Option_IceLess { get; set; }      // 얼음 적게

        // 2. 당도 옵션
        public bool Option_LessSweet { get; set; }    // 덜달게
        public bool Option_Sweet { get; set; }        // 달게

        // 3. 꿀 추가
        public bool Option_SteviaSugar { get; set; }

        // 4. 컵 사이즈 업그레이드
        public bool Option_CupSizeUp { get; set; }

        // 5. 펄 추가
        public bool Option_Pearl { get; set; }

        // 6. 샷 추가
        public bool Option_Shot { get; set; }
        public bool Option_2Shot { get; set; }


        // 7. 시럽 추가 (종류별)
        public bool Option_Syrup_Vanilla { get; set; }
        public bool Option_Syrup_Hazelnut { get; set; }
        public bool Option_Syrup_Caramel { get; set; }

        // 8. 우유 변경 (종류별)
        public bool Option_Milk_Oat { get; set; }
        public bool Option_Milk_Almond { get; set; }
        public bool Option_Milk_Soy { get; set; }

        // 9. 휘핑크림 추가
        public bool Option_WhippedCream { get; set; }

        // 10. 드리즐 추가 (종류별)
        public bool Option_Drizzle_Chocolate { get; set; }
        public bool Option_Drizzle_Caramel { get; set; }

        // 11. 디카페인 샷 추가
        public int Option_Decaf2Shot { get; set; }

        // 생성자
        public MenuInformation(string name)
        {
            try
            {
                MenuName = name;
                Count = 1;

                if (MenuCategoryMap.TryGetValue(name, out string category))
                    MenuHead = category;
                else
                    MenuHead = "기타"; // 없는 메뉴는 "기타"로 분류

                // 옵션 초기화
                Option_IceMore = false;
                Option_IceLess = false;
                Option_LessSweet = false;
                Option_Sweet = false;
                Option_SteviaSugar = false;
                Option_CupSizeUp = false;
                Option_Pearl = false;
                Option_Shot = false;
                Option_2Shot = false;
                Option_Syrup_Vanilla = false;
                Option_Syrup_Hazelnut = false;
                Option_Syrup_Caramel = false;
                Option_Milk_Oat = false;
                Option_Milk_Almond = false;
                Option_Milk_Soy = false;
                Option_WhippedCream = false;
                Option_Drizzle_Chocolate = false;
                Option_Drizzle_Caramel = false;
                Option_Decaf2Shot = 0;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
                // 또는 로그 저장 등
            }

        }
    }
}
