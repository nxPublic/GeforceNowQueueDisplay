﻿using System;
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
        string splitKey = "⌐";
        string splitKey2 = "|";

        public Form1()
        {
            InitializeComponent();
            updateStats();
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
            loadRecentQueDebugData();

            totalDifferentQueueStagesLabel.Text = totalDifferentQueStages + " total unique queue entries";

            averageQueTimeInMinutesLabel.Text = (averageTimeBetweenQueueChange / 60) + " average minutes per person in queue";
        }

        float averageTimeBetweenQueueChange = 0;
        int actualPosition = 0;
        int totalDifferentQueStages = 0;
        private void loadRecentQueDebugData()
        {
            // read all lines + filter for queue lines only + filter line content
            string[] debugFileContents = readDebugFileLines();

            // Error Handling for not enough entries
            if(debugFileContents.Length < 2)
            {
                return;
            }

            // calculate the average time to change between queue states
            int index = 0;

            // get the actual current position
            actualPosition = Convert.ToInt32(debugFileContents[debugFileContents.Length - 1].Split(new[] { splitKey2 }, StringSplitOptions.None)[3]);

            totalDifferentQueStages = debugFileContents.Length;

            List<int> timeDifferences = new List<int>();
            int total = 0;
            int count = 0;
            bool isFirst = true;
            
            int currentPosition = 0;
            int currentPositionTimestamp = 0;

            while (index < debugFileContents.Length)
            {
                // format : "1607622916|20-12-10|18:55:16|255"
                // I could have used dictonaries but thats quite ressource heavy in this scale of loops.
                // I dislike arrays with indexies becouse you usually forget the specifics without documentation.

                string[] lineContent = debugFileContents[index].Split(new[] { splitKey2 }, StringSplitOptions.None);
                int newPosition = Convert.ToInt32(lineContent[3]);
                int newPositionTimestamp = Convert.ToInt32(lineContent[0]);

                // set the first entry as default
                if (isFirst)
                {
                    currentPosition = newPosition;
                    currentPositionTimestamp = newPositionTimestamp;
                    isFirst = false;
                }

                // check if current position is different from next lines position
                if (currentPosition != newPosition)
                {
                    total = total + (newPositionTimestamp - currentPositionTimestamp);
                    timeDifferences.Add(newPositionTimestamp - currentPositionTimestamp);
                    currentPosition = newPosition;
                    currentPositionTimestamp = newPositionTimestamp;
                    count += 1;
                }
                index += 1;
            }

            // error handling for not enough different que states
            if(count == 0)
            {
                return;
            }
            averageTimeBetweenQueueChange = total / count;
            averageQueueTime.Text = Convert.ToString((Math.Round((averageTimeBetweenQueueChange / 60) * actualPosition)) + " minutes");
            currentPositionLabel.Text = actualPosition.ToString();


            // TODO: There is a wierd index inconsistency in terms of size, i will investigate by time. Potentially it was due to being a global variable.
        }

        string[] readDebugFileLines()
        {
            // Only stream readers allow to read files opened by other processes
            Stream stream = File.Open(path + fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader streamReader = new StreamReader(stream);
            string fileContents = streamReader.ReadToEnd();
            streamReader.Close();
            stream.Close();

            // split all lines
            string[] lines = fileContents.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            // remove redundant lines
            int index = 0;
            string returnContent = "";
            while (index < lines.Length)
            {
                if (lines[index].Contains("onSessionSetupProgress"))
                {
                    returnContent += splitLineData(lines[index]); 
                    returnContent += splitKey;
                }
                index += 1;
            }
            // format : "[3920-12-10/ 21:31:25.271:INFO:simple_grid_app.cc(830)] onSessionSetupProgress(state: 1, queue: 83, eta: 288590)"

            return returnContent.Split(new[] { splitKey }, StringSplitOptions.RemoveEmptyEntries);
        }

        string splitLineData(string content) // returns: log date|log time|position
        {
            // [3920-12-10/ 21:31:25.271:INFO:simple_grid_app.cc(830)]
            string[] half = content.Split(new[] { "]" }, StringSplitOptions.RemoveEmptyEntries);

            string logDate = half[0].Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries)[0].Replace("[39", "").Trim();
            string logTime = half[0].Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();

            // onSessionSetupProgress(state: 1, queue: 83, eta: 288590)
            string position = half[1].Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)[1].Replace(" queue: ", "").Trim();

            return convertStringToTimestamp(logDate, logTime) + splitKey2 + logDate + splitKey2 + logTime + splitKey2 + position;
        }

        int convertStringToTimestamp(string date, string time)
        {
            // 20-12-10 21:31:25
            DateTime data = DateTime.ParseExact(date + " " + time, "yy-MM-dd HH:mm:ss", null);
            int timestamp = (Int32)(data.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            return timestamp;
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
            totalRunTime.Text = "In queue since " + totalRuntimeInSeconds / 60 + " minutes";
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
