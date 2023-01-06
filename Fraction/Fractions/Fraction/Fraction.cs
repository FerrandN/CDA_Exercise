using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    public class Fraction : IComparable<Fraction>
    {
        private int numerateur;
        private int denominateur = 1;
        public Fraction()
        {

        }
        public Fraction(int numerateur, int denominateur)
        {
            this.numerateur = numerateur;
            this.denominateur = denominateur;
        }
        public Fraction(int numerateur)
        {
            this.numerateur=numerateur;
        }

        public string toString()
        {
            return ("numerateur: " + numerateur + " denominateur: " + denominateur);
        }

        public void Oppose()
        {
            numerateur *= -1;
        }

        public void Inverse()
        {
            int temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }

        public bool SuperieurA(Fraction toCompare)
        {
            return (this.numerateur/this.denominateur) > (toCompare.numerateur/toCompare.denominateur);
        }

        public bool EgalA(Fraction toCompare)
        {
            return (this.numerateur / this.denominateur) == (toCompare.numerateur / toCompare.denominateur);
        }

        private void Reduire()
        {
            int pgcd = GetPgcd();
            this.numerateur /= pgcd;
            this.denominateur /= pgcd;
            if(this.denominateur < 0 && this.numerateur < 0)
            {
                this.denominateur *= -1;
                this.numerateur *= -1;
            }
        }

        private Fraction Plus(Fraction toAdd)
        {
            Fraction temp = new Fraction();
            temp.denominateur = this.denominateur * toAdd.denominateur;
            temp.numerateur = (this.numerateur * toAdd.denominateur) + (toAdd.numerateur * this.denominateur);
            temp.Reduire();
            return temp;
        }

        private int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;
            if ( a != 0 && b != 0)
            {
                if (a < 0)
                {
                    {
                        a *= -1;
                    }
                }
            }
            if (b != 0 && b != 0)
            {
                if (b < 0)
                {
                    {
                        b *= -1;
                    }
                }
            }
            while (a != b)
            {
                if(a<b)
                {
                    b = b - a;
                }
                else
                {
                    a = a - b;
                }
            }
            pgcd = a;
            return pgcd;
        }

        private Fraction Moin(Fraction toSubstract)
        {
            Fraction temp = new Fraction();
            temp.denominateur = this.denominateur * toSubstract.denominateur;
            temp.numerateur = (this.numerateur * toSubstract.denominateur) - (toSubstract.numerateur * this.denominateur);
            temp.Reduire();
            return temp;
        }

        private Fraction Multiplie(Fraction toMultiplie)
        {
            Fraction temp = new Fraction();
            temp.numerateur = toMultiplie.numerateur * this.numerateur;
            temp.denominateur = toMultiplie.denominateur * this.denominateur;
            Reduire();
            return temp;
        }

        private Fraction Divise(Fraction toDivide)
        {
            Fraction temp = new Fraction();
            toDivide.Inverse();
            temp = this.Multiplie(toDivide);
            return temp;
        }

        private float GetValue()
        {
            return (this.numerateur/this.denominateur);
        }

        private string ToDisplay()
        {
            return (" Numerateur= " + this.numerateur + " \n Dénominateur" + this.denominateur);
        }

        public int CompareTo(Fraction? other)
        {
            throw new NotImplementedException();
        }
        public static Fraction operator +(Fraction _frac1, Fraction _frac2)
        {

            return _frac1.Plus(_frac2);
        }


    }
}
