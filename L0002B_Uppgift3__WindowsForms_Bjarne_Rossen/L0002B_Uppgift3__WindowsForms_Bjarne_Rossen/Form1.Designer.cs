namespace L0002B_Uppgift3__WindowsForms_Bjarne_Rossen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Förnamn = new System.Windows.Forms.Label();
            this.Efternamn = new System.Windows.Forms.Label();
            this.Personnummer = new System.Windows.Forms.Label();
            this.txtFörnamn = new System.Windows.Forms.TextBox();
            this.txtEfternamn = new System.Windows.Forms.TextBox();
            this.txtPersonnummer = new System.Windows.Forms.TextBox();
            this.btnKontrollera = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registreraPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Förnamn
            // 
            this.Förnamn.AutoSize = true;
            this.Förnamn.Location = new System.Drawing.Point(127, 135);
            this.Förnamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Förnamn.Name = "Förnamn";
            this.Förnamn.Size = new System.Drawing.Size(62, 17);
            this.Förnamn.TabIndex = 0;
            this.Förnamn.Text = "Förnamn:";
            // 
            // Efternamn
            // 
            this.Efternamn.AutoSize = true;
            this.Efternamn.Location = new System.Drawing.Point(127, 187);
            this.Efternamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Efternamn.Name = "Efternamn";
            this.Efternamn.Size = new System.Drawing.Size(70, 17);
            this.Efternamn.TabIndex = 1;
            this.Efternamn.Text = "Efternamn:";
            // 
            // Personnummer
            // 
            this.Personnummer.AutoSize = true;
            this.Personnummer.Location = new System.Drawing.Point(127, 241);
            this.Personnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Personnummer.Name = "Personnummer";
            this.Personnummer.Size = new System.Drawing.Size(99, 17);
            this.Personnummer.TabIndex = 2;
            this.Personnummer.Text = "Personnummer:";
            this.Personnummer.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFörnamn
            // 
            this.txtFörnamn.Location = new System.Drawing.Point(234, 135);
            this.txtFörnamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFörnamn.Name = "txtFörnamn";
            this.txtFörnamn.Size = new System.Drawing.Size(116, 25);
            this.txtFörnamn.TabIndex = 3;
            // 
            // txtEfternamn
            // 
            this.txtEfternamn.Location = new System.Drawing.Point(234, 183);
            this.txtEfternamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEfternamn.Name = "txtEfternamn";
            this.txtEfternamn.Size = new System.Drawing.Size(116, 25);
            this.txtEfternamn.TabIndex = 4;
            // 
            // txtPersonnummer
            // 
            this.txtPersonnummer.Location = new System.Drawing.Point(234, 237);
            this.txtPersonnummer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonnummer.Name = "txtPersonnummer";
            this.txtPersonnummer.Size = new System.Drawing.Size(116, 25);
            this.txtPersonnummer.TabIndex = 5;
            this.txtPersonnummer.Text = "ÅÅMMDD-XXXX";
            // 
            // btnKontrollera
            // 
            this.btnKontrollera.Location = new System.Drawing.Point(233, 293);
            this.btnKontrollera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKontrollera.Name = "btnKontrollera";
            this.btnKontrollera.Size = new System.Drawing.Size(117, 31);
            this.btnKontrollera.TabIndex = 6;
            this.btnKontrollera.Text = "✔ Kontrollera";
            this.btnKontrollera.UseVisualStyleBackColor = true;
            this.btnKontrollera.Click += new System.EventHandler(this.btnKontrollera_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(130, 354);
            this.txtResultat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultat.Multiline = true;
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.Size = new System.Drawing.Size(217, 195);
            this.txtResultat.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registreraPersonToolStripMenuItem,
            this.avslutaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(753, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Arkiv";
            // 
            // registreraPersonToolStripMenuItem
            // 
            this.registreraPersonToolStripMenuItem.Name = "registreraPersonToolStripMenuItem";
            this.registreraPersonToolStripMenuItem.Size = new System.Drawing.Size(110, 19);
            this.registreraPersonToolStripMenuItem.Text = "Registrera person";
            this.registreraPersonToolStripMenuItem.Click += new System.EventHandler(this.registreraPersonToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(58, 19);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(127, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 17);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Personnummerkontroll";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(753, 588);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.btnKontrollera);
            this.Controls.Add(this.txtPersonnummer);
            this.Controls.Add(this.txtEfternamn);
            this.Controls.Add(this.txtFörnamn);
            this.Controls.Add(this.Personnummer);
            this.Controls.Add(this.Efternamn);
            this.Controls.Add(this.Förnamn);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnummerkontroll";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Förnamn;
        private System.Windows.Forms.Label Efternamn;
        private System.Windows.Forms.Label Personnummer;
        private System.Windows.Forms.TextBox txtFörnamn;
        private System.Windows.Forms.TextBox txtEfternamn;
        private System.Windows.Forms.TextBox txtPersonnummer;
        private System.Windows.Forms.Button btnKontrollera;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registreraPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
    }
}

