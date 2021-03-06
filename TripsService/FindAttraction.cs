﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TripsService
{
    public partial class FindAttraction : Form
    {
        public FindAttraction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AttractionEdiorForm form = new AttractionEdiorForm();
        }

        private void FindAttraction_Load(object sender, EventArgs e)
        {
            User userAuth = AuthAdapter.GetInstance().getIdentity();
            if (!UserFactory.isRoot(userAuth)) {
                this.button1.Visible = false;
            }

            this.dataGridView1.DataSource = TripsService.AppFiles.Database.DbService.GetAll<Attraction>();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            Attraction attr = (Attraction)((IList<Attraction>)dataGridView1.DataSource).ToList<Attraction>().ElementAt<Attraction>(index);
            Form f=new AttractionEdiorForm(attr);
            f.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            Attraction attr = (Attraction)((IList<Attraction>)dataGridView1.DataSource).ToList<Attraction>().ElementAt<Attraction>(index);
            Form f = new AttractionEdiorForm(attr);
            f.Visible = true;
        }

    }
}
