using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L0002B_Uppgift1__WindowsForms_Bjarne_Rossen
{
    public partial class Vaxelberakning : Form
    {
        // Konstanta valörer (singular, plural)
        readonly (int varde, string singular, string plural)[] valorer =
        {
            (500, "femhundralapp", "femhundralappar"),
            (200, "tvåhundralapp", "tvåhundralappar"),
            (100, "hundralapp", "hundralappar"),
            (50,  "femtiolapp", "femtiolappar"),
            (20,  "tjugolapp", "tjugolappar"),
            (10,  "tiokrona", "tiokronor"),
            (5,   "femkrona", "femkronor"),
            (1,   "krona", "kronor")
        };
        public Vaxelberakning()
        {
            InitializeComponent();
            // Gör Enter/Return till beräkna-knapp
            this.AcceptButton = btnBerakna;
            // Säkerställ att resultatrutan är readonly och multiline (kan också ställas i Designer)
            txtResultat.ReadOnly = true;
            txtResultat.Multiline = true;
            txtResultat.ScrollBars = ScrollBars.Vertical;
        }

        // När användaren klickar på "Beräkna växel"
        private void btnBerakna_Click(object sender, EventArgs e)
        {
            // Validera pris
            if (!int.TryParse(txtPris.Text.Trim(), out int pris) || pris <= 0)
            {
                MessageBox.Show("Ange ett giltigt pris (positivt heltal).", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPris.Focus();
                return;
            }

            // Validera betalt - vi summerar inte tidigare värden, användaren matar in nytt varje gång
            if (!int.TryParse(txtBetalt.Text.Trim(), out int betalt) || betalt < 0)
            {
                MessageBox.Show("Ange ett giltigt betalt belopp (positivt heltal).", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBetalt.Focus();
                return;
            }

            // Om betalt är för lite: visa meddelande, markera betalt-fältet och avbryt (pris bibehålls)
            if (betalt < pris)
            {
                MessageBox.Show($"Kunden har betalat för lite! {pris - betalt} kr saknas.", "För lite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBetalt.SelectAll();
                txtBetalt.Focus();
                return;
            }

            // Räkna växel och skriv ut kvitto + valörer i txtResultat
            int vaxel = betalt - pris;
            txtResultat.Clear();
            txtResultat.AppendText("=== KVITTO ===\r\n");
            txtResultat.AppendText($"Pris:   {pris} kr\r\n");
            txtResultat.AppendText($"Betalt: {betalt} kr\r\n");
            txtResultat.AppendText($"Växel:  {vaxel} kr\r\n\r\n");

            if (vaxel == 0)
            {
                txtResultat.AppendText("Ingen växel behövs. Tack för köpet!\r\n");
            }
            else
            {
                txtResultat.AppendText("Växel tillbaka:\r\n");
                foreach (var v in valorer)
                {
                    int antal = vaxel / v.varde;
                    if (antal > 0)
                    {
                        string namn = antal == 1 ? v.singular : v.plural;
                        txtResultat.AppendText($"{antal} {namn}\r\n");
                        vaxel %= v.varde;
                    }
                }
                txtResultat.AppendText("\r\nTack för köpet!\r\n");
            }
        }

        // Avsluta-knappen
        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }
