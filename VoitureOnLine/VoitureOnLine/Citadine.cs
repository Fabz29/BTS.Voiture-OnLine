using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureOnLine
{
    public class Citadine : Voiture
    {
        private bool quatrePortes;

        public Citadine(string uneCouleur, string uneFinitionExt, string uneFinitionInt, string uneMotorisation, bool pQuatrePortes)
            :base(uneCouleur, uneFinitionExt, uneFinitionInt, uneMotorisation)
        {
            this.quatrePortes = pQuatrePortes;
        }

        public override string Chaine()
        {
            if (quatrePortes)
            {
                return string.Format(" a choisi une voiture Citadine, quatre portes, finition intérieur : {0}, finition extérieur :  {1}, couleur :  {2}, Motorisation : {3}. Prix A prog.",
                    FinitionInt, FinitionExt, Couleur, Motorisation);
            }
            else
            {
                return string.Format(" a choisi une voiture Citadine, deux portes, finition intérieur : {0}, finition extérieur :  {1}, couleur :  {2}, Motorisation : {3}. Prix A prog",
                    FinitionInt, FinitionExt, Couleur, Motorisation);
            }
        }

        public override double Prix()
        {
            return base.Prix() - 2000;
        }
    }
}
