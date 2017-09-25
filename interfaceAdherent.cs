using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projet_winForm
{
    public partial class interfaceAdherent : Form
    {
        private List<Adherent> bb;
        private int ID;

        public interfaceAdherent()
        {
            InitializeComponent();
            ID = 0; //utile lors de la modification d'un adherent
        }

        /// <summary>
        /// bouton qui envoie les différents donnée des champs dans le base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Envoyer_Click(object sender, EventArgs e)
        {
            
            DBConnectTest Db = new DBConnectTest();
            string nom = textNomAD.Text;
            string prenom = textPrenomAD.Text;
            string adresse = textAdresseAD.Text;
            string ville = textVilleAD.Text;
            string sexe = textSexeAD.Text;
            int cotisation = Convert.ToInt32(textCotisationAD.Text);
            int CP = Convert.ToInt32(textCPAD.Text);
            int numLicence = Convert.ToInt32(textNumLicence.Text);
            DateTime DateNaissance = dateTimePicker1.Value;
            DateNaissance.Date.ToString("dd-MM-yyyy");
            Db.InsertAD(nom, prenom, ville, adresse, sexe, CP, cotisation, DateNaissance, numLicence);

            textBoxClearAD();

            ListeAD.Items.Clear();
            actuAD();

        }



        /// <summary>
        /// Aux moment de la chargement de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void interfaceAdherent_Load(object sender, EventArgs e)
        {
            DBConnectTest db = new DBConnectTest();
             bb = db.Read();
            foreach (Adherent unAdherent in bb)
            {
                ListeAD.Items.Add(unAdherent.GetNom());
            }

            ConfirmeAD.Hide();
        }
        /// <summary>
        /// permet d'afficher les donnée de la base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListeAD_Click(object sender, EventArgs e)
        {
            ListeInfo.Items.Clear();
            int x = ListeAD.SelectedIndex;
            ID = Convert.ToInt32(bb[x].GetID());
            ListeInfo.Items.Add(bb[x].GetPrenom());
            ListeInfo.Items.Add(bb[x].GetDateNaissance());
            ListeInfo.Items.Add(bb[x].GetSexe());
            ListeInfo.Items.Add(bb[x].GetVille());
            ListeInfo.Items.Add(bb[x].GetAdresse());
            ListeInfo.Items.Add(bb[x].GetNumLicence());
            ListeInfo.Items.Add(bb[x].GetCP());
            ListeInfo.Items.Add(bb[x].GetCotisation());

        }
        /// <summary>
        /// permet de recuperer les données de la base de donnée et les metre dans les champs et ainsi les modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierAD_Click(object sender, EventArgs e)
        {
            int x = ListeAD.SelectedIndex;

            DBConnectTest db = new DBConnectTest();
            textNomAD.Text = bb[x].GetNom();
            textPrenomAD.Text = bb[x].GetPrenom();
            dateTimePicker1.Text = Convert.ToString(bb[x].GetDateNaissance());
            textSexeAD.Text = bb[x].GetSexe();
            textVilleAD.Text = bb[x].GetVille();
            textAdresseAD.Text = bb[x].GetAdresse();
            textNumLicence.Text = Convert.ToString(bb[x].GetNumLicence());
            textCPAD.Text = Convert.ToString(bb[x].GetCP());
            textCotisationAD.Text = Convert.ToString(bb[x].GetCotisation());
            ID = bb[x].GetID();

            ConfirmeAD.Show();
            ModifierAD.Hide();

           // if ()
          
            
        }
        /// <summary>
        /// envoie les champs modifier dans la base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmeAD_Click(object sender, EventArgs e)
        {
            DBConnectTest db = new DBConnectTest();
            string upNom = textNomAD.Text;
            string upPrenom = textPrenomAD.Text;
            DateTime upDate = dateTimePicker1.Value;
            string upSexe = textSexeAD.Text;
            string upVille = textVilleAD.Text;
            string upAdresse = textAdresseAD.Text;
            int upNumLicence = Convert.ToInt32(textNumLicence.Text);
            int upCP = Convert.ToInt32(textCPAD.Text);
            int upCotisation = Convert.ToInt32(textCotisationAD.Text);

            db.UpdateAD(upNom, upPrenom, upVille, upAdresse, upSexe, upCP, upCotisation, upDate, upNumLicence, ID);
            actuAD();

            textBoxClearAD();
            ConfirmeAD.Hide();
            ModifierAD.Show();
            ID = 0;
        }
        /// <summary>
        /// supprime un un objet de la liste d'adherent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAD_Click(object sender, EventArgs e)
        {
            int x = ListeAD.SelectedIndex;

            DBConnectTest db = new DBConnectTest();
            ID = Convert.ToInt32(bb[x].GetID());

            db.DeleteAD(ID);
            ListeInfo.Items.Clear();
            actuAD();
        }
        /// <summary>
        /// actualise la liste d'adherent
        /// </summary>
        private void actuAD()
        {
            ListeAD.Items.Clear();
            DBConnectTest db = new DBConnectTest();
            bb = db.Read();
            foreach (Adherent unAdherent in bb)
            {
                ListeAD.Items.Add(unAdherent.GetNom());
            }
        }
        /// <summary>
        /// vide les champs  
        /// </summary>
        private void textBoxClearAD()
        {
            textAdresseAD.Clear();
            textNomAD.Clear();
            textPrenomAD.Clear();
            textVilleAD.Clear();
            textSexeAD.Clear();
            textCotisationAD.Clear();
            textCPAD.Clear();
            textNumLicence.Clear();
        }

       
    }   
}