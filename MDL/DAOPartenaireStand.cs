using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class DAOPartenaireStand
    {
        public static void addPartenaireStand(PartenaireStand p)
        {
            string requete = "INSERT equipementStand (idStand, idPartenaire, prix) VALUES ('" + p.unIdStand + "','" + p.unIdPartenaire + "','" + p.unPrix + "')";
            DAOFactory CS = new DAOFactory();
            CS.connecter();
            CS.execSQLWrite(requete);
        }

        public static List<Equipement> getAllParteneaireStand(PartenaireStand p)
        {
            List<Equipement> lesEquipement = new List<Equipement>();
            string req = "Select libelle, prixEquipementier, prixClubOrganisateur from equipement inner join equipementStand on equipementStand.idEquipement = equipement.idEquipement where idpartenaireStand = '" + p.unIdPartenaire + "'";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Equipement equipement = new Equipement(reader[0].ToString(), decimal.Parse(reader[1].ToString()), decimal.Parse(reader[2].ToString()));
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
