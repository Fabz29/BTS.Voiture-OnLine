using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureOnLine
{
    public class Voiture
    {
        private string couleur;
        private string finitionExt;
        private string finitionInt;
        private string motorisation;

        public Voiture(string uneCouleur, string uneFinitionExt, string uneFinitionInt, string uneMotorisation)
        {
            this.couleur = uneCouleur;
            this.finitionExt = uneFinitionExt;
            this.finitionInt = uneFinitionInt;
            this.motorisation = uneMotorisation;
        }

        public string Couleur
        {
            get { return couleur; }
        }

        public string FinitionExt
        {
            get { return finitionExt; }
        }

        public string FinitionInt
        {
            get { return finitionInt; }
        }

        public string Motorisation
        {
            get { return motorisation; }
        }

        public virtual string Chaine()
        {
            return "chaine";
        }

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
