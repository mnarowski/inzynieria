using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TripsService.AppFiles.Database;

namespace TripsService
{
    public partial class FindLocation : Form
    {
        public FindLocation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form2 f = new Form2( new Location());
           f.Visible = true;
        }

        private void FindLocation_Load(object sender, EventArgs e)
        {
            User userAuth = AuthAdapter.GetInstance().getIdentity();
            if (!UserFactory.isRoot(userAuth)) {
                this.button1.Visible = false;
            }
            this.dataGridView1.DataSource = DbService.GetAll<Location>();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            Location l = ((IList<Location>)dataGridView1.DataSource).ElementAt<Location>(index);

            Form f = new Form2(l);
            f.Visible = true;
        }
    }
}
