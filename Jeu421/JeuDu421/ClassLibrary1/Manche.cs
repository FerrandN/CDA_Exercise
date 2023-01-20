using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDu421
{
    internal class Manche
    {
        private byte nbLancerEffectue = 0;

        private readonly byte nbLancerMax = 3;
        private List<De> des;

        public byte NbLancerEffectue { get => nbLancerEffectue; set => nbLancerEffectue=value; }
        public byte NbLancerMax { get => nbLancerMax; }

        public Manche()
        {
            des = new List<De>();
            for (int i = 0; i < 3; i++)
            {
                des.Add(new De());
                this.Trier();
            }
        }

        //sort dice
        public void Trier()
        {
            des.Sort();
        }

        //compare 2 byte, return boolean to know if player can reroll dices
        public bool AEncoreUnLance()
        {
            if (NbLancerEffectue < nbLancerMax)
            {
                return true;
            }
            else
                return false;
        }

        //Compare dices in list, to value. If all value found, return true
        public bool EstGagnee()
        {
            De? d4=des.Find(x => x.Valeur == 4);
            if (d4 != null)
            {
                De? d2 = des.Find(x => x.Valeur == 2);
                
                if (d2 != null)
                {
                    De? d1 = des.Find(x => x.Valeur == 1);
                    if(d1 != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        internal void Relance(byte numeroDe)
        {
            des[numeroDe].Rouler();
            NbLancerEffectue++;
        }

        //override ToString method, tu return dices value
        public override string ToString()
        {
            return string.Format("Dé:\n1: {0}\n2: {1}\n3: {2}", des[0].Valeur, des[1].Valeur, des[2].Valeur);
        }
    }
}
