using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormeFigure
{
    public class Carre : Figure
    {
        private double hauteur;
        private double largeur;

        public Carre(double _hauteur, double _largeur, double _x, double _y):base(_x, _y)
        {
            this.hauteur = _hauteur;
            this.largeur = _largeur;
        }

        public override void SeDessiner()
        {
            Console.WriteLine("Coordonné: " + this.x + " " + this.y);
            Console.WriteLine("Taille: " + this.hauteur + " " + this.largeur);
        }
    }
}
