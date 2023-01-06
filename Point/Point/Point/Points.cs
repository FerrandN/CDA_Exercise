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

        }

        public int GetAbscisse
        {
            get { return abscisse; }
        }

        public int GetOrdonnee
        {
            get { return abscisse; }
        }


        public Points DuplicateSymmetrically()
        {
            Points newPoint = new Points(abscisse * -1, ordonnee * -1);
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
            try
            {
                abscisse += toAddToAbscisse;
                ordonnee += toAddToOrdonnee;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SwapParticular()
        {
            try
            {
                int temp = abscisse;
                abscisse = ordonnee;
                ordonnee = temp;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string ParticularToString()
        {
            return (" abscisse: " + abscisse + " \n ordonnee: " + ordonnee);
        }
    }
}