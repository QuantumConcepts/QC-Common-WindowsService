namespace QuantumConcepts.Common.WindowsService.UI.Forms
{
    partial class About
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bugsLink = new System.Windows.Forms.LinkLabel();
            this.wwwLink = new System.Windows.Forms.LinkLabel();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(347, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "{0} v{1}";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "To report an issue, please visit:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "For more information, please visit:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bugsLink
            // 
            this.bugsLink.ActiveLinkColor = System.Drawing.SystemColors.WindowText;
            this.bugsLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bugsLink.BackColor = System.Drawing.Color.Transparent;
            this.bugsLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugsLink.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bugsLink.LinkColor = System.Drawing.SystemColors.WindowText;
            this.bugsLink.Location = new System.Drawing.Point(12, 104);
            this.bugsLink.Name = "bugsLink";
            this.bugsLink.Size = new System.Drawing.Size(347, 20);
            this.bugsLink.TabIndex = 10;
            this.bugsLink.TabStop = true;
            this.bugsLink.Text = "bugs.quantumconceptscorp.com";
            this.bugsLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bugsLink.VisitedLinkColor = System.Drawing.SystemColors.WindowText;
            this.bugsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // wwwLink
            // 
            this.wwwLink.ActiveLinkColor = System.Drawing.SystemColors.WindowText;
            this.wwwLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wwwLink.BackColor = System.Drawing.Color.Transparent;
            this.wwwLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wwwLink.ForeColor = System.Drawing.SystemColors.WindowText;
            this.wwwLink.LinkColor = System.Drawing.SystemColors.WindowText;
            this.wwwLink.Location = new System.Drawing.Point(12, 52);
            this.wwwLink.Name = "wwwLink";
            this.wwwLink.Size = new System.Drawing.Size(347, 20);
            this.wwwLink.TabIndex = 9;
            this.wwwLink.TabStop = true;
            this.wwwLink.Text = "www.quantumconceptscorp.com";
            this.wwwLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wwwLink.VisitedLinkColor = System.Drawing.SystemColors.WindowText;
            this.wwwLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.copyrightLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.copyrightLabel.Location = new System.Drawing.Point(12, 136);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(347, 20);
            this.copyrightLabel.TabIndex = 8;
            this.copyrightLabel.Text = "© {0} Quantum Concepts Corporation. All rights reserved.";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 168);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bugsLink);
            this.Controls.Add(this.wwwLink);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About {0}";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel bugsLink;
        private System.Windows.Forms.LinkLabel wwwLink;
        private System.Windows.Forms.Label copyrightLabel;
    }
}