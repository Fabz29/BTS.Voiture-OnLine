using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureOnLine
{
    public class Familiale : Voiture
    {
        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="uneFinitionInt">La finition intérieur</param>
        /// <param name="uneFinitionExt">La finition extérieur</param>
        /// <param name="uneCouleur">La couleur</param>
        /// <param name="uneMotorisation">La motorisation</param>
        public Familiale(string uneCouleur, string uneFinitionExt, string uneFinitionInt, string uneMotorisation)
            :base(uneCouleur, uneFinitionExt, uneFinitionInt, uneMotorisation)
        {
            
        }

        /// <summary>
        /// Méthode qui retourne une chaine qui représente la classe.
        /// </summary>
        /// <returns>Une chaine représentant la classe</returns>
        public override string Chaine()
        {
            return string.Format(" a choisi une voiture Famillial, finition intérieur : {0}, finition extérieur :  {1}, couleur :  {2}, Motorisation : {3}. Prix {4}€",
    FinitionInt, FinitionExt, Couleur, Motorisation, Prix());
        }

        /// <summary>
        /// Méthode qui calcule le prix.
        /// </summary>
        /// <returns>Le prix</returns>
        public override double Prix()
        {
            double prix = base.Prix() + 13000;

            return prix;
        }
    }
}
