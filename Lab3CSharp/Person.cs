using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class Person
    {
        protected string Name { get; set; }
        public int Age { get; set; }

        public Person() 
        {
            this.Name = "Ivan";
            this.Age = 30;
        } 
        public Person(string name, int age)
        {
            this.Name = name; 
            this.Age = age;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {this.Name}, Age: {this.Age}");
        }
    }
}
