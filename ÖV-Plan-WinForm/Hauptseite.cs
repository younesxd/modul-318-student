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

            frmC.Show();
            frmC.connectionAusgabe(abfahrt, ankunft);

                
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            string station = txtStation.Text;

            frmF.Show();
            frmF.fahrplanAusgabe(station);


        }
    }
}
