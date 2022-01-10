using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    abstract class AbstractShape : IShape
    {
        int x = 0;
        public abstract void Draw();

        public abstract void Color();

        public void DoSomething()
        {
            Console.WriteLine("Shape is doing something!");
        }
    }
}
