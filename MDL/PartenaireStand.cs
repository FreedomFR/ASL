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
        private decimal prix;

        public PartenaireStand(string unIdPartenaire, string unIdStand, decimal unPrix)
        {
            this.idPartenaire = unIdPartenaire;
            this.idStand = unIdStand;
            this.prix = unPrix;
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

        public decimal unPrix
        {
            get { return prix; }
            set { prix = value; }
        }

        public void ajouterPartenaireStand()
        {
            DAOPartenaireStand.addPartenaireStand(this);
        }

    }
}
