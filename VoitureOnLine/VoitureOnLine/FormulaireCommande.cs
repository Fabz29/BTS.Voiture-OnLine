using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoitureOnLine
{
    public partial class FormulaireCommande : Form
    {
        public List<Commande> lesCommandes;
        public FormulaireCommande()
        {
            InitializeComponent();
            lesCommandes = new List<Commande>();
            Init();
        }

        public void Init()
        {
            rbCitadine.Checked = true;
            cbCouleur.Text = "Métallisée";
            cbFinitionInter.Text = "Young";
            cbFinitionExter.Text = "Urban";
            cbMotorisation.Text = "Essence";
            lbSelection.Text = "Selection enregistré : Prix : 10000 €";
            tbClient.Text = "";
            checkB4portes.Checked = false;
            checkBCabriolet.Checked = false;
            lbSelection.ForeColor = System.Drawing.Color.Green;
        }

        private void BTValider_Click(object sender, EventArgs e)
        {
            if (tbClient.Text == "")
            {
                lbSelection.Text = "Veuiller remplir tous les champs";
                lbSelection.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                Voiture uneVoiture = null;

                if (rbCitadine.Checked)
                {
                    uneVoiture = new Citadine(cbCouleur.Text, cbFinitionExter.Text, cbFinitionInter.Text, cbMotorisation.Text, checkB4portes.Checked);
                }
                else if (rbCompacte.Checked)
                {
                    uneVoiture = new Compacte(cbCouleur.Text, cbFinitionExter.Text, cbFinitionInter.Text, cbMotorisation.Text, checkBCabriolet.Checked);
                }
                else if (rbFamiliale.Checked)
                {
                    uneVoiture = new Familiale(cbCouleur.Text, cbFinitionExter.Text, cbFinitionInter.Text, cbMotorisation.Text);
                }
                else if (rbLimousine.Checked)
                {
                    uneVoiture = new Limousine(cbCouleur.Text, cbFinitionExter.Text, cbFinitionInter.Text, cbMotorisation.Text);
                }

                Commande uneCommande = new Commande(tbClient.Text, uneVoiture);
                lesCommandes.Add(uneCommande);
                MessageBox.Show("La commande de la voiture a bien été ajouté", "Validé");
                Init();            
            }
        }

        private void BTAnnuler_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void BTQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RBCitadine_CheckedChanged(object sender, EventArgs e)
        {
            checkB4portes.Enabled = true;
            checkBCabriolet.Enabled = false; 
        }

        private void RBCompacte_CheckedChanged(object sender, EventArgs e)
        {
            checkBCabriolet.Enabled = true;
            checkB4portes.Enabled = false;
        }

        private void RBFamiliale_CheckedChanged(object sender, EventArgs e)
        {
            checkBCabriolet.Enabled = false;
            checkB4portes.Enabled = false;
        }

        private void RBLimousine_CheckedChanged(object sender, EventArgs e)
        {
            checkBCabriolet.Enabled = false;
            checkB4portes.Enabled = false;
        }

        private void AfficheSimu_Click(object sender, EventArgs e)
        {
            listeCommandes fa = new listeCommandes(lesCommandes);
            fa.Show();
        }
    }
}
