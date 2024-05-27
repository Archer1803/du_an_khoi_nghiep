using System;
using System.Windows.Forms;

namespace du_an_khoi_nghiep
{
    public partial class Form4 : Form
    {
        private int hours = 0, minutes = 0, seconds = 0, countdownSeconds = 0; int totalSeconds; int remainingSeconds;
        private bool isTimerRunning = false;
        private bool isCountdownRunning = false;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            UpdateTimerText();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isTimerRunning)
            {
                seconds++;
                if (seconds >= 60)
                {
                    seconds = 0;
                    minutes++;
                    if (minutes >= 60)
                    {
                        minutes = 0;
                        hours++;
                    }
                }
                UpdateTimerText();
            }
            else if (isCountdownRunning)
            {
                if (countdownSeconds > 0)
                {
                    countdownSeconds--;
                    UpdateTimerText();
                }
                else
                {
                    timer1.Stop();
                    isCountdownRunning = false;
                    MessageBox.Show("dã phát lại toàn bộ bản ghi");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            isTimerRunning = true;
            isCountdownRunning = false;
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            isTimerRunning = false;
            isCountdownRunning = false;
            UpdateTimerText();
            timer1.Stop();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StartCountdown();

        }

        private void UpdateTimerText()
        {
            if (isCountdownRunning)
            {
                remainingSeconds = countdownSeconds;
                label1.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", remainingSeconds / 3600, (remainingSeconds % 3600) / 60, remainingSeconds % 60);

            }
            else
            {
                label1.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
            }
        }

        private void ResetTimer()
        {
            isTimerRunning = false;
            isCountdownRunning = false;
            hours = 0;
            minutes = 0;
            seconds = 0;
            countdownSeconds = 0;
            UpdateTimerText();
            timer1.Stop();
        }

        private void StartCountdown()
        {
            isTimerRunning = false;
            isCountdownRunning = true;
            countdownSeconds = hours * 3600 + minutes * 60 + seconds;
            timer1.Start();
            timer1.Interval = 1000; // 1 giây
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}