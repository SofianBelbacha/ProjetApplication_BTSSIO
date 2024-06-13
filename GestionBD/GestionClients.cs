using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionClients
    {

        /// <summary>
        /// Retourne la liste de tous les clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from client", "TousLesClients");
        }

        /// <summary>
        /// Retourne le dernier clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getLastIdClient()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT MAX(client.idClient), CONCAT(UPPER(client.nom),' ',client.prenom)AS Patronyme FROM client ;\r\n", "LeDernierClients");
        }

        /// <summary>
        /// Retourne la liste des Patronymes de Clients : id et NOM prenom)
        /// </summary>
        /// <returns></returns>
        public static DataTable getPatronymes()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT CONCAT(UPPER(nom),' ',prenom) AS Patronyme FROM client", "TousLesPatronymesClients");
        }

        /// <summary>
        /// Retourne l'id du client en fonction de son Patronymes
        /// </summary>
        /// <param name="patronyme">patronyme du client</param>
        /// <returns></returns>
        public static DataTable getIdByPatronymes(string patronyme)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT idClient FROM Client WHERE CONCAT(UPPER(nom),' ',prenom) = '" + patronyme + "'", "IdClientParPatronyme");
        }

        /// <summary>
        /// Retourne la liste des Patronymes de Clients en fonction de leur id : NOM prenom)
        /// </summary>
        /// <returns></returns>
        public static DataTable getPatronymeById(int idClient)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT CONCAT(UPPER(nom),' ',prenom) FROM client WHERE idClient = " + idClient + "", "TousLesPatronymesClientsParId");
        }

        /// <summary>
        /// Retourne la liste des clients recherché
        /// </summary>
        /// <param name="nom">Nom du client</param>
        /// <param name="prenom">Prénom du client</param>
        /// <param name="rue">Adresse du client</param>
        /// <param name="codePostal">Code postal du client</param>
        /// <param name="ville">Ville du client</param>
        /// <param name="telephone">Téléphone du client</param>
        /// <param name="email">Email du client</param>
        /// <returns></returns>
        public static DataTable getClientBySearch(string nom, string prenom, string rue, string codePostal, string ville, string telephone, string email)
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from client where nom LIKE '" + nom + "%' and prenom LIKE '" + prenom + "%' and ville LIKE '" + ville + "%' and codePostal LIKE '" + codePostal + "%' and rue LIKE '" + rue + "%' and telephone LIKE '" + telephone + "%' and email LIKE '" + email + "%' ", "TousLesClients");
            //return GestionBoutique.getTuplesRequeteSelect("CALL '_recherche_clients'('" + nom + "', '" + prenom + "', '" + rue + "', '" + codePostal + "', '" + ville + "', '" + telephone + "', '" + email + "')", "RechercheClient");
        }

        /// <summary>
        /// Retourne le nombre de clients
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from client"));
        }

        /// <summary>
        /// Ajoute un client
        /// </summary>
        /// <param name="nom">Nom du client</param>
        /// <param name="prenom">Prénom du client</param>
        /// <param name="rue">Rue du client</param>
        /// <param name="codePostal">Code postal du client</param>
        /// <param name="ville">Ville du client</param>
        /// <param name="tel">Téléphone du client</param>
        /// <param name="email">Email du client</param>
        public static void ajouter(string nom, string prenom, string rue, string codePostal, string ville, string tel, string email)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO client (nom, prenom, rue, codePostal, ville, telephone, email) VALUES ('" + nom + "','" + prenom + "', '" + rue + "', '" + codePostal + "' , '" + ville + "', '" + tel + "', '" + email + "')");
        }

        /// <summary>
        /// Modifie les informations d'un client
        /// </summary>
        /// <param name="id">Identifiant du client à modifier</param>
        /// <param name="nom">Nom du client à modifier</param>
        /// <param name="prenom">Prénom du client à modifier</param>
        /// <param name="rue">Rue du client à modifier</param>
        /// <param name="codePostal">Code postal du client à modifier</param>
        /// <param name="ville">Ville du client à modifier</param>
        /// <param name="tel">Téléphone du client à modifier</param>
        /// <param name="email">Email du client à modifier</param>
        public static void modifier(int id, string nom, string prenom, string rue, int codePostal, string ville, string tel, string email)
        {
            GestionBoutique.executerRequeteAction("UPDATE client SET nom = '" + nom + "',prenom = '" + prenom + "',rue = '" + rue + "',codePostal =" + codePostal + ",ville='" + ville + "', telephone = '" + tel + "', email='" + email + "' WHERE idClient = " + id);
        }

        /// <summary>
        /// Supprime un user
        /// </summary>
        /// <param name="id">Identifiant du client à supprimer</param>
        public static void supprimerUser(int id)
        {
            GestionBoutique.executerRequeteAction("CALL '_supprimer_utilisateur_par_id'('" + id + "')");
        }


        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="id">Identifiant du client à supprimer</param>
        public static void supprimer(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM client WHERE idClient = " + id);
        }

        /// <summary>
        /// retourne le nombre de commande par client.
        /// </summary>
        /// <param name="idClient">Identifiant du client</param>
        public static Double getNbCommandesByClient_FS(int idClient)
        {
            return GestionBoutique.getResultatRequeteScalaire("CALL 'selectNbCommandesByClient_FS'('" + idClient + "')");
        }

    }
}
