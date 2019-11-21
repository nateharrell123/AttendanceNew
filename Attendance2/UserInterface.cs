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
        int counter = 0;
        int presentCount = 0;
        int absentCount = 0;
        int deCount = 0;

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
                uxRosterNames.Text = allNames[0];
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
                uxRosterNames.Text = allNames[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("The roster file needs to end with '.txt'");
            }
           
        }

        private void UxPresentButton_Click(object sender, EventArgs e)
        {
            if(allNames.Count > 0)
            {
                int index = counter++;
                if(index <= allNames.Count - 1)
                {
                    uxRosterNames.Text = allNames[index + 1]; // TODO: Index out of range
                    presentCount++;
                    peoplePresent.Add(allNames[index]);
                    uxPeoplePresentCount.Text = peoplePresent.Count.ToString();
                }
                else if(index > allNames.Count)
                {
                    MessageBox.Show("All names entered.");
                }
            }
            else
            {
                MessageBox.Show("The file is empty.");
            }
        }

        private void UxAbsentButton_Click(object sender, EventArgs e)
        {
            if (allNames.Count > 0)
            {
                int index = deCount++;
                if (index <= allNames.Count - 1)
                {
                    index++;
                    uxRosterNames.Text = allNames[index + 1];
                    absentCount++;
                    peopleAbsent.Add(allNames[index - 1]);
                    uxAbsentCount.Text = peopleAbsent.Count.ToString();
                }
                else if (index >= allNames.Count)
                {
                    MessageBox.Show("All names entered.");
                }
            }
            else
            {
                MessageBox.Show("The file is empty.");
            }
        }
    }
}