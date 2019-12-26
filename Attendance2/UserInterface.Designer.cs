namespace Attendance
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.uxFileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.uxNewDate = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxRosterNameLabel = new System.Windows.Forms.Label();
            this.uxStartButton = new System.Windows.Forms.Button();
            this.uxNameTextBox = new System.Windows.Forms.TextBox();
            this.uxPresentButton = new System.Windows.Forms.Button();
            this.uxAbsentButton = new System.Windows.Forms.Button();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxPPLabel = new System.Windows.Forms.Label();
            this.uxPeoplePresentCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxPeopleAbsentLabel = new System.Windows.Forms.Label();
            this.uxAbsentCount = new System.Windows.Forms.Label();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxAttendanceStatus = new System.Windows.Forms.Label();
            this.uxSaveResults = new System.Windows.Forms.Button();
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxRoster = new System.Windows.Forms.Label();
            this.uxRosterNames = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.uxAttendanceStatusLabel = new System.Windows.Forms.Label();
            this.uxAbsentUnexcused = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxUnexcusedLabel = new System.Windows.Forms.Label();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Date:";
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileStrip});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.uxMenuStrip.TabIndex = 4;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // uxFileStrip
            // 
            this.uxFileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxNewDate});
            this.uxFileStrip.Name = "uxFileStrip";
            this.uxFileStrip.Size = new System.Drawing.Size(37, 20);
            this.uxFileStrip.Text = "File";
            // 
            // uxNewDate
            // 
            this.uxNewDate.Name = "uxNewDate";
            this.uxNewDate.Size = new System.Drawing.Size(155, 22);
            this.uxNewDate.Text = "Enter New Date";
            this.uxNewDate.Click += new System.EventHandler(this.UxNewDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Roster in use:";
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "openFileDialog1";
            // 
            // uxRosterNameLabel
            // 
            this.uxRosterNameLabel.AutoSize = true;
            this.uxRosterNameLabel.Location = new System.Drawing.Point(593, 39);
            this.uxRosterNameLabel.Name = "uxRosterNameLabel";
            this.uxRosterNameLabel.Size = new System.Drawing.Size(0, 13);
            this.uxRosterNameLabel.TabIndex = 5;
            // 
            // uxStartButton
            // 
            this.uxStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartButton.Location = new System.Drawing.Point(307, 128);
            this.uxStartButton.Name = "uxStartButton";
            this.uxStartButton.Size = new System.Drawing.Size(172, 59);
            this.uxStartButton.TabIndex = 6;
            this.uxStartButton.Text = "Start";
            this.uxStartButton.UseVisualStyleBackColor = true;
            this.uxStartButton.Click += new System.EventHandler(this.UxStartButton_Click);
            // 
            // uxNameTextBox
            // 
            this.uxNameTextBox.Location = new System.Drawing.Point(307, 229);
            this.uxNameTextBox.Multiline = true;
            this.uxNameTextBox.Name = "uxNameTextBox";
            this.uxNameTextBox.ReadOnly = true;
            this.uxNameTextBox.Size = new System.Drawing.Size(172, 38);
            this.uxNameTextBox.TabIndex = 7;
            // 
            // uxPresentButton
            // 
            this.uxPresentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPresentButton.Location = new System.Drawing.Point(307, 273);
            this.uxPresentButton.Name = "uxPresentButton";
            this.uxPresentButton.Size = new System.Drawing.Size(80, 57);
            this.uxPresentButton.TabIndex = 6;
            this.uxPresentButton.Text = "Present";
            this.uxPresentButton.UseVisualStyleBackColor = true;
            this.uxPresentButton.Click += new System.EventHandler(this.UxPresentButton_Click);
            // 
            // uxAbsentButton
            // 
            this.uxAbsentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAbsentButton.Location = new System.Drawing.Point(401, 273);
            this.uxAbsentButton.Name = "uxAbsentButton";
            this.uxAbsentButton.Size = new System.Drawing.Size(78, 57);
            this.uxAbsentButton.TabIndex = 6;
            this.uxAbsentButton.Text = "Absent";
            this.uxAbsentButton.UseVisualStyleBackColor = true;
            this.uxAbsentButton.Click += new System.EventHandler(this.UxAbsentButton_Click);
            // 
            // uxPPLabel
            // 
            this.uxPPLabel.AutoSize = true;
            this.uxPPLabel.Location = new System.Drawing.Point(16, 128);
            this.uxPPLabel.Name = "uxPPLabel";
            this.uxPPLabel.Size = new System.Drawing.Size(103, 13);
            this.uxPPLabel.TabIndex = 8;
            this.uxPPLabel.Text = "# of People present:";
            // 
            // uxPeoplePresentCount
            // 
            this.uxPeoplePresentCount.AutoSize = true;
            this.uxPeoplePresentCount.Location = new System.Drawing.Point(136, 128);
            this.uxPeoplePresentCount.Name = "uxPeoplePresentCount";
            this.uxPeoplePresentCount.Size = new System.Drawing.Size(0, 13);
            this.uxPeoplePresentCount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start will prompt you to open a .txt file full of names.";
            // 
            // uxPeopleAbsentLabel
            // 
            this.uxPeopleAbsentLabel.AutoSize = true;
            this.uxPeopleAbsentLabel.Location = new System.Drawing.Point(15, 153);
            this.uxPeopleAbsentLabel.Name = "uxPeopleAbsentLabel";
            this.uxPeopleAbsentLabel.Size = new System.Drawing.Size(100, 13);
            this.uxPeopleAbsentLabel.TabIndex = 8;
            this.uxPeopleAbsentLabel.Text = "# of People absent:";
            // 
            // uxAbsentCount
            // 
            this.uxAbsentCount.AutoSize = true;
            this.uxAbsentCount.Location = new System.Drawing.Point(117, 154);
            this.uxAbsentCount.Name = "uxAbsentCount";
            this.uxAbsentCount.Size = new System.Drawing.Size(0, 13);
            this.uxAbsentCount.TabIndex = 8;
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNameLabel.Location = new System.Drawing.Point(365, 206);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(55, 20);
            this.uxNameLabel.TabIndex = 10;
            this.uxNameLabel.Text = "Name:";
            // 
            // uxAttendanceStatus
            // 
            this.uxAttendanceStatus.AutoSize = true;
            this.uxAttendanceStatus.Location = new System.Drawing.Point(304, 343);
            this.uxAttendanceStatus.Name = "uxAttendanceStatus";
            this.uxAttendanceStatus.Size = new System.Drawing.Size(0, 13);
            this.uxAttendanceStatus.TabIndex = 10;
            // 
            // uxSaveResults
            // 
            this.uxSaveResults.Enabled = false;
            this.uxSaveResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveResults.Location = new System.Drawing.Point(485, 229);
            this.uxSaveResults.Name = "uxSaveResults";
            this.uxSaveResults.Size = new System.Drawing.Size(161, 99);
            this.uxSaveResults.TabIndex = 12;
            this.uxSaveResults.Text = "Save Results";
            this.uxSaveResults.UseVisualStyleBackColor = true;
            this.uxSaveResults.Click += new System.EventHandler(this.UxSaveResults_Click);
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.Location = new System.Drawing.Point(83, 42);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.uxDateTimePicker.TabIndex = 13;
            this.uxDateTimePicker.ValueChanged += new System.EventHandler(this.UxDateTimePicker_ValueChanged);
            // 
            // uxRoster
            // 
            this.uxRoster.AutoSize = true;
            this.uxRoster.Location = new System.Drawing.Point(12, 202);
            this.uxRoster.Name = "uxRoster";
            this.uxRoster.Size = new System.Drawing.Size(41, 13);
            this.uxRoster.TabIndex = 15;
            this.uxRoster.Text = "Roster:";
            // 
            // uxRosterNames
            // 
            this.uxRosterNames.Location = new System.Drawing.Point(12, 226);
            this.uxRosterNames.Multiline = true;
            this.uxRosterNames.Name = "uxRosterNames";
            this.uxRosterNames.Size = new System.Drawing.Size(79, 169);
            this.uxRosterNames.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 226);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 169);
            this.textBox2.TabIndex = 16;
            // 
            // uxAttendanceStatusLabel
            // 
            this.uxAttendanceStatusLabel.AutoSize = true;
            this.uxAttendanceStatusLabel.Location = new System.Drawing.Point(94, 206);
            this.uxAttendanceStatusLabel.Name = "uxAttendanceStatusLabel";
            this.uxAttendanceStatusLabel.Size = new System.Drawing.Size(84, 13);
            this.uxAttendanceStatusLabel.TabIndex = 15;
            this.uxAttendanceStatusLabel.Text = "Present/Absent:";
            // 
            // uxAbsentUnexcused
            // 
            this.uxAbsentUnexcused.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAbsentUnexcused.Location = new System.Drawing.Point(307, 336);
            this.uxAbsentUnexcused.Name = "uxAbsentUnexcused";
            this.uxAbsentUnexcused.Size = new System.Drawing.Size(172, 57);
            this.uxAbsentUnexcused.TabIndex = 6;
            this.uxAbsentUnexcused.Text = "Absent (Unexcused)";
            this.uxAbsentUnexcused.UseVisualStyleBackColor = true;
            this.uxAbsentUnexcused.Click += new System.EventHandler(this.UxAbsentButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 226);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 169);
            this.textBox1.TabIndex = 16;
            // 
            // uxUnexcusedLabel
            // 
            this.uxUnexcusedLabel.AutoSize = true;
            this.uxUnexcusedLabel.Location = new System.Drawing.Point(181, 206);
            this.uxUnexcusedLabel.Name = "uxUnexcusedLabel";
            this.uxUnexcusedLabel.Size = new System.Drawing.Size(64, 13);
            this.uxUnexcusedLabel.TabIndex = 15;
            this.uxUnexcusedLabel.Text = "Unexcused:";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.uxRosterNames);
            this.Controls.Add(this.uxAttendanceStatusLabel);
            this.Controls.Add(this.uxUnexcusedLabel);
            this.Controls.Add(this.uxRoster);
            this.Controls.Add(this.uxDateTimePicker);
            this.Controls.Add(this.uxSaveResults);
            this.Controls.Add(this.uxAttendanceStatus);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxPeoplePresentCount);
            this.Controls.Add(this.uxAbsentCount);
            this.Controls.Add(this.uxPeopleAbsentLabel);
            this.Controls.Add(this.uxPPLabel);
            this.Controls.Add(this.uxNameTextBox);
            this.Controls.Add(this.uxAbsentUnexcused);
            this.Controls.Add(this.uxAbsentButton);
            this.Controls.Add(this.uxPresentButton);
            this.Controls.Add(this.uxStartButton);
            this.Controls.Add(this.uxRosterNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "Attendance";
            this.Text = "Form1";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxFileStrip;
        private System.Windows.Forms.ToolStripMenuItem uxNewDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.Label uxRosterNameLabel;
        private System.Windows.Forms.Button uxStartButton;
        private System.Windows.Forms.TextBox uxNameTextBox;
        private System.Windows.Forms.Button uxPresentButton;
        private System.Windows.Forms.Button uxAbsentButton;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private System.Windows.Forms.Label uxPPLabel;
        private System.Windows.Forms.Label uxPeoplePresentCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label uxPeopleAbsentLabel;
        private System.Windows.Forms.Label uxAbsentCount;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.Label uxAttendanceStatus;
        private System.Windows.Forms.Button uxSaveResults;
        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
        private System.Windows.Forms.Label uxRoster;
        private System.Windows.Forms.TextBox uxRosterNames;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label uxAttendanceStatusLabel;
        private System.Windows.Forms.Button uxAbsentUnexcused;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label uxUnexcusedLabel;
    }
}