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
        int counter = 0;
        int presentCount = 0;

        StreamReader fileReading;
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                date = uxDateText.Text;
                uxDateText.Enabled = false;
                uxDate.Text = date;
            }
        }
        private void UxDateText_TextChanged(object sender, EventArgs e)
        {
            this.uxDateText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
        }

        private void UxNewDate_Click(object sender, EventArgs e)
        {
            uxDateText.Enabled = true;
            date = uxDateText.Text;
            uxDate.Text = date;
        }

        private void UxImportRoster_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = uxOpenFileDialog.FileName;
                using (StreamReader temp = new StreamReader(fileName))
                {
                    uxRosterNameLabel.Text = fileName;
                }
            }
        }

        private void UxStartButton_Click(object sender, EventArgs e)
        {
           
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = uxOpenFileDialog.FileName;
                using (StreamReader temp = new StreamReader(fileName))
                {
                    uxRosterNameLabel.Text = fileName;
                    while (!temp.EndOfStream)
                    {
                        allNames.Add(temp.ReadLine());
                    }
                }
            }
        }

        private void UxPresentButton_Click(object sender, EventArgs e)
        {
            if(allNames.Count > 0)
            {
                uxRosterNames.Text = allNames[counter++];
                presentCount++;
                using (StreamWriter sw = new StreamWriter(date + "_Attendance.txt"))
                {
                    sw.WriteLine("There were " + presentCount + "people present today.");
                    sw.WriteLine("These people were: ");

                }
            }
            else
            {
                MessageBox.Show("The file is empty.");
            }
        }
    }
}