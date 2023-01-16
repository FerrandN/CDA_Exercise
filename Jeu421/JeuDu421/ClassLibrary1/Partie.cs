using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDu421
{
    public class Partie
    {
        private int nombreDeManchesEffectuees;
        private int nombreDeMancheSouhaitees;
        private int score;
        public Manche mancheCourante;

        public Partie() : base()
        {
        
        }
        public Partie(int _nombreDeMancheSouhaitees)
        {
            this.nombreDeMancheSouhaitees = _nombreDeMancheSouhaitees;
            mancheCourante = new Manche();
            score = _nombreDeMancheSouhaitees*10;
        }

        public void setScore(int toSet)
        {
            score += toSet;
        }

        public int getScore()
        {
            return score;
        }

        public int getNombreDeManchesEffectuees()
        {
            return nombreDeManchesEffectuees;
        }
        public int getNombreDeManchesSouhaitees()
        {
            return nombreDeMancheSouhaitees;
        }
        public bool AEncoreUneMancheAjouer()
        {
            if(nombreDeMancheSouhaitees > nombreDeManchesEffectuees)
            {
                return true;
            }
            return false;
        }

        public void CreerUneNouvelleManche()
        {
            if(AEncoreUneMancheAjouer())
            {
                mancheCourante = new Manche();
                nombreDeManchesEffectuees++;
            }
        }

        public void RelancerLesDesDeLaMancheCourantes()
        {
            mancheCourante.Relance();
        }
    }
}
