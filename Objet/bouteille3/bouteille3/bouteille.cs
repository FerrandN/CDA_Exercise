using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bouteille3
{
    internal class bouteille
    {
        bool isOpen = false;
        float maxCapacity = 100;
        float liquidInLiter = 0;

        public bouteille() : this(100,0,false)
        {

        }
        public bouteille(float maxCapacity)
        {
            this.maxCapacity = maxCapacity;
        }
        public bouteille(float maxCapacity, float liquidInLiter, bool isOpen)
        {
            this.maxCapacity = maxCapacity;
            this.isOpen = isOpen;
            this.liquidInLiter= liquidInLiter;
        }

        public bouteille (bouteille otherBottle)
        {
            isOpen = otherBottle.isOpen;
            maxCapacity = otherBottle.maxCapacity;
            liquidInLiter = otherBottle.liquidInLiter;
        }

        public bool Open()
        {
            if(isOpen == false)
            {
                isOpen = true;
                Console.WriteLine("Vous avez ouvert la bouteille \n");
            }
            else
            {
                Console.WriteLine("La bouteille est déjà ouverte \n");
            }
            return isOpen;
        }

        public bool Close()
        {
            if(isOpen == true)
            {
                isOpen = false;
                Console.WriteLine("Vous avez fermer la bouteille \n");
            }
            else
            {
                Console.WriteLine("La bouteille est déjà fermer \n");
            }
            return isOpen;
        }

        public float Fill(float liter)
        {
            if (isOpen == true)
            {
                if (liquidInLiter + liter > maxCapacity)
                {
                    Console.WriteLine("ça déborde ! \n");
                    liquidInLiter = maxCapacity;
                    return liquidInLiter;
                }
                else if (liter < 0)
                {
                    Console.WriteLine("Veuillez utiliser la commande vider pour enlever du liquide de la bouteille \n");
                }
                else
                {
                    Console.WriteLine("Vous avez rajouter " + liter + " centi Litre à la bouteille \n");
                    liquidInLiter += liter;
                }
            }
            else
            {
                Console.WriteLine("La bouteille est fermer et ne pas recevoir de liquide \n");
            }
            return liquidInLiter;
        }
        public float Empty(float liter)
        {
            if (isOpen == true)
            {
                if (liquidInLiter - liter < 0)
                {
                    Console.WriteLine("vous avez enlever " + liquidInLiter + " Centi Litre \n");
                    liquidInLiter = 0;
                    return liquidInLiter;
                }
                else
                {
                    Console.WriteLine("Vous avez enlever " + liter + "cl");
                    liquidInLiter -= liter;
                    Console.WriteLine("il reste " + liquidInLiter + "cl \n");
                }
            }
            else
            {
                Console.WriteLine("La bouteille est fermer et ne peu pas être vidé \n");
            }
            return liquidInLiter;
        }

        public bool FullEmpty()
        {
            if(isOpen == true && liquidInLiter>0)
            {
                liquidInLiter = 0;
                return true;
            }
            return false;
        }

        public bool FullFill()
        {
            if (isOpen == true && liquidInLiter < 100)
            {
                liquidInLiter = 100;
                return true;
            }
            return false;
        }

        public void State()
        {
            Console.WriteLine("la bouteille est: " + (isOpen==true ? "ouverte": "fermé"));
            Console.WriteLine("il y a " + liquidInLiter + "cl de liquide à l'interieur \n");
        }
    }
}
