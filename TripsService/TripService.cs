﻿using System;
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
    public partial class TripService : Form
    {
        public TripService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = null;
            NHibernate.ISession session = SessionFactory.GetNewSession();
            string login = this.textBox1.Text.ToString();
            string pass = UserFactory.EncodePassword(textBox2.Text.ToString());

            user = session.CreateQuery("from User u WHERE login=:login AND password=:password").SetParameter("login",login).SetParameter("password",pass).List<User>().FirstOrDefault();
            if ( user != null )
            {
                AuthAdapter adapter = AuthAdapter.GetInstance();
                adapter.WriteIdentity(user);

                new UserEditorForm().Visible = true;
                this.Visible = false;
                label3.Text = "";
            }
            else {
                label3.Text = "Nie poprawny login lub hasło"; 
            }
        }

        private void TripService_Load(object sender, EventArgs e)
        {

        }
    }
}
