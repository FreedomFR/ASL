using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class PartenaireStand
    {
        private string idPartenaire;
        private string idStand;
        private string prix;
        private string nom;

        public PartenaireStand(string unIdPartenaire, string unIdStand, string unPrix)
        {
            this.idPartenaire = unIdPartenaire;
            this.idStand = unIdStand;
            this.prix = unPrix;
        }

        public PartenaireStand(string unIdPartenaire, string unIdStand, string unPrix, string unNom)
        {
            this.idPartenaire = unIdPartenaire;
            this.idStand = unIdStand;
            this.prix = unPrix;
            this.nom = unNom;
        }

        public PartenaireStand()
        {

        }

        public string unIdPartenaire
        {
            get { return idPartenaire; }
            set { idPartenaire = value; }
        }

        public string unIdStand
        {
            get { return idStand; }
            set { idStand = value; }
        }

        public string unPrix
        {
            get { return prix; }
            set { prix = value; }
        }

        public string unNom
        {
            get { return nom; }
            set { nom = value; }
        }

        public void ajouterPartenaireStand()
        {
            DAOPartenaireStand.addPartenaireStand(this);
        }

        public static List<PartenaireStand> avoirPartenaireStandAquis()
        {
            return DAOPartenaireStand.getAllParteneaireStandAquis();
        }
    }
}
