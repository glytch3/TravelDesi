using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTD
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ticketDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flight_Information flight = new Flight_Information();
            flight.MdiParent = this;
            flight.Show();
        }

        private void addNewPassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User customer = new User();
            customer.MdiParent = this;
            customer.Show();
        }

        private void searchPassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Passenger search = new Search_Passenger();
            search.MdiParent = this;
            search.Show();
        }

        private void bookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticket_Booking ticket = new Ticket_Booking();
            ticket.MdiParent = this;
            ticket.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
