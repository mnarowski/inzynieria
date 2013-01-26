using System;
using System.Windows.Forms;
using TripsService.AppFiles.Database;

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
                this.comboBoxRole.Visible = false;
            }
            this.plec.Items.Insert((int)SexEnum.Male, "mężczyzna");
            this.plec.Items.Insert((int)SexEnum.Female, "kobieta");
            this.textBoxName.Text = userAuth.GetName();
            this.textBoxSureName.Text = userAuth.GetSureName();
            this.dateOfBirthTimePicker.Value = userAuth.GetDateOfBirth();
            this.plec.SelectedIndex = (int) userAuth.GetSex();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.form == null) {
                this.form = new TripInfoForm();
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
            TripEdit form = new TripEdit();
            
            //form.showOnlyMine(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //new Form2();
        }

    }
}
