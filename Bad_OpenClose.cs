using System;
using System.Collections.Generic;

namespace Open_Close
{
    public enum ShapeType { circle, square };

    //Base Class Shape
    public class Shape
    {
        public ShapeType itsType;
    };

    //Circle inherits from Shape
    public class Circle : Shape
    {
        //itsType inherited from Shape
        public double itsRadius;
        public Point itsCenter;
    };

    //Square inherits from Shape
    public class Square : Shape
    {
        //itsType inherited from Shape
        public double itsSide;
        public Point itsTopLeft;
    };

    public class Bad
    {
        //static void Main(string[] args)
        //{
        //    //Create your list of shapes
        //    var shapes = new List<Shape>();
        //    shapes.Add(new Square()
        //    {
        //        itsSide = 1,
        //        itsTopLeft = new Point() { x = 1, y = 1 },
        //        itsType = ShapeType.square
        //    });
        //    shapes.Add(new Circle()
        //    {
        //        itsRadius = 1,
        //        itsCenter = new Point() { x = 1, y = 1 },
        //        itsType = ShapeType.circle
        //    });

        //    //Draw all the shapes in your list
        //    DrawAllShapes(shapes);

        //    Console.Read();
        //}

        static void DrawSquare(Square sqaure)
        {
            //Contains logic to draw a square on the screen
            Console.WriteLine("Square side: " + sqaure.itsSide);
        }

        static void DrawCircle(Circle circle)
        {
            //Contains logic to draw a circle on the screen
            Console.WriteLine("Circle radius: " + circle.itsRadius);
        }

        static void DrawAllShapes(List<Shape> list)
        {
            foreach (var shape in list)
            {
                //We need to determine what type of shape it is before we can draw it
                //With every new shape added we have to change this method
                switch (shape.itsType)
                {
                    case ShapeType.circle:
                        DrawCircle((Circle)shape);
                        break;
                    case ShapeType.square:
                        DrawSquare((Square)shape);
                        break;
                }
            }
        }
    }

    public class Point
    {
        public int x;

        public int y;
    };
}
