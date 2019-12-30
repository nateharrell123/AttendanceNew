// Author: Nate Harrell
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance2
{
    public partial class CreateRoster : Form
    {
        public CreateRoster()
        {
            InitializeComponent();
        }

        Stack<string> names = new Stack<string>(); 

        List<string> nameDisplay = new List<string>();

        /// <summary>
        /// Starts the program. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxRosterStartButton_Click(object sender, EventArgs e)
        {
            uxStartButton.Enabled = false;
            uxRemoveNameButton.Enabled = true;
            uxNamesTextBox.ReadOnly = false;
        }

        /// <summary>
        /// Stuff to do when remove name button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxRemoveNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (names.Peek() != null)
                {
                    string removed = names.Pop();
                    nameDisplay.Clear();
                    foreach(string name in names)
                    {
                        nameDisplay.Add(name);
                    }
                    uxRemovedText.Text = "Removed " + removed + " from the roster.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no one in the roster to remove!");
            }

            UpdateDisplay();
        }

        /// <summary>
        /// Stuff to do when enter key is pressed within textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void input_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                names.Push(uxNamesTextBox.Text);
                nameDisplay.Add(names.Peek());
                e.Handled = true;
                uxNamesTextBox.Clear();

                UpdateDisplay();
            }
        }

        /// <summary>
        /// Updates the display.
        /// </summary>
        public void UpdateDisplay()
        {
            if(names.Count >= 0)
            {
                string displayName = string.Empty;
                foreach (string name in names)
                {
                    displayName += name + "\r\n";
                }
                uxFileContentsTextBox.Text = displayName;
            }
        }

        private void UxExportRoster_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = uxSaveFileDialog.FileName;
                    using (StreamWriter sw = new StreamWriter(fileName + ".txt"))
                    {
                        foreach (string name in names)
                        {
                            sw.WriteLine(name);
                        }
                    }
                    MessageBox.Show("Roster created!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt();
            ActiveForm.Hide();
            prompt.Show();
        }
    }
}
