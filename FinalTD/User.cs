using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTD
{
    public partial class User : Form
    {
        FinalTDEntities db;
        static int id=0;
        public User([Optional]int ? Id)
        {
            InitializeComponent();
            if(Id!=null)
            {
                button1.Visible = false;
                db = new FinalTDEntities();
                User_Details customer = db.User_Details.Where(a => a.Id == Id).FirstOrDefault();
                id=customer.Id;
                nametxt.Text= customer.Name;
                parenttxt.Text=customer.ParentsName;
                birthdate.Value = (DateTime)customer.DateOfBirth;
                emailtxt.Text= customer.Email;
                phonetxt.Text=customer.Phone;
                addresstxt.Text = customer.Address;

            }
            else
            {
                button2.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalTDEntities db = new FinalTDEntities();
            User_Details customers = new User_Details
            {
                Name = nametxt.Text,
                ParentsName = parenttxt.Text,
                DateOfBirth = birthdate.Value,
                Email = emailtxt.Text,
                Phone = phonetxt.Text,
                Address = addresstxt.Text

            };
            db.User_Details.Add(customers);
            db.SaveChanges();
            MessageBox.Show("User Saved");
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            db = new FinalTDEntities();
            User_Details customer = db.User_Details.Where(a => a.Id == id).FirstOrDefault();
            customer.Name = nametxt.Text;
            customer.ParentsName = parenttxt.Text;
            customer.DateOfBirth = birthdate.Value;
            customer.Email = emailtxt.Text;
            customer.Phone = phonetxt.Text;
            customer.Address = addresstxt.Text;
            db.SaveChanges();
            MessageBox.Show("Passenger Details Updated");
        }
    }
}
