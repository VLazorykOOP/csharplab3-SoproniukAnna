using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class Worker:Employee
    {
        protected string Department { get; set; }

        public Worker()
        {
            this.Department = "ggg";
        }

        public Worker(string name, int age, string position, int salary, string department): base(name, age, position, salary)
        {
            this.Name = name;
            this.Age = age;
            this.Position= position;
            this.Salary = salary;
            this.Department = department;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Department: {this.Department}");
        }
    }
}
