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
    public partial class CreateRoster : Form
    {
        public CreateRoster()
        {
            InitializeComponent();
        }

        private void UxYesButton_Click(object sender, EventArgs e)
        {
            Attendance3 attendance = new Attendance3();
            CreateRoster.ActiveForm.Hide();
            attendance.Show();
        }
    }
}
