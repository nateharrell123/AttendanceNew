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

        string date = DateTime.Now.ToShortDateString();
        Prompt prompt = new Prompt();
        


        /// <summary>
        /// int = placeholder. Attendee has three properties: name, whether they were here or not, & if they're excused.
        /// </summary>
        public Dictionary<int, Attendee> allNames = new Dictionary<int, Attendee>();

        Queue<string> nameDisplay = new Queue<string>();
        Queue<string> everyName = new Queue<string>();

        int counter = 0;
        int peoplePresent = 0;
        int peopleAbsent = 0;
        int absentUnexcused = 0;

        string attendanceStatus;

        bool hasBeenImported = false;

        public DateTime DateCreated // Stack Overflow
        {
            get
            {
                return this.dateCreated.HasValue
                   ? this.dateCreated.Value
                   : DateTime.Now;
            }

            set { this.dateCreated = value; }
        }
        private DateTime? dateCreated = null;

        /// <summary>
        /// Goes through allNames, imported from roster, and displays their names one by one, adding them to the peoplePresent list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxPresentButton_Click(object sender, EventArgs e)
        {
            int count = nameDisplay.Count - 1;
            if(nameDisplay.Count > 0)
            {
                peoplePresent++;

                uxDataGridView.Rows.Add(allNames[count].Name, "No", "Yes"); // insane!!!

                if (allNames[count].Present == false)
                {
                    allNames[count].Present = true;
                }
                uxPeoplePresentCount.Text = peoplePresent.ToString();

                attendanceStatus = " present.";
                IncrementNames();
       
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Event handler for Absences (Excused).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxAbsentButton_Click(object sender, EventArgs e)
        {
            int count = nameDisplay.Count - 1;
            if (nameDisplay.Count > 0)
            {
                peopleAbsent++;

                uxDataGridView.Rows.Add(allNames[count].Name, "No", "No");
                uxAbsentCount.Text = peopleAbsent.ToString();
                allNames[counter].Present = false;
                attendanceStatus = " absent.";

                IncrementNames();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Event handler for Unexcused absences.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxUnexcused_Click(object sender, EventArgs e)
        {
            int count = nameDisplay.Count - 1;
            if(nameDisplay.Count > 0)
            {
                absentUnexcused++;

                uxDataGridView.Rows.Add(allNames[count].Name, "Yes", "No");
                uxAbsentUnexcused.Text = absentUnexcused.ToString();
                allNames[count].Unexcused = true;
                attendanceStatus = " absent (unexcused).";

                IncrementNames();
            }
            else
            {
                return;
            }
           
        }



        private void UxDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            date = DateTime.Now.ToShortDateString();
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
            if (counter > allNames.Count)
            {
                DisableEverything();
                return;
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
                nameDisplay.Enqueue(name);
            }


            if (!nameDisplay.Peek().Equals(string.Empty))
            {
                nameDisplay.Dequeue();
                everyName.Dequeue();
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
            if(everyName.Count > 0)
            {
                uxNameTextBox.Text = everyName.Peek();
            }
            else
            {
                return;
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

            uxDataGridView.Text += allNames[counter - 1].Name + " was" + attendanceStatus + "\r\n";

            uxRosterNamesTextBox.Text = displayName;

            if(nameDisplay.Count > 0)
            {
                uxNameTextBox.Text = nameDisplay.Peek();
            }
            else
            {
                uxNameTextBox.Text = "";
                return;
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
        public class Attendee
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
                        nameDisplay.Enqueue(fileContents[i]);
                        everyName.Enqueue(fileContents[i]);
                        
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
            ExportRoster();  
        }

       

        private void MainMenuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Prompt prompt = new Prompt();
            prompt.Show();
        }

        private void UxReviseResults_Click(object sender, EventArgs e)
        {

        }

        private void ExportRoster()
        {
            if (!hasBeenImported)
            {
                MessageBox.Show("You need to import a roster before you can export anything.");
            }
            if (hasBeenImported && uxDataGridView.Text == "")
            {
                MessageBox.Show("There are no results to export!");
            }
            if (uxRosterNamesTextBox.Text != "" && uxDataGridView.Text != string.Empty)
            {
                MessageBox.Show("There are still names that haven't been entered yet!");
                return;
            }
            if (uxDataGridView.Text == "")
            {
                return;
            }
            else if (hasBeenImported == true)
            {
                uxSaveFileDialog.Filter = "Text Files (*.txt)|*.txt";

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

                        fileName = uxSaveFileDialog.FileName;

                        while (!fileName.EndsWith(".txt"))
                        {
                            MessageBox.Show("The filename needs to end with .txt");
                            uxSaveFileDialog.ShowDialog();
                        }

                        if (fileName.EndsWith(".txt"))
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

        // Fix later: 
        private void UxReviseResults_Click_1(object sender, EventArgs e)
        {
            bool submitChanges = false;
            if(hasBeenImported)
            {
                uxFilePreviewLabel.Text = "Now editing results:";
                uxDataGridView.ReadOnly = false;
                uxReviseResults.Text = "Submit Changes";
            }
            else
            {
                MessageBox.Show("You need to import a roster before you can edit anything!");
            }
            if(uxReviseResults.Text.Equals("Submit Changes"))
            {
                uxFilePreviewLabel.Text = "Successfully edited your results.";
            }

        }
    }
}