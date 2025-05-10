using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    public class MenuInformation
    {
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
        public int Option_DecafShot { get; set; }

        // 생성자
        public MenuInformation(string name)
        {
            MenuName = name;
            Count = 1;

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
            Option_DecafShot = 0;
        }
    }
}
