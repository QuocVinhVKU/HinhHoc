using System;
using Models;

namespace DoiTuongHinhHoc
{
    class Program
    {
        public static void Main(string[] args)
        {
            Shape shape = new Shape();
            Console.WriteLine(shape);

            shape = new Shape("red", false);
            Console.WriteLine(shape);
            Console.WriteLine("hello world!");

            Console.ReadKey();
        }
    }
/*
    public class CircleTest
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine(circle);

            circle = new Circle(3.5);
            Console.WriteLine(circle);


            circle = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle);
            Console.ReadKey();
        }
    }


    public class RectangleTest
    {
        public static void Main(String[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.3, 5.8);
            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.5, 3.8, "orange", true);
            Console.WriteLine(rectangle);
            Console.ReadKey();
        }
    }

    public class SquareTest
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Console.WriteLine(square);

            square = new Square(2.3);
            Console.WriteLine(square);

            square = new Square(5.8, "yellow", true);
            Console.WriteLine(square);

            Console.ReadKey();
        }
    }*/
}