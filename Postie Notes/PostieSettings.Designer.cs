namespace Postie_Notes
{
    partial class PostieSettings
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
            this.DSLBrowseButton = new System.Windows.Forms.Button();
            this.DSLText = new System.Windows.Forms.TextBox();
            this.DSLLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DSLBrowseButton
            // 
            this.DSLBrowseButton.Location = new System.Drawing.Point(307, 33);
            this.DSLBrowseButton.Name = "DSLBrowseButton";
            this.DSLBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.DSLBrowseButton.TabIndex = 7;
            this.DSLBrowseButton.Text = "Browse...";
            this.DSLBrowseButton.UseVisualStyleBackColor = true;
            this.DSLBrowseButton.Click += new System.EventHandler(this.DSLBrowseButton_Click);
            // 
            // DSLText
            // 
            this.DSLText.Location = new System.Drawing.Point(128, 34);
            this.DSLText.Name = "DSLText";
            this.DSLText.Size = new System.Drawing.Size(173, 20);
            this.DSLText.TabIndex = 6;
            // 
            // DSLLabel
            // 
            this.DSLLabel.AutoSize = true;
            this.DSLLabel.Location = new System.Drawing.Point(12, 37);
            this.DSLLabel.Name = "DSLLabel";
            this.DSLLabel.Size = new System.Drawing.Size(110, 13);
            this.DSLLabel.TabIndex = 5;
            this.DSLLabel.Text = "Default save location:";
            // 
            // PostieSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 86);
            this.Controls.Add(this.DSLBrowseButton);
            this.Controls.Add(this.DSLText);
            this.Controls.Add(this.DSLLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostieSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postie Note Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PostieSettings_FormClosing);
            this.Load += new System.EventHandler(this.PostieSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button DSLBrowseButton;
        internal System.Windows.Forms.TextBox DSLText;
        internal System.Windows.Forms.Label DSLLabel;
    }
}