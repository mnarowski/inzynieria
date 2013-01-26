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
           Form2 f = new Form2();
           f.Visible = true;
        }

        private void FindLocation_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DbService.GetAll<Location>();
        }
    }
}
