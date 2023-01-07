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
    public partial class Ticket_Booking : Form
    {
        FinalTDEntities db;
        public Ticket_Booking()
        {
            InitializeComponent();
            db = new FinalTDEntities();
            BindSource();
            BindDestination();

        }

        private void BindDestination()
        {
            var items = db.Flight_Details.ToList();
            DestinationCombo.DataSource = items;
            DestinationCombo.DisplayMember = "Destination";
            //throw new NotImplementedException();
        }

        private void BindSource()
        {
            var items = db.Flight_Details.ToList();
            SourceCombo.DataSource = items;
            SourceCombo.DisplayMember = "Source";
            //throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SourceCombo.Text!=DestinationCombo.Text)
            {
                dataGridView1.DataSource = db.Flight_Details.Where(a => a.Source.Equals(SourceCombo.Text) && a.Destination.Equals(DestinationCombo.Text)).ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(customeridtxt.Text);
            var item = db.User_Details.Where(a => a.Id == id).FirstOrDefault();
            customernametxt.Text = item.Name;
            parentsnametxt.Text = item.ParentsName;
            dateTimePicker1.Value = (DateTime)item.DateOfBirth;
            emailtxt.Text = item.Email;
            phonetxt.Text = item.Phone;
            addresstxt.Text = item.Address;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var flightid = dataGridView1.SelectedRows[0].Cells[0].Value;
            flightidtxt.Text = flightid.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(seatnotxt.Text)<=50)
            {
                if(AvailableSeat()==true)
                {
                    Booking booking = new Booking();
                    booking.CustomerId = Convert.ToInt32(customeridtxt.Text);
                    booking.DateOfJourney = dateTimePicker2.Value;
                    booking.FlightId = Convert.ToInt32(flightidtxt.Text);
                    booking.Seatno = Convert.ToInt32(seatnotxt.Text);
                    db.Bookings.Add(booking);
                    db.SaveChanges();
                    MessageBox.Show("Ticket Booked");
                }
                else
                {
                    MessageBox.Show("Seat is already booked");
                }
            }
            else
            {
                MessageBox.Show("Seat Number should be lower than 51");
            }
            
        }

        private bool AvailableSeat()
        {
            int flightid=Convert.ToInt32(flightidtxt.Text);
            int seatno = Convert.ToInt32(seatnotxt.Text);
            string dateofjourney = dateTimePicker2.Value.ToString("dd/MM/YYYY");
            var item = db.Bookings.Where(a => a.FlightId==flightid && a.Seatno == seatno).FirstOrDefault();
            if(item!=null)
            {
                string existsdate = ((DateTime)item.DateOfJourney).ToString("dd/MM/YYYY");
                if(existsdate==dateofjourney)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
