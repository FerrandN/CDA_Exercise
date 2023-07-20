using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormeFigure
{
    public class Cercle : Figure
    {
        private double rayon;

        public Cercle(double rayon, double _x, double _y) : base(_x, _y)
        {
            this.rayon = rayon;
        }

        public override void SeDessiner()
        {
            Console.WriteLine("Coordonné: " + this.x + " " + this.y);
            Console.WriteLine("Taille: " + this.rayon);
        }

    }
}
