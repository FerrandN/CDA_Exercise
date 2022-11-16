using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaourts
{
    internal class App
    {
        public static string run(String[] results)
        {
            List<string> color = new List<string>();
            List<short> count = new List<short>();

            // We count the number of occurence for each colors
            foreach(string s in results)
            {
                int i = 0;
                
                bool found = false;
                while (i < color.Count && !found)
                {
                    found = color[i].Equals(s);
                    if (found)
                    {
                        count[i]++;
                    }
                    i++;
                }
                if (!found)
                {
                    color.Add(s);
                    count.Add(1);
                }
                
            }
            byte[] idOrder = orderByAsc(count.ToArray());

            return color[idOrder[0]] + " " + color[idOrder[1]];
        }


        private static byte[] orderByAsc(short[] values)
        {
            byte[] rt = new byte[values.Length];
            for(byte i = 0; i < rt.Length; i++)
            {
                rt[i] = i;
            }
            // --
            for (int i = 0; i < values.Length-1; i++)
            {
                for (int j = i+1; j < values.Length; j++)
                {
                    if (values[i] > values[j])
                    {
                        short tmp = values[i];
                        values[i] = values[j];
                        values[j] = tmp;
                        byte tmprt = rt[i];
                        rt[i] = rt[j];
                        rt[j] = tmprt;
                    }
                }
            }
            return rt;
        }
    }
}
