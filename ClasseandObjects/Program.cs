using ClasseandObjects;
using System;
using System.Runtime.InteropServices;

namespace Classes
{
    public class ClasseObjects
    {
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1)
            {
                length = 1;
                width = l;
            }

            public double Area()
            {
                return length * width;
            }
        }

        static void Main(string[] args) {
            // struct examples
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rec1 : {0}", rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("Rect2.length : {0}", rect2.length);

            // objects examples
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
             };

            Console.WriteLine("# of Animals {0}", Animal.GetNumAnimals());

            Console.WriteLine("Area of Rectangle : {0}",ShapeMath.GetArea("Rectangel", 5,6));

            // nullable types and check nulls
            int? randNum = null;
            
            if(randNum == null)
            {
                Console.WriteLine("randNum is null");
            }

            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }
        }
    }
    
}
