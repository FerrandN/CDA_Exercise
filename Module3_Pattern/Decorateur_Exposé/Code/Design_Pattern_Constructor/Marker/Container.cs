using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public abstract class Container
    {
        private string text = "";
        private string markedText = "";
        private string color = "white";
        private string font = "";

        public string Text { get { return text; } set { text = value; } }
        public string Color { get { return color; } set { color = value; } }
        public string Font { get { return font; } set { font = value; } }

        public string MarkedText { get { return markedText; } set { markedText = value; } }

        public void DisplayState()
        {
            Console.WriteLine("Mon texte est de couleur " + color + " et d'apparence" + (font != "" ? font : " normale"));
        }

        public void DisplayMarkedText()
        {
            Console.WriteLine(markedText);
        }

        public void DisplayText()
        {
            Console.WriteLine(text);
        }

    }
}
