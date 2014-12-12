using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureOnLine
{
    public class Compacte : Voiture
    {
        /// <summary>
        /// Si c'est un cabriolet.
        /// </summary>
        private bool cabriolet;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="uneFinitionInt">La finition intérieur</param>
        /// <param name="uneFinitionExt">La finition extérieur</param>
        /// <param name="uneCouleur">La couleur</param>
        /// <param name="uneMotorisation">La motorisation</param>
        /// <param name="pCabriolet">Si c'est un cabriolet</param>
        public Compacte(string uneCouleur, string uneFinitionExt, string uneFinitionInt, string uneMotorisation, bool pCabriolet)
            :base(uneCouleur, uneFinitionExt, uneFinitionInt, uneMotorisation)
        {
            this.cabriolet = pCabriolet;
        }

        /// <summary>
        /// Méthode qui retourne une chaine qui représente la classe.
        /// </summary>
        /// <returns>Une chaine représentant la classe</returns>
        public override string Chaine()
        {
            if(cabriolet)
            {
                return string.Format(" a choisi une voiture Compacte cabriolet, finition intérieur : {0}, finition extérieur :  {1}, couleur :  {2}, Motorisation : {3}. Prix {4}€",
                                       FinitionInt, FinitionExt, Couleur, Motorisation, Prix());
            }
            else
            {
                return string.Format(" a choisi une voiture Compacte, finition intérieur : {0}, finition extérieur :  {1}, couleur :  {2}, Motorisation : {3}. Prix {4}€",
                                        FinitionInt, FinitionExt, Couleur, Motorisation, Prix());
            }
        }

        /// <summary>
        /// Méthode qui calcule le prix.
        /// </summary>
        /// <returns>Le prix</returns>
        public override double Prix()
        {
            double prix = base.Prix() + 7000;

            if (cabriolet)
            {
                prix += 3000;
            }

            return prix;
        }
    }
}
