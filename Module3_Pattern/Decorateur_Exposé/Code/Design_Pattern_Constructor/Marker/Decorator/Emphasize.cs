using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text.Decorator
{
    public class Emphasize : Decorator
    {
        public Emphasize(Container objectToDecorate) : base(objectToDecorate)
        {

        }

        private string AddEmphasize()
        {
            return " Souligné";
        }

        private string AddMarkEmphasize()
        {
            return "<em> " + this.Text + " </em>";
        }
        public override Container ChangeObject()
        {
            this.Font += this.AddEmphasize();
            this.MarkedText = AddMarkEmphasize();

            return this;
        }
    }
}
