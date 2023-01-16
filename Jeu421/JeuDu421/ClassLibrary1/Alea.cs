using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JeuDu421
{
    public class Alea : Random
    {
        private static Alea aleaUnique;

        public Alea()
        {
            
        }

        public byte DonneNbAleatoire(byte min, byte max)
        {
            return (byte)aleaUnique.Next(min, max + 1);
        }

        public static Alea GetInstance()
        {
            if (aleaUnique == null)
            {
                aleaUnique = new Alea();
            }
            return aleaUnique;
        }
    }
}
