﻿namespace Attendance
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
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxUnexcused = new System.Windows.Forms.Button();
            this.uxRosterNamesTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.uxFilePreviewLabel = new System.Windows.Forms.Label();
            this.uxDataGridView = new System.Windows.Forms.DataGridView();
            this.uxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxColumnPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxUnexcusedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxDateLabel.Location = new System.Drawing.Point(10, 385);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(47, 19);
            this.uxDateLabel.TabIndex = 3;
            this.uxDateLabel.Text = "Date:";
            // 
            // uxCurrentRosterLabel
            // 
            this.uxCurrentRosterLabel.AutoSize = true;
            this.uxCurrentRosterLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxCurrentRosterLabel.Location = new System.Drawing.Point(10, 106);
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
            this.uxRosterNameLabel.Location = new System.Drawing.Point(122, 104);
            this.uxRosterNameLabel.Name = "uxRosterNameLabel";
            this.uxRosterNameLabel.Size = new System.Drawing.Size(0, 19);
            this.uxRosterNameLabel.TabIndex = 5;
            // 
            // uxNameTextBox
            // 
            this.uxNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxNameTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxNameTextBox.Location = new System.Drawing.Point(239, 63);
            this.uxNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxNameTextBox.Multiline = true;
            this.uxNameTextBox.Name = "uxNameTextBox";
            this.uxNameTextBox.ReadOnly = true;
            this.uxNameTextBox.Size = new System.Drawing.Size(280, 42);
            this.uxNameTextBox.TabIndex = 7;
            // 
            // uxPresentButton
            // 
            this.uxPresentButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxPresentButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxPresentButton.Location = new System.Drawing.Point(290, 129);
            this.uxPresentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxPresentButton.Name = "uxPresentButton";
            this.uxPresentButton.Size = new System.Drawing.Size(178, 47);
            this.uxPresentButton.TabIndex = 6;
            this.uxPresentButton.Text = "Present";
            this.uxPresentButton.UseVisualStyleBackColor = false;
            this.uxPresentButton.Click += new System.EventHandler(this.UxPresentButton_Click);
            // 
            // uxAbsentExcusedButton
            // 
            this.uxAbsentExcusedButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxAbsentExcusedButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxAbsentExcusedButton.Location = new System.Drawing.Point(290, 195);
            this.uxAbsentExcusedButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxAbsentExcusedButton.Name = "uxAbsentExcusedButton";
            this.uxAbsentExcusedButton.Size = new System.Drawing.Size(178, 46);
            this.uxAbsentExcusedButton.TabIndex = 6;
            this.uxAbsentExcusedButton.Text = "Absent (Excused)";
            this.uxAbsentExcusedButton.UseVisualStyleBackColor = false;
            this.uxAbsentExcusedButton.Click += new System.EventHandler(this.UxAbsentButton_Click);
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxNameLabel.Location = new System.Drawing.Point(350, 40);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(56, 19);
            this.uxNameLabel.TabIndex = 10;
            this.uxNameLabel.Text = "Name:";
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.Font = new System.Drawing.Font("Tahoma", 8F);
            this.uxDateTimePicker.Location = new System.Drawing.Point(66, 385);
            this.uxDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.Size = new System.Drawing.Size(218, 20);
            this.uxDateTimePicker.TabIndex = 13;
            this.uxDateTimePicker.ValueChanged += new System.EventHandler(this.UxDateTimePicker_ValueChanged);
            // 
            // uxUnexcused
            // 
            this.uxUnexcused.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxUnexcused.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxUnexcused.Location = new System.Drawing.Point(290, 263);
            this.uxUnexcused.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxUnexcused.Name = "uxUnexcused";
            this.uxUnexcused.Size = new System.Drawing.Size(178, 46);
            this.uxUnexcused.TabIndex = 17;
            this.uxUnexcused.Text = "Absent (Unexcused)";
            this.uxUnexcused.UseVisualStyleBackColor = false;
            this.uxUnexcused.Click += new System.EventHandler(this.UxUnexcused_Click);
            // 
            // uxRosterNamesTextBox
            // 
            this.uxRosterNamesTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxRosterNamesTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxRosterNamesTextBox.Location = new System.Drawing.Point(11, 129);
            this.uxRosterNamesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxRosterNamesTextBox.Multiline = true;
            this.uxRosterNamesTextBox.Name = "uxRosterNamesTextBox";
            this.uxRosterNamesTextBox.ReadOnly = true;
            this.uxRosterNamesTextBox.Size = new System.Drawing.Size(273, 248);
            this.uxRosterNamesTextBox.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
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
            // uxFilePreviewLabel
            // 
            this.uxFilePreviewLabel.AutoSize = true;
            this.uxFilePreviewLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxFilePreviewLabel.Location = new System.Drawing.Point(470, 109);
            this.uxFilePreviewLabel.Name = "uxFilePreviewLabel";
            this.uxFilePreviewLabel.Size = new System.Drawing.Size(99, 19);
            this.uxFilePreviewLabel.TabIndex = 5;
            this.uxFilePreviewLabel.Text = "File Preview:";
            // 
            // uxDataGridView
            // 
            this.uxDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uxDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uxColumnName,
            this.uxColumnPresent,
            this.uxUnexcusedColumn});
            this.uxDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.uxDataGridView.Location = new System.Drawing.Point(474, 129);
            this.uxDataGridView.Name = "uxDataGridView";
            this.uxDataGridView.ReadOnly = true;
            this.uxDataGridView.Size = new System.Drawing.Size(281, 248);
            this.uxDataGridView.TabIndex = 21;
            this.uxDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UxDataGridView_KeyPress);
            // 
            // uxColumnName
            // 
            this.uxColumnName.HeaderText = "Name";
            this.uxColumnName.Name = "uxColumnName";
            this.uxColumnName.ReadOnly = true;
            // 
            // uxColumnPresent
            // 
            this.uxColumnPresent.HeaderText = "Present";
            this.uxColumnPresent.Name = "uxColumnPresent";
            this.uxColumnPresent.ReadOnly = true;
            // 
            // uxUnexcusedColumn
            // 
            this.uxUnexcusedColumn.HeaderText = "Unexcused";
            this.uxUnexcusedColumn.Name = "uxUnexcusedColumn";
            this.uxUnexcusedColumn.ReadOnly = true;
            // 
            // Attendance3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 418);
            this.Controls.Add(this.uxDataGridView);
            this.Controls.Add(this.uxRosterNamesTextBox);
            this.Controls.Add(this.uxUnexcused);
            this.Controls.Add(this.uxDateTimePicker);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxNameTextBox);
            this.Controls.Add(this.uxAbsentExcusedButton);
            this.Controls.Add(this.uxPresentButton);
            this.Controls.Add(this.uxFilePreviewLabel);
            this.Controls.Add(this.uxRosterNameLabel);
            this.Controls.Add(this.uxCurrentRosterLabel);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Attendance3";
            this.Text = "Attendance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridView)).EndInit();
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
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
        private System.Windows.Forms.Button uxUnexcused;
        private System.Windows.Forms.TextBox uxRosterNamesTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importRosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxSaveToolStrip;
        private System.Windows.Forms.Label uxFilePreviewLabel;
        private System.Windows.Forms.DataGridView uxDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxColumnPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxUnexcusedColumn;
    }
}