using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MDL
{
    class DAOEquipements
    {
        public static void AjouterEquipement(Equipement equipement)
        {
            string requete = "INSERT equipement (libelle, prixClubOrganisateur, prixEquipementier) VALUES ('" + equipement.unlibelle + "','" + equipement.unPrixClubOrganisateur + "','" + equipement.unPrixEquipementier + "')";
            DAOFactory CS = new DAOFactory();
            CS.connecter();
            CS.execSQLWrite(requete);
        }

        public static List<Equipement> getAllEquipement()
        {
            List<Equipement> lesEquipement = new List<Equipement>();
            string req = "Select * from equipement";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Equipement equipement = new Equipement(reader[0].ToString(), reader[1].ToString(), decimal.Parse(reader[2].ToString()), decimal.Parse(reader[3].ToString()));
                lesEquipement.Add(equipement);
            }
            return lesEquipement;
        }

        public static string getIdEquipement(Equipement e)
        {
            string equip = "";
            string req = "Select idEquipement from equipement where libelle = '" + e.unlibelle + "'";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                equip = reader[0].ToString();
            }
            return equip;
        }
    }
}
