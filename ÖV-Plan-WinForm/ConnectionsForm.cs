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



        public void connectionAusgabe(string abfahrt, string ankunft)
        {
            transport = new SwissTransport.Transport();
            var connections = transport.GetConnections(abfahrt, ankunft);

            libConnections.Items.Clear();

            for (int i = 0; i < 4; i++)
            {
                string ausgabe = abfahrt + " (" + connections.ConnectionList[i].From.Departure.Remove(0, 11).Remove(5, 8) + ") -> " + ankunft + " (" + connections.ConnectionList[i].To.Arrival.Remove(0, 11).Remove(5, 8) + ") \t Dauer: " + connections.ConnectionList[i].Duration.Remove(0, 3).Remove(5, 3);
                libConnections.Items.Add(ausgabe);
            }
        }
    }
}
