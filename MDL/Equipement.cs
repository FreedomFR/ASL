using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDL
{
    class Equipement
    {
        private string idEquipement;
        private string libelle;
        private decimal prixEquipementier;
        private decimal prixClubOrganisateur;


        public Equipement(string unLibelle, decimal unPrixEquipementier,decimal unPrixClubOrganisateur)
        {
            this.libelle = unLibelle;
            this.prixEquipementier = unPrixEquipementier;
            this.prixClubOrganisateur = unPrixClubOrganisateur;
        }
        public Equipement(string unIdEquipement,string unLibelle, decimal unPrixEquipementier, decimal unPrixClubOrganisateur)
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

        public decimal unPrixEquipementier
        {
            get { return prixEquipementier; }
            set { prixEquipementier = value; }
        }

        public decimal unPrixClubOrganisateur
        {
            get { return prixClubOrganisateur; }
            set { prixClubOrganisateur = value; }
        }

        public string getIdEquipement()
        {
            return DAOEquipements.getIdEquipement(this);
        }
    }
}
