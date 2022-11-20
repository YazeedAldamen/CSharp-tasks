using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your firstname: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Input your lastname: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Input your year of birth: ");
            string birth = Console.ReadLine();
            Console.Write(fname +" "+ lname +" "+ birth+ " ");

        }
    }
}
