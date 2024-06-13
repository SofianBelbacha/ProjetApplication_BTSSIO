using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionCategorie
    {
        /// <summary>
        /// Retourne la liste de tous les categories
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuples()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from categorie", "TousLesCategories");
        }

        /// <summary>
        /// Retourne l'identifiant de la categorie en fonction du libelle en paramêtre
        /// </summary>
        /// <returns></returns>
        public static DataTable getIdCategorieByLibelle(string libelle)
        {
            return GestionBoutique.getTuplesRequeteSelect("select idCategorie from categorie where libelle = '" + libelle + "'", "TousLesCategories");
        }

        /// <summary>
        /// Retourne le nombre de categories
        /// </summary>
        /// <returns></returns>
        public static int getNbTuples()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from categorie"));
        }

        /// <summary>
        /// Ajoute une categorie
        /// </summary>
        ///<param name="id">Identifiant de la categorie</param>
        /// <param name="libelle">libelle de la categorie</param>
        
        public static void ajouter(int id, string libelle)
        {
            GestionBoutique.executerRequeteAction("CALL _insert_into_categorie('" + id + "', '" + libelle + "')");
        }

        /// <summary>
        /// Modifie les informations d'une categorie
        /// </summary>
        /// <param name="id">Identifiant de la categorie à modifier</param>
        /// <param name="libelle">Libelle de la categorie à modifier</param>
        
        public static void modifier(string id, string libelle)
        {
            GestionBoutique.executerRequeteAction("UPDATE categorie SET libelle = '" + libelle + "' where idCategorie = " + id);
        }

        /// <summary>
        /// Supprime une categorie
        /// </summary>
        /// <param name="id">Identifiant de la categorie à supprimer</param>
        public static void supprimer(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM categorie WHERE idCategorie = " + id);
        }
    }
}


