using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureOnLine
{
    public class Commande
    {
        private string nomClient;
        private Voiture uneVoiture;

        public Commande(string unNomClient, Voiture pUneVoiture)
        {
            this.nomClient = unNomClient;
            this.uneVoiture = pUneVoiture;
        }

        public string NomClient
        {
            get { return nomClient; }
        }

        public string Chaine()
        {
            string commandes = "";
            if(uneVoiture is Citadine)
            {
                commandes = (nomClient + " : " + uneVoiture.Chaine());
            }
            else if (uneVoiture is Compacte)
            {
                commandes = (nomClient + " : " + uneVoiture.Chaine());
            }
            else if(uneVoiture is Familiale)
            {
                commandes = (nomClient + " : " + uneVoiture.Chaine());
            }
            else if (uneVoiture is Limousine)
            {
                commandes = (nomClient + " : " + uneVoiture.Chaine());
            }
            return commandes;
        }

        public double Total()
        {
            throw new System.NotImplementedException();
        }
    }
}
