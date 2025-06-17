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

        private List<Seat> seatList;

        static Seat lastSeat = null;

        public 좌석배치도(List<Seat> seats, int t)
        {
            InitializeComponent();
            seatList = seats;

            if (lastSeat != null)
            {
                string seatId = lastSeat.SeatId;
                Seat seat = seatList.FirstOrDefault(s => s.SeatId == seatId);

                seat.IsLocked = false;
                seat.IsOccupied = true;

                TimeSpan usageDuration = TimeSpan.FromSeconds(15 - t);
                seat.OccupiedUntil = DateTime.Now.Add(usageDuration);

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
