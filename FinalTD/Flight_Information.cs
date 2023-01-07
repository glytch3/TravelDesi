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
    public partial class Flight_Information : Form
    {
        FinalTDEntities db;
        public Flight_Information()
        {
            InitializeComponent();
            db=new FinalTDEntities();
        }

        private void Flight_Information_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flight_Details fd = new Flight_Details();
            fd.Flight_Name = flightnametxt.Text;
            fd.Source = sourcetxt.Text;
            fd.Destination = destinationtxt.Text;
            fd.Departure = departuretxt.Text;
            fd.Arrival= arrivaltxt.Text;
            fd.Flight_Class = classtxt.Text;
            fd.Flight_Price = Convert.ToDecimal(prictxt.Text);
            fd.Seats = Convert.ToInt16(seatstxt.Text);
            db.Flight_Details.Add(fd);
            db.SaveChanges();
            MessageBox.Show("Flight Details Added");
        }
    }
}
