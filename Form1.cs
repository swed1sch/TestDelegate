﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test4
{
    public partial class Form1 : Form
    {
                
        public Form1()
        {
            timer1 = new Timer();
            TimerEnabled();
            
            InitializeComponent();
        }

        private void bt1_MouseClick(object sender, MouseEventArgs e)
        {   
            
            if (timer1.Enabled == false)
            {
                bt1.Click += Bt1_Start;
            }
            else
            {
                bt1.Click += Bt1_Stop;
            }
        }

        private void Bt1_Stop(object sender, EventArgs e)
        {                        
            timer1.Enabled = false;
            timer1.Stop();
            tb1.Text = " ";
        }
        private void TimerEnabled()
        {
            timer1.Enabled = true;
            timer1.Start();
            
        }
        private void Bt1_Start(object sender, EventArgs e)
        {
                                  
            timer1.Enabled = true;
            timer1.Start();
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            tb1.Text = string.Format("Текущее время:{0}", DateTime.Now.ToString("HH:mm:ss"));
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tb2.Text = string.Format("Текущее время:{0}", DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
