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
    
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKontrollera_Click(object sender, EventArgs e)
        {
            // Töm alltid resultatfältet först
            txtResultat.Clear();

            if (txtFörnamn.Text == "Förnamn" || txtEfternamn.Text == "Efternamn" || txtPersonnummer.Text == "ÅÅMMDD-XXXX")
            {
                MessageBox.Show("Fyll i alla fält innan du kontrollerar.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!ValideraInmatning(out string fel))
                {
                    // Visa felmeddelande och avbryt
                    MessageBox.Show(fel, "Fel i inmatning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string förnamn = txtFörnamn.Text.Trim();
                string efternamn = txtEfternamn.Text.Trim();
                string personnummer = txtPersonnummer.Text.Trim();

                Person p = new Person(förnamn, efternamn, personnummer);

                bool giltigt = p.ÄrPersonnummerGiltigt();
                string kön = p.Kön();

                // Skriv direkt till textfältet istället för AppendText
                txtResultat.Text =
                    $"Namn: {p.Förnamn} {p.Efternamn}\r\n" +
                    $"Personnummer: {p.Personnummer}\r\n" +
                    $"Giltigt: {(giltigt ? "Ja" : "Nej")}\r\n" +
                    $"Kön: {kön}\r\n";
            }
            catch (FormatException)
            {
                MessageBox.Show("Felaktigt format på personnummer. Kontrollera att du bara använder siffror och eventuellt ett bindestreck.", "Formatfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett oväntat fel inträffade:\r\n{ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValideraInmatning(out string felmeddelande)
        {
            felmeddelande = "";

            string förnamn = txtFörnamn.Text.Trim();
            string efternamn = txtEfternamn.Text.Trim();
            string personnummer = txtPersonnummer.Text.Trim();

            // Nollställ färgerna
            txtFörnamn.BackColor = Color.White;
            txtEfternamn.BackColor = Color.White;
            txtPersonnummer.BackColor = Color.White;

            // Kontrollera tomma fält OCH placeholders
            if (string.IsNullOrWhiteSpace(förnamn) || förnamn == "Förnamn" ||
                string.IsNullOrWhiteSpace(efternamn) || efternamn == "Efternamn" ||
                string.IsNullOrWhiteSpace(personnummer) || personnummer == "ÅÅMMDD-XXXX")
            {
                felmeddelande = "Alla fält måste fyllas i.";

                if (string.IsNullOrWhiteSpace(förnamn) || förnamn == "Förnamn")
                    txtFörnamn.BackColor = Color.MistyRose;
                if (string.IsNullOrWhiteSpace(efternamn) || efternamn == "Efternamn")
                    txtEfternamn.BackColor = Color.MistyRose;
                if (string.IsNullOrWhiteSpace(personnummer) || personnummer == "ÅÅMMDD-XXXX")
                    txtPersonnummer.BackColor = Color.MistyRose;

                return false;
            }

            // Kolla att namn bara innehåller bokstäver
            if (!System.Text.RegularExpressions.Regex.IsMatch(förnamn, @"^[A-Za-zÅÄÖåäö]+$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(efternamn, @"^[A-Za-zÅÄÖåäö]+$"))
            {
                felmeddelande = "För- och efternamn får bara innehålla bokstäver.";
                txtFörnamn.BackColor = Color.MistyRose;
                txtEfternamn.BackColor = Color.MistyRose;
                return false;
            }

            // Kolla personnummerformat
            if (!System.Text.RegularExpressions.Regex.IsMatch(personnummer, @"^\d{6}[-]?\d{4}$") &&
                !System.Text.RegularExpressions.Regex.IsMatch(personnummer, @"^\d{8}[-]?\d{4}$"))
            {
                felmeddelande = "Personnumret måste vara i formatet ÅÅMMDD-XXXX eller ÅÅÅÅMMDDXXXX.";
                txtPersonnummer.BackColor = Color.MistyRose;
                return false;
            }

            return true;
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
            lblTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTitle.AutoSize = false;
            lblTitle.Width = this.Width;

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

            // Placeholder för personnummer
            txtPersonnummer.Text = "ÅÅMMDD-XXXX";
            txtPersonnummer.ForeColor = Color.Gray;

            // Koppla händelser
            txtPersonnummer.Enter += TxtPersonnummer_Enter;
            txtPersonnummer.Leave += TxtPersonnummer_Leave;
        }
        private void TxtPersonnummer_Enter(object sender, EventArgs e)
        {
            if (txtPersonnummer.Text == "ÅÅMMDD-XXXX")
            {
                txtPersonnummer.Text = "";
                txtPersonnummer.ForeColor = Color.Black;
            }
        }

        private void TxtPersonnummer_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPersonnummer.Text))
            {
                txtPersonnummer.Text = "ÅÅMMDD-XXXX";
                txtPersonnummer.ForeColor = Color.Gray;
            }
        }
    }
}
