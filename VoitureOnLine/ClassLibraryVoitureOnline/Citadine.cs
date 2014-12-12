using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureOnLine
{
    public class Citadine : Voiture
    {
        /// <summary>
        /// 2 portes ou 4 portes.
        /// </summary>
        private bool quatrePortes;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="uneFinitionInt">La finition intérieur</param>
        /// <param name="uneFinitionExt">La finition extérieur</param>
        /// <param name="uneCouleur">La couleur</param>
        /// <param name="uneMotorisation">La motorisation</param>
        /// <param name="pQuatrePortes">2 portes ou 4 portes</param>
        public Citadine(string uneCouleur, string uneFinitionExt, string uneFinitionInt, string uneMotorisation, bool pQuatrePortes)
            :base(uneCouleur, uneFinitionExt, uneFinitionInt, uneMotorisation)
        {
            this.quatrePortes = pQuatrePortes;
        }

        /// <summary>
        /// Méthode qui retourne une chaine qui représente la classe.
        /// </summary>
        /// <returns>Une chaine représentant la classe</returns>
        public override string Chaine()
        {
            if (quatrePortes)
            {
                return string.Format(" a choisi une voiture Citadine, quatre portes, finition intérieur : {0}, finition extérieur :  {1}, couleur :  {2}, Motorisation : {3}. Prix {4}€.",
                    FinitionInt, FinitionExt, Couleur, Motorisation, Prix());
            }
            else
            {
                return string.Format(" a choisi une voiture Citadine, deux portes, finition intérieur : {0}, finition extérieur :  {1}, couleur :  {2}, Motorisation : {3}. Prix {4}€",
                    FinitionInt, FinitionExt, Couleur, Motorisation, Prix());
            }
        }

        /// <summary>
        /// Méthode qui calcule le prix.
        /// </summary>
        /// <returns>Le prix</returns>

        public override double Prix()
        {
            double prix = base.Prix();

            if(!quatrePortes)
            {
                prix -= 2000;
            }

            return prix;
        }
    }
}
