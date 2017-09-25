using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_winForm
{
    class Affectation
    {
        private int id, id_club, id_adherent;

        public Affectation()
        {
            
        }

        public void SetId(int ID)
        {
            ID = id;
        }

        public void SetId_club(int id_Club)
        {
            id_club = id_Club;
        }

        public void SetId_adherent(int id_Adherent)
        {
            id_adherent = id_Adherent;
        }
 

        public int Getid()
        {
            return id;
        }

        public int Getid_club()
        {
            return id_club;
        }

        public int Getid_adherent()
        {
            return id_adherent;
        }
    }
}
