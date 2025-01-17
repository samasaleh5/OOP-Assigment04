using OOP_Assigment04.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment04
{
    internal class Rectangle:IRectangle
    {
        public double Width {  get; }
        public double Height { get; }

        public Rectangle(double height,double width)
        {
            Height = height;
            Width = width;
        }

        public double Area => Width * Height;
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with width {Width} and height {Height} has an area of {Area}.");
        }
    }
}
