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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalTDEntities db = new FinalTDEntities();
            if (tb1.Text != String.Empty && tb2.Text != String.Empty)
            {
                var user = db.Logins.Where(a => a.Username.Equals(tb1.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(tb2.Text))
                    {
                        Mainform mainform = new Mainform();
                        mainform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username");
                }
            }
            else
            {
                MessageBox.Show("Please enter Username and Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
