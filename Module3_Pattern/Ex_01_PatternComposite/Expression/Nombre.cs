using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    public class Nombre : Expression
    {
        int valeur;

        public Nombre(int _valeur)
        {
            valeur = _valeur;
        }
        public override int Evalue()
        {
            return valeur;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string FormateDeGauche()
        {
            return "" + valeur.ToString() + " ";
        }
    }
}
