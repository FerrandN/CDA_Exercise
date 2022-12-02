using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class NombreRationel
    {
        float numerateur = 0;
        float dénominateur = 1;

        public NombreRationel(float numerateur, float dénominateur)
        {
            this.numerateur = numerateur;
            this.dénominateur = dénominateur;
        }

        public NombreRationel()
        {

        }

        public NombreRationel(float numerateur)
        {
            this.numerateur = numerateur;
        }

        public void Display()
        {
            if(this.numerateur != 0)
            {
                if(this.dénominateur != 1)
                {
                    Console.WriteLine("numerateur : " + numerateur + " dénominateur : " + dénominateur);
                }
                else
                {
                    Console.WriteLine(numerateur);
                }
            }
            else
            {
                Console.WriteLine(numerateur);
            }
        }

        public void Oppose()
        {
            this.numerateur = numerateur * (-1);
        }

        public void Inverse()
        {
            float temp = numerateur;
            numerateur = dénominateur;
            dénominateur = temp;
        }

        public bool SuperieurA(NombreRationel n)
        {
            return (this.numerateur / this.dénominateur) != (n.numerateur/n.dénominateur);
        }

        public bool EgalA(NombreRationel n)
        {
            return (this.numerateur / this.dénominateur) == (n.numerateur / n.dénominateur);
        }

        private void Réduire()
        {
            if((numerateur>0 && dénominateur<0) || (numerateur<0 && dénominateur<0))
            {
                float pgcdNumerateur = GetPgcd();
                numerateur /= pgcdNumerateur;
                dénominateur /= pgcdNumerateur;
                numerateur *= (-1);
                dénominateur *= (-1);
            }
            else
            {
                float pgcdNumerateur = GetPgcd();
                numerateur /= pgcdNumerateur;
                dénominateur /= pgcdNumerateur;
            }
        }

        private float GetPgcd()
        {
            float a = this.numerateur;
            float b = this.dénominateur;
            float pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a<b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
            }
            pgcd = a;
            return pgcd;
        }

        public NombreRationel Plus (NombreRationel a, NombreRationel b)
        {
            NombreRationel sum = new NombreRationel();
            sum.numerateur = a.numerateur + b.numerateur;
            sum.dénominateur = a.dénominateur + b.dénominateur;
            return sum;
        }

        public NombreRationel Moins(NombreRationel a, NombreRationel b)
        {
            NombreRationel sum = new NombreRationel();
            sum.numerateur = a.numerateur - b.numerateur;
            sum.dénominateur = a.dénominateur - b.dénominateur;
            return sum;
        }

        public NombreRationel Multiplie(NombreRationel a, NombreRationel b)
        {
            NombreRationel sum = new NombreRationel();
            sum.numerateur = a.numerateur * b.numerateur;
            sum.dénominateur = a.dénominateur * b.dénominateur;
            return sum;
        }

        public NombreRationel Divise(NombreRationel a, NombreRationel b)
        {
            NombreRationel sum = new NombreRationel();
            b.Inverse();
            sum.numerateur = a.numerateur * b.numerateur;
            sum.dénominateur = a.dénominateur * b.dénominateur;
            return sum;
        }

    }
}
