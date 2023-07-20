using PackageFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageFigure
{
    public interface IVisiteurDeFigure
    {
        public abstract void Visite(Cercle c);
        public abstract void Visite(Rectangle r);
        public abstract void Visite(Figures f);
    }
}
