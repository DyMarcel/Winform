namespace Projet_winForm
{
    partial class interfaceAdherent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteAD = new System.Windows.Forms.Button();
            this.ModifierAD = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListeInfo = new System.Windows.Forms.ListBox();
            this.ListeAD = new System.Windows.Forms.ListBox();
            this.Envoyer = new System.Windows.Forms.Button();
            this.textCotisationAD = new System.Windows.Forms.TextBox();
            this.textNumLicence = new System.Windows.Forms.TextBox();
            this.textNomAD = new System.Windows.Forms.TextBox();
            this.NumLicence = new System.Windows.Forms.Label();
            this.textCPAD = new System.Windows.Forms.TextBox();
            this.villeAdherent = new System.Windows.Forms.Label();
            this.textVilleAD = new System.Windows.Forms.TextBox();
            this.CotisationAdherent = new System.Windows.Forms.Label();
            this.textSexeAD = new System.Windows.Forms.TextBox();
            this.CPAdherent = new System.Windows.Forms.Label();
            this.textAdresseAD = new System.Windows.Forms.TextBox();
            this.DateNaissanceAdherent = new System.Windows.Forms.Label();
            this.textPrenomAD = new System.Windows.Forms.TextBox();
            this.sexeAdherent = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.Label();
            this.prenomAdherent = new System.Windows.Forms.Label();
            this.NomAdherent = new System.Windows.Forms.Label();
            this.ConfirmeAD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.DeleteAD);
            this.panel1.Controls.Add(this.ModifierAD);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ListeInfo);
            this.panel1.Controls.Add(this.ListeAD);
            this.panel1.Controls.Add(this.Envoyer);
            this.panel1.Controls.Add(this.textCotisationAD);
            this.panel1.Controls.Add(this.textNumLicence);
            this.panel1.Controls.Add(this.textNomAD);
            this.panel1.Controls.Add(this.NumLicence);
            this.panel1.Controls.Add(this.textCPAD);
            this.panel1.Controls.Add(this.villeAdherent);
            this.panel1.Controls.Add(this.textVilleAD);
            this.panel1.Controls.Add(this.CotisationAdherent);
            this.panel1.Controls.Add(this.textSexeAD);
            this.panel1.Controls.Add(this.CPAdherent);
            this.panel1.Controls.Add(this.textAdresseAD);
            this.panel1.Controls.Add(this.DateNaissanceAdherent);
            this.panel1.Controls.Add(this.textPrenomAD);
            this.panel1.Controls.Add(this.sexeAdherent);
            this.panel1.Controls.Add(this.adresse);
            this.panel1.Controls.Add(this.prenomAdherent);
            this.panel1.Controls.Add(this.NomAdherent);
            this.panel1.Controls.Add(this.ConfirmeAD);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 353);
            this.panel1.TabIndex = 0;
            // 
            // DeleteAD
            // 
            this.DeleteAD.Location = new System.Drawing.Point(729, 275);
            this.DeleteAD.Name = "DeleteAD";
            this.DeleteAD.Size = new System.Drawing.Size(75, 23);
            this.DeleteAD.TabIndex = 26;
            this.DeleteAD.Text = "Supprimer";
            this.DeleteAD.UseVisualStyleBackColor = true;
            this.DeleteAD.Click += new System.EventHandler(this.DeleteAD_Click);
            // 
            // ModifierAD
            // 
            this.ModifierAD.Location = new System.Drawing.Point(425, 162);
            this.ModifierAD.Name = "ModifierAD";
            this.ModifierAD.Size = new System.Drawing.Size(75, 23);
            this.ModifierAD.TabIndex = 25;
            this.ModifierAD.Text = "Modifier";
            this.ModifierAD.UseVisualStyleBackColor = true;
            this.ModifierAD.Click += new System.EventHandler(this.ModifierAD_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(859, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Information d\'adherent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Liste d\'adherent";
            // 
            // ListeInfo
            // 
            this.ListeInfo.FormattingEnabled = true;
            this.ListeInfo.Location = new System.Drawing.Point(850, 41);
            this.ListeInfo.Name = "ListeInfo";
            this.ListeInfo.Size = new System.Drawing.Size(120, 199);
            this.ListeInfo.TabIndex = 22;
            // 
            // ListeAD
            // 
            this.ListeAD.FormattingEnabled = true;
            this.ListeAD.Location = new System.Drawing.Point(708, 41);
            this.ListeAD.Name = "ListeAD";
            this.ListeAD.Size = new System.Drawing.Size(120, 199);
            this.ListeAD.TabIndex = 21;
            this.ListeAD.Click += new System.EventHandler(this.ListeAD_Click);
            // 
            // Envoyer
            // 
            this.Envoyer.Location = new System.Drawing.Point(232, 162);
            this.Envoyer.Name = "Envoyer";
            this.Envoyer.Size = new System.Drawing.Size(75, 23);
            this.Envoyer.TabIndex = 20;
            this.Envoyer.Text = "Ajouter";
            this.Envoyer.UseVisualStyleBackColor = true;
            this.Envoyer.Click += new System.EventHandler(this.Envoyer_Click);
            // 
            // textCotisationAD
            // 
            this.textCotisationAD.Location = new System.Drawing.Point(537, 106);
            this.textCotisationAD.Name = "textCotisationAD";
            this.textCotisationAD.Size = new System.Drawing.Size(100, 20);
            this.textCotisationAD.TabIndex = 17;
            // 
            // textNumLicence
            // 
            this.textNumLicence.Location = new System.Drawing.Point(537, 59);
            this.textNumLicence.Name = "textNumLicence";
            this.textNumLicence.Size = new System.Drawing.Size(100, 20);
            this.textNumLicence.TabIndex = 18;
            // 
            // textNomAD
            // 
            this.textNomAD.Location = new System.Drawing.Point(121, 18);
            this.textNomAD.Name = "textNomAD";
            this.textNomAD.Size = new System.Drawing.Size(100, 20);
            this.textNomAD.TabIndex = 11;
            // 
            // NumLicence
            // 
            this.NumLicence.AutoSize = true;
            this.NumLicence.Location = new System.Drawing.Point(474, 62);
            this.NumLicence.Name = "NumLicence";
            this.NumLicence.Size = new System.Drawing.Size(57, 13);
            this.NumLicence.TabIndex = 10;
            this.NumLicence.Text = "N°Licence";
            // 
            // textCPAD
            // 
            this.textCPAD.Location = new System.Drawing.Point(537, 15);
            this.textCPAD.Name = "textCPAD";
            this.textCPAD.Size = new System.Drawing.Size(100, 20);
            this.textCPAD.TabIndex = 16;
            // 
            // villeAdherent
            // 
            this.villeAdherent.AutoSize = true;
            this.villeAdherent.Location = new System.Drawing.Point(281, 109);
            this.villeAdherent.Name = "villeAdherent";
            this.villeAdherent.Size = new System.Drawing.Size(26, 13);
            this.villeAdherent.TabIndex = 8;
            this.villeAdherent.Text = "Ville";
            // 
            // textVilleAD
            // 
            this.textVilleAD.Location = new System.Drawing.Point(313, 106);
            this.textVilleAD.Name = "textVilleAD";
            this.textVilleAD.Size = new System.Drawing.Size(100, 20);
            this.textVilleAD.TabIndex = 15;
            // 
            // CotisationAdherent
            // 
            this.CotisationAdherent.AutoSize = true;
            this.CotisationAdherent.Location = new System.Drawing.Point(478, 109);
            this.CotisationAdherent.Name = "CotisationAdherent";
            this.CotisationAdherent.Size = new System.Drawing.Size(53, 13);
            this.CotisationAdherent.TabIndex = 7;
            this.CotisationAdherent.Text = "Cotisation";
            // 
            // textSexeAD
            // 
            this.textSexeAD.Location = new System.Drawing.Point(313, 15);
            this.textSexeAD.Name = "textSexeAD";
            this.textSexeAD.Size = new System.Drawing.Size(100, 20);
            this.textSexeAD.TabIndex = 14;
            // 
            // CPAdherent
            // 
            this.CPAdherent.AutoSize = true;
            this.CPAdherent.Location = new System.Drawing.Point(468, 18);
            this.CPAdherent.Name = "CPAdherent";
            this.CPAdherent.Size = new System.Drawing.Size(63, 13);
            this.CPAdherent.TabIndex = 6;
            this.CPAdherent.Text = "Code postal";
            // 
            // textAdresseAD
            // 
            this.textAdresseAD.Location = new System.Drawing.Point(121, 109);
            this.textAdresseAD.Name = "textAdresseAD";
            this.textAdresseAD.Size = new System.Drawing.Size(100, 20);
            this.textAdresseAD.TabIndex = 13;
            // 
            // DateNaissanceAdherent
            // 
            this.DateNaissanceAdherent.AutoSize = true;
            this.DateNaissanceAdherent.Location = new System.Drawing.Point(250, 62);
            this.DateNaissanceAdherent.Name = "DateNaissanceAdherent";
            this.DateNaissanceAdherent.Size = new System.Drawing.Size(57, 13);
            this.DateNaissanceAdherent.TabIndex = 5;
            this.DateNaissanceAdherent.Text = "Naissance";
            // 
            // textPrenomAD
            // 
            this.textPrenomAD.Location = new System.Drawing.Point(121, 62);
            this.textPrenomAD.Name = "textPrenomAD";
            this.textPrenomAD.Size = new System.Drawing.Size(100, 20);
            this.textPrenomAD.TabIndex = 12;
            // 
            // sexeAdherent
            // 
            this.sexeAdherent.AutoSize = true;
            this.sexeAdherent.Location = new System.Drawing.Point(276, 18);
            this.sexeAdherent.Name = "sexeAdherent";
            this.sexeAdherent.Size = new System.Drawing.Size(31, 13);
            this.sexeAdherent.TabIndex = 4;
            this.sexeAdherent.Text = "Sexe";
            // 
            // adresse
            // 
            this.adresse.AutoSize = true;
            this.adresse.Location = new System.Drawing.Point(62, 109);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(45, 13);
            this.adresse.TabIndex = 3;
            this.adresse.Text = "Adresse";
            // 
            // prenomAdherent
            // 
            this.prenomAdherent.AutoSize = true;
            this.prenomAdherent.Location = new System.Drawing.Point(62, 62);
            this.prenomAdherent.Name = "prenomAdherent";
            this.prenomAdherent.Size = new System.Drawing.Size(43, 13);
            this.prenomAdherent.TabIndex = 2;
            this.prenomAdherent.Text = "Prenom";
            // 
            // NomAdherent
            // 
            this.NomAdherent.AutoSize = true;
            this.NomAdherent.Location = new System.Drawing.Point(78, 18);
            this.NomAdherent.Name = "NomAdherent";
            this.NomAdherent.Size = new System.Drawing.Size(29, 13);
            this.NomAdherent.TabIndex = 1;
            this.NomAdherent.Text = "Nom";
            // 
            // ConfirmeAD
            // 
            this.ConfirmeAD.Location = new System.Drawing.Point(425, 162);
            this.ConfirmeAD.Name = "ConfirmeAD";
            this.ConfirmeAD.Size = new System.Drawing.Size(75, 23);
            this.ConfirmeAD.TabIndex = 0;
            this.ConfirmeAD.Text = "Confirmer";
            this.ConfirmeAD.UseVisualStyleBackColor = true;
            this.ConfirmeAD.Click += new System.EventHandler(this.ConfirmeAD_Click);
            // 
            // interfaceAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 377);
            this.Controls.Add(this.panel1);
            this.Name = "interfaceAdherent";
            this.Text = "Interface Adherent";
            this.Load += new System.EventHandler(this.interfaceAdherent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NomAdherent;
        private System.Windows.Forms.Button ConfirmeAD;
        private System.Windows.Forms.Label villeAdherent;
        private System.Windows.Forms.Label CotisationAdherent;
        private System.Windows.Forms.Label CPAdherent;
        private System.Windows.Forms.Label DateNaissanceAdherent;
        private System.Windows.Forms.Label sexeAdherent;
        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.Label prenomAdherent;
        private System.Windows.Forms.Label NumLicence;
        private System.Windows.Forms.TextBox textNomAD;
        private System.Windows.Forms.TextBox textPrenomAD;
        private System.Windows.Forms.TextBox textAdresseAD;
        private System.Windows.Forms.TextBox textSexeAD;
        private System.Windows.Forms.TextBox textVilleAD;
        private System.Windows.Forms.TextBox textCPAD;
        private System.Windows.Forms.TextBox textCotisationAD;
        private System.Windows.Forms.TextBox textNumLicence;
        private System.Windows.Forms.ListBox ListeAD;
        private System.Windows.Forms.Button Envoyer;
        private System.Windows.Forms.ListBox ListeInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ModifierAD;
        private System.Windows.Forms.Button DeleteAD;
    }
}