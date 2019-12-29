using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        int counter = 0;
        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                names.Push(uxNamesTextBox.Text);
                uxFileContentsTextBox.Text = names.Peek();
                counter++;
            }
        }


        private void UxRosterStartButton_Click(object sender, EventArgs e)
        {
            uxStartButton.Enabled = false;
            uxRemoveNameButton.Enabled = true;
            uxNamesTextBox.ReadOnly = false;
        }

        private void UxRemoveNameButton_Click(object sender, EventArgs e)
        {
            if(names.Peek() != null)
            {
                string removed = names.Pop();
                uxRemovedText.Text = "Removed" + removed + " from the roster.";
            }
        }
    }
}
