using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class Engineer : Worker
    {
        protected string Specialization { get; set; }

        public Engineer()
        {
            this.Specialization = "aaa";
        }

        public Engineer(string name, int age, string position, int salary, string department, string specialization) : base(name, age, position, salary, department)
        {
            this.Name = name;
            this.Age = age;
            this.Position = position;
            this.Salary = salary;
            this.Department = department;
            this.Specialization = specialization;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Specialization: {this.Specialization}");
        }
    }
}
