using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDu421
{
    public class Manche
    {
        byte nbLancerEffectue = 0;
        public readonly byte nbLancerMax = 3;
        List<De> des;

        public Manche()
        {
            des = new List<De>();
            for (int i = 0; i < 3; i++)
            {
                des.Add(new De());
                this.Trier();
            }
        }

        public byte getNbLancerEffectue()
        {
            return nbLancerEffectue;
        }

        public void setNbLancerEffectue(byte value)
        {
            nbLancerEffectue += value;
        }
        public void Trier()
        {
            des.Sort();
        }
        public bool AEncoreUnLance()
        {
            if (nbLancerEffectue < nbLancerMax)
            {
                return true;
            }
            else
                return false;
        }

        public bool EstGagnee()
        {
            De? d4=des.Find(x => x.GetValeur() == 4);
            if (d4 != null)
            {
                De? d2 = des.Find(x => x.GetValeur() == 2);
                
                if (d2 != null)
                {
                    De? d1 = des.Find(x => x.GetValeur() == 1);
                    if(d1 != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Relance()
        {
            foreach (De de in des)
            {
                de.Rouler();
            }
        }

        public void Relance(byte numeroDe)
        {
            des[numeroDe].Rouler();
        }
        public void Relance(byte numeroDe, byte numeroSecondDe)
        {
            des[numeroDe].Rouler();
            des[numeroSecondDe].Rouler();
        }

        public override string ToString()
        {
            return string.Format("Dé:\n1: {0}\n2: {1}\n3: {2}", des[0].GetValeur(), des[1].GetValeur(), des[2].GetValeur());
        }
    }
}
