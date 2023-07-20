using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageFigure
{
    public class Cercle : Figure
    {
        private double rayon;

        public double Rayon
        {
            get { return rayon; }
        }

        public Cercle(double _x, double _y, double _rayon):base(_x,_y)
        {
            this.rayon = _rayon;
        }

        public override void AccepterVisiteur(IVisiteurDeFigure v)
        {
            v.Visite(this);
        }
    }
}
