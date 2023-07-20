using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageFigure
{
    public class Rectangle : Figure
    {
        private double hauteur;
        private double largeur;
        public double Hauteur
        {
            get { return hauteur; }
        }

        public double Largeur
        {
            get { return largeur; }
        }
        public Rectangle(double _x, double _y, double _hauteur, double _largeur) : base(_x, _y)
        {
            this.hauteur = _hauteur;
            this.largeur = _largeur;
        }

        public override void AccepterVisiteur(IVisiteurDeFigure v)
        {
            v.Visite(this);
        }
    }
}
