using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text.Decorator
{
    public abstract class Decorator : Container
    {
        protected Container objectToDecorate;

        public Decorator(Container _objectToDecorate)
        {
            this.objectToDecorate = _objectToDecorate;
        }

        public void ChangeColor(string color)
        {
            this.Color = color;
        }

        public abstract Container ChangeObject();
    }
}
