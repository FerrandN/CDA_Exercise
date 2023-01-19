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
        //Constructeur
        public Partie() : base()
        {
        
        }
        public Partie(int _nombreDeMancheSouhaitees)
        {
            this.nombreDeMancheSouhaitees = _nombreDeMancheSouhaitees;
            mancheCourante = new Manche();
            score = _nombreDeMancheSouhaitees*10;
        }
        //get, set. score
        public void setScore(int toSet)
        {
            score += toSet;
        }

        public int getScore()
        {
            return score;
        }
        //get, set. nombreDeMancheEffectuees
        public int getNombreDeManchesEffectuees()
        {
            return nombreDeManchesEffectuees;
        }
        public int getNombreDeManchesSouhaitees()
        {
            return nombreDeMancheSouhaitees;
        }

        //compare 2 int, return boolean to know if player can continue to play
        public bool AEncoreUneMancheAjouer()
        {
            if(nombreDeMancheSouhaitees > nombreDeManchesEffectuees)
            {
                return true;
            }
            return false;
        }

        //reset manche
        public void CreerUneNouvelleManche()
        {
            if(AEncoreUneMancheAjouer())
            {
                mancheCourante = new Manche();
                nombreDeManchesEffectuees++;
            }
        }

        //reroll dices
        public void RelancerLesDesDeLaMancheCourantes()
        {
            mancheCourante.Relance();
        }
    }
}
