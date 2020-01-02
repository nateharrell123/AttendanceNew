namespace Attendance
{
    partial class Attendance3
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
            this.label3 = new System.Windows.Forms.Label();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxRosterNameLabel = new System.Windows.Forms.Label();
            this.uxStartButton = new System.Windows.Forms.Button();
            this.uxNameTextBox = new System.Windows.Forms.TextBox();
            this.uxPresentButton = new System.Windows.Forms.Button();
            this.uxAbsentExcusedButton = new System.Windows.Forms.Button();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxPPLabel = new System.Windows.Forms.Label();
            this.uxPeoplePresentCount = new System.Windows.Forms.Label();
            this.uxStartLabel = new System.Windows.Forms.Label();
            this.uxPeopleAbsentLabel = new System.Windows.Forms.Label();
            this.uxAbsentCount = new System.Windows.Forms.Label();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxAttendanceStatus = new System.Windows.Forms.Label();
            this.uxSaveResults = new System.Windows.Forms.Button();
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxUnexcused = new System.Windows.Forms.Button();
            this.uxDontHaveRosterButton = new System.Windows.Forms.Button();
            this.uxRosterNamesTextBox = new System.Windows.Forms.TextBox();
            this.uxAbsentttUnexcused = new System.Windows.Forms.Label();
            this.uxAbsentUnexcused = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
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
            this.uxRosterNameLabel.Location = new System.Drawing.Point(90, 108);
            this.uxRosterNameLabel.Name = "uxRosterNameLabel";
            this.uxRosterNameLabel.Size = new System.Drawing.Size(0, 13);
            this.uxRosterNameLabel.TabIndex = 5;
            // 
            // uxStartButton
            // 
            this.uxStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartButton.Location = new System.Drawing.Point(307, 131);
            this.uxStartButton.Name = "uxStartButton";
            this.uxStartButton.Size = new System.Drawing.Size(172, 59);
            this.uxStartButton.TabIndex = 6;
            this.uxStartButton.Text = "Start";
            this.uxStartButton.UseVisualStyleBackColor = true;
            this.uxStartButton.Click += new System.EventHandler(this.UxStartButton_Click);
            // 
            // uxNameTextBox
            // 
            this.uxNameTextBox.Location = new System.Drawing.Point(307, 232);
            this.uxNameTextBox.Multiline = true;
            this.uxNameTextBox.Name = "uxNameTextBox";
            this.uxNameTextBox.ReadOnly = true;
            this.uxNameTextBox.Size = new System.Drawing.Size(172, 38);
            this.uxNameTextBox.TabIndex = 7;
            // 
            // uxPresentButton
            // 
            this.uxPresentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPresentButton.Location = new System.Drawing.Point(307, 276);
            this.uxPresentButton.Name = "uxPresentButton";
            this.uxPresentButton.Size = new System.Drawing.Size(80, 57);
            this.uxPresentButton.TabIndex = 6;
            this.uxPresentButton.Text = "Present";
            this.uxPresentButton.UseVisualStyleBackColor = true;
            this.uxPresentButton.Click += new System.EventHandler(this.UxPresentButton_Click);
            // 
            // uxAbsentExcusedButton
            // 
            this.uxAbsentExcusedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAbsentExcusedButton.Location = new System.Drawing.Point(393, 276);
            this.uxAbsentExcusedButton.Name = "uxAbsentExcusedButton";
            this.uxAbsentExcusedButton.Size = new System.Drawing.Size(86, 57);
            this.uxAbsentExcusedButton.TabIndex = 6;
            this.uxAbsentExcusedButton.Text = "Absent (Excused)";
            this.uxAbsentExcusedButton.UseVisualStyleBackColor = true;
            this.uxAbsentExcusedButton.Click += new System.EventHandler(this.UxAbsentButton_Click);
            // 
            // uxPPLabel
            // 
            this.uxPPLabel.AutoSize = true;
            this.uxPPLabel.Location = new System.Drawing.Point(485, 145);
            this.uxPPLabel.Name = "uxPPLabel";
            this.uxPPLabel.Size = new System.Drawing.Size(103, 13);
            this.uxPPLabel.TabIndex = 8;
            this.uxPPLabel.Text = "# of People present:";
            // 
            // uxPeoplePresentCount
            // 
            this.uxPeoplePresentCount.AutoSize = true;
            this.uxPeoplePresentCount.Location = new System.Drawing.Point(605, 142);
            this.uxPeoplePresentCount.Name = "uxPeoplePresentCount";
            this.uxPeoplePresentCount.Size = new System.Drawing.Size(0, 13);
            this.uxPeoplePresentCount.TabIndex = 8;
            // 
            // uxStartLabel
            // 
            this.uxStartLabel.AutoSize = true;
            this.uxStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartLabel.Location = new System.Drawing.Point(307, 108);
            this.uxStartLabel.Name = "uxStartLabel";
            this.uxStartLabel.Size = new System.Drawing.Size(292, 20);
            this.uxStartLabel.TabIndex = 9;
            this.uxStartLabel.Text = "Start will prompt you to open your roster.";
            // 
            // uxPeopleAbsentLabel
            // 
            this.uxPeopleAbsentLabel.AutoSize = true;
            this.uxPeopleAbsentLabel.Location = new System.Drawing.Point(484, 170);
            this.uxPeopleAbsentLabel.Name = "uxPeopleAbsentLabel";
            this.uxPeopleAbsentLabel.Size = new System.Drawing.Size(100, 13);
            this.uxPeopleAbsentLabel.TabIndex = 8;
            this.uxPeopleAbsentLabel.Text = "# of People absent:";
            // 
            // uxAbsentCount
            // 
            this.uxAbsentCount.AutoSize = true;
            this.uxAbsentCount.Location = new System.Drawing.Point(586, 168);
            this.uxAbsentCount.Name = "uxAbsentCount";
            this.uxAbsentCount.Size = new System.Drawing.Size(0, 13);
            this.uxAbsentCount.TabIndex = 8;
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNameLabel.Location = new System.Drawing.Point(365, 209);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(55, 20);
            this.uxNameLabel.TabIndex = 10;
            this.uxNameLabel.Text = "Name:";
            // 
            // uxAttendanceStatus
            // 
            this.uxAttendanceStatus.AutoSize = true;
            this.uxAttendanceStatus.Location = new System.Drawing.Point(304, 396);
            this.uxAttendanceStatus.Name = "uxAttendanceStatus";
            this.uxAttendanceStatus.Size = new System.Drawing.Size(0, 13);
            this.uxAttendanceStatus.TabIndex = 10;
            // 
            // uxSaveResults
            // 
            this.uxSaveResults.Enabled = false;
            this.uxSaveResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveResults.Location = new System.Drawing.Point(608, 339);
            this.uxSaveResults.Name = "uxSaveResults";
            this.uxSaveResults.Size = new System.Drawing.Size(161, 99);
            this.uxSaveResults.TabIndex = 12;
            this.uxSaveResults.Text = "Save Results";
            this.uxSaveResults.UseVisualStyleBackColor = true;
            this.uxSaveResults.Click += new System.EventHandler(this.UxSaveResults_Click);
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.Location = new System.Drawing.Point(78, 33);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.uxDateTimePicker.TabIndex = 13;
            this.uxDateTimePicker.ValueChanged += new System.EventHandler(this.UxDateTimePicker_ValueChanged);
            // 
            // uxUnexcused
            // 
            this.uxUnexcused.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUnexcused.Location = new System.Drawing.Point(307, 339);
            this.uxUnexcused.Name = "uxUnexcused";
            this.uxUnexcused.Size = new System.Drawing.Size(172, 48);
            this.uxUnexcused.TabIndex = 17;
            this.uxUnexcused.Text = "Absent (Unexcused)";
            this.uxUnexcused.UseVisualStyleBackColor = true;
            this.uxUnexcused.Click += new System.EventHandler(this.UxUnexcused_Click);
            // 
            // uxDontHaveRosterButton
            // 
            this.uxDontHaveRosterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDontHaveRosterButton.Location = new System.Drawing.Point(14, 335);
            this.uxDontHaveRosterButton.Name = "uxDontHaveRosterButton";
            this.uxDontHaveRosterButton.Size = new System.Drawing.Size(141, 103);
            this.uxDontHaveRosterButton.TabIndex = 18;
            this.uxDontHaveRosterButton.Text = "I don\'t have a roster";
            this.uxDontHaveRosterButton.UseVisualStyleBackColor = true;
            this.uxDontHaveRosterButton.Click += new System.EventHandler(this.UxDontHaveRosterButton_Click);
            // 
            // uxRosterNamesTextBox
            // 
            this.uxRosterNamesTextBox.Location = new System.Drawing.Point(14, 131);
            this.uxRosterNamesTextBox.Multiline = true;
            this.uxRosterNamesTextBox.Name = "uxRosterNamesTextBox";
            this.uxRosterNamesTextBox.Size = new System.Drawing.Size(287, 189);
            this.uxRosterNamesTextBox.TabIndex = 19;
            // 
            // uxAbsentttUnexcused
            // 
            this.uxAbsentttUnexcused.AutoSize = true;
            this.uxAbsentttUnexcused.Location = new System.Drawing.Point(484, 196);
            this.uxAbsentttUnexcused.Name = "uxAbsentttUnexcused";
            this.uxAbsentttUnexcused.Size = new System.Drawing.Size(158, 13);
            this.uxAbsentttUnexcused.TabIndex = 8;
            this.uxAbsentttUnexcused.Text = "# of People absent(unexcused):";
            // 
            // uxAbsentUnexcused
            // 
            this.uxAbsentUnexcused.AutoSize = true;
            this.uxAbsentUnexcused.Location = new System.Drawing.Point(648, 196);
            this.uxAbsentUnexcused.Name = "uxAbsentUnexcused";
            this.uxAbsentUnexcused.Size = new System.Drawing.Size(0, 13);
            this.uxAbsentUnexcused.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exportRosterToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click);
            // 
            // exportRosterToolStripMenuItem
            // 
            this.exportRosterToolStripMenuItem.Name = "exportRosterToolStripMenuItem";
            this.exportRosterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportRosterToolStripMenuItem.Text = "Export Roster";
            // 
            // Attendance3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxRosterNamesTextBox);
            this.Controls.Add(this.uxDontHaveRosterButton);
            this.Controls.Add(this.uxUnexcused);
            this.Controls.Add(this.uxDateTimePicker);
            this.Controls.Add(this.uxSaveResults);
            this.Controls.Add(this.uxAttendanceStatus);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxStartLabel);
            this.Controls.Add(this.uxPeoplePresentCount);
            this.Controls.Add(this.uxAbsentUnexcused);
            this.Controls.Add(this.uxAbsentCount);
            this.Controls.Add(this.uxAbsentttUnexcused);
            this.Controls.Add(this.uxPeopleAbsentLabel);
            this.Controls.Add(this.uxPPLabel);
            this.Controls.Add(this.uxNameTextBox);
            this.Controls.Add(this.uxAbsentExcusedButton);
            this.Controls.Add(this.uxPresentButton);
            this.Controls.Add(this.uxStartButton);
            this.Controls.Add(this.uxRosterNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Attendance3";
            this.Text = "Attendance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.Label uxRosterNameLabel;
        private System.Windows.Forms.Button uxStartButton;
        private System.Windows.Forms.TextBox uxNameTextBox;
        private System.Windows.Forms.Button uxPresentButton;
        private System.Windows.Forms.Button uxAbsentExcusedButton;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private System.Windows.Forms.Label uxPPLabel;
        private System.Windows.Forms.Label uxPeoplePresentCount;
        private System.Windows.Forms.Label uxStartLabel;
        private System.Windows.Forms.Label uxPeopleAbsentLabel;
        private System.Windows.Forms.Label uxAbsentCount;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.Label uxAttendanceStatus;
        private System.Windows.Forms.Button uxSaveResults;
        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
        private System.Windows.Forms.Button uxUnexcused;
        private System.Windows.Forms.Button uxDontHaveRosterButton;
        private System.Windows.Forms.TextBox uxRosterNamesTextBox;
        private System.Windows.Forms.Label uxAbsentttUnexcused;
        private System.Windows.Forms.Label uxAbsentUnexcused;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportRosterToolStripMenuItem;
    }
}