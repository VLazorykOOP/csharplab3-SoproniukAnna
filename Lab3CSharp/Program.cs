using System.Diagnostics;

namespace Lab3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         Lab 3 ");
            Console.WriteLine("         Task 1 ");
            Trapeze[] trapezes = new Trapeze[]
                {
                    new Trapeze(3,3,3,0),
                    new Trapeze(5,7,2,1),
                    new Trapeze(8,2,6,2),
                    new Trapeze(7,9,2,3),
                    new Trapeze()
                };

            foreach(var trapez in trapezes) 
            {
                trapez.DisplayLengths();
                Console.WriteLine("Color: " + trapez.C);
                Console.WriteLine("Perimetr: " + trapez.CalculatePerimeter());
                Console.WriteLine("Area: " + trapez.CalculateArea());
                Console.WriteLine("Square: " + trapez.IsSquare());
                Console.WriteLine();
            }

            Console.WriteLine("Try get and set");

            Trapeze trapeze = new Trapeze(1, 1, 1, 1);

            Console.WriteLine("Trapeze to changes");
            trapeze.DisplayLengths();
            Console.WriteLine("Color: " + trapeze.C);
            Console.WriteLine();


            Console.Write("Input base a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            trapeze.A = a;

            Console.Write("Input base b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            trapeze.B = b;
            
            Console.Write("Input height h: ");
            int h = Convert.ToInt32(Console.ReadLine());
            trapeze.H = h;
            Console.WriteLine();

            Console.WriteLine("Trapeze after changes");
            trapeze.DisplayLengths();
            Console.WriteLine("Color: " + trapeze.C);
            Console.WriteLine("Perimetr: " + trapeze.CalculatePerimeter());
            Console.WriteLine("Area: " + trapeze.CalculateArea());
            Console.WriteLine("Square: " + trapeze.IsSquare());
            Console.WriteLine();
        }
    }
}
