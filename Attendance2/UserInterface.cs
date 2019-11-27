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

        string date; // final date
        List<string> allNames = new List<string>();
        List<string> peoplePresent = new List<string>();
        List<string> peopleAbsent = new List<string>();
        int presentIndex = 0;


        StreamReader fileReading;
        /// <summary>
        /// This displays the date in the label when the user presses enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                date = uxDateText.Text;
                uxDateText.Enabled = false;
                uxDate.Text = date;
            }
        }
        /// <summary>
        /// This checks if enter was pressed on the date text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxDateText_TextChanged(object sender, EventArgs e)
        {
            this.uxDateText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
        }

        /// <summary>
        /// Resets the date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxNewDate_Click(object sender, EventArgs e)
        {
            uxDateText.Enabled = true;
            date = uxDateText.Text;
            uxDate.Text = date;
        }

        /// <summary>
        /// TODO: Finish this!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxImportRoster_Click(object sender, EventArgs e)
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
                            allNames.Add(temp.ReadLine());
                        }
                        int idk = 1;
                    }
                }
                uxCurrentTextBox.Text = allNames[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("The roster file needs to end with '.txt'");
            }
          
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
                            allNames.Add(temp.ReadLine());
                        }
                    }
                }
                uxStartButton.Enabled = false;
                uxCurrentTextBox.Text = allNames[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("The roster file needs to end with '.txt'");
            }
           
        }
        int presentCount = 0;
        int absentCount = 0;

        /// <summary>
        /// Very self explanatory!
        /// </summary>
        public void DisableEverything()
        {
            uxStartButton.Enabled = false;
            uxPresentButton.Enabled = false;
            uxAbsentButton.Enabled = false;
            uxDateText.Enabled = false;
        }
        /// <summary>
        /// Goes through allNames, imported from roster, and displays their names one by one, adding them to the peoplePresent list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxPresentButton_Click(object sender, EventArgs e)
        {
            
                if (allNames.Count > 0)
                {
                    uxCurrentTextBox.Text = allNames[presentIndex];
                    uxUpNextTextBox.Text = allNames[presentIndex + 1]; // this is screwing it up

                    allNames.Add(""); // adds it to the end

                    uxCurrentTextBox.Clear();

                    uxAttendanceStatus.Text = allNames[presentIndex] + " was present.";
                    peoplePresent.Add(allNames[presentIndex]);

                    uxPeoplePresentDebug.Text = peoplePresent[presentIndex];

                    presentIndex++;
                    presentCount++;

                    uxPeoplePresentCount.Text = presentCount.ToString();
                }

                if(uxUpNextTextBox.Text == "")
                {
                    MessageBox.Show("All names entered.");
                    DisableEverything();
                    uxSaveResults.Enabled = true;
                }

            
          
        }


        private void UxAbsentButton_Click(object sender, EventArgs e)
        {
            
                if (allNames.Count > 0)
                {
                    uxCurrentTextBox.Text = allNames[presentIndex];
                    uxUpNextTextBox.Text = allNames[presentIndex + 1]; 

                    allNames.Add(""); // adds it to the end

                    uxCurrentTextBox.Clear();

                    uxAttendanceStatus.Text = allNames[presentIndex] + " was absent.";
                    peopleAbsent.Add(allNames[presentIndex]);


                    presentIndex++;
                    absentCount++;

                    uxAbsentCount.Text = absentCount.ToString();
                }

                if (uxUpNextTextBox.Text == "")
                {
                    MessageBox.Show("All names entered.");
                    DisableEverything();
                    uxSaveResults.Enabled = true;
                }

            
          
        }

        private void UxSaveResults_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "Attendance.txt")))
            {
                sw.WriteLine("Attendance report for " + date + ":");
                sw.WriteLine("People present: ");
                while (peoplePresent.Count > 0)
                {
                    for (int i = 0; i < peoplePresent.Count; i++)
                    {
                        sw.WriteLine(peoplePresent[i]);
                        peoplePresent.RemoveAt(i);
                    }
                }
                if(peoplePresent.Count == 0)
                {
                    MessageBox.Show("done!");
                }
            }
        }
    }
}