using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureOnLine
{
    public class Voiture
    {
        /// <summary>
        /// La couleur.
        /// </summary>
        private string couleur;

        /// <summary>
        /// La finition extérieur.
        /// </summary>
        private string finitionExt;

        /// <summary>
        /// La finition intérieur.
        /// </summary>
        private string finitionInt;

        /// <summary>
        /// La motorisation.
        /// </summary>
        private string motorisation;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="uneFinitionInt">La finition intérieur</param>
        /// <param name="uneFinitionExt">La finition extérieur</param>
        /// <param name="uneCouleur">La couleur</param>
        /// <param name="uneMotorisation">La motorisation</param>
        public Voiture(string uneCouleur, string uneFinitionExt, string uneFinitionInt, string uneMotorisation)
        {
            this.couleur = uneCouleur;
            this.finitionExt = uneFinitionExt;
            this.finitionInt = uneFinitionInt;
            this.motorisation = uneMotorisation;
        }

        /// <summary>
        /// Accesseur en lectur de l'attribur couleur
        /// </summary>
        /// <returns>Une chaine</returns>
        public string Couleur
        {
            get { return couleur; }
        }

        /// <summary>
        /// Accesseur en lectur de l'attribur finitionExt
        /// </summary>
        /// <returns>Une chaine</returns>
        public string FinitionExt
        {
            get { return finitionExt; }
        }

        /// <summary>
        /// Accesseur en lectur de l'attribur finitionInt
        /// </summary>
        /// <returns>Une chaine</returns>
        public string FinitionInt
        {
            get { return finitionInt; }
        }

        /// <summary>
        /// Accesseur en lectur de l'attribur motorisation
        /// </summary>
        /// <returns>Une chaine</returns>
        public string Motorisation
        {
            get { return motorisation; }
        }

        /// <summary>
        /// Méthode qui retourne une chaine qui représente la classe.
        /// </summary>
        /// <returns>Une chaine représentant la classe</returns>

        public virtual string Chaine()
        {
            return "chaine";
        }

        /// <summary>
        /// Méthode qui calcule le prix.
        /// </summary>
        /// <returns>Le prix</returns>
        public virtual double Prix()
        {
            double prix = 10000;
            if(motorisation == "Hybride")
            {
                prix += 5000;
            }
            else if(motorisation == "Gasoil")
            {
                prix += 2000;
            }
            return prix;
        }
    }
}
