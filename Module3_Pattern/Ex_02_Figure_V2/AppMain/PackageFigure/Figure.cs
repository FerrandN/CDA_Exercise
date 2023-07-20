using System.Data;

namespace PackageFigure
{
    public abstract class Figure
    {
        protected double x;
        protected double y;
        public Figure(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public double X { get { return x; } }
        public double Y { get { return y; } }

        public abstract void AccepterVisiteur(IVisiteurDeFigure v);

    }
}