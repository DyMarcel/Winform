using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_winForm
{
    class club
    {   
        private string Nom, Lieu, SiteWeb, Email, Adresse, Ville;
        private int Telephone, CP, ID;

        public club()
        {
     
        }
    
        public void SetTelephone(int LeTelephone)
        {
            Telephone = LeTelephone;
        }

        public void SetCP(int LeCP)
        {
            CP = LeCP;
        }

        public void SetID(int LID)
        {
            ID = LID;
        }

        public void SetNom(string LeNom)
        {
            Nom = LeNom;
        }

        public void SetLieu(string LeLieu)
        {
            Lieu = LeLieu;
        }

        public void SetAdresse(string LAdresse)
        {
            Adresse = LAdresse;
        }

        public void SetSiteWeb(string LeSiteWeb)
        {
            SiteWeb = LeSiteWeb;
        }

        public void SetEmail(string LEmail)
        {
            Email = LEmail;
        }

        public void SetVille(string LaVille)
        {
            Ville = LaVille;
        }

        public int GetID()
        {
            return ID;
        }

        public int GetCP()
        {
            return CP;
        }

        public int GetTelephone()
        {
            return Telephone;
        }

        public string GetNom()
        {
            return Nom;
        }

        public string GetVille()
        {
            return Ville;
        }

        public string GetLieu()
        {
            return Lieu;
        }

        public string GetAdresse()
        {
            return Adresse;
        }

        public string GetSiteWeb()
        {
            return SiteWeb;
        }

        public string GetEmail()
        {
            return Email;
        }
    }
}
