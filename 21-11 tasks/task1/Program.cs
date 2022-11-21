using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            Console.Write("Enter first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine($"{second} is smaller");
            }
            else if (second > first)
            {
                Console.WriteLine($"{first} is smaller");
            }
            else
            {
                Console.WriteLine("They are equal");

            }

            ////////////////////////

            Console.WriteLine("Task2");
            Console.Write("Enter a number: ");
            int sign = Convert.ToInt32(Console.ReadLine());
            if (sign < 0)
            {
                Console.WriteLine("The sign is -");
            }
            else if (sign > 0)
            {
                Console.WriteLine("The sign is +");
            }
            else
            {
                Console.WriteLine("You entered 0");
            }

            ///////////////////


            Console.WriteLine("Task3");
            int a = 5;
            int b = 10;
            int c = 20;
            if (a > b && b > c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            else if (b > a && a > c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else if (c > b && b > a)
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
            else if (b > c && c > a)
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
            else if (a > c && c > b)
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
            else
            {
                Console.WriteLine(c + " " + a + " " + b);
            }

            ////////////////////////

            Console.WriteLine("Task4");
            int z = 500;
            int x = 320;
            int y = 200;
            int w = 100;
            int q = 5;
            if (z > x && z > y && z > w && z > q)
            {
                Console.WriteLine(z);
            }
            else if (y > x && y > z && y > w && y > q)
            {
                Console.WriteLine(y);
            }
            else if (x > y && x > z && x > w && x > q)
            {
                Console.WriteLine(x);
            }
            else if (w > y && w > z && w > x && w > q)
            {
                Console.WriteLine(w);
            }
            else
            {
                Console.WriteLine(q);

            }

            ////////////////////////

            Console.WriteLine("Task5");
            Console.Write("Enter speed in km/h: ");
            int km = Convert.ToInt32(Console.ReadLine());
            double mile = km / 1.6;
            Console.WriteLine($"{mile} mph");


            ////////////////////////

            Console.WriteLine("Task6");
            Console.Write("Enter hours:  ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minutes:  ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hours * 60 + minutes);

            ////////////////////////

            Console.WriteLine("Task7");
            Console.Write("Enter minutes:  ");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(minute / 60 + " " + "Hours" + " " + minute % 60 + " " + "minutes");

            ////////////////////////

            Console.WriteLine("Task8");

            string[] arrayting = { "school", "watashiwa", "sodata", "sogooy", "awesome", "sthelse" };
            Console.WriteLine(arrayting[0].Substring(2, 4));
            Console.WriteLine(arrayting[1].Substring(2, 4));
            Console.WriteLine(arrayting[2].Substring(2, 4));
            Console.WriteLine(arrayting[3].Substring(2, 4));
            Console.WriteLine(arrayting[4].Substring(2, 4));
            Console.WriteLine(arrayting[5].Substring(2, 4));

        }
    }
}
