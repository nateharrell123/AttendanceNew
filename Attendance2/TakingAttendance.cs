﻿// Author: Nate Harrell (Chintan Patel helped a bit too :-) )
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
using Attendance2;

namespace Attendance
{
    public partial class Attendance3 : Form
    {
        public Attendance3()
        {
            InitializeComponent();
            DisableEverything();
        }

        DateTime date = new DateTime();

        Prompt prompt = new Prompt();


        /// <summary>
        /// int = placeholder. Attendee has three properties: name, whether they were here or not, & if they're excused.
        /// </summary>
        Dictionary<int, Attendee> allNames = new Dictionary<int, Attendee>();

        List<string> nameDisplay = new List<string>();
        List<string> everyName = new List<string>();

        int counter = 0;
        int peoplePresent = 0;
        int peopleAbsent = 0;
        int absentUnexcused = 0;
        string attendanceStatus;

        /// <summary>
        /// Goes through allNames, imported from roster, and displays their names one by one, adding them to the peoplePresent list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxPresentButton_Click(object sender, EventArgs e)
        {
            try
            {
                peoplePresent++;

                uxNameTextBox.Text = allNames[counter].Name;

                if (allNames[counter].Present == false)
                {
                    allNames[counter].Present = true;
                }
                uxPeoplePresentCount.Text = peoplePresent.ToString();

                attendanceStatus = " present.";
                IncrementNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Event handler for Absences (Excused).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxAbsentButton_Click(object sender, EventArgs e)
        {
            try
            {
                peopleAbsent++;
                uxNameTextBox.Text = allNames[counter].Name;
                uxAbsentCount.Text = peopleAbsent.ToString();
                allNames[counter].Present = false;
                attendanceStatus = " absent.";

                IncrementNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Event handler for Unexcused absences.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxUnexcused_Click(object sender, EventArgs e)
        {
            try
            {
                absentUnexcused++;
                uxNameTextBox.Text = allNames[counter].Name;
                uxAbsentUnexcused.Text = absentUnexcused.ToString();
                allNames[counter].Unexcused = true;
                attendanceStatus = " absent (unexcused).";

                IncrementNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void UxDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            date = uxDateTimePicker.Value;
        }

        /// <summary>
        /// Very self explanatory!
        /// </summary>
        public void DisableEverything()
        {
            uxPresentButton.Enabled = false;
            uxAbsentExcusedButton.Enabled = false;
            uxUnexcused.Enabled = false;
        }

        /// <summary>
        /// Also, very self explanatory!
        /// </summary>
        public void EnableEverything()
        {
            uxPresentButton.Enabled = true;
            uxAbsentExcusedButton.Enabled = true;
            uxUnexcused.Enabled = true;
        }


        /// <summary>
        /// Move counter forward, and change text of line being displayed.
        /// </summary>
        private void IncrementNames()
        {
            counter++;
            if (counter >= allNames.Count)
            {
                DisableEverything();
            }

            ClearNames();
            UpdateDisplay();
        }
        /// <summary>
        /// Clears the nameDisplay list, and adds all the names back in.
        /// </summary>
        public void ClearNames()
        {
            nameDisplay.Clear();

            foreach (string name in everyName)
            {
                nameDisplay.Add(name);
            }
            try
            {
                nameDisplay.Remove(nameDisplay[0]);
                everyName.Remove(nameDisplay[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("All names entered. Export your results in the 'File' menu");
            }
        }

        public void StartupDisplay()
        {
            string displayNamee = string.Empty;
            foreach (string name in nameDisplay)
            {
                displayNamee += name + "\r\n";
            }
            uxRosterNamesTextBox.Text = displayNamee;
        }

        /// <summary>
        /// Updates the display.
        /// </summary>
        public void UpdateDisplay()
        {
            string displayName = string.Empty;
            foreach (string name in nameDisplay)
            {
                displayName += name + "\r\n";
            }


            uxAttendanceStatus.Text = allNames[counter - 1].Name + " was" + attendanceStatus;

            uxFilePreviewTextBox.Text += allNames[counter - 1].Name + " was" + attendanceStatus + "\r\n";

            uxRosterNamesTextBox.Text = displayName;

            try
            {
                uxNameTextBox.Text = nameDisplay[0];
            }
            catch(Exception ex)
            {
                
            }
        }



        /// <summary>
        /// Closes this form, and opens the main menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt();
            ActiveForm.Close();
            prompt.Show();
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

        private void ImportRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableEverything();
            try
            {
                if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = uxOpenFileDialog.FileName;
                    if (!fileName.EndsWith(".txt"))
                    {
                        throw new ArgumentNullException();
                    }

                    string rosterDisplayName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);
                    uxRosterNameLabel.Text = rosterDisplayName;


                    string[] fileContents = File.ReadAllLines(fileName);
                    try
                    {
                        for (int i = 0; i < fileContents.Length; i++)
                        {
                            allNames.Add(i, new Attendee(fileContents[i], false, false));
                            nameDisplay.Add(fileContents[i]);
                            everyName.Add(fileContents[i]);
                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Error in reading file. Check the format to make sure it is valid (each name on its own line.");
                    }
                    
                }
                uxNameTextBox.Text = allNames[0].Name;

                StartupDisplay();
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("The roster file needs to end with '.txt'");
            }

        }

        private void UxSaveToolStrip_Click(object sender, EventArgs e)
        {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = uxSaveFileDialog.FileName;
                using (StreamWriter sw = new StreamWriter(fileName + ".txt"))
                {
                    sw.WriteLine("Attendance report for " + date + ":");
                    try
                    {
                        foreach (var atn in allNames)
                        {
                            if (atn.Value.Present == true)
                            {
                                sw.Write(atn.Value.Name);
                                sw.WriteLine(" was present.");
                            }
                            else if (atn.Value.Present == false && atn.Value.Unexcused == false)
                            {
                                sw.Write(atn.Value.Name);
                                sw.WriteLine(" was absent.");
                            }
                            if (atn.Value.Unexcused == true)
                            {
                                sw.Write(atn.Value.Name);
                                sw.WriteLine(" was absent (unexcused).");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                MessageBox.Show("Saved results!");
                ActiveForm.Hide();
                prompt.Show();


            }
        }

        private void MainMenuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Prompt prompt = new Prompt();
            prompt.Show();
        }

    }
}