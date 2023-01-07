namespace FinalTD
{
    partial class Mainform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flightInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightInformationToolStripMenuItem,
            this.userDetailsToolStripMenuItem,
            this.ticketDetailsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flightInformationToolStripMenuItem
            // 
            this.flightInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFlightToolStripMenuItem});
            this.flightInformationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.flightInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.flightInformationToolStripMenuItem.Name = "flightInformationToolStripMenuItem";
            this.flightInformationToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.flightInformationToolStripMenuItem.Text = "| Flight Details |";
            // 
            // addNewFlightToolStripMenuItem
            // 
            this.addNewFlightToolStripMenuItem.Name = "addNewFlightToolStripMenuItem";
            this.addNewFlightToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addNewFlightToolStripMenuItem.Text = "Add New Flight";
            this.addNewFlightToolStripMenuItem.Click += new System.EventHandler(this.addNewFlightToolStripMenuItem_Click);
            // 
            // userDetailsToolStripMenuItem
            // 
            this.userDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPassengerToolStripMenuItem,
            this.searchPassengerToolStripMenuItem});
            this.userDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.userDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userDetailsToolStripMenuItem.Name = "userDetailsToolStripMenuItem";
            this.userDetailsToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.userDetailsToolStripMenuItem.Text = "| Passenger Details |";
            this.userDetailsToolStripMenuItem.Click += new System.EventHandler(this.userDetailsToolStripMenuItem_Click);
            // 
            // addNewPassengerToolStripMenuItem
            // 
            this.addNewPassengerToolStripMenuItem.Name = "addNewPassengerToolStripMenuItem";
            this.addNewPassengerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addNewPassengerToolStripMenuItem.Text = "Add New Passenger";
            this.addNewPassengerToolStripMenuItem.Click += new System.EventHandler(this.addNewPassengerToolStripMenuItem_Click);
            // 
            // searchPassengerToolStripMenuItem
            // 
            this.searchPassengerToolStripMenuItem.Name = "searchPassengerToolStripMenuItem";
            this.searchPassengerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.searchPassengerToolStripMenuItem.Text = "Search Passenger";
            this.searchPassengerToolStripMenuItem.Click += new System.EventHandler(this.searchPassengerToolStripMenuItem_Click);
            // 
            // ticketDetailsToolStripMenuItem
            // 
            this.ticketDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookTicketToolStripMenuItem});
            this.ticketDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ticketDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ticketDetailsToolStripMenuItem.Name = "ticketDetailsToolStripMenuItem";
            this.ticketDetailsToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.ticketDetailsToolStripMenuItem.Text = "| Booking Details |";
            this.ticketDetailsToolStripMenuItem.Click += new System.EventHandler(this.ticketDetailsToolStripMenuItem_Click);
            // 
            // bookTicketToolStripMenuItem
            // 
            this.bookTicketToolStripMenuItem.Name = "bookTicketToolStripMenuItem";
            this.bookTicketToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bookTicketToolStripMenuItem.Text = "Book Ticket";
            this.bookTicketToolStripMenuItem.Click += new System.EventHandler(this.bookTicketToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem1});
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.logoutToolStripMenuItem.Text = "| Account |";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 299);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flightInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
    }
}