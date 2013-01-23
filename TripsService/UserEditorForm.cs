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


        public UserEditorForm()
        {
            InitializeComponent();
        }

        private void UserEditorForm_Load(object sender, EventArgs e)
        {
            userAuth = AuthAdapter.GetInstance().getIdentity();
            if (!UserFactory.isRoot(userAuth))
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
