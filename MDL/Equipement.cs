using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class Equipement
    {
        private int idEquipementInt;
        private string idEquipement;
        private string libelle;
        private string prixEquipementier;
        private string prixClubOrganisateur;


        public Equipement(string unLibelle, string unPrixEquipementier, string unPrixClubOrganisateur)
        {
            this.libelle = unLibelle;
            this.prixEquipementier = unPrixEquipementier;
            this.prixClubOrganisateur = unPrixClubOrganisateur;
        }
        public Equipement(string unIdEquipement,string unLibelle, string unPrixEquipementier, string unPrixClubOrganisateur)
        {
            this.idEquipement = unIdEquipement;
            this.libelle = unLibelle;
            this.prixEquipementier = unPrixEquipementier;
            this.prixClubOrganisateur = unPrixClubOrganisateur;
        }

        public Equipement(string unLibelle)
        {
            this.libelle = unLibelle;
        }

        public Equipement(int unIdEquipementInt)
        {
            this.idEquipementInt = unIdEquipementInt;
        }

        public static List<Equipement> listeEquipement()
        {
            return DAOEquipements.getAllEquipement();
        }

        public void ajouterEquipement()
        {
            DAOEquipements.AjouterEquipement(this);
        }

        public string unlibelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public string unId
        {
            get { return idEquipement; }
            set { idEquipement = value; }
        }

        public int unIdEquipementInt
        {
            get { return idEquipementInt; }
            set { idEquipementInt = value; }
        }

        public string unPrixEquipementier
        {
            get { return prixEquipementier; }
            set { prixEquipementier = value; }
        }

        public string unPrixClubOrganisateur
        {
            get { return prixClubOrganisateur; }
            set { prixClubOrganisateur = value; }
        }

        public string getIdEquipement()
        {
            return DAOEquipements.getIdEquipement(this);
        }

        public string getPrixEquipementier()
        {
            return DAOEquipements.getAllPrixEquipementierEquipementStand(this);
        }

        public string getPrixClubOrganisateur()
        {
            return DAOEquipements.getAllPrixClubOrganisateurEquipementStand(this);
        }
    }
}
