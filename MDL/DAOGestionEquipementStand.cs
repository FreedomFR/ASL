using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class DAOGestionEquipementStand
    {
        public static void addEquipementStand(GestionEquipementStand g)
        {
            string requete = "INSERT equipementStand (idEquipement, idStand) VALUES ('" + g.unIdEquiment + "','" + g.unIdStand + "')";
            DAOFactory CS = new DAOFactory();
            CS.connecter();
            CS.execSQLWrite(requete);
        }

        public static List<Equipement> getAllEquipementStand(GestionEquipementStand g)
        {
            List<Equipement> lesEquipement = new List<Equipement>();
            string req = "Select libelle, prixEquipementier, prixClubOrganisateur from equipement inner join equipementStand on equipementStand.idEquipement = equipement.idEquipement where idStand = '" + g.unIdStand + "'";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);
            if (reader.HasRows) 
            {
                while (reader.Read())
                {
                    Equipement equipement = new Equipement(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                    lesEquipement.Add(equipement);
                }
            }
            else 
            {
                lesEquipement = null;
            }

        return lesEquipement;
        }
    }
}
