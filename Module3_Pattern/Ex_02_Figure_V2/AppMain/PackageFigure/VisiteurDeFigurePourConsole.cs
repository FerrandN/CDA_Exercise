using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageFigure
{
    public class VisiteurDeFigurePourConsole : IVisiteurDeFigure
    {
        public void Visite(Cercle c)
        {
            Console.WriteLine("Valeur de la position X du cercle " + c.X);
            Console.WriteLine("Valeur de la position Y du cercle " + c.Y);
            Console.WriteLine("Valeur du rayon du cercle " + c.Rayon);
        }
        public void Visite(Rectangle r)
        {
            Console.WriteLine("Valeur de la position X du rectangle " + r.X);
            Console.WriteLine("Valeur de la position Y du rectangle " + r.Y);
            Console.WriteLine("Valeur de la hauteur du rectangle " + r.Hauteur);
            Console.WriteLine("Valeur de la largeur du rectangle " + r.Largeur);
        }
        public void Visite(Figures fs)
        {
            Console.WriteLine("Valeur de la position X de la figure" + fs.X);
            Console.WriteLine("Valeur de la position Y de la figure" + fs.Y);
        }
    }
}
