using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TripsService
{
    public partial class TripEdit : Form
    {
        private Trip trip;
        private string destDir = string.Empty;
        
        public TripEdit()
        {
            InitializeComponent();
        }

        public TripEdit(Trip trip)
        {
            // TODO: Complete member initialization
            this.trip = trip;
            FileAdapter<Trip> t = new FileAdapter<Trip>();
            Type x = typeof(Trip);
            t.ForTrip(trip);
            destDir = t.GetDataBaseLocation();
            if (trip.vid == null) {
                button3.Visible = false;
            }
 
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trip t;
            if (trip.vid == null)
            {
                 t = new Trip();
            }
            else {
                 t = trip;
            }

            t.SetName(textBox1.Text);
            t.SetLength(float.Parse(textBox2.Text.ToString()));
            t.SetPrice(double.Parse(textBox3.Text));
            t.SetTransport(textBox4.Text);
            t.SetDescription(richTextBox1.Text);
            t.vattraction = comboBox1.SelectedIndex;
            t.vlocation = comboBox2.SelectedIndex;

            TripsService.AppFiles.Database.DbService.Update<Trip>(t);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (trip != null)
            {
                trip.vUsersNumber += 1;
                TripsService.AppFiles.Database.DbService.Update<Trip>(trip);
            }
        }

        private void TripEdit_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            ICollection<Attraction> items = TripsService.AppFiles.Database.DbService.GetAll<Attraction>();
            comboBox1.Items.Insert(0, string.Empty);
            foreach (Attraction a in items) {
                comboBox1.Items.Insert(a.vid, a.GetName());
            }

            comboBox2.Items.Clear();
            ICollection<Location> itemz = TripsService.AppFiles.Database.DbService.GetAll<Location>();
            comboBox2.Items.Insert(0, string.Empty);
            foreach (Location l in itemz) {
                comboBox2.Items.Insert(l.vid, l.GetName());
            }
            this.textBox1.Text = trip.GetName();
            this.textBox2.Text = trip.GetLength().ToString();
            textBox3.Text = trip.GetPrice().ToString();
            textBox4.Text = trip.GetTransport();
            richTextBox1.Text = trip.GetDescription();
            if (trip != null) {
                comboBox1.SelectedIndex = trip.vattraction;
                comboBox2.SelectedIndex = trip.vlocation;
            }
            refreshPlayList();
        }


        public void refreshPlayList() {
            listView1.Items.Clear();
            if (!Directory.Exists(destDir)) {
                Directory.CreateDirectory(destDir);
            }
            string[] files = Directory.GetFiles(destDir);
            foreach (string s in files) {
                listView1.Items.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "*.wav|*.wav";
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = openFileDialog1.FileName.ToString();
            refreshPlayList();
            fileUploadProcess(fileName, destDir);
        }

        private void fileUploadProcess(string source, string destdir) {
            Random r = new Random();
            string nfile = destdir + "time-" + r.Next() + ".wav";
            File.Copy(source, nfile);
            refreshPlayList();
        }

        public string escape(string p) {
            return p.Replace("\\", "\\\\");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = listView1.Items[listView1.FocusedItem.Index].Text;
            
        }

        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {

        }

    }
}
