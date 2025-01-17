using OOP_Assigment04.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment04
{
    internal class Circle:ICircle
    {
        public double Radius { get;}

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area => Math.PI * Radius * Radius;
        
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radius {Radius} has an area of {Area}.");
        }

    }
}
