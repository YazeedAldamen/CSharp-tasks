using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee("Ahmad", 1990, "122376");
            obj.age();
            Console.WriteLine("\n");
            Manager obj2 = new Manager("Yazeed", 1998, "55555");
            obj2.age();
        }
    }
    class Employee
    {

        public string name { get; set; }
        public int dateOfBirth { get; set; }

        public string ID { get; set; }

        public Employee(string name, int dateOfBirth, string ID)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.ID = ID;

            Console.WriteLine(name);
            Console.WriteLine(dateOfBirth);
            Console.WriteLine(ID);
        }




        protected int currentYear = 2022;
        public virtual void age()
        {

            int age =  currentYear - dateOfBirth ;
            Console.Write("Age is :");
            Console.WriteLine(age);

        }

    }
    class Manager : Employee
    {
        public Manager(string name, int dateOfBirth, string ID) : base(name, dateOfBirth, ID) { }

        public override void age()
        {

            int age = currentYear - dateOfBirth;
            Console.Write("Age is :");
            Console.WriteLine(age);

        }

    }
}
