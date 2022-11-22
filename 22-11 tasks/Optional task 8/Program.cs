using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers seperated by spaces: ");
            string inputs = Console.ReadLine();
            string[] numArray = inputs.Split(' ');
            double sum = 0;
            double entries = 0;
            //for (int i = 0; i < numArray.Length; i++)
            //{
            //    foreach (string o in numArray)
            //    {
            //        if (o == numArray[i]) // compares only for the element with that iteration's index 
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            sum += Convert.ToDouble(numArray[i]);
            //            entries++;
            //        }
            //    }

            //}
            //double avg = sum / entries;
            //Console.WriteLine($"The average is: {avg}");


            for (int i = 0; i < numArray.Length; i++)
            {
                
                        sum += Convert.ToDouble(numArray[i]);
                        entries++;
                    
                

            }
            double avg = sum / entries;
            Console.WriteLine($"The average is: {avg}");

        }
    }
}
