using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class Partenaire
    {
        private string idpartenaire;
        private string nomPartenaire;
        private string typePartenaire;

        public Partenaire()
        {

        }

        public Partenaire(string unNomPartenaire, string unTypePartenaire)
        {
            this.unNomPartenaire = unNomPartenaire;
            this.unTypePartenaire = unTypePartenaire;
        }

        public Partenaire(string unIdpartenaire)
        {
            this.unIdPartenaire = unIdPartenaire;
        }


        public string unIdPartenaire
        {
            get { return idpartenaire; }
            set { idpartenaire = value; }
        }

        public string unNomPartenaire
        {
            get { return nomPartenaire; }
            set { nomPartenaire = value; }
        }

        public string unTypePartenaire
        {
            get { return typePartenaire; }
            set { typePartenaire = value; }
        }

        public static List<Partenaire> AvoirToutLesParteneaire()
        {
            return DAOPartenaire.getAllPartenaire();
        }

        public string getIdPartenaire()
        {
            return DAOPartenaire.getIdPartenaire(this);
        }
    }
}
