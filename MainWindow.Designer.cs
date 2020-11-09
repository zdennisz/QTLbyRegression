﻿namespace QTLbyRegression
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnSimulateData = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnCalculateQTL = new System.Windows.Forms.Button();
            this.btnInputData = new System.Windows.Forms.Button();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimulateData
            // 
            this.btnSimulateData.BackColor = System.Drawing.Color.White;
            this.btnSimulateData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimulateData.FlatAppearance.BorderSize = 0;
            this.btnSimulateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulateData.Location = new System.Drawing.Point(3, 303);
            this.btnSimulateData.Name = "btnSimulateData";
            this.btnSimulateData.Size = new System.Drawing.Size(200, 48);
            this.btnSimulateData.TabIndex = 1;
            this.btnSimulateData.Text = "Simulate Data";
            this.btnSimulateData.UseVisualStyleBackColor = false;
            this.btnSimulateData.Click += new System.EventHandler(this.btnSimulateData_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.btnCalculateQTL);
            this.menuPanel.Controls.Add(this.btnInputData);
            this.menuPanel.Controls.Add(this.btnViewResults);
            this.menuPanel.Controls.Add(this.btnSimulateData);
            this.menuPanel.Location = new System.Drawing.Point(0, 83);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(208, 586);
            this.menuPanel.TabIndex = 4;
            // 
            // btnCalculateQTL
            // 
            this.btnCalculateQTL.BackColor = System.Drawing.Color.White;
            this.btnCalculateQTL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateQTL.FlatAppearance.BorderSize = 0;
            this.btnCalculateQTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateQTL.Location = new System.Drawing.Point(3, 197);
            this.btnCalculateQTL.Name = "btnCalculateQTL";
            this.btnCalculateQTL.Size = new System.Drawing.Size(200, 48);
            this.btnCalculateQTL.TabIndex = 4;
            this.btnCalculateQTL.Text = "Calculate QTL location and P Value";
            this.btnCalculateQTL.UseVisualStyleBackColor = false;
            this.btnCalculateQTL.Click += new System.EventHandler(this.btnCalculateQTL_Click);
            // 
            // btnInputData
            // 
            this.btnInputData.BackColor = System.Drawing.Color.White;
            this.btnInputData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInputData.FlatAppearance.BorderSize = 0;
            this.btnInputData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnInputData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputData.Location = new System.Drawing.Point(3, 84);
            this.btnInputData.Name = "btnInputData";
            this.btnInputData.Size = new System.Drawing.Size(200, 48);
            this.btnInputData.TabIndex = 3;
            this.btnInputData.Text = "Input Data";
            this.btnInputData.UseVisualStyleBackColor = false;
            this.btnInputData.Click += new System.EventHandler(this.btnInputData_Click);
            // 
            // btnViewResults
            // 
            this.btnViewResults.BackColor = System.Drawing.Color.White;
            this.btnViewResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewResults.FlatAppearance.BorderSize = 0;
            this.btnViewResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewResults.Location = new System.Drawing.Point(3, 415);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(202, 48);
            this.btnViewResults.TabIndex = 2;
            this.btnViewResults.Text = "View Results";
            this.btnViewResults.UseVisualStyleBackColor = false;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contentPanel.Location = new System.Drawing.Point(215, 83);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(732, 601);
            this.contentPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QTLProject.Properties.Resources.QTLLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimulateData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btnInputData;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.Button btnCalculateQTL;
    }
}
