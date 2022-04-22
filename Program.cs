using System;

namespace ConsoleApp4
{
    public class Pen
    {
        public string color;
        public int cost;

        public Pen() 
        {
            color = "Black";
            cost = 100;
        }

        public Pen(string penColor, int pencost) 
        { 
            color=penColor;
            cost = pencost;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
