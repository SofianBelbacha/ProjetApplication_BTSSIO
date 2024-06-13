using GestionBD.MySQL;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD
{
    public static class GestionPS
    {
        #region Gestion des Clients

        public static DataTable getPatronymeById(int idClient)
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL _requeteConsultation('CONCAT(UPPER(nom), \\' \\', prenom)', 'client', 'idClient = " + idClient + "');", "ClientPatronyme");
        }
        public static DataTable getIdByPatronymes(string patronyme)
        {
            return GestionBoutique.getTuplesRequeteSelect("CALL _requeteConsultation('idClient', 'Client', 'CONCAT(UPPER(nom), \\' \\', prenom) = \\'" + patronyme + "\\'');", "ClientPatronymes");
        }


        #endregion

        #region Gestion des commandes

        #endregion
    }
}
