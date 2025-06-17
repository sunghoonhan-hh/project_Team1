using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class 좌석배치도 : Form
    {
        public class Seat
        {
            public string SeatId { get; set; }
            public bool IsOccupied { get; set; }
            public bool IsLocked { get; set; }
            public DateTime? OccupiedUntil { get; set; }
        }

        static private List<Seat> seatList = null;

        static Seat lastSeat = null;

        public 좌석배치도(int t)
        {
            InitializeComponent();

            if (seatList == null)
            {
                string[] seatIds = { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };
                seatList = new List<Seat>();

                foreach (var id in seatIds)
                {
                    seatList.Add(new Seat
                    {
                        SeatId = id,
                        IsOccupied = false,
                        IsLocked = false,
                        OccupiedUntil = null
                    });
                }
            }


            if (lastSeat != null)
            {
                string seatId = lastSeat.SeatId;
                Seat seat = seatList.FirstOrDefault(s => s.SeatId == seatId);


                seat.IsLocked = false;
                seat.IsOccupied = true;

                TimeSpan usageDuration = TimeSpan.FromSeconds(30 - t);
                seat.OccupiedUntil = DateTime.Now.Add(usageDuration);

                lastSeat.IsLocked = false;
                lastSeat.IsOccupied = true;

                seatList.Remove(seat);
                seatList.Add(lastSeat);
            }
            ConnectSeatButtons(this);
            UpdateSeatButtons();

        }

        public 좌석배치도(List<Seat> seats, int t)
        {
            InitializeComponent();
            seatList = seats;

            if(seatList == null)
            {
                string[] seatIds = { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };
                seatList = new List<Seat>();

                foreach (var id in seatIds)
                {
                    seatList.Add(new Seat
                    {
                        SeatId = id,
                        IsOccupied = false,
                        IsLocked = false,
                        OccupiedUntil = null
                    });
                }
            }
            

            if (lastSeat != null)
            {
                string seatId = lastSeat.SeatId;
                Seat seat = seatList.FirstOrDefault(s => s.SeatId == seatId);
                
                
                seat.IsLocked = false;
                seat.IsOccupied = true;

                TimeSpan usageDuration = TimeSpan.FromSeconds(30 - t);
                seat.OccupiedUntil = DateTime.Now.Add(usageDuration);

                lastSeat.IsLocked = false;
                lastSeat.IsOccupied = true;

                seatList.Remove(seat);
                seatList.Add(lastSeat);
            }
            ConnectSeatButtons(this);
            UpdateSeatButtons();

        }

        private void ConnectSeatButtons(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button && c.Tag != null)
                {
                    c.Click += SeatButton_Click;
                }
                else if (c.HasChildren)
                {
                    ConnectSeatButtons(c);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var seat in seatList)
            {
                if (seat.IsOccupied && seat.OccupiedUntil.HasValue && DateTime.Now >= seat.OccupiedUntil.Value)
                {
                    seat.IsOccupied = false;
                    seat.OccupiedUntil = null;
                }
            }

            UpdateSeatButtons();
        }

        private void UpdateSeatButtons()
        {
            UpdateSeatButtonsRecursive(this);
        }

        private void UpdateSeatButtonsRecursive(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn && btn.Tag != null)
                {
                    string seatId = btn.Tag.ToString();
                    Seat seat = seatList.FirstOrDefault(s => s.SeatId == seatId);

                    if (seat != null)
                    {
                        if (seat.IsOccupied)
                        {
                            btn.Enabled = true;
                            btn.BackColor = Color.DarkGray;
                        }
                        else if (seat.IsLocked)
                        {
                            btn.Enabled = false;
                            btn.BackColor = Color.Orange;
                        }
                        else
                        {
                            btn.Enabled = true;
                            btn.BackColor = Color.LightGreen;
                        }
                    }
                }
                else if (c.HasChildren)
                {
                    UpdateSeatButtonsRecursive(c);
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                string seatId = clickedButton.Tag.ToString();
                Seat seat = seatList.FirstOrDefault(s => s.SeatId == seatId);

                if (seat != null && !seat.IsOccupied && !seat.IsLocked)
                {
                    seat.IsLocked = true;
                    this.Hide();
                    SelectCoffee menuForm = new SelectCoffee();  //(seat, seatList);

                    lastSeat = seat;


                    menuForm.FormClosed += (s, args) =>
                    {
                        seat.IsLocked = false;

                        this.Hide();
                    };
                    menuForm.Show();
                }
                else if(seat != null && seat.IsOccupied && !seat.IsLocked)
                {
                    DialogResult result = MessageBox.Show("이미 사용 중인 좌석입니다.\n추가 주문을 하시겠습니까?", "추가 주문", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        seat.IsLocked = true;
                        this.Hide();
                        SelectCoffee menuForm = new SelectCoffee();  // (seat, seatList);

                        lastSeat = seat;

                        menuForm.FormClosed += (s, args) =>
                        {
                            seat.IsLocked = false;
                            this.Hide();  // 또는 this.Show(); 등
                        };

                        menuForm.Show();
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            매장포장 newForm = new 매장포장(true);
            newForm.Show();
            this.Hide();
        }
    }
}
