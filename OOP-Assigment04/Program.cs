using OOP_Assigment04.Interface;

namespace OOP_Assigment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part01
            #region Question1
            //1-b
            //2-a,b
            //3-c
            //4-b
            //5-non the of the above c# use : operator
            //6-a
            //7-b
            //8-b
            //9-d
            //10-c
            #endregion
            //Part02
            #region Question1
            ICircle circle = new Circle(5);
            circle.DisplayShapeInfo();
            IRectangle rectangle = new Rectangle(7, 9);
            rectangle.DisplayShapeInfo();
            #endregion
        }
    }
}
