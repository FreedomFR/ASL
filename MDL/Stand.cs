using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class Stand
    {
        private string idStand;
        private string nomStand;
        private int alle;
        private int ordre;
        private int surface;
        private int nombreSiege;
        private int nombreTable;


        public Stand(string unNomStand, int uneAlle, int unOrdre, int uneSurface, int unNombreSiege, int unNombreTable)
        {
            this.nomStand = unNomStand;
            this.alle = uneAlle;
            this.ordre = unOrdre;
            this.surface = uneSurface;
            this.nombreSiege = unNombreSiege;
            this.unNombreTable = unNombreTable;
        }

        public Stand(string unNomStand)
        {
            this.nomStand = unNomStand;
        }


        public List<Equipement> LesEquipement
        {
            get { return LesEquipement; }
            set { LesEquipement = value; }
        }

        public string unId
        {
            get { return idStand; }
            set { idStand = value; }
        }

        public int uneAlle
        {
            get { return alle; }
            set { alle = value; }
        }

        public int unOrder
        {
            get { return ordre; }
            set { ordre = value; }
        }

        public int unSurface
        {
            get { return surface; }
            set { surface = value; }
        }

        public int unNombreSiege
        {
            get { return nombreSiege; }
            set { nombreSiege = value; }
        }

        public int unNombreTable
        {
            get { return nombreTable; }
            set { nombreTable = value; }
        }

        public string unNomStand
        {
            get { return nomStand; }
            set { nomStand = value; }
        }


        public void ajouterEquipement(Equipement equipement)
        {
            LesEquipement.Add(equipement);
        }

        public static List<Stand> listeStand()
        {
            return DAOStands.getAllStand();
        }

        public string getIdStand()
        {
            return DAOStands.getIdStand(this);
        }
    }
}
