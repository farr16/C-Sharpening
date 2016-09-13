namespace KerbalOrbitalCalculator
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
            this.origLabel = new System.Windows.Forms.Label();
            this.origComboBox = new System.Windows.Forms.ComboBox();
            this.destLabel = new System.Windows.Forms.Label();
            this.destComboBox = new System.Windows.Forms.ComboBox();
            this.parkingOrbitLabel = new System.Windows.Forms.Label();
            this.parkingOrbitEntry = new System.Windows.Forms.NumericUpDown();
            this.kmLabel = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.phaseAngleDisplay = new System.Windows.Forms.Label();
            this.ejectionAngleDisplay = new System.Windows.Forms.Label();
            this.ejectionVelocityDisplay = new System.Windows.Forms.Label();
            this.ejectionDeltaVDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parkingOrbitEntry)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // origLabel
            // 
            this.origLabel.AutoSize = true;
            this.origLabel.Location = new System.Drawing.Point(13, 13);
            this.origLabel.Name = "origLabel";
            this.origLabel.Size = new System.Drawing.Size(34, 13);
            this.origLabel.TabIndex = 0;
            this.origLabel.Text = "Origin";
            // 
            // origComboBox
            // 
            this.origComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.origComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origComboBox.FormattingEnabled = true;
            this.origComboBox.Location = new System.Drawing.Point(16, 29);
            this.origComboBox.Name = "origComboBox";
            this.origComboBox.Size = new System.Drawing.Size(238, 21);
            this.origComboBox.TabIndex = 1;
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Location = new System.Drawing.Point(12, 53);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(60, 13);
            this.destLabel.TabIndex = 2;
            this.destLabel.Text = "Destination";
            // 
            // destComboBox
            // 
            this.destComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destComboBox.FormattingEnabled = true;
            this.destComboBox.Location = new System.Drawing.Point(16, 70);
            this.destComboBox.Name = "destComboBox";
            this.destComboBox.Size = new System.Drawing.Size(238, 21);
            this.destComboBox.TabIndex = 3;
            // 
            // parkingOrbitLabel
            // 
            this.parkingOrbitLabel.AutoSize = true;
            this.parkingOrbitLabel.Location = new System.Drawing.Point(13, 98);
            this.parkingOrbitLabel.Name = "parkingOrbitLabel";
            this.parkingOrbitLabel.Size = new System.Drawing.Size(66, 13);
            this.parkingOrbitLabel.TabIndex = 4;
            this.parkingOrbitLabel.Text = "Parking orbit";
            // 
            // parkingOrbitEntry
            // 
            this.parkingOrbitEntry.Location = new System.Drawing.Point(85, 96);
            this.parkingOrbitEntry.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.parkingOrbitEntry.Name = "parkingOrbitEntry";
            this.parkingOrbitEntry.Size = new System.Drawing.Size(50, 20);
            this.parkingOrbitEntry.TabIndex = 5;
            this.parkingOrbitEntry.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // kmLabel
            // 
            this.kmLabel.AutoSize = true;
            this.kmLabel.Location = new System.Drawing.Point(141, 98);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(92, 13);
            this.kmLabel.TabIndex = 6;
            this.kmLabel.Text = "km above surface";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.Controls.Add(this.resetButton);
            this.buttonPanel.Controls.Add(this.calculateButton);
            this.buttonPanel.Location = new System.Drawing.Point(13, 125);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(241, 31);
            this.buttonPanel.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.Location = new System.Drawing.Point(126, 4);
            this.calculateButton.MaximumSize = new System.Drawing.Size(76, 24);
            this.calculateButton.MinimumSize = new System.Drawing.Size(76, 24);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(76, 24);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(38, 4);
            this.resetButton.MaximumSize = new System.Drawing.Size(76, 24);
            this.resetButton.MinimumSize = new System.Drawing.Size(76, 24);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(76, 24);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // labelPanel
            // 
            this.labelPanel.Controls.Add(this.ejectionDeltaVDisplay);
            this.labelPanel.Controls.Add(this.ejectionVelocityDisplay);
            this.labelPanel.Controls.Add(this.ejectionAngleDisplay);
            this.labelPanel.Controls.Add(this.phaseAngleDisplay);
            this.labelPanel.Controls.Add(this.resultsLabel);
            this.labelPanel.Location = new System.Drawing.Point(13, 163);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(241, 186);
            this.labelPanel.TabIndex = 8;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(4, 4);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(42, 13);
            this.resultsLabel.TabIndex = 0;
            this.resultsLabel.Text = "Results";
            // 
            // phaseAngleDisplay
            // 
            this.phaseAngleDisplay.AutoSize = true;
            this.phaseAngleDisplay.Location = new System.Drawing.Point(4, 21);
            this.phaseAngleDisplay.Name = "phaseAngleDisplay";
            this.phaseAngleDisplay.Size = new System.Drawing.Size(70, 13);
            this.phaseAngleDisplay.TabIndex = 1;
            this.phaseAngleDisplay.Text = "Phase Angle:";
            // 
            // ejectionAngleDisplay
            // 
            this.ejectionAngleDisplay.AutoSize = true;
            this.ejectionAngleDisplay.Location = new System.Drawing.Point(4, 38);
            this.ejectionAngleDisplay.Name = "ejectionAngleDisplay";
            this.ejectionAngleDisplay.Size = new System.Drawing.Size(78, 13);
            this.ejectionAngleDisplay.TabIndex = 2;
            this.ejectionAngleDisplay.Text = "Ejection Angle:";
            // 
            // ejectionVelocityDisplay
            // 
            this.ejectionVelocityDisplay.AutoSize = true;
            this.ejectionVelocityDisplay.Location = new System.Drawing.Point(4, 55);
            this.ejectionVelocityDisplay.Name = "ejectionVelocityDisplay";
            this.ejectionVelocityDisplay.Size = new System.Drawing.Size(88, 13);
            this.ejectionVelocityDisplay.TabIndex = 3;
            this.ejectionVelocityDisplay.Text = "Ejection Velocity:";
            // 
            // ejectionDeltaVDisplay
            // 
            this.ejectionDeltaVDisplay.AutoSize = true;
            this.ejectionDeltaVDisplay.Location = new System.Drawing.Point(4, 72);
            this.ejectionDeltaVDisplay.Name = "ejectionDeltaVDisplay";
            this.ejectionDeltaVDisplay.Size = new System.Drawing.Size(65, 13);
            this.ejectionDeltaVDisplay.TabIndex = 4;
            this.ejectionDeltaVDisplay.Text = "Ejection ΔV:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 361);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.kmLabel);
            this.Controls.Add(this.parkingOrbitEntry);
            this.Controls.Add(this.parkingOrbitLabel);
            this.Controls.Add(this.destComboBox);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.origComboBox);
            this.Controls.Add(this.origLabel);
            this.Name = "Form1";
            this.Text = "KSP Orbital Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.parkingOrbitEntry)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label origLabel;
        private System.Windows.Forms.ComboBox origComboBox;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.ComboBox destComboBox;
        private System.Windows.Forms.Label parkingOrbitLabel;
        private System.Windows.Forms.NumericUpDown parkingOrbitEntry;
        private System.Windows.Forms.Label kmLabel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Label ejectionDeltaVDisplay;
        private System.Windows.Forms.Label ejectionVelocityDisplay;
        private System.Windows.Forms.Label ejectionAngleDisplay;
        private System.Windows.Forms.Label phaseAngleDisplay;
        private System.Windows.Forms.Label resultsLabel;
    }
}

