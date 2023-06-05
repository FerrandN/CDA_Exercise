using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    public class Fraction 
    {
        private int numerateur;
        private int denominateur = 1;
        public int Denominateur
        {
            get { return denominateur; }
            private set { denominateur = value; }
        }
        public int Numerateur
        {
            get { return numerateur; }
            private set { numerateur = value; }
        }
        public Fraction()
        {

        }
        public Fraction(int numerateur, int denominateur)
        {
            if(denominateur == 0)
            {
                throw new DenominateurEgalAZeroException();
            }
            this.numerateur = numerateur;
            this.denominateur = denominateur;
        }
        public Fraction(int numerateur)
        {
            this.numerateur=numerateur;
        }

        public Fraction(Fraction f)
        {
            this.numerateur = f.numerateur;
            this.denominateur = f.denominateur;
        }

        public override string ToString()
        {
            return ("numerateur: " + numerateur + " denominateur: " + denominateur);
        }

        public void Oppose()
        {
            numerateur = numerateur * -1;
        }

        public void Inverse()
        {
            if (numerateur == 0)
            {
                throw new Exception("le numerateur ne peu pas être égale à 0 pour utiliser cette fonction");
            }
            int temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }

        private float CalculerFraction()
        {
            return this.numerateur / this.denominateur;
        }

        public bool SuperieurA(Fraction toCompare)
        {
            return this.CalculerFraction() > toCompare.CalculerFraction();
        }

        public bool EgalA(Fraction toCompare)
        {
            return this.CalculerFraction() == toCompare.CalculerFraction();
        }

        private void Reduire()
        {
            int pgcd = GetPgcd();
            this.numerateur = this.numerateur / pgcd;
            this.denominateur = this.denominateur / pgcd;
            this.GererSigne();
            if(this.denominateur == 0)
            {
                throw new Exception();
            }
        }

        public Fraction Plus(Fraction toAdd)
        {
            Fraction temp = new Fraction((this.numerateur * toAdd.denominateur) + 
                (toAdd.numerateur * this.denominateur),
                this.denominateur * toAdd.denominateur);
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
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
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

        public Fraction Moins(Fraction toSubstract)
        {
            Fraction temp = new Fraction();
            temp.denominateur = this.denominateur * toSubstract.denominateur;
            temp.numerateur = (this.numerateur * toSubstract.denominateur) - (toSubstract.numerateur * this.denominateur);
            temp.Reduire();
            return temp;
        }

        public Fraction Multiplie(Fraction toMultiplie)
        {
            Fraction temp = new Fraction();
            temp.numerateur = toMultiplie.numerateur * this.numerateur;
            temp.denominateur = toMultiplie.denominateur * this.denominateur;
            temp.Reduire();
            return temp;
        }

        public Fraction Divise(Fraction toDivide)
        {
            Fraction temp = toDivide;
            temp.Inverse();
            return this.Multiplie(temp);
        }

        public void GererSigne()
        {
            if(this.numerateur < 0 && this.denominateur < 0)
            {
                this.numerateur *= -1;
                this.denominateur *= -1;
            }
        }

        public string ToDisplay()
        {
            if (denominateur != 1)
            {
                return (numerateur + "/" + denominateur);
            }
            else
            {
                return string.Format("{0}", numerateur);
            }
        }

        public float GetValue()
        {
            return (this.numerateur/this.denominateur);
        }

        public static Fraction operator +(Fraction _frac1, Fraction _frac2)
        {

            return _frac1.Plus(_frac2);
        }


    }
}
