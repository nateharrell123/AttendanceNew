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

        bool isFinalized = false;


        /// <summary>
        /// Stuff to do when remove name button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxRemoveNameButton_Click(object sender, EventArgs e)
        {
            if (isFinalized)
            {
                return;
            }
            try
            {
               
                if (names.Count > 0)
                {
                    string removed = names[names.Count - 1];
                    nameDisplay.Clear();
                    foreach (string name in names)
                    {
                        nameDisplay.Add(name);
                    }
                    names.Remove(names[names.Count - 1]);

                    uxRemovedText.Text = "Removed " + removed + " from the roster.";
                }
                else if (names.Count == 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no one in the roster to remove!");
                uxRemovedText.Text = "";
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
            if (isFinalized)
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                string promptText = uxNamesTextBox.Text;
                if (promptText.Equals("") || promptText.Equals("\r\n"))
                {
                    MessageBox.Show("Please enter a name.");
                    uxNamesTextBox.Clear();
                    return;
                }
                else
                {
                    names.Add(promptText.Trim());
                    nameDisplay.Add(promptText);
                    e.Handled = true;
                    uxNamesTextBox.Clear();
                    UpdateDisplay();
                }
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
                    if(!string.IsNullOrEmpty(name))
                    {
                        displayName += name + "\r\n";
                    }

                }
                uxFileContentsTextBox.Text = displayName;
                uxFilePreviewLabel.Font = new Font("Tahoma", 12);
                uxFilePreviewLabel.Text = "File Preview:";
            }
        }

        /// <summary>
        /// Makes sure there's something in the roster.
        /// </summary>
        public bool IsEmpty()
        {
            if (uxFileContentsTextBox.Text.Equals(string.Empty) && names.Count == 0)
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
                if(names.Count == 0)
                {
                    return;
                }
                uxSaveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                uxSaveFileDialog.DefaultExt = ".txt";
                uxSaveFileDialog.AddExtension = true;
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
                    MessageBox.Show("Saved to " + uxSaveFileDialog.FileName);

                    DialogResult dialogResult = MessageBox.Show("Would you like to use this roster now?", "Testing", MessageBoxButtons.YesNo); // stack overflow
                    if (dialogResult == DialogResult.Yes)
                    {
                        ActiveForm.Hide();
                        Attendance3 newForm = new Attendance3();
                        newForm.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
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
            MessageBox.Show("Roster finalized. Export it in the 'File' menu");
        }
        /// <summary>
        /// So they know they're done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxFinalizeRoster_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to finalize your roster?", "Finalize Roster", MessageBoxButtons.YesNo); // stack overflow
            if (dialogResult == DialogResult.Yes && names.Count > 0)
            {
                isFinalized = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            if (names.Count > 0)
            {
                DisableEverything();
            }
            else if (names.Count == 0)
            {
                MessageBox.Show("There is no one in the roster to finalize!");
            }
        }

        private void EditRoster()
        {
            uxFileContentsTextBox.ReadOnly = false;
            uxNamesTextBox.ReadOnly = true;
            uxFilePreviewLabel.Font = new Font("Tahoma", 9);
            uxFilePreviewLabel.Text = "Press 'TAB' to submit your changes.";
            uxRemovedText.Text = "";
        }

        private void DoneEditingRoster()
        {
            uxFileContentsTextBox.ReadOnly = true;
            uxNamesTextBox.ReadOnly = false;
            uxFilePreviewLabel.Text = "Successfully edited roster.";
            uxFilePreviewLabel.Font = new Font("Tahoma", 12);
        }

        /// <summary>
        /// Edit roster.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdjustRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(IsEmpty())
            {
                return;
            }
            else if(isFinalized)
            {
                return;
            }

            else
            {
                EditRoster();
            }

        }


        /// <summary>
        /// Tab Key pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxFileContentsTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab && uxFileContentsTextBox.ReadOnly == false)
            {
                string[] lines = uxFileContentsTextBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None); // Stack OverFlow
                names.Clear();
                
                for(int i = 0; i < lines.Length - 1; i++) 
                {
                    names.Add(lines[i]);
                }
                uxRemovedText.Text = "";
                DoneEditingRoster();
            }
            else
            {
                return;
            }
        }

        private void ClearRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFinalized)
            {
                return;
            }
            if (names.Count > 0)
            {
                uxFileContentsTextBox.Text = string.Empty;
                uxRemovedText.Text = "";
                names.Clear();
                nameDisplay.Clear();
            }
            else if (names.Count == 0)
            {
                MessageBox.Show("There is no one in the roster to clear!");
            }
        }


    }   
}
