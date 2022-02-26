using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAdapter
{
    public class TextShape : Shape
    {
        private Text t;

        public TextShape()
        {
            t = new Text("Hello");
        }

        public TextShape(string content)
        {
            t = new Text(content);
        }

        public override void Draw()
        {
            t.Print();
        }
    }
}