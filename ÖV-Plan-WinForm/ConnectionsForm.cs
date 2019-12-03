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



        public void connectionAusgabe(string abfahrt, string ankunft, string date, string time)
        {
            transport = new SwissTransport.Transport();
            var connections = transport.GetConnections(abfahrt, ankunft, date, time).ConnectionList;
            var stations = transport.GetStationBoard(abfahrt, "null", date, time).Entries;

            libConnections.Items.Clear();

            for (int i = 0; i < connections.Count; i++)
            {
                string ausgabe = "      " +connections[i].From.Departure.Remove(0, 11).Remove(5, 8) + "\t\t" + connections[i].To.Arrival.Remove(0, 11).Remove(5, 8) + "\t\t" + connections[i].Duration.Remove(0, 3).Remove(5, 3) + "\t\t" + stations[i].Category + stations[i].Number;
                libConnections.Items.Add(ausgabe);
            }
        }
    }
}
