using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace GeforceNowQueVB
{
    public partial class Form1 : Form
    {
        string appdataLocal = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "Local");
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "Local") + "\\NVIDIA Corporation\\GeForceNOW\\";
        string fileName = "debug.log";
        public Form1()
        {
            InitializeComponent();
        }


        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://n-x.xyz");
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nxPublic/GeforceNowQueueDisplay");
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            updateStats();
        }

        private void updateStats()
        {
            Stream stream = File.Open(path + fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader streamReader = new StreamReader(stream);
            string fileContents = streamReader.ReadToEnd();
            streamReader.Close();
            stream.Close();

            string[] lines = fileContents.Split(new[] { "\r\n", "\r", "\n" },StringSplitOptions.None);
            string lastLine = lines[lines.Length -2];
            labelSize.Text = System.Text.ASCIIEncoding.ASCII.GetByteCount(fileContents) / 1024 + " kb";
            labelLength.Text = lines.Length.ToString()  + " lines";
            string quePosition = lastLine.Split(new[] { "," }, StringSplitOptions.None)[1].Replace(" queue: ", "");
            // format : "[3920-12-10/ 21:31:25.271:INFO:simple_grid_app.cc(830)] onSessionSetupProgress(state: 1, queue: 83, eta: 288590)"
            if (lastLine.Contains("onSessionSetupProgress"))
            {
                label1.Text = quePosition;
            }
        }


        int totalRuntimeInSeconds = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            bgPanel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            updateTimeDisplays();   
        }

        private void updateTimeDisplays()
        {
            toolStripProgressBar1.Maximum = timer1.Interval / 1000;
            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value = 0;
            }
            toolStripProgressBar1.Increment(1);
            totalRuntimeInSeconds += 1;
            labelTimer.Text = "Next update in " + ((timer1.Interval / 1000) - toolStripProgressBar1.Value) + " seconds";
            totalRunTime.Text = "In que since " + totalRuntimeInSeconds / 60 + " minutes";
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButton1.ShowDropDown();
        }

        private void clickToForceUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateStats();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.50;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.TopMost)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }

        private void selectLogFileManuallyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = appdataLocal;
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.CheckFileExists)
            {
                path = openFileDialog1.FileName;
            }
        }

        private void secondsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 30000;
            // Reset internal tick timer
            toolStripProgressBar1.Value = 0;
            updateTimeDisplays();
        }

        private void secondsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            toolStripProgressBar1.Value = 0;
            updateTimeDisplays();
        }

        private void hideProgressbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Visible)
            {
                toolStripProgressBar1.Visible = false;
            }
            else
            {
                toolStripProgressBar1.Visible  = true;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.75;
        }
    }
}
