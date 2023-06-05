using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point
{
    public class Points
    {
        private int abscisse = 0;
        private int ordonnee = 0;

        public Points()
        {

        }

        public Points(int _abscisse, int _ordonnee)
        {
            this.abscisse = _abscisse;
            this.ordonnee = _ordonnee;
        }

        public Points(Points p)
        {
            this.abscisse = p.abscisse;
            this.ordonnee = p.ordonnee;
        }

        public int GetAbscisse
        {
            get { return abscisse; }
            set { abscisse = value; }
        }

        public int GetOrdonnee
        {
            get { return abscisse; }
            set { abscisse = value; }
        }


        public Points DuplicateSymmetricallyOrigin()
        {
            Points newPoint = this.DuplicateSymmetricallyOrdonnee();
            newPoint = newPoint.DuplicateSymmetricallyAbscisse();
            return newPoint;
        }

        public Points DuplicateSymmetricallyAbscisse()
        {
            Points newPoint = new Points(abscisse * -1, ordonnee);
            return newPoint;
        }

        public Points DuplicateSymmetricallyOrdonnee()
        {
            Points newPoint = new Points(abscisse, ordonnee * -1);
            return newPoint;
        }

        public bool Move(int toAddToAbscisse, int toAddToOrdonnee)
        {
            abscisse += toAddToAbscisse;
            ordonnee += toAddToOrdonnee;
            return true;
        }

        public void SwapParticular()
        {
            int temp = abscisse;
            abscisse = ordonnee;
            ordonnee = temp;
        }

        public override string ToString()
        {
            return (" abscisse: " + abscisse + " \n ordonnee: " + ordonnee);
        }
    }
}