using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖV_Plan_WinForm
{
    public partial class ConnectionsForm : Form
    {
        private SwissTransport.ITransport transport;
        public ConnectionsForm()
        {
            InitializeComponent();
        }


        /*
         * -Übergibt dem API die verschiedenen Daten zur Verbindung
         * -Gibt diese Verbindungen im ListView aus
         */
        public void connectionAusgabe(string abfahrt, string ankunft, string datum, string zeit)
        {
            transport = new SwissTransport.Transport();
            var verbindungen = transport.GetConnections(abfahrt, ankunft, datum, zeit).ConnectionList;
            var stationen = transport.GetStationBoard(abfahrt, "null").Entries;

            for (int i = 0; i < verbindungen.Count; i++)
            {
                string ausgabeNummer = stationen[i].Category + stationen[i].Number;
                string[] ausgabe = { verbindungen[i].From.Departure.Remove(0, 11).Remove(5, 8), verbindungen[i].To.Arrival.Remove(0, 11).Remove(5, 8), ausgabeNummer, verbindungen[i].Duration.Remove(0, 3).Remove(5, 3)};
                livConnections.Items.Add(new ListViewItem(ausgabe));
            }
        }
    }
}
