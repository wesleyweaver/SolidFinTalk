 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close
{
    public enum ShapeType2 { circle, square };

    public abstract class Shape2
    {
        public ShapeType itsType;

        //abstract method Draw which must be overwritten by classes that inherit from Shape
        public abstract void Draw();
    };

    public class Circle2 : Shape2
    {
        public double itsRadius;
        public Point itsCenter;

        //Overwrite with a separate circle draw method
        public override void Draw()
        {
            Console.WriteLine("Circle radius: " + itsRadius);
        }
    };

    public class Square2 : Shape2
    {
        public double itsSide;
        public Point itsTopLeft;

        //Overwrite with a separate square draw method
        public override void Draw()
        {
            Console.WriteLine("Square side: " + itsSide);
        }
    };

    public class Good
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape2>();
            shapes.Add(new Square2()
            {
                itsSide = 1,
                itsTopLeft = new Point() { x = 1, y = 1 },
                itsType = ShapeType.square
            });
            shapes.Add(new Circle2()
            {
                itsRadius = 1,
                itsCenter = new Point() { x = 1, y = 1 },
                itsType = ShapeType.circle
            });

            DrawAllShapes(shapes);

            Console.Read();
        }

        static void DrawAllShapes(List<Shape2> list)
        {
            //No longer needs to be modified whenever you create a new shape
            //In general much simpler and more understandable code
            list.ForEach(s => s.Draw());
        }
    }
}
