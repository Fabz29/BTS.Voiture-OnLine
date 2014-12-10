using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureOnLine
{
    public class Compacte : Voiture
    {
        private bool cabriolet;

        public Compacte(string uneCouleur, string uneFinitionExt, string uneFinitionInt, string uneMotorisation, bool pCabriolet)
            :base(uneCouleur, uneFinitionExt, uneFinitionInt, uneMotorisation)
        {
            this.cabriolet = pCabriolet;
        }

        public override string Chaine()
        {
            return string.Format(" a choisi une voiture Cabriolet, finition intérieur : {0}, finition extérieur :  {1}, couleur :  {2}, Motorisation : {3}. Prix A prog.",
    FinitionInt, FinitionExt, Couleur, Motorisation);
        }

        public override double Prix()
        {
            throw new System.NotImplementedException();
        }
    }
}
