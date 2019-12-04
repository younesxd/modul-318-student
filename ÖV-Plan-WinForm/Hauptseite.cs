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

        /*
         * -Speichert die 2 Stationen, das Datum und die Zeit in Variablen welche
         * dann an das Form: ConnectionsForm übergibt.
         * -Öffnet ein neues Form welches die Verbindungen anzeigt.
         */
        private void btnSearch1_Click(object sender, EventArgs e)
        {
            string abfahrt = txtAbfahrt.Text;
            string ankunft = txtAnkunft.Text;

            string datum = datePicker.Text;
            string zeit = txtTime.Text;

            frmC.Show();
            frmC.connectionAusgabe(abfahrt, ankunft, datum, zeit);

                
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            string station = txtStation.Text;

            frmF.Show();
            frmF.fahrplanAusgabe(station);
        }

        /*
         * -Vergleicht den String welcher sich in der Suche befindet,
         * vergleicht diesen mit allen Stationen und gibt die Stationen,
         * welche den eingegebenen String enthalten, in der ListBox aus.
         */
        private void On_Text_Changed_Von(object sender, EventArgs e)
        {
            string abfahrt = txtAbfahrt.Text;

            transport = new SwissTransport.Transport();

            libVorschlagVon.Items.Clear();

            var stationVon = transport.GetStations(abfahrt).StationList;
            
            for (int i = 0; i < stationVon.Count -1; i++)
            {
                string ausgabeVon = stationVon[i].Name;
                try
                {
                    libVorschlagVon.Items.Add(ausgabeVon);
                }catch (System.ArgumentNullException)
                {
                    txtAbfahrt.Text = txtAbfahrt.Text.Substring(0, txtAbfahrt.Text.Length - 1);
                    txtAbfahrt.Select(txtAbfahrt.Text.Length, 0);
                }

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
                try
                {
                    libVorschlagNach.Items.Add(ausgabeNach);
                }catch (System.ArgumentNullException)
                {
                    txtAnkunft.Text = txtAnkunft.Text.Substring(0, txtAnkunft.Text.Length - 1);
                    txtAnkunft.Select(txtAnkunft.Text.Length, 0);
                }
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
                try
                {
                    libVorschlagStation.Items.Add(ausgabeStation);
                }
                catch (System.ArgumentNullException)
                {
                    txtStation.Text = txtStation.Text.Substring(0, txtStation.Text.Length - 1);
                    txtStation.Select(txtStation.Text.Length, 0);
                }
            }
        }

        /*
         * -Wenn man auf einen Vorschalg doppel Clickt, wir die Station in 
         * die TextBox eingefügt.
         */
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

        /*
         * -Schaut das keine ungültige Zeit eingegeben wird.
         * -erzeugt nach 2 Zahlen ein ":".
         */
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

        /*
         * -löscht die Zeichen in der Zeit TextBox
         */
        private void DeleteChars()
        {
            if (!txtTime.Text.EndsWith("0") && !txtTime.Text.EndsWith("1") && !txtTime.Text.EndsWith("2") && !txtTime.Text.EndsWith("3") && !txtTime.Text.EndsWith("4") && !txtTime.Text.EndsWith("5") && !txtTime.Text.EndsWith("6") && !txtTime.Text.EndsWith("7") && !txtTime.Text.EndsWith("8") && !txtTime.Text.EndsWith("9") && !txtTime.Text.EndsWith(":"))
                SendKeys.Send("{BACKSPACE}");
        }
    }
}
