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
    public partial class Search_Passenger : Form
    {
        public Search_Passenger()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //FinalTDEntities db = new FinalTDEntities();
            //var items=db.User_Details.ToList();
            //dataGridView1.DataSource = items;

            FinalTDEntities db = new FinalTDEntities();
            var items = db.User_Details.Where(a => a.Name.Equals(textBox1.Text)).ToList();
            dataGridView1.DataSource = items;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            User c1 = new User(id);
            c1.ShowDialog();
        }
    }
}
