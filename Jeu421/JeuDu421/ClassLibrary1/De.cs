using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDu421
{
    public class De : IComparable<De>
    {

        byte valeur;
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

        public byte GetValeur()
        {
            return valeur;
        }

        public void Rouler()
        {
            Alea alea = Alea.GetInstance();
            valeur = alea.DonneNbAleatoire(valeurMin, valeurMax);
        }

        public int CompareTo(De? other)
        {
            return other.valeur.CompareTo(valeur);
        }
    }
}
