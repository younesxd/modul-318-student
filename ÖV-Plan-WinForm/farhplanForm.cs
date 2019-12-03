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

        public void fahrplanAusgabe(string station, string date, string time)
        {
            transport = new SwissTransport.Transport();
            var stations = transport.GetStationBoard(station, "null", date, time).Entries;

            libFahrplan.Items.Clear();

            for (int i = 0; i < stations.Count; i++)
            {
                string ausgabe = stations[i].Stop.Departure.TimeOfDay + stations[i].To + stations[i].Category + stations[i].Number;
                libFahrplan.Items.Add(ausgabe);
            }


        }

    }
}
