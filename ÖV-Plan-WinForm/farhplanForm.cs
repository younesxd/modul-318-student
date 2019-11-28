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
    public partial class farhplanForm : Form
    {
        private SwissTransport.ITransport transport;
        public farhplanForm()
        {
            InitializeComponent();
        }

        public void fahrplanAusgabe(string station)
        {
            transport = new SwissTransport.Transport();

            var stations = transport.GetStationBoard(station, "null");

            libFahrplan.Items.Clear();

            for (int i = 0; i < 4; i++)
            {
                string ausgabe = station + " (" + stations.Entries[i].to.Remove(0, 11).Remove(5, 8) + ") -> ";
                libFahrplan.Items.Add(ausgabe);
            }


        }

    }
}
