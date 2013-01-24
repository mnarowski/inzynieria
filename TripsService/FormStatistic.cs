using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TripsService
{
    public partial class FormStatistics : Form
    {

        private bool mine;

        public FormStatistics()
        {
            //InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            FormResults Form = new FormResults();
            //Co to za smiec?
            //FormResults.show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void showOnlyMine(bool mine = false) {
            this.mine = mine;
        }
    }
}
