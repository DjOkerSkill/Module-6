using System;

namespace ConsoleApp4
{
    class Triangle 
    {
        double side1;
        double side2;
        double side3;

        public Triangle(double _side1, double _side2, double _side3) 
        { 
            side1 = _side1;
            side2 = _side2;
            side3 = _side3;
        }
        
        public double GetSquareTriangle() 
        {  
            double p = (side1+ side2 + side3)/2 ;

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
