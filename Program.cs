using System;

namespace ConsoleApp4
{
    class Triangle 
    {
        int side1;
        int side2;
        int side3;

        public int Side1 
        { 
            get { return side1; }
            set { if(value>0 && side2+side3<value) side1 = value; }
        }

        public int Side2
        {
            get { return side2; }
            set { if (value > 0 && side1 + side3 < value) side2 = value; }
        }

        public int Side3
        {
            get { return side3; }
            set { if (value > 0 && side1 + side2 < value) side3 = value; }
        }

        public Triangle(int _side1, int _side2, int _side3) 
        { 
            side1 = _side1;
            side2 = _side2;
            side3 = _side3;
        }
        
        public double GetSquareTriangle() 
        {  
            double p = (double)(side1 + side2 + side3)/2 ;

            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public double GetPerimetreTriangle()
        {
            return (side1 + side2 + side3);
        }
    }

    class Circle 
    {
        const double PI = 3.14;
        int radius;

        public Circle(int _radius) 
        { 
            radius = _radius;
        }

        public double GetSquareCircle() 
        {
            return (PI * radius * radius) / 2;
        }

        public double GetPerimetreCircle()
        {
            return 2 * PI * radius;
        }

    }

    class Square 
    {
        int side;

        public Square(int _side) 
        { 
            side= _side;
        }

        public int GetSquaresquare() 
        {
            return side * side;
        }

        public double GetPerimetresquare()
        {
            return 4 * side;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Вычисление площади и периметра треугольника
            {
                Triangle triangle = new Triangle(5, 7, 10);

                double squareTriangle = triangle.GetSquareTriangle();
                Console.WriteLine(squareTriangle);

                squareTriangle = triangle.GetPerimetreTriangle();
                Console.WriteLine(squareTriangle);
            }

             // Вычисление площади и периметра круга
            {
                Circle circle = new Circle(5);
                double squareCircle = circle.GetSquareCircle();
                Console.WriteLine(squareCircle);

                squareCircle = circle.GetPerimetreCircle();
                Console.WriteLine(squareCircle);
            }

            // Вычисление площади и периметра квадрата
            { 
                Square squre = new Square(5);

                double squareCircle = squre.GetSquaresquare();
                Console.WriteLine(squareCircle);

                squareCircle = squre.GetPerimetresquare();
                Console.WriteLine(squareCircle);
            }
        }

    }
}
