using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Rectangle
    {
        private Point topLeft;
        private double width;
        private double height;

        public virtual double Width
        {
            get { return width; }
            set { width = value; }
        }

        public virtual double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Area()
        {
            return width * height;
        }
    }

    public class Square : Rectangle
    {
        public override double Width
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
        public override double Height
        {
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }

    public class Square_Rectangle
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 4;

            Console.WriteLine("Rectangle Area: " + rect.Area().ToString());

            var sq = new Square();
            sq.Width = 5;
            sq.Height = 4;

            Console.WriteLine("Square Area: " + sq.Area().ToString());

            Console.Read();
        }
    }

    public class Point
    {
        public int x;

        public int y;
    };

}
