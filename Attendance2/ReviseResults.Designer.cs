namespace Attendance2
{
    partial class ReviseResults
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
            this.uxFilePreviewTextBox = new System.Windows.Forms.TextBox();
            this.uxFilePreviewLabel = new System.Windows.Forms.Label();
            this.uxSubmitChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxFilePreviewTextBox
            // 
            this.uxFilePreviewTextBox.Location = new System.Drawing.Point(12, 36);
            this.uxFilePreviewTextBox.Multiline = true;
            this.uxFilePreviewTextBox.Name = "uxFilePreviewTextBox";
            this.uxFilePreviewTextBox.Size = new System.Drawing.Size(373, 335);
            this.uxFilePreviewTextBox.TabIndex = 0;
            // 
            // uxFilePreviewLabel
            // 
            this.uxFilePreviewLabel.AutoSize = true;
            this.uxFilePreviewLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxFilePreviewLabel.Location = new System.Drawing.Point(12, 12);
            this.uxFilePreviewLabel.Name = "uxFilePreviewLabel";
            this.uxFilePreviewLabel.Size = new System.Drawing.Size(99, 19);
            this.uxFilePreviewLabel.TabIndex = 1;
            this.uxFilePreviewLabel.Text = "File Preview:";
            // 
            // uxSubmitChangesButton
            // 
            this.uxSubmitChangesButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxSubmitChangesButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxSubmitChangesButton.Location = new System.Drawing.Point(189, 377);
            this.uxSubmitChangesButton.Name = "uxSubmitChangesButton";
            this.uxSubmitChangesButton.Size = new System.Drawing.Size(196, 59);
            this.uxSubmitChangesButton.TabIndex = 2;
            this.uxSubmitChangesButton.Text = "Submit Changes";
            this.uxSubmitChangesButton.UseVisualStyleBackColor = false;
            // 
            // ReviseResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 458);
            this.Controls.Add(this.uxSubmitChangesButton);
            this.Controls.Add(this.uxFilePreviewLabel);
            this.Controls.Add(this.uxFilePreviewTextBox);
            this.Name = "ReviseResults";
            this.Text = "ReviseResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxFilePreviewTextBox;
        private System.Windows.Forms.Label uxFilePreviewLabel;
        private System.Windows.Forms.Button uxSubmitChangesButton;
    }
}