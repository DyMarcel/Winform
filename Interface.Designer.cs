namespace Projet_winForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Club = new System.Windows.Forms.Button();
            this.Adherent = new System.Windows.Forms.Button();
            this.Affectation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.Affectation);
            this.panel1.Controls.Add(this.Club);
            this.panel1.Controls.Add(this.Adherent);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 176);
            this.panel1.TabIndex = 0;
            // 
            // Club
            // 
            this.Club.Location = new System.Drawing.Point(322, 58);
            this.Club.Name = "Club";
            this.Club.Size = new System.Drawing.Size(107, 33);
            this.Club.TabIndex = 1;
            this.Club.Text = " Club";
            this.Club.UseVisualStyleBackColor = true;
            this.Club.Click += new System.EventHandler(this.Club_Click);
            // 
            // Adherent
            // 
            this.Adherent.Location = new System.Drawing.Point(110, 58);
            this.Adherent.Name = "Adherent";
            this.Adherent.Size = new System.Drawing.Size(109, 33);
            this.Adherent.TabIndex = 0;
            this.Adherent.Text = "Adherent";
            this.Adherent.UseVisualStyleBackColor = true;
            this.Adherent.Click += new System.EventHandler(this.Adherent_Click);
            // 
            // Affectation
            // 
            this.Affectation.Location = new System.Drawing.Point(219, 97);
            this.Affectation.Name = "Affectation";
            this.Affectation.Size = new System.Drawing.Size(107, 32);
            this.Affectation.TabIndex = 2;
            this.Affectation.Text = "Affectattion";
            this.Affectation.UseVisualStyleBackColor = true;
            this.Affectation.Click += new System.EventHandler(this.Affectation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 199);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Interface";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Club;
        private System.Windows.Forms.Button Adherent;
        private System.Windows.Forms.Button Affectation;
    }
}

