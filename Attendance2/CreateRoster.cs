// Author: Nate Harrell
using Attendance;
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

        Attendance3 attendance3 = new Attendance3();



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

        /// <summary>
        /// Makes sure there's something in the roster.
        /// </summary>
        public bool IsEmpty()
        {
            if (uxFileContentsTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("You haven't added anyone to the roster yet!");
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Exports the roster as a .txt file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxExportRoster_Click(object sender, EventArgs e)
        {
            try
            {
                if(IsEmpty())
                {
                    return;
                }
                uxSaveFileDialog.Filter = "*.txt|";
                var showDialog = uxSaveFileDialog.ShowDialog();
                if (showDialog == DialogResult.OK)
                {
                    string fileName = uxSaveFileDialog.FileName;
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        foreach (string name in names)
                        {
                            sw.WriteLine(name);
                        }
                    }
                    MessageBox.Show("Roster created!");
                    ActiveForm.Hide();
                    attendance3.Show();
                }
                else if(showDialog == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Main menu navigation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt();
            ActiveForm.Hide();
            prompt.Show();
        }

        private void DisableEverything()
        {
            uxRemoveNameButton.Enabled = false;
            uxNamesTextBox.Enabled = false;
            uxFinalizeRoster.Enabled = false;
            MessageBox.Show("Roster finalized. Export it in the 'File' menu");
        }
        /// <summary>
        /// So they know they're done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxFinalizeRoster_Click(object sender, EventArgs e)
        {
            DisableEverything();
        }

        private void EditRoster()
        {
            uxFileContentsTextBox.ReadOnly = false;
            uxRemoveNameButton.Enabled = false;
            uxFinalizeRoster.Enabled = false;
            uxNamesTextBox.ReadOnly = true;
            uxFilePreviewText.Text = "Press enter to submit your changes.";
            uxFilePreviewText.Font = new Font("Microsoft Sans Serif", 8);
        }

        private void AdjustRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(IsEmpty())
            {
                return;
            }
            EditRoster();


        }

        private void UxFileContentsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string[] textBoxNames = 
            }

        }
    }   
}
