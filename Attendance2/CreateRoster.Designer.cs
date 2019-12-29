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
            this.uxWelcomeLabel = new System.Windows.Forms.Label();
            this.uxPictureBox = new System.Windows.Forms.PictureBox();
            this.uxPictureLabel = new System.Windows.Forms.Label();
            this.uxStepOneLabel = new System.Windows.Forms.Label();
            this.uxStartButton = new System.Windows.Forms.Button();
            this.uxFileContentsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxNamesTextBox = new System.Windows.Forms.TextBox();
            this.uxEnterInstructionsLabel = new System.Windows.Forms.Label();
            this.uxRemoveNameButton = new System.Windows.Forms.Button();
            this.uxRemovedText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxPictureBox)).BeginInit();
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
            // uxWelcomeLabel
            // 
            this.uxWelcomeLabel.AutoSize = true;
            this.uxWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWelcomeLabel.Location = new System.Drawing.Point(26, 33);
            this.uxWelcomeLabel.Name = "uxWelcomeLabel";
            this.uxWelcomeLabel.Size = new System.Drawing.Size(209, 20);
            this.uxWelcomeLabel.TabIndex = 1;
            this.uxWelcomeLabel.Text = "You can make a roster here!";
            // 
            // uxPictureBox
            // 
            this.uxPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("uxPictureBox.Image")));
            this.uxPictureBox.Location = new System.Drawing.Point(535, 59);
            this.uxPictureBox.Name = "uxPictureBox";
            this.uxPictureBox.Size = new System.Drawing.Size(140, 108);
            this.uxPictureBox.TabIndex = 2;
            this.uxPictureBox.TabStop = false;
            // 
            // uxPictureLabel
            // 
            this.uxPictureLabel.AutoSize = true;
            this.uxPictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPictureLabel.Location = new System.Drawing.Point(531, 25);
            this.uxPictureLabel.Name = "uxPictureLabel";
            this.uxPictureLabel.Size = new System.Drawing.Size(216, 20);
            this.uxPictureLabel.TabIndex = 1;
            this.uxPictureLabel.Text = "Rosters need to look like this:";
            // 
            // uxStepOneLabel
            // 
            this.uxStepOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStepOneLabel.Location = new System.Drawing.Point(681, 59);
            this.uxStepOneLabel.Name = "uxStepOneLabel";
            this.uxStepOneLabel.Size = new System.Drawing.Size(106, 73);
            this.uxStepOneLabel.TabIndex = 1;
            this.uxStepOneLabel.Text = "Every name needs to be on its own line.";
            // 
            // uxStartButton
            // 
            this.uxStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartButton.Location = new System.Drawing.Point(30, 117);
            this.uxStartButton.Name = "uxStartButton";
            this.uxStartButton.Size = new System.Drawing.Size(116, 50);
            this.uxStartButton.TabIndex = 3;
            this.uxStartButton.Text = "Start";
            this.uxStartButton.UseVisualStyleBackColor = true;
            this.uxStartButton.Click += new System.EventHandler(this.UxRosterStartButton_Click);
            // 
            // uxFileContentsTextBox
            // 
            this.uxFileContentsTextBox.Location = new System.Drawing.Point(536, 228);
            this.uxFileContentsTextBox.Multiline = true;
            this.uxFileContentsTextBox.Name = "uxFileContentsTextBox";
            this.uxFileContentsTextBox.ReadOnly = true;
            this.uxFileContentsTextBox.Size = new System.Drawing.Size(252, 210);
            this.uxFileContentsTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Contents:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Just click \"Start\" when you\'re ready.";
            // 
            // uxNamesTextBox
            // 
            this.uxNamesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNamesTextBox.Location = new System.Drawing.Point(277, 228);
            this.uxNamesTextBox.Multiline = true;
            this.uxNamesTextBox.Name = "uxNamesTextBox";
            this.uxNamesTextBox.ReadOnly = true;
            this.uxNamesTextBox.Size = new System.Drawing.Size(253, 32);
            this.uxNamesTextBox.TabIndex = 6;
            this.uxNamesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxNamesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // uxEnterInstructionsLabel
            // 
            this.uxEnterInstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterInstructionsLabel.Location = new System.Drawing.Point(274, 183);
            this.uxEnterInstructionsLabel.Name = "uxEnterInstructionsLabel";
            this.uxEnterInstructionsLabel.Size = new System.Drawing.Size(191, 55);
            this.uxEnterInstructionsLabel.TabIndex = 1;
            this.uxEnterInstructionsLabel.Text = "Enter a name, followed by the \"Enter\" key:";
            // 
            // uxRemoveNameButton
            // 
            this.uxRemoveNameButton.Enabled = false;
            this.uxRemoveNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemoveNameButton.Location = new System.Drawing.Point(277, 266);
            this.uxRemoveNameButton.Name = "uxRemoveNameButton";
            this.uxRemoveNameButton.Size = new System.Drawing.Size(253, 53);
            this.uxRemoveNameButton.TabIndex = 4;
            this.uxRemoveNameButton.Text = "Remove Name";
            this.uxRemoveNameButton.UseVisualStyleBackColor = true;
            this.uxRemoveNameButton.Click += new System.EventHandler(this.UxRemoveNameButton_Click);
            // 
            // uxRemovedText
            // 
            this.uxRemovedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemovedText.Location = new System.Drawing.Point(274, 322);
            this.uxRemovedText.Name = "uxRemovedText";
            this.uxRemovedText.Size = new System.Drawing.Size(191, 55);
            this.uxRemovedText.TabIndex = 1;
            // 
            // CreateRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxNamesTextBox);
            this.Controls.Add(this.uxFileContentsTextBox);
            this.Controls.Add(this.uxRemoveNameButton);
            this.Controls.Add(this.uxStartButton);
            this.Controls.Add(this.uxPictureBox);
            this.Controls.Add(this.uxStepOneLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxPictureLabel);
            this.Controls.Add(this.uxRemovedText);
            this.Controls.Add(this.uxEnterInstructionsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxWelcomeLabel);
            this.Controls.Add(this.label1);
            this.Name = "CreateRoster";
            this.Text = "CreateRoster";
            ((System.ComponentModel.ISupportInitialize)(this.uxPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxWelcomeLabel;
        private System.Windows.Forms.PictureBox uxPictureBox;
        private System.Windows.Forms.Label uxPictureLabel;
        private System.Windows.Forms.Label uxStepOneLabel;
        private System.Windows.Forms.Button uxStartButton;
        private System.Windows.Forms.TextBox uxFileContentsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxNamesTextBox;
        private System.Windows.Forms.Label uxEnterInstructionsLabel;
        private System.Windows.Forms.Button uxRemoveNameButton;
        private System.Windows.Forms.Label uxRemovedText;
    }
}