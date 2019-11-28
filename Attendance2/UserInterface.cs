// Author: Nate Harrell (Chintan Patel helped a bit too :-) )
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Attendance
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime date = new DateTime(); // final date


        Dictionary<string, bool> allNames = new Dictionary<string, bool>();
        Dictionary<int, KeyValuePair<string, bool>> dict = new Dictionary<int, KeyValuePair<string, bool>>();
        // int is placeholder, KVP is "name", and whether they're present or not.

        int counter = 0;
        int peoplePresent = 0;
        int peopleAbsent = 0;
        string attendanceStatus;


        StreamReader fileReading;
        
     

        /// <summary>
        /// Resets the date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxNewDate_Click(object sender, EventArgs e)
        {
           
        }

        

        /// <summary>
        /// Prompts the user to open a roster .txt file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxStartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = uxOpenFileDialog.FileName;
                    if (!fileName.EndsWith(".txt"))
                    {
                        throw new Exception();
                    }
                    using (StreamReader temp = new StreamReader(fileName))
                    {
                        uxRosterNameLabel.Text = fileName;
                        while (!temp.EndOfStream)
                        {
                            allNames.Add(temp.ReadLine(), false);
                            
                        }
                    }
                }
                uxStartButton.Enabled = false;
                uxCurrentTextBox.Text = allNames.Keys.ElementAt(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The roster file needs to end with '.txt'");
            }
           
        }


        /// <summary>
        /// Very self explanatory!
        /// </summary>
        public void DisableEverything()
        {
            uxStartButton.Enabled = false;
            uxPresentButton.Enabled = false;
            uxAbsentButton.Enabled = false;
        }

        /// <summary>
        /// Goes through allNames, imported from roster, and displays their names one by one, adding them to the peoplePresent list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxPresentButton_Click(object sender, EventArgs e)
        {
            peoplePresent++;
            uxPeoplePresentCount.Text = peoplePresent.ToString();
            
            allNames[uxCurrentTextBox.Text] = true;
            attendanceStatus = " here.";
            IncrementNames();
        }


        private void UxAbsentButton_Click(object sender, EventArgs e)
        {
            peopleAbsent++;
            uxAbsentCount.Text = peopleAbsent.ToString();
            allNames[uxCurrentTextBox.Text] = false;
            attendanceStatus = " absent.";
            IncrementNames();
        }

        /// <summary>
        /// Move counter forward, and change text of line being displayed.
        /// </summary>
        private void IncrementNames()
        {
            counter++;
            if (counter > allNames.Count)
            {
                MessageBox.Show("All names entered.");
                DisableEverything();
            }

            uxAttendanceStatus.Text = allNames.Keys.ElementAt(counter - 1).ToString() + " was" + attendanceStatus;
            if (!allNames.TryGetValue(uxCurrentTextBox.Text, out _))
            {
                DisableEverything();
            }
            else
            {
                uxCurrentTextBox.Text = allNames.Keys.ElementAt(counter - 1).ToString(); // TODO: Fix this 

            }
        }

        private void UxSaveResults_Click(object sender, EventArgs e)
        {
            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "Attendance.txt")))
            //{
            //    sw.WriteLine("Attendance report for " + date + ":");
            //    sw.WriteLine("People present: ");
            //    while (peoplePresent.Count > 0)
            //    {
            //        for (int i = 0; i < peoplePresent.Count; i++)
            //        {
            //            sw.WriteLine(peoplePresent[i]);
            //            peoplePresent.RemoveAt(i);
            //        }
            //    }
            //    if(peoplePresent.Count == 0)
            //    {
            //        MessageBox.Show("done!");
            //    }
            //}
        }

        private void UxDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            date = uxDateTimePicker.Value;
        }
    }
}