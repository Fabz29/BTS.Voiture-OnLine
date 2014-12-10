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
    public partial class Form1 : Form
    {
        public List<Commande> lesCommandes;
        public Form1()
        {
            InitializeComponent();
            lesCommandes = new List<Commande>();
            Init();
        }

        public void Init()
        {
            RBCitadine.Checked = true;
            CBCouleur.Text = "Métallisée";
            CBFinitionInter.Text = "Young";
            CBFinitionExter.Text = "Urban";
            CBMotorisation.Text = "Essence";
            LBSelection.Text = "Selection enregistré : Prix : 10000 €";
            TBClient.Text = "";
            checkB4portes.Checked = false;
            checkBCabriolet.Checked = false;
        }

        private void BTValider_Click(object sender, EventArgs e)
        {
            if (TBClient.Text == "")
            {
                LBSelection.Text = "Veuiller remplir tous les champs";
                LBSelection.ForeColor = System.Drawing.Color.Red;
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
