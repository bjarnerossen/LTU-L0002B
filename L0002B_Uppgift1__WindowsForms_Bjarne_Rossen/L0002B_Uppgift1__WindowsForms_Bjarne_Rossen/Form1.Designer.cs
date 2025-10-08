
namespace L0002B_Uppgift1__WindowsForms_Bjarne_Rossen
{
    partial class Vaxelberakning
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
            this.lblPris = new System.Windows.Forms.Label();
            this.txtPris = new System.Windows.Forms.TextBox();
            this.lblBetalt = new System.Windows.Forms.Label();
            this.txtBetalt = new System.Windows.Forms.TextBox();
            this.btnBerakna = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.btnAvsluta = new System.Windows.Forms.Button();
            this.grpboxResultat = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblPris
            // 
            this.lblPris.AutoSize = true;
            this.lblPris.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPris.Location = new System.Drawing.Point(53, 54);
            this.lblPris.Name = "lblPris";
            this.lblPris.Size = new System.Drawing.Size(78, 13);
            this.lblPris.TabIndex = 0;
            this.lblPris.Text = "Ange pris (kr):";
            // 
            // txtPris
            // 
            this.txtPris.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPris.Location = new System.Drawing.Point(131, 51);
            this.txtPris.Name = "txtPris";
            this.txtPris.Size = new System.Drawing.Size(136, 21);
            this.txtPris.TabIndex = 1;
            // 
            // lblBetalt
            // 
            this.lblBetalt.AutoSize = true;
            this.lblBetalt.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetalt.Location = new System.Drawing.Point(53, 83);
            this.lblBetalt.Name = "lblBetalt";
            this.lblBetalt.Size = new System.Drawing.Size(64, 13);
            this.lblBetalt.TabIndex = 2;
            this.lblBetalt.Text = "Betalt (kr) :";
            // 
            // txtBetalt
            // 
            this.txtBetalt.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBetalt.Location = new System.Drawing.Point(131, 80);
            this.txtBetalt.Name = "txtBetalt";
            this.txtBetalt.Size = new System.Drawing.Size(136, 21);
            this.txtBetalt.TabIndex = 3;
            // 
            // btnBerakna
            // 
            this.btnBerakna.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerakna.Location = new System.Drawing.Point(56, 118);
            this.btnBerakna.Name = "btnBerakna";
            this.btnBerakna.Size = new System.Drawing.Size(153, 36);
            this.btnBerakna.TabIndex = 4;
            this.btnBerakna.Text = "Beräkna växel";
            this.btnBerakna.UseVisualStyleBackColor = true;
            this.btnBerakna.Click += new System.EventHandler(this.btnBerakna_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultat.Location = new System.Drawing.Point(56, 191);
            this.txtResultat.Multiline = true;
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultat.Size = new System.Drawing.Size(211, 186);
            this.txtResultat.TabIndex = 5;
            // 
            // btnAvsluta
            // 
            this.btnAvsluta.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvsluta.Location = new System.Drawing.Point(215, 118);
            this.btnAvsluta.Name = "btnAvsluta";
            this.btnAvsluta.Size = new System.Drawing.Size(52, 36);
            this.btnAvsluta.TabIndex = 6;
            this.btnAvsluta.Text = "Avsluta";
            this.btnAvsluta.UseVisualStyleBackColor = true;
            this.btnAvsluta.Click += new System.EventHandler(this.btnAvsluta_Click);
            // 
            // grpboxResultat
            // 
            this.grpboxResultat.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxResultat.Location = new System.Drawing.Point(49, 172);
            this.grpboxResultat.Name = "grpboxResultat";
            this.grpboxResultat.Size = new System.Drawing.Size(229, 220);
            this.grpboxResultat.TabIndex = 7;
            this.grpboxResultat.TabStop = false;
            this.grpboxResultat.Text = "Växel tillbaka:";
            // 
            // Vaxelberakning
            // 
            this.AcceptButton = this.btnBerakna;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 426);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.grpboxResultat);
            this.Controls.Add(this.btnAvsluta);
            this.Controls.Add(this.btnBerakna);
            this.Controls.Add(this.txtBetalt);
            this.Controls.Add(this.lblBetalt);
            this.Controls.Add(this.txtPris);
            this.Controls.Add(this.lblPris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Vaxelberakning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Växelberäkning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPris;
        private System.Windows.Forms.TextBox txtPris;
        private System.Windows.Forms.Label lblBetalt;
        private System.Windows.Forms.TextBox txtBetalt;
        private System.Windows.Forms.Button btnBerakna;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Button btnAvsluta;
        private System.Windows.Forms.GroupBox grpboxResultat;
    }
}

