namespace Attendance
{
    partial class Form1
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
            this.uxDateText = new System.Windows.Forms.TextBox();
            this.uxDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxFileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.uxNewDate = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxImportRoster = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxRosterNameLabel = new System.Windows.Forms.Label();
            this.uxStartButton = new System.Windows.Forms.Button();
            this.uxCurrentTextBox = new System.Windows.Forms.TextBox();
            this.uxPresentButton = new System.Windows.Forms.Button();
            this.uxAbsentButton = new System.Windows.Forms.Button();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxPPLabel = new System.Windows.Forms.Label();
            this.uxPeoplePresentCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxPeopleAbsentLabel = new System.Windows.Forms.Label();
            this.uxAbsentCount = new System.Windows.Forms.Label();
            this.uxUpNextTextBox = new System.Windows.Forms.TextBox();
            this.uxUpNextLabel = new System.Windows.Forms.Label();
            this.uxCurrentLabel = new System.Windows.Forms.Label();
            this.uxAttendanceStatus = new System.Windows.Forms.Label();
            this.uxPeoplePresentDebug = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxDateText
            // 
            this.uxDateText.Location = new System.Drawing.Point(78, 39);
            this.uxDateText.Multiline = true;
            this.uxDateText.Name = "uxDateText";
            this.uxDateText.Size = new System.Drawing.Size(139, 32);
            this.uxDateText.TabIndex = 0;
            this.uxDateText.TextChanged += new System.EventHandler(this.UxDateText_TextChanged);
            // 
            // uxDate
            // 
            this.uxDate.AutoSize = true;
            this.uxDate.Location = new System.Drawing.Point(111, 85);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(0, 13);
            this.uxDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Today\'s Date:";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uxFileStrip
            // 
            this.uxFileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxNewDate,
            this.saveResultsToolStripMenuItem,
            this.uxImportRoster});
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
            // saveResultsToolStripMenuItem
            // 
            this.saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
            this.saveResultsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveResultsToolStripMenuItem.Text = "Save Results";
            // 
            // uxImportRoster
            // 
            this.uxImportRoster.Name = "uxImportRoster";
            this.uxImportRoster.Size = new System.Drawing.Size(155, 22);
            this.uxImportRoster.Text = "Import Roster";
            this.uxImportRoster.Click += new System.EventHandler(this.UxImportRoster_Click);
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
            // uxCurrentTextBox
            // 
            this.uxCurrentTextBox.Location = new System.Drawing.Point(307, 229);
            this.uxCurrentTextBox.Multiline = true;
            this.uxCurrentTextBox.Name = "uxCurrentTextBox";
            this.uxCurrentTextBox.ReadOnly = true;
            this.uxCurrentTextBox.Size = new System.Drawing.Size(80, 38);
            this.uxCurrentTextBox.TabIndex = 7;
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
            this.label4.Location = new System.Drawing.Point(485, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start will prompt you to open a .txt file full of names.";
            // 
            // uxPeopleAbsentLabel
            // 
            this.uxPeopleAbsentLabel.AutoSize = true;
            this.uxPeopleAbsentLabel.Location = new System.Drawing.Point(16, 154);
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
            // uxUpNextTextBox
            // 
            this.uxUpNextTextBox.Location = new System.Drawing.Point(401, 229);
            this.uxUpNextTextBox.Multiline = true;
            this.uxUpNextTextBox.Name = "uxUpNextTextBox";
            this.uxUpNextTextBox.ReadOnly = true;
            this.uxUpNextTextBox.Size = new System.Drawing.Size(78, 38);
            this.uxUpNextTextBox.TabIndex = 7;
            // 
            // uxUpNextLabel
            // 
            this.uxUpNextLabel.AutoSize = true;
            this.uxUpNextLabel.Location = new System.Drawing.Point(398, 203);
            this.uxUpNextLabel.Name = "uxUpNextLabel";
            this.uxUpNextLabel.Size = new System.Drawing.Size(49, 13);
            this.uxUpNextLabel.TabIndex = 10;
            this.uxUpNextLabel.Text = "Up Next:";
            // 
            // uxCurrentLabel
            // 
            this.uxCurrentLabel.AutoSize = true;
            this.uxCurrentLabel.Location = new System.Drawing.Point(304, 203);
            this.uxCurrentLabel.Name = "uxCurrentLabel";
            this.uxCurrentLabel.Size = new System.Drawing.Size(32, 13);
            this.uxCurrentLabel.TabIndex = 10;
            this.uxCurrentLabel.Text = "Start:";
            // 
            // uxAttendanceStatus
            // 
            this.uxAttendanceStatus.AutoSize = true;
            this.uxAttendanceStatus.Location = new System.Drawing.Point(304, 343);
            this.uxAttendanceStatus.Name = "uxAttendanceStatus";
            this.uxAttendanceStatus.Size = new System.Drawing.Size(0, 13);
            this.uxAttendanceStatus.TabIndex = 10;
            // 
            // uxPeoplePresentDebug
            // 
            this.uxPeoplePresentDebug.Location = new System.Drawing.Point(12, 177);
            this.uxPeoplePresentDebug.Multiline = true;
            this.uxPeoplePresentDebug.Name = "uxPeoplePresentDebug";
            this.uxPeoplePresentDebug.Size = new System.Drawing.Size(241, 153);
            this.uxPeoplePresentDebug.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxPeoplePresentDebug);
            this.Controls.Add(this.uxAttendanceStatus);
            this.Controls.Add(this.uxCurrentLabel);
            this.Controls.Add(this.uxUpNextLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxPeoplePresentCount);
            this.Controls.Add(this.uxAbsentCount);
            this.Controls.Add(this.uxPeopleAbsentLabel);
            this.Controls.Add(this.uxPPLabel);
            this.Controls.Add(this.uxUpNextTextBox);
            this.Controls.Add(this.uxCurrentTextBox);
            this.Controls.Add(this.uxAbsentButton);
            this.Controls.Add(this.uxPresentButton);
            this.Controls.Add(this.uxStartButton);
            this.Controls.Add(this.uxRosterNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.uxDateText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxDateText;
        private System.Windows.Forms.Label uxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxFileStrip;
        private System.Windows.Forms.ToolStripMenuItem uxNewDate;
        private System.Windows.Forms.ToolStripMenuItem saveResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxImportRoster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.Label uxRosterNameLabel;
        private System.Windows.Forms.Button uxStartButton;
        private System.Windows.Forms.TextBox uxCurrentTextBox;
        private System.Windows.Forms.Button uxPresentButton;
        private System.Windows.Forms.Button uxAbsentButton;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private System.Windows.Forms.Label uxPPLabel;
        private System.Windows.Forms.Label uxPeoplePresentCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label uxPeopleAbsentLabel;
        private System.Windows.Forms.Label uxAbsentCount;
        private System.Windows.Forms.TextBox uxUpNextTextBox;
        private System.Windows.Forms.Label uxUpNextLabel;
        private System.Windows.Forms.Label uxCurrentLabel;
        private System.Windows.Forms.Label uxAttendanceStatus;
        private System.Windows.Forms.TextBox uxPeoplePresentDebug;
    }
}