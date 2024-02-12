using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class Employee: Person
    {
        protected string Position { get; set; }
        protected int Salary { get; set; }
        public Employee() 
        {
            this.Position = "Programmer";
            this.Salary = 1000;
        }

        public Employee(string name, int age, string position, int salary):base(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Position = position;
            this.Salary = salary;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {this.Position}, Salary: {this.Salary}");
        }
    }
}
