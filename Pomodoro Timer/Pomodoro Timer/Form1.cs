using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Pomodoro_Timer
{
    public partial class Form1 : Form
    {
        int time, minute, second;
        bool running = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            running = false;
            Console.WriteLine("tedsadas");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            minute = Convert.ToInt32(setTime.Text);
            second = 0;
            if (minute < 10)
            {
                timer.Text = "0" + minute + ":00";
            }
            else
            {
                timer.Text = minute + ":00";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            if (minute > 0)
            {
                if (second < 0)
                {
                    second = 59;
                    minute--;
                }
            }
            if (minute < 10 && second < 10)
            {
                timer.Text = "0" + minute + ":" + "0" + second;
            }
            else if (minute >= 10 && second < 10)
            {
                timer.Text = minute + ":" + "0" + second;
            }
            else if (minute < 10 && second >= 10)
            {
                timer.Text = "0" + minute + ":" + second;
            }
            else
            {
                timer.Text = minute + ":" + second;
            }
            if (minute == 0 && second == 0)
            {
                timer1.Enabled = false;
                //SoundPlayer alarmSound = new SoundPlayer(@"Alarm\Clock\Path");
                //alarmSound.Play();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int newTime = Convert.ToInt32(setTime.Text);
            if (newTime != time)
            {
                running = true;
            }
            if (running)
            {
                time = Convert.ToInt32(setTime.Text);
                minute = time;
                second = 0;
                if (minute < 10)
                {
                    timer.Text = "0" + minute + ":00";
                }
                else
                {
                    timer.Text = minute + ":00";
                }

                timer1.Enabled = true;
            }
            else
            {
                if (minute < 10 && second < 10)
                {
                    timer.Text = "0" + minute + ":" + "0" + second;
                }
                else if (minute >= 10 && second < 10)
                {
                    timer.Text = minute + ":" + "0" + second;
                }
                else if (minute < 10 && second >= 10)
                {
                    timer.Text = "0" + minute + ":" + second;
                }
                else
                {
                    timer.Text = minute + ":" + second;
                }
                timer1.Enabled = true;
                running = true;

            }
        }
    }
}
