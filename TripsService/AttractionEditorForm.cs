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
    public partial class AttractionEdiorForm : Form
    {
        private Attraction attr;

        public AttractionEdiorForm()
        {
            InitializeComponent();
        }

        public AttractionEdiorForm(Attraction attr)
        {
            // TODO: Complete member initialization
            this.attr = attr;
            InitializeComponent();
        }

        private void AttractionEdiorForm_Load(object sender, EventArgs e)
        {
            textBoxNameAttraction.Text = attr.GetName();
            textBoxLongitudeAttraction.Text = attr.GetLongitude().ToString();
            textBoxLatiudeAttraction.Text = attr.GetLatitude().ToString();
            comboBox1.Items.Clear();
            comboBox1.Items.Insert((int)AttractionType.Building, "budynek");
            comboBox1.Items.Insert((int)AttractionType.Nature, "natura");
            comboBox1.Items.Insert((int)AttractionType.Vechicle, "pojazd");
            comboBox1.Items.Insert((int)AttractionType.Viewport, "krajobraz");
            comboBox1.SelectedIndex = (int)attr.GetType();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attraction a;
            if (attr.vid == 0)
            {
                a = new Attraction();
            }
            else {
                a = attr;
            }
            AttractionType attractiontype = comboBox1.SelectedIndex == (int)AttractionType.Viewport ? AttractionType.Viewport : comboBox1.SelectedIndex == (int)AttractionType.Vechicle ? AttractionType.Vechicle : comboBox1.SelectedIndex == (int)AttractionType.Nature ? AttractionType.Nature : AttractionType.Building;  

            a.SetName(textBoxNameAttraction.Text);
            a.SetLongitude(float.Parse(textBoxLongitudeAttraction.Text));
            a.SetLatitude(float.Parse(textBoxLatiudeAttraction.Text));
            a.vtype = attractiontype;

            TripsService.AppFiles.Database.DbService.Update<Attraction>(a);
        }
    }
}
