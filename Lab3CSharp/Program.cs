using System;
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

            Console.WriteLine("Trapeze before changes");
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





            Console.WriteLine("         Task 2 ");
            List<Person> people = new List<Person>()
            {
                new Person("Petro", 45),
                new Employee("Ivan", 25,"aaa", 700),
                new Worker("Taras", 32,"aaa", 1700,"bbb"),
                new Engineer("Roma", 22,"aaa", 900,"bbb","ccc") 
            };


            Console.WriteLine("Before sorting by Age:");
            foreach (var person in people) 
            {
                person.Show();
                Console.WriteLine();
            }
            Console.WriteLine();

            List<Person> sortedPeople = people.OrderBy(p => p.Age).ToList();
            Console.WriteLine("\nAfter sorting by Age:");
            foreach (var person in sortedPeople)
            {
                person.Show();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
