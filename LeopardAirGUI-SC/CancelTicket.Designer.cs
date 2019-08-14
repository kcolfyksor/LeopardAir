namespace leopardair_wfa
{
    partial class CancelTicket
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
            this.lblFlightCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxFlightcode = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxICNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFlightCode
            // 
            this.lblFlightCode.AutoSize = true;
            this.lblFlightCode.Location = new System.Drawing.Point(12, 27);
            this.lblFlightCode.Name = "lblFlightCode";
            this.lblFlightCode.Size = new System.Drawing.Size(66, 13);
            this.lblFlightCode.TabIndex = 0;
            this.lblFlightCode.Text = "Flight Code :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // tbxFlightcode
            // 
            this.tbxFlightcode.Location = new System.Drawing.Point(84, 24);
            this.tbxFlightcode.Name = "tbxFlightcode";
            this.tbxFlightcode.Size = new System.Drawing.Size(144, 20);
            this.tbxFlightcode.TabIndex = 2;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(84, 58);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(315, 20);
            this.tbxName.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(422, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 55);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel air ticket";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IC Number :";
            // 
            // tbxICNumber
            // 
            this.tbxICNumber.Location = new System.Drawing.Point(84, 93);
            this.tbxICNumber.Name = "tbxICNumber";
            this.tbxICNumber.Size = new System.Drawing.Size(315, 20);
            this.tbxICNumber.TabIndex = 6;
            // 
            // CancelTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 129);
            this.Controls.Add(this.tbxICNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxFlightcode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFlightCode);
            this.Name = "CancelTicket";
            this.Text = "Cancel Air Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlightCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxFlightcode;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxICNumber;
    }
}