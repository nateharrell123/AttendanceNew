namespace Attendance2
{
    partial class CreateRoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoster));
            this.label1 = new System.Windows.Forms.Label();
            this.uxPictureBox = new System.Windows.Forms.PictureBox();
            this.uxPictureLabel = new System.Windows.Forms.Label();
            this.uxFileContentsTextBox = new System.Windows.Forms.TextBox();
            this.uxFilePreviewText = new System.Windows.Forms.Label();
            this.uxNamesTextBox = new System.Windows.Forms.TextBox();
            this.uxEnterInstructionsLabel = new System.Windows.Forms.Label();
            this.uxRemoveNameButton = new System.Windows.Forms.Button();
            this.uxRemovedText = new System.Windows.Forms.Label();
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxExportRoster = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxFinalizeRoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxPictureBox)).BeginInit();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // uxPictureBox
            // 
            this.uxPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("uxPictureBox.Image")));
            this.uxPictureBox.Location = new System.Drawing.Point(12, 57);
            this.uxPictureBox.Name = "uxPictureBox";
            this.uxPictureBox.Size = new System.Drawing.Size(142, 108);
            this.uxPictureBox.TabIndex = 2;
            this.uxPictureBox.TabStop = false;
            // 
            // uxPictureLabel
            // 
            this.uxPictureLabel.AutoSize = true;
            this.uxPictureLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxPictureLabel.Location = new System.Drawing.Point(8, 35);
            this.uxPictureLabel.Name = "uxPictureLabel";
            this.uxPictureLabel.Size = new System.Drawing.Size(75, 19);
            this.uxPictureLabel.TabIndex = 1;
            this.uxPictureLabel.Text = "Example:";
            // 
            // uxFileContentsTextBox
            // 
            this.uxFileContentsTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxFileContentsTextBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.uxFileContentsTextBox.Location = new System.Drawing.Point(271, 57);
            this.uxFileContentsTextBox.Multiline = true;
            this.uxFileContentsTextBox.Name = "uxFileContentsTextBox";
            this.uxFileContentsTextBox.ReadOnly = true;
            this.uxFileContentsTextBox.Size = new System.Drawing.Size(187, 346);
            this.uxFileContentsTextBox.TabIndex = 5;
            this.uxFileContentsTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.UxFileContentsTextBox_PreviewKeyDown);
            // 
            // uxFilePreviewText
            // 
            this.uxFilePreviewText.AutoSize = true;
            this.uxFilePreviewText.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxFilePreviewText.Location = new System.Drawing.Point(267, 35);
            this.uxFilePreviewText.Name = "uxFilePreviewText";
            this.uxFilePreviewText.Size = new System.Drawing.Size(99, 19);
            this.uxFilePreviewText.TabIndex = 1;
            this.uxFilePreviewText.Text = "File Preview:";
            // 
            // uxNamesTextBox
            // 
            this.uxNamesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNamesTextBox.Location = new System.Drawing.Point(12, 193);
            this.uxNamesTextBox.Multiline = true;
            this.uxNamesTextBox.Name = "uxNamesTextBox";
            this.uxNamesTextBox.Size = new System.Drawing.Size(253, 30);
            this.uxNamesTextBox.TabIndex = 6;
            this.uxNamesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxNamesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyDown);
            // 
            // uxEnterInstructionsLabel
            // 
            this.uxEnterInstructionsLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxEnterInstructionsLabel.Location = new System.Drawing.Point(8, 174);
            this.uxEnterInstructionsLabel.Name = "uxEnterInstructionsLabel";
            this.uxEnterInstructionsLabel.Size = new System.Drawing.Size(226, 55);
            this.uxEnterInstructionsLabel.TabIndex = 1;
            this.uxEnterInstructionsLabel.Text = "Press Enter to add a name:";
            // 
            // uxRemoveNameButton
            // 
            this.uxRemoveNameButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxRemoveNameButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxRemoveNameButton.Location = new System.Drawing.Point(12, 232);
            this.uxRemoveNameButton.Name = "uxRemoveNameButton";
            this.uxRemoveNameButton.Size = new System.Drawing.Size(253, 53);
            this.uxRemoveNameButton.TabIndex = 4;
            this.uxRemoveNameButton.Text = "Remove Name";
            this.uxRemoveNameButton.UseVisualStyleBackColor = false;
            this.uxRemoveNameButton.Click += new System.EventHandler(this.UxRemoveNameButton_Click);
            // 
            // uxRemovedText
            // 
            this.uxRemovedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemovedText.Location = new System.Drawing.Point(12, 285);
            this.uxRemovedText.Name = "uxRemovedText";
            this.uxRemovedText.Size = new System.Drawing.Size(253, 34);
            this.uxRemovedText.TabIndex = 1;
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(470, 24);
            this.uxMenuStrip.TabIndex = 7;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.uxExportRoster});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click);
            // 
            // uxExportRoster
            // 
            this.uxExportRoster.Name = "uxExportRoster";
            this.uxExportRoster.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.uxExportRoster.Size = new System.Drawing.Size(183, 22);
            this.uxExportRoster.Text = "Export Roster";
            this.uxExportRoster.Click += new System.EventHandler(this.UxExportRoster_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adjustRosterToolStripMenuItem,
            this.clearRosterToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // adjustRosterToolStripMenuItem
            // 
            this.adjustRosterToolStripMenuItem.Name = "adjustRosterToolStripMenuItem";
            this.adjustRosterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.adjustRosterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adjustRosterToolStripMenuItem.Text = "Edit Roster";
            this.adjustRosterToolStripMenuItem.Click += new System.EventHandler(this.AdjustRosterToolStripMenuItem_Click);
            // 
            // clearRosterToolStripMenuItem
            // 
            this.clearRosterToolStripMenuItem.Name = "clearRosterToolStripMenuItem";
            this.clearRosterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.clearRosterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearRosterToolStripMenuItem.Text = "Clear Roster";
            this.clearRosterToolStripMenuItem.Click += new System.EventHandler(this.ClearRosterToolStripMenuItem_Click);
            // 
            // uxFinalizeRoster
            // 
            this.uxFinalizeRoster.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxFinalizeRoster.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxFinalizeRoster.Location = new System.Drawing.Point(12, 350);
            this.uxFinalizeRoster.Name = "uxFinalizeRoster";
            this.uxFinalizeRoster.Size = new System.Drawing.Size(253, 53);
            this.uxFinalizeRoster.TabIndex = 8;
            this.uxFinalizeRoster.Text = "Finalize Roster";
            this.uxFinalizeRoster.UseVisualStyleBackColor = false;
            this.uxFinalizeRoster.Click += new System.EventHandler(this.UxFinalizeRoster_Click);
            // 
            // CreateRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 419);
            this.Controls.Add(this.uxFinalizeRoster);
            this.Controls.Add(this.uxNamesTextBox);
            this.Controls.Add(this.uxFileContentsTextBox);
            this.Controls.Add(this.uxRemoveNameButton);
            this.Controls.Add(this.uxPictureBox);
            this.Controls.Add(this.uxFilePreviewText);
            this.Controls.Add(this.uxPictureLabel);
            this.Controls.Add(this.uxRemovedText);
            this.Controls.Add(this.uxEnterInstructionsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.uxMenuStrip;
            this.MaximizeBox = false;
            this.Name = "CreateRoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateRoster";
            ((System.ComponentModel.ISupportInitialize)(this.uxPictureBox)).EndInit();
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox uxPictureBox;
        private System.Windows.Forms.Label uxPictureLabel;
        private System.Windows.Forms.TextBox uxFileContentsTextBox;
        private System.Windows.Forms.Label uxFilePreviewText;
        private System.Windows.Forms.TextBox uxNamesTextBox;
        private System.Windows.Forms.Label uxEnterInstructionsLabel;
        private System.Windows.Forms.Button uxRemoveNameButton;
        private System.Windows.Forms.Label uxRemovedText;
        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxExportRoster;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.Button uxFinalizeRoster;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustRosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearRosterToolStripMenuItem;
    }
}