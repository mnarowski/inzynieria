using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Linq;
using NHibernate.Criterion;

namespace TripsService
{
    public partial class TripGroup : Form
    {
        private bool firstToGroup = false;

        public TripGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IQueryable<Trip> tripQuery = TripsService.AppFiles.Database.DbService.GetAll<Trip>().AsQueryable<Trip>();
            //var result = from n in tripQuery select n;

            string what = string.Empty;
            
            if(checkBox1.Checked){
                what += "t.vname";
            }

            if(checkBox2.Checked){
                what += ",t.vlength";
                //dq = dq.AddOrder(Order.Asc("vlength"));
            }

            if(checkBox3.Checked){
                what += ",t.vlocation";
                //dq = dq.AddOrder(Order.Asc("vlocation"));
            }

            if(checkBox4.Checked){
                what += ",t.vUsersNUmber";
                //dq = dq.AddOrder(Order.Asc("vUsersNumber"));
            }

            if(checkBox5.Checked){
                what += ",t.vprice";
                //dq= dq.AddOrder(Order.Asc("vprice"));
            }

            if(checkBox6.Checked){
                what += ",t.vattraction";
                //dq = dq.AddOrder(Order.Asc("vattraction"));
            }
            //string whatSelect = "count(*)";
            //string QuerySelect = "SELECT {0} FROM trip";
            //if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked) {
            //    QuerySelect += " Group BY ";
            //}

            //if (checkBox1.Checked) {
            //    whatSelect += ",name";
            //    QuerySelect += addGroupBy("name");
            //}

            //if (checkBox2.Checked) {
            //    whatSelect += ",length";
            //    QuerySelect += addGroupBy("length");
            //}

            //if (checkBox3.Checked) {
            //    whatSelect += "(Select name FROM location l WHERE l.id_location = trip.localisation) as location";
            //    QuerySelect += addGroupBy("localisation");
            //}

            //if (checkBox4.Checked) {
            //    whatSelect += ",usersnumber";
            //    QuerySelect += addGroupBy("usersnumber");
            //}
            //
            //if (checkBox5.Checked) {
            //    whatSelect += ",price";
            //    QuerySelect += addGroupBy("price");
            //}

            //if (checkBox6.Checked) {
             //   whatSelect += ",(SELECT name FROM attraction a WHERE a.id_attraction = trip.attraction) as attraction";
              //  QuerySelect += addGroupBy("attraction");
            //}
            
            //NHibernate.Criterion.DetachedCriteria dq = NHibernate.Criterion.DetachedCriteria.For<Trip>("t");
            //dq = dq.SetProjection(Projections.GroupProperty("t.vid"));
            //NHibernate.ISession session = TripsService.AppFiles.Database.SessionFactory.GetNewSession();
            //NHibernate.IQuery query = TripsService.AppFiles.Database.SessionFactory.GetNewSession().CreateSQLQuery(String.Format(QuerySelect,whatSelect));
           
           // dataGridView1.DataSource = dq.GetExecutableCriteria(session).List();

        }

        public string addGroupBy(string param) {
            if (!firstToGroup) {
                return param;
            }

            return "," + param;
        }
    }
}
