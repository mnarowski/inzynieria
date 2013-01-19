using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;


namespace TripsService
{
    public partial class Form_AddTrip : Form
    {
        public Form_AddTrip()
        {
            InitializeComponent();
        }

        private void tripallBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tripallBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_TripDataSet);

        }

        private void Form_AddTrip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_TripDataSet.Tripall' table. You can move, or remove it, as needed.
            this.tripallTableAdapter.Fill(this.database_TripDataSet.Tripall);

        }

        private void tripallBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        public SmtpClient client = new SmtpClient();
        public MailMessage msg = new MailMessage();

        public System.Net.NetworkCredential smtpCreds =
            new System.Net.NetworkCredential("mail", "hasło");






        public void SendEmail(string sendTo, string sendFrom, string subject, string body)
        {
            try
            {
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.Credentials = smtpCreds;
                client.EnableSsl = true;

                MailAddress to = new MailAddress(sendTo);
                MailAddress from = new MailAddress(sendFrom);

                msg.Subject = subject;
                msg.Body = body;
                msg.From = from;
                msg.To.Add(to);

                client.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coś poszło nie tak");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SendEmail(imieTextBox.Text,nazwiskoTextBox.Text,wiekTextBox.Text,peselTextBox.Text);
        }

        
    }
}
