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
    public partial class InterfaceAffectation : Form
    {
        private List<Adherent> cd;
        private List<club> dc;
        private List<Affectation> abc;

        private int id_ad, id_cd;

        public InterfaceAffectation()
        {
            InitializeComponent();
        }

        private void InterfaceAffectation_Load(object sender, EventArgs e)
        {
            DBConnectTest bb = new DBConnectTest();
            DBConnectTest dd = new DBConnectTest();

            cd = bb.Read();
            dc = dd.ReadClub();

            foreach (Adherent unAdherent in cd)
            {
                AFlistAdherent.Items.Add(unAdherent.GetNom());
            }

            foreach (club unClub in dc)
            {
                AFlistclub.Items.Add(unClub.GetNom());
            }

            
            AfConf.Hide();
        }

        private void BtAff_Click(object sender, EventArgs e)
        {
            int x = AFlistAdherent.SelectedIndex;
            int y = AFlistclub.SelectedIndex;
            id_ad = cd[x].GetID();
            id_cd = dc[y].GetID();
            
            AfConf.Show();
            BtAff.Hide();
        }

        private void AFlistAdherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            listAff.Items.Clear();
            int b = AFlistAdherent.SelectedIndex;
            /*if (id_ad = adc. )
            {
                listAff.Items.Add(dc[b].GetNom());
            }*/
            
        }

        private void AfConf_Click(object sender, EventArgs e)
        {
            DBConnectTest bb = new DBConnectTest();

            bb.Liaison(id_ad, id_cd);

            AfConf.Hide();
            BtAff.Show();
        }
    }
}
