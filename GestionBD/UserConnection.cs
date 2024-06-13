using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public static class UserConnection
    {
        /// <summary>
        /// Retourne la liste de tous les produits
        /// <param name="login">Login de l'utilisateur</param>
        /// <param name="passe">Password de l'utilisateur</param>
        /// </summary>
        /// <returns></returns>
        public static DataTable getConnexion(string login, string passe)
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT * FROM utilisateur WHERE login = '" + login + "' AND passe = '" + passe + "' AND isAdmin = 1", "getConnect");
        }
    }
}
