using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class DAOPartenaire
    {

        public static List<Partenaire> getAllPartenaire()
        {
            List<Partenaire> lesPartenaires = new List<Partenaire>();
            string req = "Select * from partenaire";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Partenaire partenaire = new Partenaire(reader[1].ToString(), reader[2].ToString());
                lesPartenaires.Add(partenaire);
            }
            return lesPartenaires;
        }

        public static string getIdPartenaire(Partenaire p)
        {
            string partenaire = "";
            string req = "Select idParteneaire from stand where nomPartenaire = '" + p.unNomPartenaire + "'";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                partenaire = reader[0].ToString();
            }
            return partenaire;
        }
    }
}
