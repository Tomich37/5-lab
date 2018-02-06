using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");
            //Создать объект Point с установкой каждого свойства вручную
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            //Создать объект Point с использованием специального конструктора
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            //Создать объект Point  с использьзованием синтаксиса инициализатора объекта.
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();
            Console.ReadLine();
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }
        public Point() { }
        public void DisplayStats()
        {
            Console.WriteLine("{0}, {1}", X, Y);
        }
    }

    class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();
        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }
        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}]", topLeft.X, topLeft.Y, topLeft.Color, bottomRight.X, bottomRight.Y, bottomRight.Color);
        }
    }
}
