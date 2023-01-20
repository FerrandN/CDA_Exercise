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
        public int NombreDeManchesEffectuees { get { return nombreDeManchesEffectuees; } set => nombreDeManchesEffectuees = value; }
        private int nombreDeMancheSouhaitees;
        public int NombreDeManchesSouhaitees { get { return nombreDeMancheSouhaitees;  } set => nombreDeMancheSouhaitees = value; }
        private int score;

        public int Score { get { return score; } private set { score = value; } }
        internal Manche mancheCourante;
        internal Manche MancheCourante { get => mancheCourante; }
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
        public void RelancerLesDesDeLaMancheCourantes(byte dicesSelected)
        {
            mancheCourante.Relance(dicesSelected);
        }

        public byte GetMancheNbLancerEffectue()
        {
            return mancheCourante.NbLancerEffectue;
        }

        public byte GetNbLancerMax()
        {
            return mancheCourante.NbLancerMax;
        }

        public bool EstGagnee()
        {
            return mancheCourante.EstGagnee();
        }

        public void SetNbLancerEffectue(byte b)
        {
            mancheCourante.NbLancerEffectue = b;
        }

        public void AddOneToNbLancerEffectue()
        {
            MancheCourante.NbLancerEffectue++;
        }
        public string MancheToString()
        {
            return mancheCourante.ToString();
        }

        public bool AEncoreUnLance()
        {
            return mancheCourante.AEncoreUnLance();
        }

        public void SubstractTenFromScore()
        {
            score = score - 10;
        }

        public void AddThirtyToScore()
        {
            score = score + 30;
        }
    }
}
