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
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxCurrentRosterLabel = new System.Windows.Forms.Label();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxRosterNameLabel = new System.Windows.Forms.Label();
            this.uxNameTextBox = new System.Windows.Forms.TextBox();
            this.uxPresentButton = new System.Windows.Forms.Button();
            this.uxAbsentExcusedButton = new System.Windows.Forms.Button();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxPPLabel = new System.Windows.Forms.Label();
            this.uxPeoplePresentCount = new System.Windows.Forms.Label();
            this.uxPeopleAbsentLabel = new System.Windows.Forms.Label();
            this.uxAbsentCount = new System.Windows.Forms.Label();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxUnexcused = new System.Windows.Forms.Button();
            this.uxRosterNamesTextBox = new System.Windows.Forms.TextBox();
            this.uxAbsentttUnexcused = new System.Windows.Forms.Label();
            this.uxAbsentUnexcused = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.uxFilePreviewTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxDateLabel.Location = new System.Drawing.Point(13, 326);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(47, 19);
            this.uxDateLabel.TabIndex = 3;
            this.uxDateLabel.Text = "Date:";
            // 
            // uxCurrentRosterLabel
            // 
            this.uxCurrentRosterLabel.AutoSize = true;
            this.uxCurrentRosterLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxCurrentRosterLabel.Location = new System.Drawing.Point(12, 80);
            this.uxCurrentRosterLabel.Name = "uxCurrentRosterLabel";
            this.uxCurrentRosterLabel.Size = new System.Drawing.Size(107, 19);
            this.uxCurrentRosterLabel.TabIndex = 5;
            this.uxCurrentRosterLabel.Text = "Roster in use:";
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = " ";
            // 
            // uxRosterNameLabel
            // 
            this.uxRosterNameLabel.AutoSize = true;
            this.uxRosterNameLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxRosterNameLabel.Location = new System.Drawing.Point(117, 80);
            this.uxRosterNameLabel.Name = "uxRosterNameLabel";
            this.uxRosterNameLabel.Size = new System.Drawing.Size(0, 19);
            this.uxRosterNameLabel.TabIndex = 5;
            // 
            // uxNameTextBox
            // 
            this.uxNameTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxNameTextBox.Location = new System.Drawing.Point(283, 66);
            this.uxNameTextBox.Multiline = true;
            this.uxNameTextBox.Name = "uxNameTextBox";
            this.uxNameTextBox.ReadOnly = true;
            this.uxNameTextBox.Size = new System.Drawing.Size(264, 35);
            this.uxNameTextBox.TabIndex = 7;
            // 
            // uxPresentButton
            // 
            this.uxPresentButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxPresentButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxPresentButton.Location = new System.Drawing.Point(257, 118);
            this.uxPresentButton.Name = "uxPresentButton";
            this.uxPresentButton.Size = new System.Drawing.Size(153, 52);
            this.uxPresentButton.TabIndex = 6;
            this.uxPresentButton.Text = "Present";
            this.uxPresentButton.UseVisualStyleBackColor = false;
            this.uxPresentButton.Click += new System.EventHandler(this.UxPresentButton_Click);
            // 
            // uxAbsentExcusedButton
            // 
            this.uxAbsentExcusedButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxAbsentExcusedButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxAbsentExcusedButton.Location = new System.Drawing.Point(257, 177);
            this.uxAbsentExcusedButton.Name = "uxAbsentExcusedButton";
            this.uxAbsentExcusedButton.Size = new System.Drawing.Size(153, 53);
            this.uxAbsentExcusedButton.TabIndex = 6;
            this.uxAbsentExcusedButton.Text = "Absent (Excused)";
            this.uxAbsentExcusedButton.UseVisualStyleBackColor = false;
            this.uxAbsentExcusedButton.Click += new System.EventHandler(this.UxAbsentButton_Click);
            // 
            // uxPPLabel
            // 
            this.uxPPLabel.AutoSize = true;
            this.uxPPLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxPPLabel.Location = new System.Drawing.Point(412, 139);
            this.uxPPLabel.Name = "uxPPLabel";
            this.uxPPLabel.Size = new System.Drawing.Size(67, 19);
            this.uxPPLabel.TabIndex = 8;
            this.uxPPLabel.Text = "Present:";
            // 
            // uxPeoplePresentCount
            // 
            this.uxPeoplePresentCount.AutoSize = true;
            this.uxPeoplePresentCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxPeoplePresentCount.Location = new System.Drawing.Point(479, 141);
            this.uxPeoplePresentCount.Name = "uxPeoplePresentCount";
            this.uxPeoplePresentCount.Size = new System.Drawing.Size(0, 19);
            this.uxPeoplePresentCount.TabIndex = 8;
            // 
            // uxPeopleAbsentLabel
            // 
            this.uxPeopleAbsentLabel.AutoSize = true;
            this.uxPeopleAbsentLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxPeopleAbsentLabel.Location = new System.Drawing.Point(412, 195);
            this.uxPeopleAbsentLabel.Name = "uxPeopleAbsentLabel";
            this.uxPeopleAbsentLabel.Size = new System.Drawing.Size(138, 19);
            this.uxPeopleAbsentLabel.TabIndex = 8;
            this.uxPeopleAbsentLabel.Text = "Absent (Excused):";
            // 
            // uxAbsentCount
            // 
            this.uxAbsentCount.AutoSize = true;
            this.uxAbsentCount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxAbsentCount.Location = new System.Drawing.Point(540, 198);
            this.uxAbsentCount.Name = "uxAbsentCount";
            this.uxAbsentCount.Size = new System.Drawing.Size(0, 19);
            this.uxAbsentCount.TabIndex = 8;
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxNameLabel.Location = new System.Drawing.Point(381, 43);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(56, 19);
            this.uxNameLabel.TabIndex = 10;
            this.uxNameLabel.Text = "Name:";
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.Font = new System.Drawing.Font("Tahoma", 8F);
            this.uxDateTimePicker.Location = new System.Drawing.Point(61, 326);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.Size = new System.Drawing.Size(188, 20);
            this.uxDateTimePicker.TabIndex = 13;
            this.uxDateTimePicker.ValueChanged += new System.EventHandler(this.UxDateTimePicker_ValueChanged);
            // 
            // uxUnexcused
            // 
            this.uxUnexcused.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxUnexcused.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxUnexcused.Location = new System.Drawing.Point(257, 236);
            this.uxUnexcused.Name = "uxUnexcused";
            this.uxUnexcused.Size = new System.Drawing.Size(153, 53);
            this.uxUnexcused.TabIndex = 17;
            this.uxUnexcused.Text = "Absent (Unexcused)";
            this.uxUnexcused.UseVisualStyleBackColor = false;
            this.uxUnexcused.Click += new System.EventHandler(this.UxUnexcused_Click);
            // 
            // uxRosterNamesTextBox
            // 
            this.uxRosterNamesTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxRosterNamesTextBox.Location = new System.Drawing.Point(14, 118);
            this.uxRosterNamesTextBox.Multiline = true;
            this.uxRosterNamesTextBox.Name = "uxRosterNamesTextBox";
            this.uxRosterNamesTextBox.ReadOnly = true;
            this.uxRosterNamesTextBox.Size = new System.Drawing.Size(235, 202);
            this.uxRosterNamesTextBox.TabIndex = 19;
            // 
            // uxAbsentttUnexcused
            // 
            this.uxAbsentttUnexcused.AutoSize = true;
            this.uxAbsentttUnexcused.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxAbsentttUnexcused.Location = new System.Drawing.Point(412, 249);
            this.uxAbsentttUnexcused.Name = "uxAbsentttUnexcused";
            this.uxAbsentttUnexcused.Size = new System.Drawing.Size(157, 19);
            this.uxAbsentttUnexcused.TabIndex = 8;
            this.uxAbsentttUnexcused.Text = "Absent (Unexcused):";
            // 
            // uxAbsentUnexcused
            // 
            this.uxAbsentUnexcused.AutoSize = true;
            this.uxAbsentUnexcused.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxAbsentUnexcused.Location = new System.Drawing.Point(556, 253);
            this.uxAbsentUnexcused.Name = "uxAbsentUnexcused";
            this.uxAbsentUnexcused.Size = new System.Drawing.Size(0, 19);
            this.uxAbsentUnexcused.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.importRosterToolStripMenuItem,
            this.uxSaveToolStrip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click_1);
            // 
            // importRosterToolStripMenuItem
            // 
            this.importRosterToolStripMenuItem.Name = "importRosterToolStripMenuItem";
            this.importRosterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importRosterToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.importRosterToolStripMenuItem.Text = "Import Roster";
            this.importRosterToolStripMenuItem.Click += new System.EventHandler(this.ImportRosterToolStripMenuItem_Click);
            // 
            // uxSaveToolStrip
            // 
            this.uxSaveToolStrip.Name = "uxSaveToolStrip";
            this.uxSaveToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.uxSaveToolStrip.Size = new System.Drawing.Size(187, 22);
            this.uxSaveToolStrip.Text = "Export Results";
            this.uxSaveToolStrip.Click += new System.EventHandler(this.UxSaveToolStrip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(575, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Preview:";
            // 
            // uxFilePreviewTextBox
            // 
            this.uxFilePreviewTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxFilePreviewTextBox.Location = new System.Drawing.Point(577, 118);
            this.uxFilePreviewTextBox.Multiline = true;
            this.uxFilePreviewTextBox.Name = "uxFilePreviewTextBox";
            this.uxFilePreviewTextBox.ReadOnly = true;
            this.uxFilePreviewTextBox.Size = new System.Drawing.Size(235, 212);
            this.uxFilePreviewTextBox.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button2.Location = new System.Drawing.Point(341, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 34);
            this.button2.TabIndex = 22;
            this.button2.Text = "Revise Results";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Attendance3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uxFilePreviewTextBox);
            this.Controls.Add(this.uxRosterNamesTextBox);
            this.Controls.Add(this.uxUnexcused);
            this.Controls.Add(this.uxDateTimePicker);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxPeoplePresentCount);
            this.Controls.Add(this.uxAbsentUnexcused);
            this.Controls.Add(this.uxAbsentCount);
            this.Controls.Add(this.uxAbsentttUnexcused);
            this.Controls.Add(this.uxPeopleAbsentLabel);
            this.Controls.Add(this.uxPPLabel);
            this.Controls.Add(this.uxNameTextBox);
            this.Controls.Add(this.uxAbsentExcusedButton);
            this.Controls.Add(this.uxPresentButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxRosterNameLabel);
            this.Controls.Add(this.uxCurrentRosterLabel);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Attendance3";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.Label uxCurrentRosterLabel;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.Label uxRosterNameLabel;
        private System.Windows.Forms.TextBox uxNameTextBox;
        private System.Windows.Forms.Button uxPresentButton;
        private System.Windows.Forms.Button uxAbsentExcusedButton;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private System.Windows.Forms.Label uxPPLabel;
        private System.Windows.Forms.Label uxPeoplePresentCount;
        private System.Windows.Forms.Label uxPeopleAbsentLabel;
        private System.Windows.Forms.Label uxAbsentCount;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
        private System.Windows.Forms.Button uxUnexcused;
        private System.Windows.Forms.TextBox uxRosterNamesTextBox;
        private System.Windows.Forms.Label uxAbsentttUnexcused;
        private System.Windows.Forms.Label uxAbsentUnexcused;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importRosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxSaveToolStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxFilePreviewTextBox;
        private System.Windows.Forms.Button button2;
    }
}