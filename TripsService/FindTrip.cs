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
    public partial class FindTrip : Form
    {
        private bool nextChecked = false;
        private bool userGroup = false;

        public FindTrip()
        {
            InitializeComponent();
        }

        private void FindTrip_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NHibernate.ISession session = SessionFactory.GetNewSession();
            
            string QueryString = "from Trip t ";
            if (!isEmpty(textBox5.Text)) {
                userGroup = true;
                QueryString += " LEFT JOIN User u ON t.vorganiser = u.id_user";
            }
            
            QueryString += " WHERE 1=1 ";

            if (!isEmpty(this.textBox1.Text)) {
                QueryString += " AND t.vname LIKE :name ";    
            }

            if (!isEmpty(this.textBox2.Text)) {
                QueryString += " AND t.vlength = :length ";
            }

            if (!isEmpty(textBox3.Text)) {
                QueryString += " AND t.vUsersNumber = :usersnumber";
            }

            if (!isEmpty(textBox4.Text)) {
                QueryString += " AND t.vtransport LIKE :transport";
            }
            if (!isEmpty(textBox5.Text)) {
                QueryString += " AND u.vname LIKE :user";
            }

            if (!isEmpty(textBox6.Text)) {
                QueryString += " AND t.vprice = :price";
            }

            if (!isEmpty(textBox7.Text)) {
                QueryString += " AND t.vdescription LIKE :description";
            }

            if (this.checkBox1.Checked || this.checkBox2.Checked || this.checkBox3.Checked || this.checkBox4.Checked || this.checkBox5.Checked || this.checkBox6.Checked)
            {
                QueryString += " Group BY ";
            }

            if (checkBox1.Checked) {
                QueryString += GroupedBy(" t.vname ASC ");
            }

            if (checkBox2.Checked) {
                QueryString += GroupedBy(" t.vlength ASC ");
            }

            if (checkBox3.Checked) {
                QueryString += GroupedBy(" t.vUsersNumber ASC ");
            }

            if (checkBox4.Checked) {
                QueryString += GroupedBy(" t.vtransport ");
            }

            if (checkBox5.Checked && userGroup) {
                QueryString += GroupedBy(" u.vname ");
            }

            if (checkBox6.Checked) {
                QueryString += GroupedBy(" t.vprice");
            }
            System.Windows.Forms.MessageBox.Show(QueryString);
            NHibernate.IQuery query = session.CreateQuery(QueryString);

            if (!isEmpty(this.textBox1.Text))
            {
               query= query.SetParameter("name", '%' + this.textBox1.Text + '%');
            }

            if (!isEmpty(this.textBox2.Text))
            {
                query = query.SetParameter("lenght", this.textBox2.Text );
            }

            if (!isEmpty(textBox3.Text))
            {
                query = query.SetParameter("usersnumber",this.textBox3.Text);
            }

            if (!isEmpty(textBox4.Text))
            {
                query = query.SetParameter("transport", '%' + this.textBox4.Text + '%');
            }
            if (!isEmpty(textBox5.Text))
            {
                query = query.SetParameter("user", '%' + this.textBox5.Text + '%');
            }

            if (!isEmpty(textBox6.Text))
            {
                query = query.SetParameter("price", this.textBox6.Text );
            }

            if (!isEmpty(textBox7.Text))
            {
                query = query.SetParameter("description", '%' + this.textBox7.Text + '%');
            }

            ICollection<Trip> ultras = query.List<Trip>();

            //this.dataGridView1.DataSource = ultras;
            
        }

        private bool isEmpty(string value) {
            if (value.Trim() == string.Empty) {
                return true;
            }

            return false;
        } 

        public string GroupedBy(string checparam){
            if (!nextChecked) {
                nextChecked = true;
                return checparam;
            }

            return "," + checparam;
        }

        
    }
}
