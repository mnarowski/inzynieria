using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TripsService
{
    public partial class Form2 : Form
    {
        private Location location;

        public Form2()
        {
           InitializeComponent();
        }

        public Form2(Location location)
        {
            // TODO: Complete member initialization
            this.location = location;
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
