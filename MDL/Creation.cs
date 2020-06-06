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
        List<Equipement> mesEquipement = Equipement.listeEquipement();
        List<Stand> mesStands = Stand.listeStand();
        List<Partenaire> mesPartenaires = Partenaire.AvoirToutLesParteneaire();
        List<PartenaireStand> mesPartenaireStands = PartenaireStand.avoirPartenaireStandAquis();

        public Creation()
        {
            InitializeComponent();
        }

        private void Creation_Load(object sender, EventArgs e)
        {
            remplirListeEquipements();
            remplirListePartenaire();
            remplirListeStand();
            remplirListeStandAquisPrestataire();
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

            stand.ajouterStand();
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
                equipement = new Equipement(txbNomEquipement.Text, txbPrixEquipementier.Text, txbPrixClubOrganisateur.Text);

                equipement.ajouterEquipement();
                remplirListeEquipements();
            }
        }

        private void checkListBoxStand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remplirListeEquipements()
        {
            mesEquipement = Equipement.listeEquipement();
            List<string> lesLibelles = new List<string>();
            for (int i = 0; i < mesEquipement.Count; i++)
            {
                lesLibelles.Add(mesEquipement.ElementAt(i).unlibelle);
            }
            cbxGestionEquipement.DataSource = lesLibelles;
        }

        private void remplirListeStand()
        {
            mesStands = Stand.listeStand();
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
            mesPartenaires = Partenaire.AvoirToutLesParteneaire();
            List<string> lesPartenaires = new List<string>();
            for (int i = 0; i < mesPartenaires.Count; i++)
            {
                lesPartenaires.Add(mesPartenaires.ElementAt(i).unNomPartenaire);
            }
            cbxPartenaire.DataSource = lesPartenaires;
        }

        private void remplirListeStandAquisPrestataire()
        {
            mesPartenaireStands = PartenaireStand.avoirPartenaireStandAquis();
            PartenaireStand p;
            for (int i = 0; i < mesPartenaireStands.Count; i++)
            {
                dgvListeStandAqui.DataSource = null;
                p = new PartenaireStand();
                dgvListeStandAqui.DataSource = mesPartenaireStands;
            }
        }

        private void cbxGestionsNonStands_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idStand = "";
            Stand stand = new Stand(cbxGestionsNonStands.SelectedItem.ToString());
            GestionEquipementStand g;
            
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

            for (int i = 0; i < mesStands.Count; i++)
            {
                idStand = stand.getIdStand();
            }

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
            int idStand = 0;
            string type = "";
            string prix = "";
            if(cbxNomStand.SelectedItem != null && cbxPartenaire.SelectedItem != null)
            {
                Stand stand = new Stand(cbxNomStand.SelectedItem.ToString());
                Partenaire partenaire = new Partenaire(cbxPartenaire.SelectedItem.ToString());

                for (int i = 0; i < mesStands.Count; i++)
                {
                    idStand = int.Parse(stand.getIdStand());
                }

                for (int i = 0; i < mesPartenaires.Count; i++)
                {
                    type = partenaire.getTypePartenaire();
                }

                if (type == "équipementier")
                {
                    Equipement equipement = new Equipement(idStand);
                    prix = equipement.getPrixEquipementier();
                    lbPrix.Text = prix.ToString();
                }
                if (type == "clubOrganisateur")
                {
                    Equipement equipement = new Equipement(idStand);
                    prix = equipement.getPrixClubOrganisateur();
                    lbPrix.Text = prix.ToString();
                }
            }
           
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            int idStand = 0;
            string idPartenaire = "";
            string type = "";
            string prix = "";

            Stand stand = new Stand(cbxNomStand.SelectedItem.ToString());
            Partenaire partenaire = new Partenaire(cbxPartenaire.SelectedItem.ToString());

            for (int i = 0; i < mesStands.Count; i++)
            {
                idStand = int.Parse(stand.getIdStand());
            }

            for (int i = 0; i < mesPartenaires.Count; i++)
            {
                idPartenaire = partenaire.getIdPartenaire();
                type = partenaire.getTypePartenaire();
            }

            if (type == "équipementier")
            {
                Equipement equipement = new Equipement(idStand);
                prix = equipement.getPrixEquipementier();
                lbPrix.Text = prix.ToString();
            }
            if (type == "clubOrganisateur")
            {
                Equipement equipement = new Equipement(idStand);
                prix = equipement.getPrixClubOrganisateur();
                lbPrix.Text = prix.ToString();
            }

            PartenaireStand p = new PartenaireStand(idPartenaire, Convert.ToString(idStand), prix);
            p.ajouterPartenaireStand();
        }

        private void cbxNomStand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idStand = 0;
            string type = "";
            string prix = "";
            if (cbxNomStand.SelectedItem != null && cbxPartenaire.SelectedItem != null)
            {
                Stand stand = new Stand(cbxNomStand.SelectedItem.ToString());
                Partenaire partenaire = new Partenaire(cbxPartenaire.SelectedItem.ToString());

                for (int i = 0; i < mesStands.Count; i++)
                {
                    idStand = int.Parse(stand.getIdStand());
                }

                for (int i = 0; i < mesPartenaires.Count; i++)
                {
                    type = partenaire.getTypePartenaire();
                }

                if (type == "équipementier")
                {
                    Equipement equipement = new Equipement(idStand);
                    prix = equipement.getPrixEquipementier();
                    lbPrix.Text = prix.ToString();
                }
                if (type == "clubOrganisateur")
                {
                    Equipement equipement = new Equipement(idStand);
                    prix = equipement.getPrixClubOrganisateur();
                    lbPrix.Text = prix.ToString();
                }
            }
                
        }
    }
}
