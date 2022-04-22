using System;


namespace ConsoleApp4
{
    internal class Rectangle
    {
        public int a;
        public int b;

        public Rectangle() 
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        public Rectangle(int c)
        {
            a = b = c;
        }

        public int Square() 
        { 
            return a * b;
        }

    }
}
