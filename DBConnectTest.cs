using MySql.Data.MySqlClient;
using Projet_winForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projet_winForm
{
    class DBConnectTest
    {

        private string connectionString;

        //Constructor
        public DBConnectTest()
        {
            Initialize();
        }

        /// <summary>
        /// Initialise les champs et cree un objet connection.
        /// </summary>
        private void Initialize()
        {
            string server = "localhost";
            string port = "3306";
            string database = "exo";
            string uid = "root";
            string password = "";
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        }



        /// <summary>
        /// La méthode Read retourne une liste adherent en fonction de son Nom dans la table. 
        /// </summary>
        /// <param name="Nom">id du adherent recherché</param>
        /// <returns></returns>
        public List<Adherent> Read()
        {
            Adherent ladherent = null;
            List<Adherent> ListAD = new List<Adherent>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM adherent";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

               

                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                       ladherent = new Adherent();
                        ladherent.SetID((int)dataReader["id"]);
                        ladherent.SetNom((string)dataReader["Nom"]);
                        ladherent.SetVille((string)dataReader["Ville"]);
                        ladherent.SetAdresse((string)dataReader["Adresse"]);
                        ladherent.SetDateNaissance((DateTime)dataReader["DateNaissance"]);
                        ladherent.SetPrenom((string)dataReader["Prenom"]);
                        ladherent.SetSexe((string)dataReader["Sexe"]);
                        ladherent.SetCP((int)dataReader["CP"]);
                        ladherent.SetNumLicence((int)dataReader["NumLicence"]);
                        ladherent.SetCotisation((int)dataReader["Cotisation"]);
                        ListAD.Add(ladherent);

                     
                    }

                }


            }

            return ListAD;
        }
        /// <summary>
        /// methode qui pert d'ajouter un nouvelle adherent dans la base de donnée 
        /// </summary>
        /// <param name="Nom"></param>
        /// <param name="Prenom"></param>
        /// <param name="Ville"></param>
        /// <param name="Adresse"></param>
        /// <param name="Sexe"></param>
        /// <param name="CP"></param>
        /// <param name="Cotisation"></param>
        /// <param name="dateNaissance"></param>
        /// <param name="NumLicence"></param>
        /// <returns></returns>
        public Adherent InsertAD(string Nom, string Prenom, string Ville, string Adresse, string Sexe, int CP, int Cotisation, DateTime dateNaissance, int NumLicence)
        {
            Adherent ladherent = null;

            using (MySqlConnection conection = new MySqlConnection(connectionString))
            {
                conection.Open();
                string query = "INSERT INTO adherent (Nom, Prenom, Ville , Adresse, Sexe, CP, Cotisation, dateNaissance, NumLicence) VALUES (@Nom, @Prenom, @Ville, @Adresse, @Sexe ,@CP ,@Cotisation, @DateNaissance, @NumLicence )";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conection);

                dateNaissance.Date.ToString("dd-MM-yyyy");
                cmd.Parameters.AddWithValue("@Nom",Nom);
                cmd.Parameters.AddWithValue("@Prenom", Prenom);
                cmd.Parameters.AddWithValue("@adresse", Adresse);
                cmd.Parameters.AddWithValue("@Sexe", Sexe);
                cmd.Parameters.AddWithValue("@CP", Convert.ToString(CP));
                cmd.Parameters.AddWithValue("@DateNaissance",dateNaissance);
                cmd.Parameters.AddWithValue("@Ville", Ville);
                cmd.Parameters.AddWithValue("@Cotisation",Convert.ToString(Cotisation));
                cmd.Parameters.AddWithValue("@NumLicence",Convert.ToString(NumLicence));
               
                cmd.ExecuteNonQuery();
                ladherent = new Adherent();
                conection.Close();
                    
                

            }

            return ladherent;
        }
        /// <summary>
        /// methode qui permet de supprimé un adherent 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Adherent DeleteAD(int ID)
        {
            Adherent ladherent = null;

            using (MySqlConnection conection = new MySqlConnection(connectionString))
            {
                conection.Open();
                string query = "DELETE from adherent Where id = @ID";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conection);

                cmd.Parameters.AddWithValue("@id", ID);

                cmd.ExecuteNonQuery();
                ladherent = new Adherent();
                conection.Close();

            }

            return ladherent;
        }
        /// <summary>
        /// methode qui permet de metre a jour les données liée a un adherent 
        /// </summary>
        /// <param name="Nom"></param>
        /// <param name="Prenom"></param>
        /// <param name="Ville"></param>
        /// <param name="Adresse"></param>
        /// <param name="Sexe"></param>
        /// <param name="CP"></param>
        /// <param name="Cotisation"></param>
        /// <param name="dateNaissance"></param>
        /// <param name="NumLicence"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Adherent UpdateAD(string Nom, string Prenom, string Ville, string Adresse, string Sexe, int CP, int Cotisation, DateTime dateNaissance, int NumLicence, int ID)
        {
            Adherent ladherent = null;

            using (MySqlConnection conection = new MySqlConnection(connectionString))
            {
                conection.Open();
                string query = "Update adherent Set Nom = @Nom, Prenom = @Prenom , Ville = @Ville , Adresse = @Adresse , Sexe = @Sexe, CP = @CP, Cotisation = @Cotisation , dateNaissance = @DateNaissance , NumLicence = @NumLicence Where id = @id";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conection);

                dateNaissance.Date.ToString("dd-MM-yyyy");
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@Nom", Nom);
                cmd.Parameters.AddWithValue("@Prenom", Prenom);
                cmd.Parameters.AddWithValue("@adresse", Adresse);
                cmd.Parameters.AddWithValue("@Sexe", Sexe);
                cmd.Parameters.AddWithValue("@CP", Convert.ToString(CP));
                cmd.Parameters.AddWithValue("@DateNaissance", dateNaissance);
                cmd.Parameters.AddWithValue("@Ville", Ville);
                cmd.Parameters.AddWithValue("@Cotisation", Convert.ToString(Cotisation));
                cmd.Parameters.AddWithValue("@NumLicence", Convert.ToString(NumLicence));

                cmd.ExecuteNonQuery();
                ladherent = new Adherent();
                conection.Close();



            }

            return ladherent;
        }
        /// <summary>
        /// methode retourne une liste de club en fonction du nom 
        /// </summary>
        /// <returns></returns>
        public List<club> ReadClub()
        {
            club leclub = null;
            List<club> ListCB = new List<club>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM club";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);



                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        leclub = new club();
                        leclub.SetID((int)dataReader["id"]);
                        leclub.SetNom((string)dataReader["Nom"]);
                        leclub.SetVille((string)dataReader["Ville"]);
                        leclub.SetAdresse((string)dataReader["Adresse"]);
                        leclub.SetEmail((string)dataReader["Email"]);
                        leclub.SetSiteWeb((string)dataReader["SiteWeb"]);
                        leclub.SetLieu((string)dataReader["Lieu"]);
                        leclub.SetCP((int)dataReader["CP"]);
                        leclub.SetTelephone((int)dataReader["Telephone"]);
                        ListCB.Add(leclub);

                    }

                }


            }

            return ListCB;
        }
        /// <summary>
        /// methode qui permet d'ajouter un club
        /// </summary>
        /// <param name="Nom"></param>
        /// <param name="Email"></param>
        /// <param name="Ville"></param>
        /// <param name="Adresse"></param>
        /// <param name="Lieu"></param>
        /// <param name="Siteweb"></param>
        /// <param name="CP"></param>
        /// <param name="Telephone"></param>
        /// <returns></returns>
        public club InsertCB(string Nom, string Email, string Ville, string Adresse, string Lieu, string Siteweb, int CP, int Telephone)
        {
            club leClub = null;

            using (MySqlConnection conection = new MySqlConnection(connectionString))
            {
                conection.Open();
                string query = "INSERT INTO club (Nom, Email, Ville , Adresse, Lieu, Siteweb, CP, Telephone) VALUES (@Nom, @Email, @Ville, @Adresse, @Lieu, @SiteWeb ,@CP ,@Telephone)";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conection);

                cmd.Parameters.AddWithValue("@Nom", Nom);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@adresse", Adresse);
                cmd.Parameters.AddWithValue("@Lieu", Lieu);
                cmd.Parameters.AddWithValue("@Ville", Ville);
                cmd.Parameters.AddWithValue("@SiteWeb", Siteweb);
                cmd.Parameters.AddWithValue("@CP", Convert.ToString(CP));
                cmd.Parameters.AddWithValue("@Telephone", Convert.ToString(Telephone));

                cmd.ExecuteNonQuery();
                leClub = new club();
                conection.Close();
            }
        
            return leClub;
        }
        /// <summary>
        /// methode qui permet de supprimée un club
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public club DeleteCB(int ID)
        {
            club leclub = null;

            using (MySqlConnection conection = new MySqlConnection(connectionString))
            {
                conection.Open();
                string query = "DELETE from club Where id = @ID";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conection);

                cmd.Parameters.AddWithValue("@id", ID);

                cmd.ExecuteNonQuery();
                leclub = new club();
                conection.Close();

            }

            return leclub;
        }
        /// <summary>
        /// methode qui permet de modifier les attributs d'un club  
        /// </summary>
        /// <param name="Nom"></param>
        /// <param name="Email"></param>
        /// <param name="Ville"></param>
        /// <param name="Adresse"></param>
        /// <param name="Lieu"></param>
        /// <param name="Siteweb"></param>
        /// <param name="CP"></param>
        /// <param name="Telephone"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public club UpdateCB(string Nom, string Email, string Ville, string Adresse, string Lieu, string Siteweb, int CP, int Telephone, int ID)
        {
            club leclub = null;

            using (MySqlConnection conection = new MySqlConnection(connectionString))
            {
                conection.Open();
                string query = "Update club Set Nom = @Nom, Email = @Email , Ville = @Ville , Adresse = @Adresse , Lieu = Lieu, Siteweb = @SiteWeb, CP = @CP, Telephone = @Telephone Where id = @id";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conection);

                
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@Nom", Nom);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@adresse", Adresse);
                cmd.Parameters.AddWithValue("@Lieu", Lieu);
                cmd.Parameters.AddWithValue("@Ville", Ville);
                cmd.Parameters.AddWithValue("@SiteWeb", Siteweb);
                cmd.Parameters.AddWithValue("@CP", Convert.ToString(CP));
                cmd.Parameters.AddWithValue("@Telephone", Convert.ToString(Telephone));

                cmd.ExecuteNonQuery();
                leclub = new club();
                conection.Close();



            }

            return leclub;


        }
        /// <summary>
        /// methode qui lie la classe adherent et club a la table affectation
        /// </summary>
        /// <param name="idA"></param>
        /// <param name="idC"></param>
        /// <returns></returns>
        public Affectation Liaison(int idA, int idC)
        {
            Affectation aff = null;

            using (MySqlConnection conection = new MySqlConnection(connectionString))
            {
                conection.Open();
                string query = "Insert into affectation (id_adherent, id_club) values (@idA, @idC)";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conection);


                 cmd.Parameters.AddWithValue("@idA",idA);
                 cmd.Parameters.AddWithValue("@idC",idC);
               

                cmd.ExecuteNonQuery();
                aff = new Affectation();
                conection.Close();

            }
            return aff;
        }

        public List<Affectation> ReadAff()
        {
            Affectation uneAff = null;
            List<Affectation> listAff = new List<Affectation>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM affectation";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);



                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        uneAff = new Affectation();
                        uneAff.SetId((int)dataReader["id"]);
                        uneAff.SetId_adherent((int)dataReader["id_ad"]);
                        uneAff.SetId_club((int)dataReader["id_cd"]);

                        listAff.Add(uneAff);
                    }
                }
            }

            return listAff;
        }

        public securite connexion()
        {
            securite secu = null;
           

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM securite";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);



                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        secu = new securite();
                        secu.SetID((int)dataReader["id"]);
                        secu.SetLogin((string)dataReader["login"]);
                        secu.SetMDP((string)dataReader["MDP"]);
                       
                        
                    }

                }


            }

            return secu ;
        }

    }
               
}


