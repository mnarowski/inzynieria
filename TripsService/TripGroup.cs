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
using Npgsql;

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
            string QueryString = "SELECT count(t.*) as liczba {0} FROM Trip t ";
            string what = string.Empty;

            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked
                || checkBox5.Checked || checkBox6.Checked) {
                    QueryString += " GROUP BY ";
            }

            if(checkBox1.Checked){
                what += ",t.name";
                QueryString += addGroupBy(" t.name as nazwa");
            }

            if(checkBox2.Checked){
                what += ",t.length";
                QueryString += addGroupBy(" t.length as odleglosc_trasy");
                //dq = dq.AddOrder(Order.Asc("vlength"));
            }

            if(checkBox3.Checked){
                what += ",(Select name FROM location l WHERE l.id_location = t.localisation) as lokalizacja";
                QueryString += addGroupBy(" t.localisation ");
                //dq = dq.AddOrder(Order.Asc("vlocation"));
            }

            if(checkBox4.Checked){
                what += ",t.usersnumber as uczestnicy";
                QueryString += addGroupBy(" t.usersnumber ");
                //dq = dq.AddOrder(Order.Asc("vUsersNumber"));
            }

            if(checkBox5.Checked){
                what += ",t.price as cena";
                QueryString += addGroupBy(" t.price ");
                //dq= dq.AddOrder(Order.Asc("vprice"));
            }

            if(checkBox6.Checked){
                what += ",(SELECT name FROM attraction a WHERE a.id_attraction = t.attraction) as atrakcja";
                QueryString += addGroupBy(" t.attraction ");
                //dq = dq.AddOrder(Order.Asc("vattraction"));
            }

            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(TripsService.AppFiles.Database.SessionFactory.connectionString);
                conn.Open();
                DataSet ds = new DataSet();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(String.Format(QueryString, what), conn);
                ds.Reset();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception e) {
                System.Windows.Forms.MessageBox.Show("Problem z pobraniem danych");
            }
        }

        public string addGroupBy(string param) {
            if (!firstToGroup) {
                firstToGroup = true;
                return param;
            }

            return "," + param;
        }
    }
}
