using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionProduit
    {
        /// <summary>
        /// Retourne la liste de tous les produits
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            //return GestionBoutique.getTuplesRequeteSelect("SELECT produit.idProduit, produit.nom, produit.description, produit.image, produit.couleur, categorie.libelle AS categorie, COALESCE(livrer.qteLivrer, 0) AS quantite, fournisseur.nomSociete AS fournisseur, livrer.dateLivraison, prixproduit.prix FROM produit LEFT JOIN livrer ON produit.idProduit = livrer.idProduit LEFT JOIN categorie ON produit.idCategorie = categorie.idCategorie LEFT JOIN fournisseur ON livrer.idFournisseur = fournisseur.idFournisseur LEFT JOIN prixproduit ON produit.idProduit = prixproduit.idProduit;\r\n", "TousLesProduit");
            return GestionBoutique.getTuplesRequeteSelect("SELECT p.idProduit, p.nom,   p.description, p.image, p.couleur, c.libelle AS categorie, \r\n\t\tCOALESCE(l.qteLivrer, 0) AS quantite, f.nomSociete AS fournisseur, l.dateLivraison, pp.prix\r\nFROM produit p\r\nLEFT JOIN livrer l ON p.idProduit = l.idProduit \r\nLEFT JOIN categorie c ON p.idCategorie = c.idCategorie \r\nLEFT JOIN fournisseur f ON l.idFournisseur = f.idFournisseur \r\nLEFT JOIN prixproduit pp ON p.idProduit = pp.idProduit\r\nJOIN\r\n    (SELECT idProduit, MAX(JJMMAAAA) AS max_date\r\n     FROM prixproduit\r\n     GROUP BY idProduit) max_pp\r\nON\r\n    pp.idProduit = max_pp.idProduit AND pp.JJMMAAAA = max_pp.max_date;", "TousLesProduit");
        }

        /// <summary>
        /// Retourne les infos du dernier produit
        /// </summary>
        /// <returns></returns>
        public static DataTable getLastProduit()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT produit.nom, prixproduit.prix, produit.image \r\nFROM produit, prixproduit \r\nWHERE produit.idProduit = prixproduit.idProduit\r\nAND produit.idProduit = (select MAX(produit.idProduit) FROM produit );", "LeDernierProduit");
        }

        /// <summary>
        /// Retourne la liste des noms de tous les produits
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesNom()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT distinct produit.nom FROM produit", "TousLesNomDeProduit");
        }

        /// <summary>
        /// Retourne l'id du produit en fonction du libelle en parametre
        /// </summary>
        /// <param name="libelle">liblle du produit</param>
        /// <returns></returns>
        public static DataTable getIdProduitByName(string libelle)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT produit.idProduit FROM produit WHERE produit.nom = '" + libelle + "'", "IdDuProduitParNom");
        }


        /// <summary>
        /// Retourne le nom du produit pour un id en paramétre
        /// </summary>
        ///<param name="id">code du produit(s)</param>
        /// <returns></returns>
        public static DataTable getProduitById(int id)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT produit.nom from produit WHERE produit.idProduit =" + id + "", "NomDUProduitParId");
        }

        /// <summary>
        /// Retourne la clé primaire du produit ajouté
        /// </summary>
        /// <returns></returns>
        public static int getPrimayKeyProduit()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select Max(idProduit) from produit"));
        }

        /// <summary>
        /// Ajouter un produit
        /// </summary>
        ///<param name="nom">libelle du produit</param>
        ///<param name="description">description du produit</param>
        /// <param name="image">image du produit</param>
        ///<param name="couleur">Couleur du produit</param>
        ///<param name="idCategorie">Categorie du produit</param>

        public static void ajouter(string nom, string description, string image, string couleur, int idCategorie)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO produit (nom, description, image, couleur, idCategorie) VALUES ('" + nom + "', '" + description + "', '" + image + "', '" + couleur + "', " + idCategorie + ")");
        }

        /// <summary>
        /// Modifie les informations d'un produit
        /// </summary>
        ///<param name="id">Identifiant du produit à modifier</param>
        ///<param name="nom">nom du produit à modifier</param>
        ///<param name="description">Identifiant du produit</param>
        ///<param name="prix">libelle du produit</param>
        ///<param name="idCategorie">description du produit</param>
        ///<param name="idFournisseur">prix du produit</param>

        public static void modifier(string id, string nom, string description, string image, string couleur, int idCategorie)
        {
            GestionBoutique.executerRequeteAction("UPDATE produit SET nom = '" + nom +"', description = '" + description +"', image = '" + image +"', couleur = '" + couleur + "', idCategorie = '" + idCategorie + "' where idProduit = " + id);
        }

        /// <summary>
        /// Ajoute un prix au produit
        /// </summary>
        /// <param name="id">Identifiant du produit</param>
        /// <param name="prix">Prix du produit</param>
        public static void ajouterPrix(int id, string prix)
        {
            string dateNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            GestionBoutique.executerRequeteAction("INSERT INTO prixproduit (idProduit, JJMMAAAA, prix) VALUES (" + id + ", '" + dateNow + "', '" + prix + "');");
        }

        /// <summary>
        /// Modifie le prix du produit
        /// </summary>
        /// <param name="id">Identifiant du produit</param>
        /// <param name="prix">Prix du produit</param>
        public static void modifierPrix(int id, string prix)
        {
            string dateNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            GestionBoutique.executerRequeteAction("UPDATE prixproduit SET JJMMAAAA = '" + dateNow + "', prix = " + prix + " WHERE idProduit = " + id + ";");
        }

        /// <summary>
        /// Supprime un produit
        /// </summary>
        /// <param name="id">Identifiant du produit à supprimer</param>
        public static void supprimer(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM produit WHERE idProduit = " + id);
        }
    }
}
