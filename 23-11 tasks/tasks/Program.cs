using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
                    
        static void Main()
        {

            //Task1();

            //Task2();

            //////Task3
            //int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            //Task3(years);

            //////Task4
            //Console.WriteLine("Enter age in years: ");
            //int days = Task4(Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine(days);

            //////Task5
            //int legs = Task5();
            //Console.WriteLine(legs + " legs");

            ////Task6
            //string[] users = { "yazeed", "mohammad", "ahmad" };
            //string[] password = { "123", "456", "789" };
            //Task6(users, password);

            ////Task7
            //Console.WriteLine("Enter a number: ");
            //int num7 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the power: ");
            //int num8 = Convert.ToInt32(Console.ReadLine());
            //Task7(num7, num8);

            //Task8();


            Task9();

            //int num10 = Task10();
            //Console.WriteLine(num10);

        }
        static void Task1()
        {
            int sum = 0;
            int entries = 0;
            Console.WriteLine("Enter 10 numbers each on a line:");
            for (int i = 0; i < 10; i++)
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                sum += num1;
                entries++;
            }
            Console.WriteLine($"The summation is : {sum}");
            Console.WriteLine($"The average is : {sum / entries}");
        }
        static void Task2()
        {
            Console.WriteLine("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num2; i++)
            {
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{i*i*i}"); //{Math.Pow(i,3)}
            }

        }

        static void Task3(int[] years)
        {
            int[] arr = { };
            for (int i = 0; i < years.Length; i++)
            {

                if (years[i] > 1950)
                {
                    Console.WriteLine(years[i]);
                }
                else
                {
                    continue;
                }
            }
        }

        static int Task4(int x)
        {
            int y = x * 365;
            return y;
        }

        static int Task5()
        {
            Console.WriteLine("Chicken: ");
            int chicken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cows: ");
            int cows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pigs: ");
            int pigs = Convert.ToInt32(Console.ReadLine());

            return chicken * 2 + cows * 4 + pigs * 4;

        }


        static void Task6(string[] user, string[] pass)
        {
            Console.WriteLine("User: ");
            string use = Console.ReadLine().ToLower();
            Console.WriteLine("Password: ");
            string pas = Console.ReadLine();
            bool ting = false;
            for (int i = 0; i < user.Length; i++)
            {
                
                if (use == user[i] && pas == pass[i])
                {
                    ting = true;
                    break;
                }

            }
            if (ting == true)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }

        }


        static void Task7(int num7, int num8)
        {
            int ting = 1;
            for (int i = 1; i <= num8; i++)
            {
                ting *= num7;
            }
            Console.WriteLine(ting);
        }

        static void Task8()
        {   
            Console.WriteLine("Enter a year from 1900 to 2024: ");
            int leap = Convert.ToInt32(Console.ReadLine());
            if (leap >= 1900 && leap <= 2024)
            {
                if (leap == 1900)
                {
                    Console.WriteLine($"{leap} is not a leap year");
                }
                else if (leap % 4 == 0)
                {
                    Console.WriteLine($"{leap} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{leap} is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("The year you entered is out of range!");
            }
        }

        static void Task9()
        {
            Console.WriteLine("Enter a number: ");
            int num9 = Convert.ToInt32(Console.ReadLine());
            if (num9 == 2 || num9 == 3 || num9 == 5 || num9 == 7)
            {
                Console.WriteLine($"{num9} is a prime number");
            }
            else if (num9 % 2 == 0)
            {
                Console.WriteLine($"{num9} is not a prime number");
            }
            else
            {
                for (int i = 3; i < 10; i++)
                {
                    if (num9 % i == 0 || num9 % 5 == 0 || num9 % 7 == 0)
                    {
                        Console.WriteLine($"{num9} is not a prime number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{num9} is a prime number");
                        break;
                    }

                }
            }
        }

        static int Task10()
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] sentArr = sentence.Split(' ');

            return sentArr.Length;
        }
    }
}


