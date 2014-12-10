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
    public partial class listeCommandes : Form
    {
        public listeCommandes(List<Commande> lesCommandes)
        {
            InitializeComponent();

            foreach (Commande c in lesCommandes)
            {
                lbCommandes.Items.Add(c.Chaine());
            }

            int nbCommandes = lesCommandes.Count();
            lbNbCommande.Text = "Nombre de commandes : " + nbCommandes;
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
