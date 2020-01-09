namespace Attendance2
{
    partial class Prompt
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
            this.uxStartedLabel = new System.Windows.Forms.Label();
            this.uxPromptLabel = new System.Windows.Forms.Label();
            this.uxYesButton = new System.Windows.Forms.Button();
            this.uxNoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxStartedLabel
            // 
            this.uxStartedLabel.AutoSize = true;
            this.uxStartedLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxStartedLabel.Location = new System.Drawing.Point(66, 24);
            this.uxStartedLabel.Name = "uxStartedLabel";
            this.uxStartedLabel.Size = new System.Drawing.Size(0, 19);
            this.uxStartedLabel.TabIndex = 0;
            // 
            // uxPromptLabel
            // 
            this.uxPromptLabel.AutoSize = true;
            this.uxPromptLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxPromptLabel.Location = new System.Drawing.Point(81, 24);
            this.uxPromptLabel.Name = "uxPromptLabel";
            this.uxPromptLabel.Size = new System.Drawing.Size(133, 19);
            this.uxPromptLabel.TabIndex = 1;
            this.uxPromptLabel.Text = "Quick Attendance";
            // 
            // uxYesButton
            // 
            this.uxYesButton.BackColor = System.Drawing.Color.White;
            this.uxYesButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxYesButton.Location = new System.Drawing.Point(70, 79);
            this.uxYesButton.Name = "uxYesButton";
            this.uxYesButton.Size = new System.Drawing.Size(160, 27);
            this.uxYesButton.TabIndex = 2;
            this.uxYesButton.Text = "Use Roster:";
            this.uxYesButton.UseVisualStyleBackColor = false;
            this.uxYesButton.Click += new System.EventHandler(this.UxYesButton_Click);
            // 
            // uxNoButton
            // 
            this.uxNoButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uxNoButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.uxNoButton.Location = new System.Drawing.Point(70, 126);
            this.uxNoButton.Name = "uxNoButton";
            this.uxNoButton.Size = new System.Drawing.Size(160, 30);
            this.uxNoButton.TabIndex = 2;
            this.uxNoButton.Text = "Add Roster:";
            this.uxNoButton.UseVisualStyleBackColor = false;
            this.uxNoButton.Click += new System.EventHandler(this.UxNoButton_Click);
            // 
            // Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 191);
            this.Controls.Add(this.uxNoButton);
            this.Controls.Add(this.uxYesButton);
            this.Controls.Add(this.uxPromptLabel);
            this.Controls.Add(this.uxStartedLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Prompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxStartedLabel;
        private System.Windows.Forms.Label uxPromptLabel;
        private System.Windows.Forms.Button uxYesButton;
        private System.Windows.Forms.Button uxNoButton;
    }
}