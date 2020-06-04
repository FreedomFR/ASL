using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class DAOStands
    {

        // Crée dans la BDD l'objet CompteBancaire passé en paramètre
        public static void creerStand(Stand unStand)
        {
            string requete = "INSERT stand (nomStand, numAlle, surface, numOrdre, nombreSiege, nombreTable) VALUES ('" + unStand.unNomStand + "','" + unStand.uneAlle + "','" + unStand.unOrder + "','" + unStand.unSurface + "','" + unStand.unNombreSiege + "','" + unStand.unNombreTable + "')";
            DAOFactory CS = new DAOFactory();
            CS.connecter();
            CS.execSQLWrite(requete);
        }

        public static List<Stand> getAllStand()
        {
            List<Stand> lesStand = new List<Stand>();
            string req = "Select * from stand";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Stand stand = new Stand(reader[1].ToString(), int.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), int.Parse(reader[4].ToString()), int.Parse(reader[5].ToString()), int.Parse(reader[6].ToString()));
                lesStand.Add(stand);
            }
            return lesStand;
        }

        public static string getIdStand(Stand s)
        {
            string stand = "";
            string req = "Select idStand from stand where nomStand = '" + s.unNomStand + "'";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                stand = reader[0].ToString();
            }
            return stand;
        }

    }
}
//            string requete = "insert into stand values('" + unStand.unNomStand + "','" + unStand.uneAlle + "','" + unStand.unOrder + "','" + unStand.unSurface + "','" + unStand.unNombreSiege + "','" + unStand.unNombreTable + "')";