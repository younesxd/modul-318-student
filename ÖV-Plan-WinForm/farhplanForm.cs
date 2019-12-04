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

        /*
         * -Übergibt dem API die Daten zum Fahrplan
         * -Gibt den Farplan im ListView aus
         */
        public void fahrplanAusgabe(string station)
        {
            transport = new SwissTransport.Transport();
            var stationen = transport.GetStationBoard(station, "null").Entries;

            for (int i = 0; i < stationen.Count; i++)
            {
                string datumString = stationen[i].Stop.Departure.ToString().Remove(0, 11);
                string ausgabeNummer = stationen[i].Category + stationen[i].Number;
                string[] ausgabe = { datumString, stationen[i].To, ausgabeNummer};

                livFahrplan.Items.Add(new ListViewItem(ausgabe));
            }


        }

    }
}
