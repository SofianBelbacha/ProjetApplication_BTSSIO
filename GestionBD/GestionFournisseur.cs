using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionFournisseur
    {
        /// <summary>
        /// Retourne la liste de tous les fournisseurs
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT fournisseur.*, COUNT(produit.idProduit) AS NombreDeProduits\r\nFROM fournisseur, livrer, produit\r\nWHERE fournisseur.idFournisseur = livrer.idFournisseur\r\nAND livrer.idProduit = produit.idProduit\r\nGROUP BY fournisseur.idFournisseur;", "TousLesFournisseur");
        }

        /// <summary>
        /// Retourne la liste des noms de fournisseurs
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesNom()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT fournisseur.nomSociete FROM fournisseur;", "TousLesNomFournisseur");
        }

        /// <summary>
        /// Retoune l'identifiant du fournisseur en fonction du nom en paramtre
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable getFournisseurByName(string name)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT idFournisseur FROM fournisseur WHERE nomSociete = '" + name + "'", "idFournisseurParNom");
        }


        /// <summary>
        /// Retourne la liste des Produits livreés par fournisseurs
        /// </summary>
        ///<param name="id">id du/des fournisseur(s)</param>
        /// <returns></returns>
        public static DataTable getTuplesProduitByFournisseur(int id)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT  p.nom AS Produit\r\nFROM fournisseur f, livrer l, produit p\r\nWHERE f.idFournisseur = l.idFournisseur\r\nAND l.idProduit = p.idProduit\r\nAND f.idFournisseur = " + id + ";", "CertainClients");
        }

        /// <summary>
        /// Retourne la liste des fournisseur au fur et à mesure dans la datagreed
        /// </summary>
        ///<param name="nom">nom du/des client(s)</param>

        /// <returns></returns>
        public static DataTable getTuplesNom(string nom, string id, string ville)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT u.nom, u.prenom, u.email, u.telephone, u.rue, u.codePostal, u.ville \r\nFROM utilisateur u\r\nINNER JOIN fournisseur c ON u.idUtilisateur = c.idUtilisateur\r\nWHERE u.nom LIKE '%" + nom + "%' OR u.idUtilisateur LIKE '%" + id + "%' OR u.ville LIKE '%" + ville + "%';", "CertainClients");
        }

        /// <summary>
        /// Retourne le nombre de fournisseur
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from fournisseur"));
        }

        /// <summary>
        /// Crée l'utilisateur
        /// </summary>
        ///<param name="id">Identifiant du fournisseur</param>
        /// <param name="nom">Nom du fournisseur</param>
        /// <param name="rue">Rue du fournisseur</param>
        /// <param name="codePostal">Code postal du fournisseur</param>
        /// <param name="ville">Ville du fournisseur</param>
        /// <param name="telehone">Téléphone du fournisseur</param>
        /// <param name="email">Email du fournisseur</param>
        public static void ajouter(int id, string nom, string prenom, string pseudo, string email, string passe, string telehone, string rue, string codePostal, string ville)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO utilisateur (idUtilisateur, nom, prenom, pseudo, email, passe, telephone, rue, codePostal, ville, isAdmin) VALUES ('" + id + "', '" + nom + "', '" + prenom + "', '" + pseudo + "', '" + email + "', '" + passe + "', '" + telehone + "', '" + rue + "', '" + codePostal + "' , '" + ville + "', '" + 0 + "')");
        }

        /// <summary>
        /// Ajoute le fournisseur = l'utilisateur
        /// </summary>
        ///<param name="idFournisseur">Identifiant du client</param>
        ///<param name="idUtilisateur">Identifiant de l'utilisateur</param>
        public static void ajouterFournisseur(int idFournisseur, int idUtilisateur)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO fournisseur (idFournisseur, idUtilisateur) VALUES ('" + idFournisseur + "', '" + idUtilisateur + "')");
        }



        /// <summary>
        /// Modifie les informations d'un fournisseur
        /// </summary>
        /// <param name="id">Identifiant du fournisseur à modifier</param>
        /// <param name="nom">Nom du fournisseur à modifier</param>
        /// <param name="rue">Rue du fournisseur à modifier</param>
        /// <param name="codePostal">Code postal du fournisseur à modifier</param>
        /// <param name="ville">Ville du fournisseur à modifier</param>
        /// <param name="tel">Téléphone du fournisseur à modifier</param>
        /// <param name="email">Email du fournisseur à modifier</param>
        public static void modifier(int id, string nom, string prenom, string pseudo, string email, string passe, string telehone, string rue, string codePostal, string ville)
        {
            GestionBoutique.executerRequeteAction("UPDATE utilisateur SET nom = '" + nom + "', prenom = '" + prenom + "', pseudo = '" + pseudo + "', email = '" + email + "', passe = '" + passe + "', rue = '" + rue + "', codePostal = '" + codePostal + "', ville = '" + ville + "', telephone = '" + telehone + "' where idUtilisateur = " + id);
        }

        /// <summary>
        /// Supprime un fournisseur
        /// </summary>
        /// <param name="id">Identifiant du fournisseur à supprimer</param>
        public static void supprimer(string id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM fournisseur WHERE idUtilisateur = " + id);
        }


    }
}
