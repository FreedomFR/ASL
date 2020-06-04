using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class GestionEquipementStand
    {
        private string idEquipement;
        private string idStand;

        public GestionEquipementStand(string unIdEquiment, string unIdStand)
        {
            this.idEquipement = unIdEquiment;
            this.idStand = unIdStand;
        }

        public GestionEquipementStand(string unIdStand)
        {
            this.idStand = unIdStand;
        }
        public GestionEquipementStand()
        {

        }

        public string unIdEquiment
        {
            get { return idEquipement; }
            set { idEquipement = value; }
        }

        public string unIdStand
        {
            get { return idStand; }
            set { idStand = value; }
        }


        public void ajouterEquipementstand()
        {
            DAOGestionEquipementStand.addEquipementStand(this);
        }

        public List<Equipement> avoirEquipementStand()
        {
            return DAOGestionEquipementStand.getAllEquipementStand(this);
        }
    }
}
