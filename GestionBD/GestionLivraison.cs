using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionLivraison
    {

        /// <summary>
        /// Retourne la liste des Fournisseurs en fonction du produit livrée
        /// </summary>
        /// <param name="idProduit">Identifiant du produit</param>
        /// <returns></returns>
        public static DataTable getFournisseurProduit(int idProduit)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT nomSociete FROM fournisseur, livrer WHERE livrer.idFournisseur = fournisseur.idFournisseur AND livrer.idProduit = " + idProduit, "lesFourniseursDuProduit");
        }

        /// <summary>
        /// Retourne la liste des fournisseurs qui ont livrés un produit
        /// </summary>
        /// <returns></returns>
        public static DataTable getFournisseur()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT distinct fournisseur.nomSociete FROM fournisseur, livrer WHERE fournisseur.idFournisseur = livrer.idFournisseur;", "TousLesNomFournisseurLivreur");
        }

        /// <summary>
        /// Retourne la liste des produits qui ont été livrés
        /// </summary>
        /// <returns></returns>
        public static DataTable getProduit()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT distinct produit.nom FROM produit, livrer WHERE produit.idProduit = livrer.idProduit;", "TousLesProduitLivre");
        }

        /// <summary>
        /// Retourne la liste des dates de produit qui ont été livrés
        /// </summary>
        /// <returns></returns>
        public static DataTable getDatesLivraison()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT DATE_FORMAT(dateLivraison, '%Y-%m-%d %H:%i:%s') AS formattedDateLivraison FROM livrer;", "TousLesDateDeLivraison");
        }

        /// <summary>
        /// Retourne la liste des dates de livraison du produit
        /// </summary>
        /// <param name="idProduit">Identifiant du produit</param>
        /// <returns></returns>
        public static DataTable getDateLivraisonProduit(int idProduit)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT dateLivraison FROM livrer WHERE livrer.idProduit = " + idProduit, "leDatesDeLivraisonDuProduit");
        }


        /// <summary>
        /// Retourne la date de livraison du produit en fonction du fournisseur
        /// </summary>
        /// <param name="idProduit">Identifiant du produit</param> 
        /// <param name="idFournisseur">Identifiant du fournisseur</param>
        /// <returns></returns>
        public static DataTable getDateLivraisonProduitByFournisseur(int idProduit, int idFournisseur)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT DATE_FORMAT(dateLivraison, '%Y-%m-%d %H:%i:%s') AS formattedDateLivraison FROM livrer WHERE livrer.idFournisseur = " + idFournisseur + " AND livrer.idProduit = " + idProduit, "leDatesDeLivraisonDuProduit");
        }

        /// <summary>
        /// Retourne la quantite de produit livrés
        /// </summary>
        /// <param name="idProduit">Identifiant du produit</param> 
        /// <param name="idFournisseur">Identifiant du fournisseur</param>
        /// <returns></returns>
        public static DataTable getQteProduitLivrés(int idProduit, int idFournisseur)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT qteLivrer FROM livrer WHERE livrer.idFournisseur = " + idFournisseur + " AND livrer.idProduit = " + idProduit, "lesQteDeLivraisonDuProduit");
        }

        /// <summary>
        /// Retourne la quantite de produit livrés
        /// </summary>
        /// <param name="idProduit">Identifiant du produit</param> 
        /// <param name="idFournisseur">Identifiant du fournisseur</param>
        /// <returns></returns>
        public static DataTable getprixProduitLivrés(int idProduit, int idFournisseur)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT prix FROM livrer WHERE livrer.idFournisseur = " + idFournisseur + " AND livrer.idProduit = " + idProduit, "lesPrixDeLivraisonDuProduit");
        }

        /// <summary>
        /// Ajoute une livraison
        /// </summary>
        /// <param name="idProduit">Identifiant du produit</param> 
        /// <param name="idFournisseur">Identifiant du fournisseur</param>
        /// <param name="qteLivrer">quantite livrer</param>
        /// <param name="prix">Prix unitaire du produit</param>
        public static void ajouter(int idProduit, int idFournisseur, int qteLivrer, string prix)
        {
            string dateNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            GestionBoutique.executerRequeteAction("INSERT INTO livrer (idProduit, idFournisseur, dateLivraison, qteLivrer, prix) VALUES (" + idProduit + "," + idFournisseur + ", '" + dateNow + "', " + qteLivrer + " , '" + prix + "')");
        }

        /// <summary>
        /// Modifie une livraison
        /// </summary>
        /// <param name="idProduit">Identifiant du produit</param> 
        /// <param name="idFournisseur">Identifiant du fournisseur</param>
        /// <param name="dateLivraison">Date de livraison</param>
        /// <param name="qteLivrer">quantite livrer</param>
        /// <param name="prix">Prix unitaire du produit</param>
        public static void modifier(int idProduit, int idFournisseur, DateTime dateLivraison, int qteLivrer, string prix)
        {
            string formattedDateLivraison = dateLivraison.ToString("yyyy-MM-dd HH:mm:ss");
            GestionBoutique.executerRequeteAction("UPDATE livrer SET qteLivrer = " + qteLivrer + ",prix = '" + prix + "' WHERE idProduit = " + idProduit + " AND idFournisseur = " + idFournisseur + " AND dateLivraison = '" + formattedDateLivraison + "'");

        }

        /// <summary>
        /// Supprime une livraison
        /// </summary>
        /// <param name="idProduit">Identifiant du produit</param> 
        /// <param name="idFournisseur">Identifiant du fournisseur</param>
        /// <param name="dateLivraison">Date de livraison</param>
        public static void supprimer(int idProduit, int idFournisseur, DateTime dateLivraison)
        {
            string formattedDateLivraison = dateLivraison.ToString("yyyy-MM-dd HH:mm:ss");
            GestionBoutique.executerRequeteAction("DELETE FROM livrer WHERE idProduit = " + idProduit + " AND idFournisseur = " + idFournisseur + " AND dateLivraison = '" + formattedDateLivraison + "'");

        }
    }
}
