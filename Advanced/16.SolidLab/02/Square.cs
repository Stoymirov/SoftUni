﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Square:IShape,IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("I am a square");
        }
    }
}
