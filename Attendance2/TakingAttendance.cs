// Author: Nate Harrell 
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

        bool hasBeenImported = false;

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
            catch(Exception)
            {
                MessageBox.Show("All names have been entered."); // fix this
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
            if (uxRosterNamesTextBox.Text == string.Empty)
            {
                MessageBox.Show("There was no one found in the .txt file.");
                DisableEverything();
            }
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

            uxFilePreviewTextBox.Text += allNames[counter - 1].Name + " was" + attendanceStatus + "\r\n";

            uxRosterNamesTextBox.Text = displayName;

            try
            {
                uxNameTextBox.Text = nameDisplay[0];
            }
            catch(Exception ex)
            {
                // ???
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

        ///
        private void ImportRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {   
                if(hasBeenImported)
                {
                    MessageBox.Show("A roster has already been imported.");
                    return;
                }
                var dialogResult = uxOpenFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    string fileName = uxOpenFileDialog.FileName;
                    if (!fileName.EndsWith(".txt"))
                    {
                        throw new ArgumentNullException();
                    }
                    
                    string rosterDisplayName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);
                    uxRosterNameLabel.Text = rosterDisplayName;

                    string[] fileContents = File.ReadAllLines(fileName);
                    for (int i = 0; i < fileContents.Length; i++)
                    {
                        allNames.Add(i, new Attendee(fileContents[i], false, false));
                        nameDisplay.Add(fileContents[i]);
                        everyName.Add(fileContents[i]);
                    }
                    hasBeenImported = true;
                    StartupDisplay();
                    EnableEverything();
                }
                else if(dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("The roster file needs to end with '.txt'");
            }
            catch(Exception)
            {
                MessageBox.Show("Error reading roster. (Did you already import a roster?)");
            }
        }

        /// <summary>
        /// Exporting Results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxSaveToolStrip_Click(object sender, EventArgs e)
        {

            if(!hasBeenImported)
            {
                MessageBox.Show("You need to import a roster before you can export anything.");
            }
            if (hasBeenImported && uxFilePreviewTextBox.Text == "")
            {
                MessageBox.Show("There are no results to export!");
            }
            if(uxRosterNamesTextBox.Text != "" && uxFilePreviewTextBox.Text != string.Empty)
            {
                MessageBox.Show("There are still names that haven't been entered yet!");
                return;
            }
            if(uxFilePreviewTextBox.Text == "")
            {
                return;
            }
            else if(hasBeenImported == true)
            {
                uxSaveFileDialog.Filter = "*.txt|Roster";

                if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileName = uxSaveFileDialog.FileName;
                        using (StreamWriter sw = new StreamWriter(fileName))
                        {
                            sw.WriteLine("Attendance report for " + date + ":");
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

                        fileName = uxSaveFileDialog.FileName; // fix this!

                        while(!fileName.EndsWith(".txt"))
                        {
                            MessageBox.Show("The filename needs to end with .txt");
                            uxSaveFileDialog.ShowDialog();
                        }

                        if(fileName.EndsWith(".txt"))
                        {
                            MessageBox.Show("Saved results to " + uxSaveFileDialog.FileName);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }
        }

        private void MainMenuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Prompt prompt = new Prompt();
            prompt.Show();
        }

        private void Attendance3_Load(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("finish this");
        }
    }
}