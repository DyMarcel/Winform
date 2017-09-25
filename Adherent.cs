using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_winForm
{
    class Adherent
    {
        private int ID ,NumLicence, CP, Cotisation;
        private string Sexe, Nom, Prenom, Adresse, Ville;
        private DateTime DateNaissance;

        public Adherent()
        {
           
        }

        public void SetID(int LId)
        {
            ID = LId;
        }

        public void SetNom(string LeNom)
        {
            Nom = LeNom;
        }

        public void SetPrenom(string LePrenom)
        {
            Prenom = LePrenom;
        }

        public void SetSexe(string LeSexe)
        {
            Sexe = LeSexe;
        }

        public void SetDateNaissance(DateTime LaDateNaissance)
        {
            DateNaissance = LaDateNaissance;
        }

        public void SetAdresse(string LAdresse)
        {
            Adresse = LAdresse;
        }

        public void SetNumLicence(int LeNumLicence)
        {
            NumLicence = LeNumLicence;
        }
        public void SetCP(int LeCP)
        {
            CP = LeCP;
        }

        public void SetVille(string LaVille)
        {
            Ville = LaVille;
        }

        public void SetCotisation(int LaCotisation)
        {
            Cotisation = LaCotisation;
        }

        public int GetID()
        {
            return ID;
        }

        public int GetCP()
        {
            return CP;
        }

        public int GetCotisation()
        {
            return Cotisation;
        }

        public int GetNumLicence()
        {
            return NumLicence;
        }

        public string GetNom()
        {
            return Nom;
        }

        public string GetPrenom()
        {
            return Prenom;
        }

        public string GetSexe()
        {
            return Sexe;
        }
        public string GetVille()
        {
            return Ville;
        }

        public string GetAdresse()
        {
            return Adresse;
        }

        public DateTime GetDateNaissance()
        {
            return DateNaissance;
        }

    }
}
