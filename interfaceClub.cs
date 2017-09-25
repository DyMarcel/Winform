using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_winForm
{
    public partial class interfaceClub : Form
    {
        List<club> CB;
        private int ID;
        public interfaceClub()
        {
            InitializeComponent();
            ID = 0;
        }

        /// <summary>
        /// recupére que les différents champs et les envoie dans la basse de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjoutClub_Click(object sender, EventArgs e)
        {
            DBConnectTest Db = new DBConnectTest();
            
            string nom = textNomCB.Text;
            string ville = textVilleCB.Text;
            string email = textEmailCB.Text;
            string lieu = textLieuCB.Text;
            string adresse = textAdresseCB.Text;
            string site = textSiteCB.Text;
            int cp = Convert.ToInt32(textCpCB.Text);
            int telephone = Convert.ToInt32(textTelephoneCB.Text);

            Db.InsertCB(nom, email, ville, adresse, lieu, site, cp, telephone);

            listClub.Items.Clear();
            textBoxClear();
            actuCB();


        }

        /// <summary>
        /// active aux moment de charger les fenetres 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void interfaceClub_Load(object sender, EventArgs e)
        {
            DBConnectTest db = new DBConnectTest();
            CB = db.ReadClub();
            foreach (club unclub in CB)
            {
                listClub.Items.Add(unclub.GetNom());
            }
            ConfirmerCB.Hide();
        }

        /// <summary>
        /// actualise la liste d'un club
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            listInfoCB.Items.Clear();
            int y = listClub.SelectedIndex;
            listInfoCB.Items.Add(CB[y].GetNom());
            listInfoCB.Items.Add(CB[y].GetEmail());
            listInfoCB.Items.Add(CB[y].GetLieu());
            listInfoCB.Items.Add(CB[y].GetAdresse());
            listInfoCB.Items.Add(CB[y].GetVille());
            listInfoCB.Items.Add(CB[y].GetCP());
            listInfoCB.Items.Add(CB[y].GetTelephone());
            listInfoCB.Items.Add(CB[y].GetSiteWeb());

            //listAffectation.Items.Add();

            
        }

        /// <summary>
        /// actualise la liste d'un club
        /// </summary>
        public void actuCB()
        {
            listInfoCB.Items.Clear();
            DBConnectTest db = new DBConnectTest();
            CB = db.ReadClub();
            foreach (club unclub in CB)
            {
                listClub.Items.Add(unclub.GetNom());
            }
        }

        /// <summary>
        /// Suprime un element de la listbox d'un club
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerCB_Click(object sender, EventArgs e)
        {
            int x = listClub.SelectedIndex;

            DBConnectTest Db = new DBConnectTest();
            ID = Convert.ToInt32(CB[x].GetID());

            Db.DeleteCB(ID);
            listInfoCB.Items.Clear();
            listClub.Items.Clear();
            textBoxClear();
            actuCB();

        }
        /// <summary>
        /// vider les champs
        /// </summary>
        private void textBoxClear()
        {
            textAdresseCB.Clear();
            textNomCB.Clear();
            textLieuCB.Clear();
            textVilleCB.Clear();
            textTelephoneCB.Clear();
            textCpCB.Clear();
            textEmailCB.Clear();
            textSiteCB.Clear();
        }
        /// <summary>
        /// methode qui permet d'effectué suite a l'évenement click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierCB_Click(object sender, EventArgs e)
        {
            int x = listClub.SelectedIndex;

            DBConnectTest db = new DBConnectTest();
            textNomCB.Text = CB[x].GetNom();
            textAdresseCB.Text = CB[x].GetAdresse();
            textLieuCB.Text = CB[x].GetLieu();
            textCpCB.Text = Convert.ToString(CB[x].GetCP());
            textTelephoneCB.Text = Convert.ToString(CB[x].GetTelephone());
            textEmailCB.Text = CB[x].GetEmail();
            textVilleCB.Text = CB[x].GetVille();
            textSiteCB.Text = CB[x].GetSiteWeb();

            ID = CB[x].GetID();
            
            ConfirmerCB.Show();
            ModifierCB.Hide();
            AjoutClub.Hide();
            supprimerCB.Hide();

        }
        /// <summary>
        /// methode qui permet d'effectué suite a l'evenement click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmerCB_Click(object sender, EventArgs e)
        {
            DBConnectTest db = new DBConnectTest();

            string UPNom = textNomCB.Text;
            string UPAdresse = textAdresseCB.Text;
            string UPLieu = textLieuCB.Text;
            int UPcp = Convert.ToInt32(textCpCB.Text);
            int UPtelephones = Convert.ToInt32(textTelephoneCB.Text);
            string UPemail = textEmailCB.Text;
            string UPville = textVilleCB.Text;
            string UPsite = textSiteCB.Text;

            db.UpdateCB(UPNom, UPAdresse, UPville, UPAdresse, UPLieu, UPsite, UPcp, UPtelephones, ID);

            listClub.Items.Clear();
            actuCB();

            ConfirmerCB.Hide();
            ModifierCB.Show();
            supprimerCB.Show();
            AjoutClub.Show();

            textBoxClear();
            ID = 0;

        }

    }
}
