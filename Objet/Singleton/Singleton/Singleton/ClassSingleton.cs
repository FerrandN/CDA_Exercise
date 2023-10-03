using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ClassSingleton
    {

        private static ClassSingleton instance;

        private ClassSingleton()
        {

        }

        public static ClassSingleton GetInstance()
        {
            if(instance == null)
            {
                instance = new ClassSingleton();
            }
            return instance;
        }
    }
}
