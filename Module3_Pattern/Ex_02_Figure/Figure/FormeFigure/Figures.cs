using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormeFigure
{
    public class Figures : Figure
    {
        private List<Figure> sesFigures;

        public Figures(double _x, double _y):base(_x,_y)
        {
            this.sesFigures = new List<Figure>();
        }

        public void Add(Figure f)
        {
            sesFigures.Add(f);
        }

        public void Remove(Figure f)
        {
            sesFigures.Remove(f);
        }

        public override void SeDessiner()
        {
            foreach(Figure f in sesFigures)
            {
                f.SeDessiner();
            }
        }

    }
}
