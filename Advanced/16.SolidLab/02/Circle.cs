using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Circle:IShape,IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("I am a circle");
        }
    }
}
