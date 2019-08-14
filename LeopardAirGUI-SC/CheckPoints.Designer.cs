namespace leopardair_wfa
{
    partial class CheckPoints
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCMP = new System.Windows.Forms.Label();
            this.lblUsername2 = new System.Windows.Forms.Label();
            this.lblCMP2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(26, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username :";
            // 
            // lblCMP
            // 
            this.lblCMP.AutoSize = true;
            this.lblCMP.Location = new System.Drawing.Point(26, 78);
            this.lblCMP.Name = "lblCMP";
            this.lblCMP.Size = new System.Drawing.Size(137, 13);
            this.lblCMP.TabIndex = 1;
            this.lblCMP.Text = "Current membership points :";
            // 
            // lblUsername2
            // 
            this.lblUsername2.AutoSize = true;
            this.lblUsername2.Location = new System.Drawing.Point(169, 33);
            this.lblUsername2.Name = "lblUsername2";
            this.lblUsername2.Size = new System.Drawing.Size(10, 13);
            this.lblUsername2.TabIndex = 2;
            this.lblUsername2.Text = "-";
            // 
            // lblCMP2
            // 
            this.lblCMP2.AutoSize = true;
            this.lblCMP2.Location = new System.Drawing.Point(169, 78);
            this.lblCMP2.Name = "lblCMP2";
            this.lblCMP2.Size = new System.Drawing.Size(10, 13);
            this.lblCMP2.TabIndex = 3;
            this.lblCMP2.Text = "-";
            // 
            // CheckPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 131);
            this.Controls.Add(this.lblCMP2);
            this.Controls.Add(this.lblUsername2);
            this.Controls.Add(this.lblCMP);
            this.Controls.Add(this.lblUsername);
            this.Name = "CheckPoints";
            this.Text = "Check Membership Points";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCMP;
        private System.Windows.Forms.Label lblUsername2;
        private System.Windows.Forms.Label lblCMP2;
    }
}