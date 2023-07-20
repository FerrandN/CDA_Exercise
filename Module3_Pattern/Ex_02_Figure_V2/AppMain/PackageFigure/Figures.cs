using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageFigure
{
    public class Figures : Figure
    {
        List<Figure> figureList;

        public Figures(double _x, double _y) : base(_x, _y)
        {
            figureList = new List<Figure>();
        }

        public List<Figure> FigureList
        {
            get { return figureList; }
        }


        public override void AccepterVisiteur(IVisiteurDeFigure v)
        {
            v.Visite(this);
            foreach (Figure f in figureList)
            {
                f.AccepterVisiteur(v);
            }
        }

        public void Add(Figure f)
        {
            figureList.Add(f);
        }

        public void Remove(Figure f)
        {
            figureList.Remove(f);
        }
    }
}
