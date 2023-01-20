using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDu421
{
    internal class De : IComparable<De>
    {

        private byte valeur;
        public byte Valeur
        {
            get { return valeur; }
        }
        private readonly byte valeurMax;
        private readonly byte valeurMin;

        public De()
        {
            valeurMax = 6;
            valeurMin = 1;
            this.Rouler();
        }
        public De(byte min, byte max)
        {
            valeurMax = max;
            valeurMin = min;
            this.Rouler();
        }

        //get random value from Alea class
        public void Rouler()
        {
            Alea alea = Alea.GetInstance();
            this.valeur = alea.DonneNbAleatoire(valeurMin, valeurMax);
        }

        //compare dice to value
        public int CompareTo(De? other)
        {
            return other.valeur.CompareTo(valeur);
        }
    }
}
