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
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            
        }

        private void btnValiderConnection_Click_1(object sender, EventArgs e)
        {
            Utilisateur utilisateur;
            if (txbMail.Text == "")
            {
                MessageBox.Show("mettre un mail", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMail.Focus();
                return;
            }
            if (txbMdp.Text == "")
            {
                MessageBox.Show("mettre un mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMdp.Focus();
                return;
            }
            if (txbMail.Text != "" && txbMdp.Text != "")
            {
                utilisateur = new Utilisateur(txbMail.Text, txbMdp.Text);
                

                if(utilisateur.getConnection() == true)
                {
                    MessageBox.Show("Connection réussit");
                    Creation creation = new Creation();
                    creation.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mauvais mail ou mot de passe");
                }
            }
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {

        }

        private void btnValiderInscription_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur;
            if (txbMailInscription.Text == "")
            {
                MessageBox.Show("mettre un mail", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMail.Focus();
                return;
            }
            if (txbMdpInscription.Text == "")
            {
                MessageBox.Show("mettre un mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMdp.Focus();
                return;
            }
            if (txbNomInscription.Text == "")
            {
                MessageBox.Show("mettre un nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMdp.Focus();
                return;
            }
            if (txbMailInscription.Text != "" && txbMdpInscription.Text != "" && txbNomInscription.Text != "")
            {
                utilisateur = new Utilisateur(txbMailInscription.Text, txbMdpInscription.Text, txbNomInscription.Text);

                utilisateur.ajouterUtilisateur();
            }
        }
    }
}
