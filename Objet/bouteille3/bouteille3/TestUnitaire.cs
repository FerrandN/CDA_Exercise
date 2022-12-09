using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bouteille3
{
    internal class TestUnitaire
    {
        bouteille ToTest = new bouteille(150, 0, false);

        public bool TestOpenClosedBottle()
        {
            Console.WriteLine("Test ouvrir une bouteille fermé devrait renvoyer true");
            if(ToTest.IsOpen == false)
            {
                ToTest.Open();
                if(ToTest.IsOpen)
                {
                    Console.WriteLine("Test réussit");
                }
                else
                {
                    Console.WriteLine("Test raté");
                }
            }
            return ToTest.IsOpen;
        }

        public bool TestCloseOpenedBottle()
        {
            Console.WriteLine("Test fermer une bouteille ouverte devrait renvoyer false");
            if (ToTest.IsOpen == true)
            {
                ToTest.Close();
                if (!ToTest.IsOpen)
                {
                    Console.WriteLine("Test réussit");
                }
                else
                {
                    Console.WriteLine("Test raté");
                }
            }
            return ToTest.IsOpen;
        }

        public bool TestOpenOpenedBottle()
        {
            Console.WriteLine("Test ouvrir une bouteille ouverte devrait renvoyer true");
            if (ToTest.IsOpen == true)
            {
                ToTest.Open();
                if (ToTest.IsOpen)
                {
                    Console.WriteLine("Test réussit");
                }
                else
                {
                    Console.WriteLine("Test raté");
                }
            }
            return ToTest.IsOpen;
        }

        public bool TestCloseClosedBottle()
        {
            Console.WriteLine("Test fermer une bouteille fermé devrait renvoyer false");
            if (ToTest.IsOpen == false)
            {
                ToTest.Close();
                if (!ToTest.IsOpen)
                {
                    Console.WriteLine("Test réussit");
                }
                else
                {
                    Console.WriteLine("Test raté");
                }
            }
            return ToTest.IsOpen;
        }

        public bool TestFillClosedBottle()
        {
            bool b = true;
            Console.WriteLine("Test remplir une bouteille fermé");
            Console.WriteLine("Doit renvoyer false");
            if (ToTest.IsOpen == false)
            {
                float temp = ToTest.LiquidInLiter;
                ToTest.Fill(5);
                if(temp != ToTest.LiquidInLiter)
                {
                    b = false;
                }
            }
            return b;
        }

        public bool TestFillOpenedBottle()
        {
            bool b = false;
            Console.WriteLine("Test remplir une bouteille ouverte");
            Console.WriteLine("Doit renvoyer true");
            if (ToTest.IsOpen == true)
            {
                float temp = ToTest.LiquidInLiter;
                ToTest.Fill(5);
                if (temp < ToTest.LiquidInLiter)
                {
                    b = true;
                }
            }
            return b;
        }

        public bool TestFullFillClosedBottle()
        {
            bool b = true;
            Console.WriteLine("Test remplir entièrement une bouteille fermé");
            Console.WriteLine("Doit renvoyer false");
            if (ToTest.IsOpen == false)
            {
                ToTest.FullFill();
                if (ToTest.LiquidInLiter != ToTest.MaxCapacity)
                {
                    b = false;
                }
            }
            return b;
        }

        public bool TestFullFillOpenedBottle()
        {
            bool b = false;
            Console.WriteLine("Test remplir entièrement une bouteille ouverte");
            Console.WriteLine("Doit renvoyer true");
            if (ToTest.IsOpen == true)
            {
                ToTest.Fill(5);
                if (ToTest.LiquidInLiter == ToTest.MaxCapacity)
                {
                    b = true;
                }
            }
            return b;
        }

        public bool TestEmptyClosedBottle()
        {
            bool b = true;
            Console.WriteLine("Test vider une bouteille fermé");
            Console.WriteLine("Doit renvoyer false");
            if (ToTest.IsOpen == false)
            {
                float temp = ToTest.LiquidInLiter;
                ToTest.Empty(5);
                if (temp != ToTest.LiquidInLiter)
                {
                    b = false;
                }
            }
            return b;
        }

        public bool TestEmptyOpenedBottle()
        {
            bool b = false;
            Console.WriteLine("Test vider une bouteille ouverte");
            Console.WriteLine("Doit renvoyer true");
            if (ToTest.IsOpen == true)
            {
                float temp = ToTest.LiquidInLiter;
                ToTest.Empty(5);
                if (temp > ToTest.LiquidInLiter)
                {
                    b = true;
                }
            }
            return b;
        }

        public bool TestFullEmptyClosedBottle()
        {
            bool b = true;
            Console.WriteLine("Test vider entièrement une bouteille fermé");
            Console.WriteLine("Doit renvoyer false");
            if (ToTest.IsOpen == false)
            {
                float temp = ToTest.LiquidInLiter;
                ToTest.FullEmpty();
                if (ToTest.LiquidInLiter != temp)
                {
                    b = false;
                }
            }
            return b;
        }

        public bool TestFullEmptyOpenedBottle()
        {
            bool b = false;
            Console.WriteLine("Test vider entièrement une bouteille ouverte");
            Console.WriteLine("Doit renvoyer true");
            if (ToTest.IsOpen == true)
            {
                ToTest.FullEmpty();
                if (ToTest.LiquidInLiter == 0)
                {
                    b = true;
                }
            }
            return b;
        }
    }
}
