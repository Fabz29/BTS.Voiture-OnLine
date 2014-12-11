using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureOnLine
{
    public class Commande
    {
        private string nomClient;
        private List<Voiture> lesVoitures = new List<Voiture>();

        public Commande(string unNomClient, Voiture pUneVoiture)
        {
            this.nomClient = unNomClient;
            this.lesVoitures.Add(pUneVoiture);
        }

        public string NomClient
        {
            get { return nomClient; }
        }

        public string Chaine()
        {
            string commandes = "";
            foreach (Voiture v in lesVoitures)
            {
                if (v is Citadine)
                {
                    commandes = (nomClient + " : " + v.Chaine());
                }
                else if (v is Compacte)
                {
                    commandes = (nomClient + " : " + v.Chaine());
                }
                else if (v is Familiale)
                {
                    commandes = (nomClient + " : " + v.Chaine());
                }
                else if (v is Limousine)
                {
                    commandes = (nomClient + " : " + v.Chaine());
                }
            }
            return commandes;
        }

        public double Total()
        {
            double total = 0;
            foreach(Voiture v in lesVoitures)
            {
                total += v.Prix();
            }
            return total;
        }
    }
}
