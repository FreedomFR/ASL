using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class Utilisateur
    {
        private string mail;
        private string mdp;
        private string nom;

        public Utilisateur(string unMail, string unMdp)
        {
            this.mail = unMail;
            this.mdp = unMdp;
        }

        public Utilisateur(string unMail, string unMdp, string unNom)
        {
            this.mail = unMail;
            this.mdp = unMdp;
            this.nom = unNom;
        }

        public string unMail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string unMdp
        {
            get { return mdp; }
            set { mdp = value; }
        }

        public string unNom
        {
            get { return nom; }
            set { nom = value; }
        }

        public bool getConnection()
        {
            return DAOUtilisateur.getUtilisateur(this);
        }

        public void ajouterUtilisateur()
        {
            DAOUtilisateur.addUtilisateur(this);
        }

    }
}
