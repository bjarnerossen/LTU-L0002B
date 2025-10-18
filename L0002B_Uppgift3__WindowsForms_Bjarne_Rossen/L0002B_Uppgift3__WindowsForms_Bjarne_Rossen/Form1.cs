using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L0002B_Uppgift3__WindowsForms_Bjarne_Rossen
{
    public partial class Form1 : Form
    {
        List<Person> säljare = new List<Person>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKontrollera_Click(object sender, EventArgs e)
        {
            string förnamn = txtFörnamn.Text.Trim();
            string efternamn = txtEfternamn.Text.Trim();
            string personnummer = txtPersonnummer.Text.Trim();

            if (string.IsNullOrEmpty(förnamn) || string.IsNullOrEmpty(efternamn) || string.IsNullOrEmpty(personnummer))
            {
                MessageBox.Show("Alla fält måste fyllas i!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Person p = new Person(förnamn, efternamn, personnummer);

            bool giltigt = p.ÄrPersonnummerGiltigt();
            string kön = p.Kön();

            string resultat =
                $"🧍‍♂️ Namn: {p.Förnamn} {p.Efternamn}\r\n" +
                $"📅 Personnummer: {p.Personnummer}\r\n" +
                $"✅ Giltigt: {(giltigt ? "Ja" : "Nej")}\r\n" +
                $"🚻 Kön: {kön}\r\n" +
                $"──────────────────────────────\r\n";

            txtResultat.AppendText(resultat);
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registreraPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtFörnamn.Clear();
            txtEfternamn.Clear();
            txtPersonnummer.Clear();
            txtResultat.Clear();
            txtFörnamn.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Gör rubriken stor och centrerad
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.AutoSize = false;
            lblTitle.Width = this.Width;
            lblTitle.Top = 20;

            // Lägg till lite luft
            txtFörnamn.Margin = new Padding(10);
            txtEfternamn.Margin = new Padding(10);
            txtPersonnummer.Margin = new Padding(10);

            // Gör knappen mer modern
            btnKontrollera.BackColor = Color.MediumSeaGreen;
            btnKontrollera.ForeColor = Color.White;
            btnKontrollera.FlatStyle = FlatStyle.Flat;
            btnKontrollera.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Gör resultatfältet som en rapportruta
            txtResultat.BackColor = Color.White;
            txtResultat.BorderStyle = BorderStyle.FixedSingle;
            txtResultat.Font = new Font("Consolas", 10, FontStyle.Regular);

            // Lägg till tooltip för personnummer
            ToolTip tip = new ToolTip();
            tip.SetToolTip(txtPersonnummer, "Skriv in personnummer i formatet ÅÅMMDD-XXXX");
        }
    }
}
