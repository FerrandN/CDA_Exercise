using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    public class Point
    {
        float abscisse = 0;
        float ordonnée = 0;

        public Point(float _abscisse, float _ordonnée)
        {
            this.abscisse = _abscisse;
            this.ordonnée = _ordonnée;
        }
        public Point()
        {

        }

        public void Display()
        {
            Console.WriteLine("Le point se trouve aux coordonnées: x:" + abscisse + " y:" + ordonnée);
        }

        public void Move(float _abscisse, float _ordonnée)
        {
            abscisse = _abscisse;
            ordonnée = _ordonnée;
        }

        public Point AbsSym(Point p)
        {
            p.ordonnée = ordonnée * (-1);
            return p;
        }
        public Point OrdSym(Point p)
        {
            p.abscisse = abscisse * (-1);
            return p;
        }

        public Point Sym(Point p)
        {
            p.abscisse = abscisse * (-1);
            p.ordonnée = ordonnée * (-1);
            return p;
        }

        public void Permuter()
        {
            float temp = abscisse;
            abscisse = ordonnée;
            ordonnée = abscisse;
        }
    }
}
