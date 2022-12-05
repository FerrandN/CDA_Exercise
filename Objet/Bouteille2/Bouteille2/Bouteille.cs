using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bouteille2
{
    internal class Bouteille
    {
        bool isOpen = false;
        float liquidInLiter = 0;
        const float bottleCapacityInLiter = 1;

        public Bouteille()
        {

        }

        public Bouteille(bool isOpen, float liquidInLiter)
        {
            this.isOpen = isOpen;
            if (liquidInLiter < bottleCapacityInLiter)
            {
                this.liquidInLiter = liquidInLiter;
                Console.WriteLine("vous avez remplis la bouteille avec" + liquidInLiter + " L d'eau");
            }
            else
            {
                Console.WriteLine("ça déborde !");
                this.liquidInLiter = liquidInLiter;
            }
        }

        public void ouvrir()
        {
            if(isOpen == false)
            {
                isOpen = true;
                Console.WriteLine("Vous avez ouvert la boutteille");
            }
            else
            {
                Console.WriteLine("La bouteile est déjà ouverte");
            }
        }

        public void close()
        {
            if (isOpen == true)
            {
                isOpen = false;
                Console.WriteLine("Vous avez fermez la boutteille");
            }
            else
            {
                Console.WriteLine("La bouteile est déjà fermé");
            }
        }

        public void empty(float liter)
        {
            if(isOpen == true)
            {
                if(liquidInLiter < liter)
                {
                    Console.WriteLine("Vous avez vider la bouteille de : " + liquidInLiter);
                }
                else
                {
                    liquidInLiter -= liter;
                    if (liquidInLiter < 0)
                    {
                        liquidInLiter = 0;
                    }
                    Console.WriteLine("Vous avez vidé la boutteille de " + liter + " L, elle contient à présent " + liquidInLiter + " litre de solution");
                }
            }
            else
            {
                Console.WriteLine("La bouteille ne peu pas être vider car elle est fermé");
            }
        }

        public void fullEmpty()
        {
            if (isOpen == true)
            {
                liquidInLiter = 0;

                Console.WriteLine("Vous avez vidé la boutteille");
            }
            else
            {
                Console.WriteLine("La bouteille ne peu pas être vider car elle est fermé");
            }
        }

        public void fill(float liter)
        {
            if (isOpen == true)
            {
                if (liter + liquidInLiter <= bottleCapacityInLiter)
                {
                    liquidInLiter += liter;
                    Console.WriteLine("Vous avez remplit la boutteille");
                }
                else
                {
                    Console.WriteLine("ça déborde !");
                    this.liquidInLiter = bottleCapacityInLiter;
                }
            }
            else
            {
                Console.WriteLine("La bouteille ne peu pas être remplit car elle est fermé");
            }
        }

        public void fillFull()
        {
            if (isOpen == true)
            {
                liquidInLiter += bottleCapacityInLiter;
                Console.WriteLine("Vous avez remplit la boutteille");
            }
            else
            {
                Console.WriteLine("La bouteille ne peu pas être remplit car elle est fermé");
            }
        }

        public void afficherStats()
        {
            Console.WriteLine("La bouteille a une capaciter de " + bottleCapacityInLiter + "L et elle contient actuelement " + liquidInLiter + " Litre d'eau");
            if(isOpen == true)
            {
                Console.WriteLine("La bouteille est ouverte et peu être remplit");
            }
            else
            {
                Console.WriteLine("La bouteille est fermé et ne peu pas être remplit");
            }
        }

    }
}
