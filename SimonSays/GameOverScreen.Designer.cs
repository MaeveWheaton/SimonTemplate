namespace SimonSays
{
    partial class GameOverScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverScreen));
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.patternLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.White;
            this.gameOverLabel.Location = new System.Drawing.Point(107, 234);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(563, 73);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "G A M E  O V E R";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.BackColor = System.Drawing.Color.Transparent;
            this.patternLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternLabel.ForeColor = System.Drawing.Color.White;
            this.patternLabel.Location = new System.Drawing.Point(134, 344);
            this.patternLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(426, 43);
            this.patternLabel.TabIndex = 1;
            this.patternLabel.Text = "Your pattern length was: ";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.lengthLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.ForeColor = System.Drawing.Color.White;
            this.lengthLabel.Location = new System.Drawing.Point(589, 344);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(39, 43);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "0";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DimGray;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(299, 456);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(187, 64);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(804, 716);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button closeButton;
    }
}
