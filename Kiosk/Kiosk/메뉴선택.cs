using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class 메뉴선택 : Form
    {
        private 좌석배치도.Seat selectedSeat;
        private List<좌석배치도.Seat> seatList;

        public bool GoHome { get; private set; } = false;

        public 메뉴선택(좌석배치도.Seat seat, List<좌석배치도.Seat> seats)
        {
            InitializeComponent();
            selectedSeat = seat;
            seatList = seats;

            btnHome.Click += btnHome_Click;
            btnOrder.Click += btnOrder_Click;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            GoHome = true;

            if (selectedSeat != null)
            {
                selectedSeat.IsLocked = false;
            }

            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (selectedSeat != null)
            {
                selectedSeat.IsLocked = false;
                selectedSeat.IsOccupied = true;

                TimeSpan usageDuration = TimeSpan.FromSeconds(5); 
                selectedSeat.OccupiedUntil = DateTime.Now.Add(usageDuration);

                string durationText;
                if (usageDuration.TotalHours >= 1)
                    durationText = $"{usageDuration.TotalHours}시간";
                else if (usageDuration.TotalMinutes >= 1)
                    durationText = $"{usageDuration.TotalMinutes}분";
                else
                    durationText = $"{usageDuration.TotalSeconds}초";

                MessageBox.Show($"좌석 {selectedSeat.SeatId} 주문 완료! {durationText} 동안 사용됩니다.");

                GoHome = true;  // 주문 후에도 매장포장으로 돌아가도록 설정
            }

            this.Close();
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {

        }
    }
}
