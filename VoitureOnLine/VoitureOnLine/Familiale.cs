using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureOnLine
{
    public class Familiale : Voiture
    {
        public Familiale(string uneCouleur, string uneFinitionExt, string uneFinitionInt, string uneMotorisation)
            :base(uneCouleur, uneFinitionExt, uneFinitionInt, uneMotorisation)
        {
            
        }

        public override string Chaine()
        {
            return string.Format(" a choisi une voiture Famillial, finition intérieur : {0}, finition extérieur :  {1}, couleur :  {2}, Motorisation : {3}. Prix A prog.",
    FinitionInt, FinitionExt, Couleur, Motorisation);
        }

        public override double Prix()
        {
            throw new System.NotImplementedException();
        }
    }
}
