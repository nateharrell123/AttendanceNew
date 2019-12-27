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
    public partial class Attendance : Form 
    {
        public Attendance()
        {
            InitializeComponent();
            DisableEverything();
            uxStartButton.Enabled = true;
        }

        DateTime date = new DateTime();


        /// <summary>
        /// int = placeholder. Attendee has two properties: name, and whether they were here or not.
        /// </summary>
        Dictionary<int, Attendee> allNames = new Dictionary<int, Attendee>();

        int counter = 0;
        int peoplePresent = 0;
        int peopleAbsent = 0;
        string attendanceStatus;
        int absentUnexcused = 0;
        

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
            EnableEverything();
            try
            {
                if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = uxOpenFileDialog.FileName;
                    if (!fileName.EndsWith(".txt"))
                    {
                        throw new Exception();
                    }
                    
                    uxRosterNameLabel.Text = fileName;

                    string[] fileContents = File.ReadAllLines(fileName);
                    for (int i = 0; i < fileContents.Length; i++)
                    {
                        allNames.Add(i, new Attendee(fileContents[i], false, false));
                        uxRosterNames.Text = allNames[i].Name; // fix later
                    }
                }

                uxStartButton.Enabled = false;
                uxNameTextBox.Text = allNames[0].Name;
            }
            catch
            {
                MessageBox.Show("The roster file needs to end with '.txt'");
            }
           
        }

        

        /// <summary>
        /// Very self explanatory!
        /// </summary>
        public void DisableEverything()
        {
            uxPresentButton.Enabled = false;
            uxAbsentButton.Enabled = false;
            uxUnexcused.Enabled = false;
        }

        public void EnableEverything()
        {
            uxStartButton.Enabled = true;
            uxPresentButton.Enabled = true;
            uxAbsentButton.Enabled = true;
            uxUnexcused.Enabled = true;
        }

        /// <summary>
        /// Goes through allNames, imported from roster, and displays their names one by one, adding them to the peoplePresent list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxPresentButton_Click(object sender, EventArgs e)
        {
            peoplePresent++;

            uxNameTextBox.Text = allNames[counter].Name;

            if (allNames[counter].Present == false)
            {
                allNames[counter].Present = true;
            }

            uxPeoplePresentCount.Text = peoplePresent.ToString();

            attendanceStatus = " here.";
            IncrementNames();
        }


        private void UxAbsentButton_Click(object sender, EventArgs e)
        {
            peopleAbsent++;
            uxNameTextBox.Text = allNames[counter].Name;
            uxAbsentCount.Text = peopleAbsent.ToString();
            allNames[counter].Present = false;
            attendanceStatus = " absent.";
            IncrementNames();
        }

        /// <summary>
        /// Move counter forward, and change text of line being displayed.
        /// </summary>
        private void IncrementNames()
        {
            counter++;
            if (counter >= allNames.Count)
            {
                MessageBox.Show("All names entered.");
                DisableEverything();
                uxSaveResults.Enabled = true;
            }
            uxAttendanceStatus.Text = allNames[counter - 1].Name + " was" + attendanceStatus;
        }

        private void UxSaveResults_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "Attendance.txt")))
            {
                sw.WriteLine("Attendance report for " + date + ":");
                try
                {
                    foreach (var atn in allNames)
                    {
                        sw.Write(atn.Value.Name);
                        sw.WriteLine(atn.Value.Present ? " was present." : " was absent."); // ? is left side, : is right side.
                    }
                    

                    MessageBox.Show("done!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
                
            }
        }

        private void UxDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            date = uxDateTimePicker.Value;
        }

        /// <summary>
        /// Attributes of an Attendee. They have names, and whether they were present or not.
        /// </summary>
        private class Attendee
        {
            public string Name { get; set; }
            public bool Present { get; set; }
            public bool Unexcused { get; set; }

            public Attendee(string name, bool present, bool unexcused)
            {
                this.Name = name;
                this.Present = present;
                this.Unexcused = unexcused;
            }
        }

        /// <summary>
        /// Event handler for Unexcused absences.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxUnexcused_Click(object sender, EventArgs e)
        {
            absentUnexcused++;
            uxNameTextBox.Text = allNames[counter].Name;
            uxAbsentCount.Text = peopleAbsent.ToString();
            allNames[peoplePresent].Present = false;
            allNames[peoplePresent].Unexcused = true;
            attendanceStatus = " absent (unexcused).";
            IncrementNames();
        }
    }
}