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

        List<string> names = new List<string>(); 

        List<string> nameDisplay = new List<string>();

        Attendance3 attendance3 = new Attendance3();

        bool rosterEdited = false;

        bool isFinalized = false;


        /// <summary>
        /// Stuff to do when remove name button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxRemoveNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (names.Count != 0)
                {
                    string removed = names[names.Count - 1];
                    nameDisplay.Clear();
                    foreach(string name in names)
                    {
                        nameDisplay.Add(name);
                    }
                    if(names.Count != 0)
                    {
                        names.Remove(names[names.Count - 1]);
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
                names.Add(uxNamesTextBox.Text);
                nameDisplay.Add(uxNamesTextBox.Text);
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
                uxFilePreviewText.Font = new Font("Microsoft Sans Serif", 12);
                uxFilePreviewText.Text = "File Preivew:";
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

        private bool HasBeenEdited()
        {
            if (rosterEdited)
            {
                return false;
            }
            return true;
        }

        private bool HasBeenFinalized()
        {
            if (isFinalized == false)
            {
                isFinalized = true;
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
                if(HasBeenFinalized())
                {
                    MessageBox.Show("You need to finalize your roster before you can export.");
                }
                if(HasBeenEdited())
                {
                    MessageBox.Show("You cannot export while editing a roster.");
                    return;
                }
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
            rosterEdited = false;
            uxFileContentsTextBox.ReadOnly = false;
            uxRemoveNameButton.Enabled = false;
            uxFinalizeRoster.Enabled = false;
            uxNamesTextBox.ReadOnly = true;
            uxFilePreviewText.Text = "Press 'TAB' to submit your changes.";
            uxFilePreviewText.Font = new Font("Microsoft Sans Serif", 8);
            uxRemovedText.Text = "";
        }

        private void DoneEditingRoster()
        {
            rosterEdited = true;
            uxFileContentsTextBox.ReadOnly = true;
            uxRemoveNameButton.Enabled = true;
            uxFinalizeRoster.Enabled = true;
            uxNamesTextBox.ReadOnly = false;
            uxFilePreviewText.Text = "Successfully edited roster.";
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



        private void UxFileContentsTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                string[] lines = uxFileContentsTextBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                names.Clear();
                
                for(int i = 0; i < lines.Length; i++)
                {
                    names.Add(lines[i]);
                }
                DoneEditingRoster();
            }
        }

        private void ClearRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxFileContentsTextBox.Text = string.Empty;
            names.Clear();
            nameDisplay.Clear();
        }
    }   
}
