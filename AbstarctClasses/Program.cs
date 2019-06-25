using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape c = new Circle();
            c.Draw();  
            Console.ReadKey();

         }
    }

    abstract class Shape
    {
        public abstract void Draw();

        //you cannot create objects with abstract methods 'cause abstract methods have no body(no implementation)
        //having an abstract method means also that the class cannot be instanciated so it must be abstract its self;
        //
        // Abstract classes:
        // - cannot be instantiated
        // - ac's may contain abstract methods and accessors
        // - Non Abstract classes derived from an abstract class must include actual implementations of all inherited
        //   abstract methods and accessors
        // - ofc abstract classes cannot be sealed :D
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Spatascia un circle sul àutput");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rect Draw");
        }
    }
}
