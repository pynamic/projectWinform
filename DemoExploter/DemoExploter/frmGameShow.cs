﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExploter
{
    public partial class frmGameShow : Form
    {
        public frmGameShow()
        {
            InitializeComponent();
        }
        Timer gameTimer = new Timer();       
        private void frmGameShow_Load(object sender, EventArgs e)
        {
            timer1.Start();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            List<GameShow> lst = new List<GameShow>();
            lst.Add(
               new GameShow()
               {
                   Id = 1,
                   Name = "Nhanh như chớp 1",
                   StartDate = DateTime.Now.AddSeconds(2),//2s
                   EndDate = DateTime.Now.AddMinutes(30)
               });

            lst.Add(
               new GameShow()
               {
                   Id = 2,
                   Name = "Nhanh như chớp 2",
                   StartDate = DateTime.Now.AddDays(1),
                   EndDate = DateTime.Now.AddDays(1).AddMinutes(30)
               });

            lst.Add(
               new GameShow()
               {
                   Id = 3,
                   Name = "Nhanh như chớp 3",
                   StartDate = DateTime.Now.AddDays(2),
                   EndDate = DateTime.Now.AddDays(2).AddMinutes(30)
               });

            lst.Add(
               new GameShow()
               {
                   Id = 4,
                   Name = "Nhanh như chớp 4",
                   StartDate = DateTime.Now.AddDays(3),
                   EndDate = DateTime.Now.AddDays(3).AddMinutes(30)
               });

            grvGameShow.DataSource = lst;

            var nearestGameShow = lst[0];
            lblName.Text = nearestGameShow.Name;
            lblTime.Text = nearestGameShow.StartDate.ToString("dd/MM/yyyy hh:mm:ss");

            OrigTime = (int)Math.Round((nearestGameShow.StartDate - DateTime.Now).TotalSeconds, 0);

            gameTimer.Enabled = true;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeX_Tick(sender, e);
        }

        int OrigTime = 500;
        void timeX_Tick(object sender, EventArgs e)
        {
            OrigTime--;
            txtCountDown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            if(OrigTime<=0)
            {
                gameTimer.Enabled = false;
                btnStart.Enabled = true;
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();

            this.WindowState = FormWindowState.Minimized;
        }

      
    }
}
