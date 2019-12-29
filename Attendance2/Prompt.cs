using Attendance;
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
    public partial class Prompt : Form
    {
        public Prompt()
        {
            InitializeComponent();
        }

        private void UxYesButton_Click(object sender, EventArgs e)
        {
            Attendance3 attendance = new Attendance3();
            ActiveForm.Hide();
            attendance.Show();
        }

        private void UxNoButton_Click(object sender, EventArgs e)
        {
            CreateRoster createRoster = new CreateRoster();
            ActiveForm.Hide();
            createRoster.Show();
        }
    }
}
