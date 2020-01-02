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
            this.uxStartedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartedLabel.Location = new System.Drawing.Point(337, 28);
            this.uxStartedLabel.Name = "uxStartedLabel";
            this.uxStartedLabel.Size = new System.Drawing.Size(0, 20);
            this.uxStartedLabel.TabIndex = 0;
            // 
            // uxPromptLabel
            // 
            this.uxPromptLabel.AutoSize = true;
            this.uxPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPromptLabel.Location = new System.Drawing.Point(337, 28);
            this.uxPromptLabel.Name = "uxPromptLabel";
            this.uxPromptLabel.Size = new System.Drawing.Size(137, 20);
            this.uxPromptLabel.TabIndex = 1;
            this.uxPromptLabel.Text = "Attendance-inator";
            // 
            // uxYesButton
            // 
            this.uxYesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxYesButton.Location = new System.Drawing.Point(304, 60);
            this.uxYesButton.Name = "uxYesButton";
            this.uxYesButton.Size = new System.Drawing.Size(101, 49);
            this.uxYesButton.TabIndex = 2;
            this.uxYesButton.Text = "Start";
            this.uxYesButton.UseVisualStyleBackColor = true;
            this.uxYesButton.Click += new System.EventHandler(this.UxYesButton_Click);
            // 
            // uxNoButton
            // 
            this.uxNoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNoButton.Location = new System.Drawing.Point(411, 60);
            this.uxNoButton.Name = "uxNoButton";
            this.uxNoButton.Size = new System.Drawing.Size(101, 49);
            this.uxNoButton.TabIndex = 2;
            this.uxNoButton.Text = "I don\'t have a roster";
            this.uxNoButton.UseVisualStyleBackColor = true;
            this.uxNoButton.Click += new System.EventHandler(this.UxNoButton_Click);
            // 
            // Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxNoButton);
            this.Controls.Add(this.uxYesButton);
            this.Controls.Add(this.uxPromptLabel);
            this.Controls.Add(this.uxStartedLabel);
            this.Name = "Prompt";
            this.Text = "CreateRoster";
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