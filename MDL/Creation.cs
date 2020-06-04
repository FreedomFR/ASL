using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDL
{
    public partial class Creation : Form
    {
        private GestionEquipementStand gestion;
        public Creation()
        {
            InitializeComponent();
        }

        private void Creation_Load(object sender, EventArgs e)
        {
            remplirListeEquipements();
            remplirListeStand();
            remplirListePartenaire();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnCreationStand_Click(object sender, EventArgs e)
        {
            Stand stand;

            int numAlle = int.Parse(txbNumAlle.Text);
            int numOrdre = int.Parse(txbNumOrdre.Text);
            int Surface = int.Parse(txbSurfaceStand.Text);
            int nombreSiege = int.Parse(txbNombreSiege.Text);
            int nombreTable= int.Parse(txbNombreTables.Text);

            stand = new Stand(txbNomStand.Text, numAlle, numOrdre, Surface, nombreSiege, nombreTable);

            DAOStands.creerStand(stand);
            remplirListeStand();
        }

        private void btnAnnulerStand_Click(object sender, EventArgs e)
        {
            txbNomStand.Clear();
            txbNumAlle.Clear();
            txbNumOrdre.Clear();
            txbSurfaceStand.Clear();
            txbNombreSiege.Clear();
            txbNombreTables.Clear();
        }

        private void btnValiderEquipement_Click(object sender, EventArgs e)
        {
            if(txbNomEquipement.Text.Length != 0 && txbPrixEquipementier != null && txbPrixClubOrganisateur != null)
            {
                Equipement equipement;
                decimal prixEquipementier = decimal.Parse(txbPrixEquipementier.Text);
                decimal prixClubOrganisateur = decimal.Parse(txbPrixClubOrganisateur.Text);
                equipement = new Equipement(txbNomEquipement.Text, prixEquipementier, prixClubOrganisateur);

                equipement.ajouterEquipement();
                remplirListeEquipements();
            }
        }

        private void checkListBoxStand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remplirListeEquipements()
        {
            Equipement equipement;
            List<Equipement> mesEquipement = Equipement.listeEquipement();

            // checkListBoxStand.Items.Add(mesEquipement);
            List<string> lesLibelles = new List<string>();
            for (int i = 0; i < mesEquipement.Count; i++)
            {
                lesLibelles.Add(mesEquipement.ElementAt(i).unlibelle);
            }
            cbxGestionEquipement.DataSource = lesLibelles;
        }

        private void remplirListeStand()
        {
            List<Stand> mesStands = Stand.listeStand();

            // checkListBoxStand.Items.Add(mesEquipement);
            List<string> lesStands = new List<string>();
            for (int i = 0; i < mesStands.Count; i++)
            {
                lesStands.Add(mesStands.ElementAt(i).unNomStand);
            }

            cbxNomStand.DataSource = lesStands;
            cbxGestionsNonStands.DataSource = lesStands;
        }


        private void remplirListePartenaire()
        {
            List<Partenaire> mesPartenaires = Partenaire.AvoirToutLesParteneaire();

            // checkListBoxStand.Items.Add(mesEquipement);
            List<string> lesPartenaires = new List<string>();
            for (int i = 0; i < mesPartenaires.Count; i++)
            {
                lesPartenaires.Add(mesPartenaires.ElementAt(i).unNomPartenaire);
            }

            cbxPrestataire.DataSource = null;
            cbxPrestataire.DataSource = lesPartenaires;
        }

        private void cbxGestionsNonStands_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idStand = "";
            Stand stand = new Stand(cbxGestionsNonStands.SelectedItem.ToString());
            GestionEquipementStand g;
            List<Stand> mesStands = Stand.listeStand();

            List<string> lesStands = new List<string>();
            for (int i = 0; i < mesStands.Count; i++)
            {
                idStand = stand.getIdStand();
                g = new GestionEquipementStand(idStand);

                listeGestionEquipement.DataSource = null;
                listeGestionEquipement.DataSource = g.avoirEquipementStand();
            }


        }

        private void btnValiderGestionStands_Click(object sender, EventArgs e)
        {
            string idStand = "";
            string idEquipement = "";
            Stand stand = new Stand(cbxGestionsNonStands.SelectedItem.ToString());
            Equipement equipement = new Equipement(cbxGestionEquipement.SelectedItem.ToString());

            List<Stand> mesStands = Stand.listeStand();
            List<Equipement> mesEquipement = Equipement.listeEquipement();


            List<string> lesStands = new List<string>();
            for (int i = 0; i < mesStands.Count; i++)
            {
                idStand = stand.getIdStand();
            }

            List<string> lesLibelles = new List<string>();
            for (int i = 0; i < mesEquipement.Count; i++)
            {
                idEquipement = equipement.getIdEquipement();
            }
            GestionEquipementStand g = new GestionEquipementStand(idEquipement, idStand);
            g.ajouterEquipementstand();
            remplirListeStand();
            
        }

        private void listeGestionEquipement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxPrestataire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string idStand = "";
            string idPartenaire = "";
            Stand stand = new Stand(cbxGestionsNonStands.SelectedItem.ToString());
            Partenaire partenaire = new Partenaire(cbxPrestataire.SelectedItem.ToString());

            List<Stand> mesStands = Stand.listeStand();
            List<Partenaire> mesPartenaires = Partenaire.AvoirToutLesParteneaire();

            List<string> lesStands = new List<string>();
            for (int i = 0; i < mesStands.Count; i++)
            {
                idStand = stand.getIdStand();
            }

            List<string> lesPartnaires = new List<string>();
            for (int i = 0; i < mesPartenaires.Count; i++)
            {
                idPartenaire = partenaire.ToString();
            }

            Partenaire p = new Partenaire(idPartenaire, idStand);
        }

        private void cbxNomStand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idStand = "";
            string idPartenaire = "";
            decimal prix = 0;
            //Stand stand = new Stand(cbxNomStand.SelectedItem.ToString());
            //Partenaire partenaire = new Partenaire(cbxPrestataire.SelectedItem.ToString());

            //List<Stand> mesStands = Stand.listeStand();
            //List<Partenaire> mesPartenaires = Partenaire.AvoirToutLesParteneaire();

            //List<string> lesStands = new List<string>();
            //for (int i = 0; i < mesStands.Count; i++)
            //{
            //    idStand = stand.getIdStand();
            //}

            //List<string> lesPartnaires = new List<string>();
            //for (int i = 0; i < mesPartenaires.Count; i++)
            //{
            //    idPartenaire = partenaire.ToString();
            //}


        }
    }
}
