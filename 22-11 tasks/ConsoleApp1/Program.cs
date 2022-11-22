using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            ///////////////////////
            //////////////////////
            Console.WriteLine(" ");
            Console.WriteLine("Task2");
            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.Write("Index of Banana: ");
            Console.WriteLine(Array.IndexOf(fruits, "Banana"));
            Console.Write("Index of Tomato: ");
            Console.WriteLine(Array.IndexOf(fruits, "Tomato"));

            ///////////////////////
            //////////////////////
            Console.WriteLine(" ");
            Console.WriteLine("Task3");
            string[] movies = new string[] { "Forest Gump", "Interstellar", "Shawshank Redemption", "The Good Fellas" };
            string[] food = new string[] { "Mansaf", "Shwarma", "Kabseh" };
            string[] sport = new string[] { "Basketball", "Chess", "Football" };
            foreach (string s in movies)
            {
                Console.WriteLine(s); Console.WriteLine(" ");
            }
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
                Console.WriteLine(" ");

            }
            foreach (string tt in sport)
            {
                Console.WriteLine(tt);
                Console.WriteLine(" ");

            }
            ///////////////////////
            //////////////////////
            Console.WriteLine(" ");
            Console.WriteLine("Task4");
            Console.WriteLine("Input three numbers separated by comma: ");
            string num = Console.ReadLine();
            string[] numint = num.Split(',');
            int sum = 0;
            for (int i = 0; i < numint.Length; i++)
            {
                Convert.ToInt32(numint[i]);
                sum += Convert.ToInt32(numint[i]);
            }
            Console.WriteLine(sum);

            ///////////////////////
            //////////////////////
            Console.WriteLine(" ");
            Console.WriteLine("Task5");
            int sum2 = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    sum2 += sum;
                }
            }
            Console.WriteLine(sum2);


            ///////////////////////
            //////////////////////
            Console.WriteLine(" ");
            Console.WriteLine("Task6");


            string c = "*";

            for (int i = 0; i < 4; i++)
            {
                for (int k = 4 - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(c + " ");

                }
                Console.Write("\n");
            }





            ///////////////////////
            //////////////////////
            Console.WriteLine(" ");
            Console.WriteLine("Task7");
            int sum3 = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 4 - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(sum3 + " ");
                    sum3++;
                }
                Console.Write("\n");
            }


            ///////////////////////
            //////////////////////
            






        }
    }
}
