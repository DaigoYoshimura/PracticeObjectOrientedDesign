using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    public interface IShape
    {
        double CalculateArea();
    }

    public interface ICircle
    {
        double Radius { get; set; }
    }

    public interface ISquare
    {
        double SideLength { get; set; }
    }
    class Circle : ICircle, IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Square : ISquare, IShape
    {
        public double SideLength { get; set; }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

}
