using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    enum ShapeType
    {
        Circle,
        Square
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            circle.Radius = 5;
            double circleArea = circle.CalculateArea();

            IShape square = new Square();
            square.SideLength = 10;
            double squareArea = square.CalculateArea();

        }
    }
}
