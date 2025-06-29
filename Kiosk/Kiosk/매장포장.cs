﻿using System;
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
        }

        public 매장포장(bool selected)
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
            isSelected = selected;
            if (isSelected) spentTime = 987654321;
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            this.Hide();
            좌석배치도 seatForm = new 좌석배치도(spentTime);
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
