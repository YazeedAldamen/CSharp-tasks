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
            Car obj = new Car("VM", 2016, "Sedan", 20000, "ID.6", 26262, "Red");
            obj.engine();
            obj.distance(18);
            BMW obj2 = new BMW("BMW", 2014, "Hatchbakc", 25000, "M6", 657849, "Black");
            obj2.test2();
        }
    }
    class Car
    {
        
        public string maker { get; set; }
        public int year { get; set; }

        public string type { get; set; }
        public int price { get; set; }
        public string model { get; set; }
        public int plateNo { get; set; }
        public string color { get; set; }


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

        protected int dist = 18;
        public void distance(int liter)
        {

            int dista = liter * dist;
            Console.Write("km/liter :");
            Console.WriteLine(dista);

        }

    }
    class BMW : Car
    {
        public BMW(string maker, int year, string type, int price, string model, int plateNo, string color) : base(maker, year, type, price, model, plateNo, color) { }

        public  void  test2()
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
