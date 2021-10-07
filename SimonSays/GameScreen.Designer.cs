namespace SimonSays
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.electroButton = new System.Windows.Forms.Button();
            this.hydroButton = new System.Windows.Forms.Button();
            this.pyroButton = new System.Windows.Forms.Button();
            this.cryoButton = new System.Windows.Forms.Button();
            this.patternCompletedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // electroButton
            // 
            this.electroButton.BackColor = System.Drawing.Color.Indigo;
            this.electroButton.Location = new System.Drawing.Point(107, 355);
            this.electroButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.electroButton.Name = "electroButton";
            this.electroButton.Size = new System.Drawing.Size(293, 262);
            this.electroButton.TabIndex = 3;
            this.electroButton.UseVisualStyleBackColor = false;
            this.electroButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // hydroButton
            // 
            this.hydroButton.BackColor = System.Drawing.Color.Navy;
            this.hydroButton.Location = new System.Drawing.Point(405, 355);
            this.hydroButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.hydroButton.Name = "hydroButton";
            this.hydroButton.Size = new System.Drawing.Size(293, 262);
            this.hydroButton.TabIndex = 2;
            this.hydroButton.UseVisualStyleBackColor = false;
            this.hydroButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // pyroButton
            // 
            this.pyroButton.BackColor = System.Drawing.Color.DarkRed;
            this.pyroButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pyroButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pyroButton.Location = new System.Drawing.Point(405, 88);
            this.pyroButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pyroButton.Name = "pyroButton";
            this.pyroButton.Size = new System.Drawing.Size(293, 262);
            this.pyroButton.TabIndex = 1;
            this.pyroButton.UseVisualStyleBackColor = false;
            this.pyroButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // cryoButton
            // 
            this.cryoButton.BackColor = System.Drawing.Color.DarkCyan;
            this.cryoButton.Location = new System.Drawing.Point(107, 88);
            this.cryoButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cryoButton.Name = "cryoButton";
            this.cryoButton.Size = new System.Drawing.Size(293, 262);
            this.cryoButton.TabIndex = 0;
            this.cryoButton.UseVisualStyleBackColor = false;
            this.cryoButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // patternCompletedLabel
            // 
            this.patternCompletedLabel.Location = new System.Drawing.Point(315, 334);
            this.patternCompletedLabel.Name = "patternCompletedLabel";
            this.patternCompletedLabel.Size = new System.Drawing.Size(181, 39);
            this.patternCompletedLabel.TabIndex = 4;
            this.patternCompletedLabel.Text = "patternIndex";
            this.patternCompletedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.patternCompletedLabel);
            this.Controls.Add(this.electroButton);
            this.Controls.Add(this.hydroButton);
            this.Controls.Add(this.pyroButton);
            this.Controls.Add(this.cryoButton);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(803, 715);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button electroButton;
        private System.Windows.Forms.Button hydroButton;
        private System.Windows.Forms.Button pyroButton;
        private System.Windows.Forms.Button cryoButton;
        private System.Windows.Forms.Label patternCompletedLabel;
    }
}
