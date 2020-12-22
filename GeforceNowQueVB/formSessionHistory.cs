using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace GeforceNowQueDisplay
{
    public partial class formSessionHistory : Form
    {
        string appdataLocal = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "Local");
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "Local") + "\\NVIDIA Corporation\\GeForceNOW\\";
        string fileName = "debug.log";
        string splitKey = "⌐";
        string splitKey2 = "|";
        public formSessionHistory()
        {
            InitializeComponent();
        }

        private void formSessionHistory_Load(object sender, EventArgs e)
        {
            loadRecentQueDebugData();
        }

        float averageTimeBetweenQueueChange = 0;
        int actualPosition = 0;
        int totalDifferentQueStages = 0;

        // index,contentSplitBySplitKey1
        private void loadRecentQueDebugData()
        {
            // read all lines + filter for queue lines only + filter line content
            string[] debugFileContents = readDebugFileLines();

            // Error Handling for not enough entries
            if (debugFileContents.Length < 2)
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

            int lastPosititonTimestamp = 0;

            int startPositionInQueue = 0;
            int sessionIndex = 1;

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
                    lastPosititonTimestamp = currentPositionTimestamp;
                    currentPositionTimestamp = newPositionTimestamp;


                    // check the length of time difference between
                    // consider each new entry with a difference greater than 3 minutes without change as new queue.
                    // add the latest session based on loop index
                    bool isNewSession = false;
                    if ((currentPositionTimestamp - lastPosititonTimestamp) > 180 || debugFileContents.Length -1 == index)
                    {
                        isNewSession = true;
                        // load start date
                        // load start time
                        // load position start

                        // add to list
                        sessionHistory.Items.Add(sessionIndex + ".");
                        sessionIndex++;
                        isNewSession = true;
                    }

                    count += 1;
                }


                index += 1;
            }

            // error handling for not enough different que states
            if (count == 0)
            {
                return;
            }
            averageTimeBetweenQueueChange = total / count;
            
        }


        public string[] readDebugFileLines()
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

        public string splitLineData(string content) // returns: log date|log time|position
        {
            // [3920-12-10/ 21:31:25.271:INFO:simple_grid_app.cc(830)]
            string[] half = content.Split(new[] { "]" }, StringSplitOptions.RemoveEmptyEntries);

            string logDate = half[0].Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries)[0].Replace("[39", "").Trim();
            string logTime = half[0].Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();

            // onSessionSetupProgress(state: 1, queue: 83, eta: 288590)
            string position = half[1].Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)[1].Replace(" queue: ", "").Trim();

            return convertStringToTimestamp(logDate, logTime) + splitKey2 + logDate + splitKey2 + logTime + splitKey2 + position;
        }

        public int convertStringToTimestamp(string date, string time)
        {
            // 20-12-10 21:31:25
            DateTime data = DateTime.ParseExact(date + " " + time, "yy-MM-dd HH:mm:ss", null);
            int timestamp = (Int32)(data.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            return timestamp;
        }


    }
}
