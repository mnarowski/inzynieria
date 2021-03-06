﻿using System;
using System.Windows.Forms;
using TripsService.AppFiles.Database;
using System.Collections.Generic;

namespace TripsService
{
    public partial class UserEditorForm : Form
    {
        User userAuth = null;
        TripEdit form = null;

        public UserEditorForm()
        {
            InitializeComponent();
        }

        private void UserEditorForm_Load(object sender, EventArgs e)
        {
            ICollection<UserRole> userRoles = DbService.GetAll<UserRole>();
            
            this.comboBoxRole.Items.Clear();
            this.comboBoxRole.Items.Insert(0, "");
            foreach (UserRole ur in userRoles) {
                this.comboBoxRole.Items.Insert(ur.vid, ur.vname);
            }
            userAuth = AuthAdapter.GetInstance().getIdentity();
            if (!UserFactory.isRoot(userAuth))
            {
                this.button2.Visible = false;
                this.comboBoxRole.Visible = false;

            }
            this.plec.Items.Insert((int)SexEnum.Male, "mężczyzna");
            this.plec.Items.Insert((int)SexEnum.Female, "kobieta");
            this.textBoxName.Text = userAuth.GetName();
            this.textBoxSureName.Text = userAuth.GetSureName();
            this.dateOfBirthTimePicker.Value = userAuth.GetDateOfBirth();
            this.plec.SelectedIndex = (int) userAuth.GetSex();
            this.comboBoxRole.SelectedIndex = userAuth.vRole;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.form == null) {
                this.form = new TripEdit(new Trip());
                this.form.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userAuth.SetName(this.textBoxName.Text);
            userAuth.SetSureName(this.textBoxSureName.Text);
            userAuth.SetDateOfBirth(this.dateOfBirthTimePicker.Value);
            SexEnum selectedSex = (((int)SexEnum.Male) == this.plec.SelectedIndex) ? SexEnum.Male : SexEnum.Female;
            userAuth.SetSex(selectedSex);

            DbService.Update<User>(userAuth);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TripEdit form = new TripEdit(new Trip());
            form.Visible = true;
            //form.showOnlyMine(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FindTrip form = new FindTrip();//new Form2();
            form.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TripGroup tg = new TripGroup();
            tg.Visible = true;
        }

        private void searchAttraction_Click(object sender, EventArgs e)
        {
            Form f = new FindAttraction();
            f.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new FindLocation();

            f.Visible = true;
        }

        private void btnPhotoGallery_Click(object sender, EventArgs e)
        {
            frmPhotoGallery oFrmPhotoGallery = new frmPhotoGallery();
            oFrmPhotoGallery.Show();
        }


    }
}
