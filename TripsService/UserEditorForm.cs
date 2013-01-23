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
    public partial class UserEditorForm : Form
    {

        User userAuth = null;
        TripInfoForm form = null;

        public UserEditorForm()
        {
            InitializeComponent();
        }

        private void UserEditorForm_Load(object sender, EventArgs e)
        {
            userAuth = AuthAdapter.GetInstance().getIdentity();
            if (!UserFactory.isRoot(userAuth))
            {
                this.button2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.form == null) {
                this.form = new TripInfoForm();

            }
        }

    }
}
