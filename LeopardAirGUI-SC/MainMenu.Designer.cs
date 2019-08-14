namespace leopardair_wfa
{
    partial class MainMenu
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
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnViewFlight = new System.Windows.Forms.Button();
            this.btnViewSeat = new System.Windows.Forms.Button();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.btnChangeSeat = new System.Windows.Forms.Button();
            this.btnCheckPoints = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(12, 12);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(216, 58);
            this.btnPurchase.TabIndex = 0;
            this.btnPurchase.Text = "Puchase air ticket";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnViewFlight
            // 
            this.btnViewFlight.Location = new System.Drawing.Point(12, 76);
            this.btnViewFlight.Name = "btnViewFlight";
            this.btnViewFlight.Size = new System.Drawing.Size(216, 58);
            this.btnViewFlight.TabIndex = 1;
            this.btnViewFlight.Text = "View available flights";
            this.btnViewFlight.UseVisualStyleBackColor = true;
            this.btnViewFlight.Click += new System.EventHandler(this.btnViewFlight_Click);
            // 
            // btnViewSeat
            // 
            this.btnViewSeat.Location = new System.Drawing.Point(12, 140);
            this.btnViewSeat.Name = "btnViewSeat";
            this.btnViewSeat.Size = new System.Drawing.Size(216, 58);
            this.btnViewSeat.TabIndex = 2;
            this.btnViewSeat.Text = "View seat status";
            this.btnViewSeat.UseVisualStyleBackColor = true;
            this.btnViewSeat.Click += new System.EventHandler(this.btnViewSeat_Click);
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.Location = new System.Drawing.Point(12, 204);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(216, 58);
            this.btnCancelTicket.TabIndex = 3;
            this.btnCancelTicket.Text = "Cancel air ticket";
            this.btnCancelTicket.UseVisualStyleBackColor = true;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // btnChangeSeat
            // 
            this.btnChangeSeat.Location = new System.Drawing.Point(12, 268);
            this.btnChangeSeat.Name = "btnChangeSeat";
            this.btnChangeSeat.Size = new System.Drawing.Size(216, 58);
            this.btnChangeSeat.TabIndex = 4;
            this.btnChangeSeat.Text = "Change seating";
            this.btnChangeSeat.UseVisualStyleBackColor = true;
            this.btnChangeSeat.Click += new System.EventHandler(this.btnChangeSeat_Click);
            // 
            // btnCheckPoints
            // 
            this.btnCheckPoints.Location = new System.Drawing.Point(12, 332);
            this.btnCheckPoints.Name = "btnCheckPoints";
            this.btnCheckPoints.Size = new System.Drawing.Size(216, 58);
            this.btnCheckPoints.TabIndex = 5;
            this.btnCheckPoints.Text = "Check membership points";
            this.btnCheckPoints.UseVisualStyleBackColor = true;
            this.btnCheckPoints.Click += new System.EventHandler(this.btnCheckPoints_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 396);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(216, 58);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 467);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCheckPoints);
            this.Controls.Add(this.btnChangeSeat);
            this.Controls.Add(this.btnCancelTicket);
            this.Controls.Add(this.btnViewSeat);
            this.Controls.Add(this.btnViewFlight);
            this.Controls.Add(this.btnPurchase);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnViewFlight;
        private System.Windows.Forms.Button btnViewSeat;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.Button btnChangeSeat;
        private System.Windows.Forms.Button btnCheckPoints;
        private System.Windows.Forms.Button btnLogout;
    }
}