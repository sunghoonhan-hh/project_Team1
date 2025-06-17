using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class 매장포장 : Form
    {
        private List<좌석배치도.Seat> seatList;

        bool isSelected = false;
        int spentTime = 0;

        public 매장포장()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();

            string[] seatIds = { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };
            seatList = new List<좌석배치도.Seat>();

            foreach (var id in seatIds)
            {
                seatList.Add(new 좌석배치도.Seat
                {
                    SeatId = id,
                    IsOccupied = false,
                    IsLocked = false,
                    OccupiedUntil = null
                });
            }
        }

        public 매장포장(bool selected)
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
            isSelected = selected;
            if (isSelected) spentTime = 987654321;

            string[] seatIds = { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };
            seatList = new List<좌석배치도.Seat>();

            foreach (var id in seatIds)
            {
                seatList.Add(new 좌석배치도.Seat
                {
                    SeatId = id,
                    IsOccupied = false,
                    IsLocked = false,
                    OccupiedUntil = null
                });
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            this.Hide();
            좌석배치도 seatForm = new 좌석배치도(seatList, spentTime);
            seatForm.FormClosed += (s, args) => this.Show();
            seatForm.Show();
        }

        private void btnTakeout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectCoffee menuForm = new SelectCoffee(); /*(null, seatList);*/
            menuForm.FormClosed += (s, args) => this.Show();
            menuForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            spentTime += 1;
        }
    }
}
