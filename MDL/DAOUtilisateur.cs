using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class DAOUtilisateur
    {
        public static bool getUtilisateur(Utilisateur utilisateur)
        {
            bool valide = false;
            string req = "Select mail, mdp from utilisateur where mail = '" + utilisateur.unMail + "' and mdp = '" + utilisateur.unMdp + "'";
            DAOFactory CS = new DAOFactory();

            CS.connecter();

            SqlDataReader reader = CS.excecSQLRead(req);
            
            if (reader.Read())
            {
                valide = true;
            }
            CS.deconnecter();
            return valide;
            
        }

        public static void addUtilisateur(Utilisateur utilisateur)
        {
            string requete = "INSERT utilisateur (mail, mdp, nom) VALUES ('" + utilisateur.unMail + "','" + utilisateur.unMdp + "','" + utilisateur.unNom + "')";
            DAOFactory CS = new DAOFactory();
            CS.connecter();
            CS.execSQLWrite(requete);
            CS.deconnecter();
        }
    }
}
