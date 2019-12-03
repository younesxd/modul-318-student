using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace ÖV_Plan_WinForm
{

    public partial class Hauptseite : Form
    {
        private SwissTransport.ITransport transport;
        public Hauptseite()
        {
            InitializeComponent();
            
        }

        Stations St = new Stations();
        Transport Tp = new Transport();
        ConnectionsForm frmC = new ConnectionsForm();
        farhplanForm frmF = new farhplanForm();

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            string abfahrt = txtAbfahrt.Text;
            string ankunft = txtAnkunft.Text;

            string date = datePicker.Text;
            string time = txtTime.Text;

            frmC.Show();
            frmC.connectionAusgabe(abfahrt, ankunft, date, time);

                
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            string station = txtStation.Text;

            string date = datePickerStation.Text;
            string time = txtTimeStation.Text;

            frmF.Show();
            frmF.fahrplanAusgabe(station, date, time);
        }

        private void On_Text_Changed_Von(object sender, EventArgs e)
        {
            string abfahrt = txtAbfahrt.Text;

            transport = new SwissTransport.Transport();

            libVorschlagVon.Items.Clear();

            var stationVon = transport.GetStations(abfahrt).StationList;

            for (int i = 0; i < stationVon.Count -1; i++)
            {
                string ausgabeVon = stationVon[i].Name;
                libVorschlagVon.Items.Add(ausgabeVon);
            }
        }

        private void On_Text_Changed_Nach(object sender, EventArgs e)
        {
            string ankunft = txtAnkunft.Text;

            transport = new SwissTransport.Transport();

            libVorschlagNach.Items.Clear();

            var stationNach = transport.GetStations(ankunft).StationList;

            for (int i = 0; i < stationNach.Count -1; i++)
            {
                string ausgabeNach = stationNach[i].Name;
                libVorschlagNach.Items.Add(ausgabeNach);
            }

            

        }
        private void On_Text_Changed_Station(object sender, EventArgs e)
        {
            string station = txtStation.Text;

            transport = new SwissTransport.Transport();

            libVorschlagStation.Items.Clear();

            var stationFahrplan = transport.GetStations(station).StationList;

            for (int i = 0; i < stationFahrplan.Count -1; i++)
            {
                string ausgabeStation = stationFahrplan[i].Name;
                libVorschlagStation.Items.Add(ausgabeStation);
            }
        }

        private void On_Double_Click_Von(object sender, MouseEventArgs e)
        {
            txtAbfahrt.Text = libVorschlagVon.SelectedItem.ToString();
        }

        private void On_Double_Click_Nach(object sender, MouseEventArgs e)
        {
            txtAnkunft.Text = libVorschlagNach.SelectedItem.ToString();
        }

        private void On_Double_Click_Station(object sender, MouseEventArgs e)
        {
            txtStation.Text = libVorschlagStation.SelectedItem.ToString();
        }

        private void On_Text_Changed_Time(object sender, EventArgs e)
        {
            txtTime.MaxLength = 5;
            DeleteChars();
            if (txtTime.Text.Length == 2)
            {
                txtTime.Text += ":";
            }

            txtTime.SelectionStart = txtTime.Text.Length;
        }

        private void On_Text_Changed_Time_Station(object sender, EventArgs e)
        {
            txtTimeStation.MaxLength = 5;
            DeleteCharsStation();
            if (txtTimeStation.Text.Length == 2)
            {
                txtTimeStation.Text += ":";
            }

            txtTimeStation.SelectionStart = txtTimeStation.Text.Length;
        }
        private void DeleteChars()
        {
            if (!txtTime.Text.EndsWith("0") && !txtTime.Text.EndsWith("1") && !txtTime.Text.EndsWith("2") && !txtTime.Text.EndsWith("3") && !txtTime.Text.EndsWith("4") && !txtTime.Text.EndsWith("5") && !txtTime.Text.EndsWith("6") && !txtTime.Text.EndsWith("7") && !txtTime.Text.EndsWith("8") && !txtTime.Text.EndsWith("9") && !txtTime.Text.EndsWith(":"))
                SendKeys.Send("{BACKSPACE}");
        }
        private void DeleteCharsStation()
        {
            if (!txtTimeStation.Text.EndsWith("0") && !txtTimeStation.Text.EndsWith("1") && !txtTimeStation.Text.EndsWith("2") && !txtTimeStation.Text.EndsWith("3") && !txtTimeStation.Text.EndsWith("4") && !txtTimeStation.Text.EndsWith("5") && !txtTimeStation.Text.EndsWith("6") && !txtTimeStation.Text.EndsWith("7") && !txtTimeStation.Text.EndsWith("8") && !txtTimeStation.Text.EndsWith("9") && !txtTimeStation.Text.EndsWith(":"))
                SendKeys.Send("{BACKSPACE}");
        }
    }
}
