using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ajout des namespaces nécessaires pour les classes utiles avec la gestion de BD
using MySql.Data.MySqlClient;

namespace GestionBD.MySQL
{
    public static class GestionBoutique
    {
        #region champs statiques

        private static MySqlConnection maConnexion = new MySqlConnection();
        private static MySqlCommand maCommandeSpecialRequete = new MySqlCommand();
        private static MySqlDataAdapter monRemplisseur = new MySqlDataAdapter();
        private static DataSet monJeuDeDonnees = new DataSet();
        private static string maRequete;

        #endregion

        #region Méthodes statiques

        /// <summary>
        /// Permet de se connecter avec les infos de connexions de la classe MysqlConfig
        /// </summary>
        public static void seConnecter()
        {
            try
            {
                if (maConnexion.State == ConnectionState.Closed)
                {
                    string maChaine = "Server=" + MysqlConfig.SERVEUR + ";Database=" + MysqlConfig.BASE + "; Uid=" + MysqlConfig.UTILISATEUR + "; Pwd=" + MysqlConfig.MOT_DE_PASSE + ";";
                    //Exemple de valeur correspondante pour maChaine : "Server=localhost;Database=votrenom_boutique;Uid=root;Pwd=;";
                    //Site de référence pour toutes les chaines de connexion : http://www.connectionstrings.com/

                    maConnexion.ConnectionString = maChaine;

                    maConnexion.Open();

                    monJeuDeDonnees = new DataSet("dsBoutique");//On  nomme le DataSet
                    monJeuDeDonnees.Clear();
                    maCommandeSpecialRequete.CommandType = CommandType.Text;
                    maCommandeSpecialRequete.Connection = maConnexion;

                }

            }
            catch (Exception ex)
            {
                // Gérer l'exception ici (par exemple, afficher un message d'erreur)
                Console.WriteLine("Erreur lors de la connexion : " + ex.Message);
            }

        }

        /// <summary>
        /// Permet de se connecter à partir des infos fournies en paramètres
        /// (provenant d'un formulaire de Connexion par exemple...)
        /// </summary>
        /// <param name="nomServeur">Nom du serveur</param>
        /// <param name="nomBase">Nom de la base de données</param>
        /// <param name="nomUtilisateur">Nom de l'utilisateur</param>
        /// <param name="motDePasse">Mot de passe</param>
        public static void seConnecter(string nomServeur, string nomBase, string nomUtilisateur, string motDePasse)
        {
            if (maConnexion.State == ConnectionState.Closed)
            {
                string maChaine = "Server=" + nomServeur + ";Database=" + nomBase + "; Uid=" + nomUtilisateur + "; Pwd=" + motDePasse + ";";
                //Exemple de valeur correspondante pour maChaine : "Server=localhost;Database=votrenom_boutique;Uid=root;Pwd=;";
                //Site de référence pour toutes les chaines de connexion : http://www.connectionstrings.com/

                maConnexion.ConnectionString = maChaine;

                maConnexion.Open();

                monJeuDeDonnees = new DataSet("dsBoutique");//On  nomme le DataSet
                monJeuDeDonnees.Clear();
                maCommandeSpecialRequete.CommandType = CommandType.Text;
                maCommandeSpecialRequete.Connection = maConnexion;

            }
        }
       

        /// <summary>
        /// Permet de vider le DataSet en mémoire
        /// </summary>
        public static void viderJeuDonnees()
        {
            monJeuDeDonnees.Clear();
        }


        #region FACTORISATION pour les requêtes de CONSULTATION, requêtes SCALAIRES et d'ACTION

        /// <summary>
        /// Récupère le résultat d'une requête SELECT
        /// </summary>
        /// <param name="texteRequete">Texte de la requête SQL</param>
        /// <param name="nomDataTable">Nom de la DataTable contenue dans le DataSet</param>
        /// <returns>DataTable retournée avec les tuples renvoyés par le SELECT</returns>
        public static DataTable getTuplesRequeteSelect(string texteRequete, string nomDataTable)
        {
            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.monRemplisseur.SelectCommand = GestionBoutique.maCommandeSpecialRequete;
            if (GestionBoutique.monJeuDeDonnees.Tables.Contains(nomDataTable))
            {
                monJeuDeDonnees.Tables[nomDataTable].Clear();
            }
            GestionBoutique.monRemplisseur.Fill(GestionBoutique.monJeuDeDonnees, nomDataTable);
            return GestionBoutique.monJeuDeDonnees.Tables[nomDataTable];
        }

        /// <summary>
        /// Récupère le résultat d'une requête scalaire
        /// (Contenant un agrégat de type COUNT, SUM, AVG, MIN, MAX...
        /// </summary>
        /// <param name="texteRequete">Texte de la requête SQL</param>
        /// <returns>Résultat retourné de type DOUBLE</returns>
        public static double getResultatRequeteScalaire(string texteRequete)
        {
            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            return Convert.ToDouble(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());

        }

        /// <summary>
        /// Exécute une requête de type ACTION
        /// (c'est à dire de type INSERT, UPDATE, DELETE)
        /// </summary>
        /// <param name="texteRequete">Texte de la requête SQL</param>
        public static void executerRequeteAction(string texteRequete)
        {
            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }

        #endregion



        #region Autres méthodes utiles
        /// <summary>
        /// Permet de générer une valeur de clé primaire pour une table donnée en paramètre
        /// (sorte d'AUTO-INCREMENT pour une table créé sans) 
        /// La clé primaire est nommée id dans toutes les tables
        /// (sinon ajouter un paramètre contenant le nom de la clé)
        /// </summary>
        /// <param name="nomtable">Nom de la table</param>
        /// <returns>Valeur de clé primaire généré</returns>
        public static int getNouvelleClePrimaire(string nomTable)
        {
            int Cle = Convert.ToInt32(GestionBoutique.getResultatRequeteScalaire("SELECT Max(id) FROM " + nomTable));
            return (Cle + 1);
        }

        #endregion

        #endregion

    }
}
