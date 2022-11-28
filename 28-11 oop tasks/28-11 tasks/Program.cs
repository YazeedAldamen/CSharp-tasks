using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car("VM", 2016, "Sedan", 20000, "ID.6", 26262, "Red");
            obj.engine();
            Test obj2 = new Test("BMW", 2014, "Hatchbakc", 25000, "M6", 657849, "Black");
            obj2.test();
        }
    }
    class Car
    {
        protected string maker;
        protected int year;
        protected string type;
        protected int price;
        protected string model;
        protected int plateNo;
        protected string color;

        public Car()
        {

        }
        public Car(string maker, int year, string type, int price, string model, int plateNo, string color)
        {
            this.maker = maker;
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.plateNo = plateNo;
            this.color = color;
        }

        public void engine()
        {
            Console.WriteLine("Do you want to start the car? yes/no");



            string start = Console.ReadLine().ToLower();
            if (start == "yes")
            {

                Console.WriteLine("Engine is ON Vroom Vroom");
                test();
            }
            else if (start == "no")
            {
                Console.WriteLine("Engine is OFF");
            }

        }
        public void test()
        {
            Console.WriteLine(maker);
            Console.WriteLine(year);
            Console.WriteLine(type);
            Console.WriteLine(price);
            Console.WriteLine(model);
            Console.WriteLine(plateNo);
            Console.WriteLine(color);
        }
    }
    class Test : Car
    {
        public Test(string maker, int year, string type, int price, string model, int plateNo, string color) : base(maker, year, type, price, model, plateNo, color) { }

        public new void  test()
        {
            Console.WriteLine("\n");
            Console.WriteLine(maker);
            Console.WriteLine(year);
            Console.WriteLine(type);
            Console.WriteLine(price);
            Console.WriteLine(model);
            Console.WriteLine(plateNo);
            Console.WriteLine(color);
        }

    }
}
