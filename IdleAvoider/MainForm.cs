using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdleTools;
using System.Runtime.InteropServices;

namespace IdleAvoider
{
    public partial class MainForm : Form
    {
        public bool MouseTask { get; set; }
        public bool CalcTask { get; set; }
        public bool NotepadTask { get; set; }
        public List<string> CheckboxesTrue { get; set; }
        

        public MainForm()
        {
            InitializeComponent();
            CheckboxesTrue = new List<string>();
            MouseMoveCheckbox.Checked = Properties.Settings.Default.MouseTask;
            NotepadCheckbox.Checked = Properties.Settings.Default.NotepadTask;
            CalculatorCheckbox.Checked = Properties.Settings.Default.CalcTask;
            TimeTextbox.Text = Properties.Settings.Default.TimeDefault;
            ProgressBar.MarqueeAnimationSpeed = 0;            
        }

        private void MouseMoveCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (MouseMoveCheckbox.Checked)
            {
                MouseTask = true;
                Properties.Settings.Default.MouseTask = true;
                CheckboxesTrue.Add("Mouse");
            }
            else
            {
                MouseTask = false;
                Properties.Settings.Default.MouseTask = false;
                CheckboxesTrue.Remove("Mouse");
            }
        }
        private void NotepadCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (NotepadCheckbox.Checked)
            {
                NotepadTask = true;
                Properties.Settings.Default.NotepadTask = true;
                CheckboxesTrue.Add("Notepad");
            }
            else
            {
                NotepadTask = false;
                Properties.Settings.Default.NotepadTask = false;
                CheckboxesTrue.Remove("Notepad");
            }
        }
        private void CalculatorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (CalculatorCheckbox.Checked)
            {
                CalcTask = true;
                Properties.Settings.Default.CalcTask = true;
                CheckboxesTrue.Add("Calc");
            }
            else
            {
                CalcTask = false;
                Properties.Settings.Default.CalcTask = false;
                CheckboxesTrue.Remove("Calc");
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        private void TimeTextbox_TextChanged(object sender, EventArgs e)
        {
            int ResultTime;
            if (!int.TryParse(TimeTextbox.Text, out ResultTime))
            {
                TimeTextbox.BackColor = Color.LightPink;
                StartButton.Enabled = false;
            }
            else
            {
                TimeTextbox.BackColor = Color.White;
                Properties.Settings.Default.TimeDefault = ResultTime.ToString();
                StartButton.Enabled = true;
            }
        }
        private void BWStart_DoWork(object sender, DoWorkEventArgs e)
        {
            PreventSleepLock.PreventSleep();
            int TimeToWait = int.Parse(TimeTextbox.Text);
            Random RandomTaskNumber = new Random();

            while (BWStart.CancellationPending == false)
            {
                int TaskNumber = RandomTaskNumber.Next(0, CheckboxesTrue.Count);
                switch (CheckboxesTrue[TaskNumber])
                {
                    case "Mouse":
                        IdleTools.MouseMove.Move();
                        break;
                    case "Notepad":
                        IdleTools.EditNotepad.WriteNotepad();
                        break;
                    case "Calc":
                        IdleTools.OpenCalc.RunCalc();
                        break;
                }

                //Iterate seconds for delay to cancel faster
                for (int i = 0; i < TimeToWait; i++)
                {
                    if (BWStart.CancellationPending == false)
                    {
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        break;
                    }                    
                }
            }
        }

        private void StartButton_MouseClick(object sender, MouseEventArgs e)
        {

            if (CheckboxesTrue.Count == 0)
            {
                MessageBox.Show("Select at least 1 option before pressing start.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BWStart.IsBusy)
                {
                    StartButton.Text = "Start";
                    BWStart.CancelAsync();
                    StartButton.Enabled = false;
                    while (BWStart.IsBusy)
                    {
                        Application.DoEvents();
                    }
                    ProgressBar.Style = ProgressBarStyle.Continuous;
                    ProgressBar.MarqueeAnimationSpeed = 0;
                    StartButton.Enabled = true;
                }
                else
                {
                    StartButton.Text = "Stop";
                    ProgressBar.Style = ProgressBarStyle.Marquee;
                    ProgressBar.MarqueeAnimationSpeed = 30;
                    BWStart.RunWorkerAsync();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string url = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=aresiusxp%40gmail%2ecom&lc=AR&item_name=Idle%20Avoider%20Donation&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted";
            System.Diagnostics.Process.Start(url);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=aresiusxp%40gmail%2ecom&lc=AR&item_name=Idle%20Avoider%20Donation&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted";
            System.Diagnostics.Process.Start(url);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Hand;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Cursor = Cursors.Hand;
        }
    }
}
