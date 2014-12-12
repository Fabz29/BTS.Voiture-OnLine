using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureOnLine
{
    public class Commande
    {
        /// <summary>
        /// Le nom du client.
        /// </summary>
        private string nomClient;


        /// <summary>
        /// Une voiture.
        /// </summary>
        private List<Voiture> lesVoitures = new List<Voiture>();

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="unNomClient">Le nom du client</param>
        /// <param name="pUneVoiture">Une voiture</param>
        public Commande(string unNomClient, Voiture pUneVoiture)
        {
            this.nomClient = unNomClient;
            this.lesVoitures.Add(pUneVoiture);
        }

        /// <summary>
        /// Accesseur en lecture sur l'attribut nomClient
        /// </summary>
        /// <returns>Une chaine</returns>
        public string NomClient
        {
            get { return nomClient; }
        }

        /// <summary>
        /// Méthode qui retourne une chaine qui représente la classe.
        /// </summary>
        /// <returns>Une chaine représentant la classe</returns>
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

        /// <summary>
        /// Le prix de la commande.
        /// </summary>
        /// <returns>Le prix de la commande</returns>
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
