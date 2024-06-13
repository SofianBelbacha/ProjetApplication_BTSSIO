using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionCommande
    {
        /// <summary>
        /// Retourne la liste dee infos du produit
        /// </summary>
        /// <returns></returns>
        public static DataTable getInfoProduit()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT produit.nom, SUM(livrer.qteLivrer) AS qte, prixproduit.prix, categorie.libelle\r\nFROM produit, prixproduit, categorie, livrer\r\nWHERE livrer.idProduit = produit.idProduit\r\nAND produit.idCategorie = categorie.idCategorie\r\nAND produit.idProduit = prixproduit.idProduit\r\nGROUP BY produit.nom;", "InfosProduit");
        }

        /// <summary>
        /// Retourne la clé primair en court
        /// </summary>
        /// <returns></returns>
        public static DataTable getPrimaryKeyCommande()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT MAX(commande.idCommande) FROM commande;", "PrimaryKeyCommande");
        }


        /// <summary>
        /// Retourne la dernieres commandes
        /// </summary>
        /// <returns></returns>
        public static DataTable getLastCommande()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT MAX(commande.idCommande), commande.dateCommande, CONCAT(UPPER(client.nom),' ',client.prenom)AS Patronyme, lignedecommande.quantite, produit.nom\r\nFROM commande, client, produit, lignedecommande\r\nWHERE commande.idClient = client.idClient\r\nAND lignedecommande.idCommande = commande.idCommande\r\nAND lignedecommande.idProduit = produit.idProduit;", "LaDerniereCommandes");
        }


        /// <summary>
        /// Retourne la liste de tous les commandes trier par date
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesOrderByDate()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from commande order by date", "TousLesCommandes");
        }

        /// <summary>
        /// Retourne la liste des lignes commandes
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesLigneCommande()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from lignedecommande ", "TousLesLignesCommandes");
        }

        /// <summary>
        /// Retourne la liste des commandes
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesCommande()
        {
            return GestionBoutique.getTuplesRequeteSelect("select commande.idCommande AS 'Commande n°', commande.dateCommande AS 'date de commande', produit.nom AS 'nom du produit', CONCAT(UPPER(client.nom),' ',client.prenom) AS 'nom du client', lignedecommande.quantite AS quantite \r\nfrom produit, client, commande, lignedecommande \r\n\r\nwhere commande.idClient = client.idClient \r\nAND lignedecommande.idProduit = produit.idProduit \r\nAND lignedecommande.idCommande = commande.idCommande;", "TousLesCommandes");
        }

        /// <summary>
        /// Retourne la liste des commandes par id
        /// </summary>
        ///<param name="id">id du/des produits(s)</param>
        /// <returns></returns>
        public static DataTable getTuplesCommandeByChamps(string id, string nom)
        {
            return GestionBoutique.getTuplesRequeteSelect("select commande.idCommande AS 'Commande n°', produit.idProduit 'code du produit', dateCommande AS 'date de commande', produit.nom AS 'nom du produit', utilisateur.nom AS 'nom du client', quantite from produit, client, commande, lignedecommande, utilisateur  where commande.idClient = client.idClient AND lignedecommande.idProduit = produit.idProduit AND lignedecommande.idCommande = commande.idCommande AND client.idUtilisateur = utilisateur.idUtilisateur AND produit.idProduit = '" + id + "' or utilisateur.nom = '" + nom + "'; ", "TousLesCommandes");
        }


        /// <summary>
        /// Retourne la liste des commande au fur et à mesure dans la datagreed
        /// </summary>
        ///<param name="idClient">id du/des client(s)</param>
        ///<param name="id">id de la commande(s)</param>
        ///<param name="date">date de la commande(s)</param>

        /// <returns></returns>
        public static DataTable getTuplesCommandeBySearch(string date, string id, string idClient)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT * from commande WHERE id LIKE '%" + id + "%' or dateCommande LIKE '%" + date + "%' or idClient LIKE '%" + idClient + "%' ", "CertainCommandes");
        }

        /// <summary>
        /// Retourne le nombre de commandes
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from commande"));
        }

        /// <summary>
        /// Ajoute une nouvelle commande
        /// </summary>
        /// <param name="date">date de la commande </param>
        /// <param name="idClient">id du client</param>
        public static void ajouter(string date, int idClient)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO commande (dateCommande, idClient) VALUES ('" + date + "', '" + idClient + "')");
        }

        /// <summary>
        /// Ajoute une nouvelle ligne de commande
        /// </summary>
        ///<param name="idProduit">Identifiant du produit</param>
        /// <param name="idCommande">id de la commande </param>
        /// <param name="quantite">quantite commandé</param>
        public static void ajouterLigneCommande(int idProduit, int idCommande, int quantite)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO lignedecommande (idProduit, idCommande, quantite) VALUES (" + idProduit + ", " + idCommande + ", " + quantite + ")");
        }

        /// <summary>
        /// Modifie les informations d'une commande
        /// </summary>
        ///<param name="id">Identifiant de la commande</param>
        /// <param name="date">date de la commande </param>
        /// <param name="idClient">id du client</param>

        public static void modifier(int id, string date, int idClient)
        {
            GestionBoutique.executerRequeteAction("UPDATE commande SET  dateCommande = '" + date + "', idClient = '" + idClient + "' where idCommande = " + id);
        }

        /// <summary>
        /// Modifie les informations d'une ligne commande
        /// </summary>
        ///<param name="idCommande">Identifiant de la commande</param>
        /// <param name="idProduit">Identifiant du produit </param>
        /// <param name="qte">quantité commandés</param>

        public static void modifierLigneCommande(int idCommande, int idProduit, int qte)
        {
            GestionBoutique.executerRequeteAction("UPDATE lignedecommande SET  idProduit = '" + idProduit + "', quantite = '" + qte + "' where idCommande = " + idCommande);
        }

        /// <summary>
        /// Supprime une commande
        /// </summary>
        /// <param name="id">Identifiant de la commande à supprimer</param>
        public static void supprimer(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM commande WHERE idCommande = " + id);
        }
    }
}
