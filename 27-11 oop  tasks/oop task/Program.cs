using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            info INFO = new info(24, "Male", "Yazeed", "yazeedaldamen98@gmail.com", 122376, "0778929863");
            INFO.getInfo();
        }

    }
    class info
    {
        private int age;
        private string gender;
        private string name;
        private string email;
        private int id;
        private string phone;

        public info(int age, string gender, string name, string email, int id, string phone)
        {
            if (age < 18 )
            {
                Console.WriteLine("You are under 18");
            }
            else if (age > 60)
            {
                Console.WriteLine("You are above 60");
            }
            else
            {
                this.age= age;
            }

            this.gender = gender;
            this.name = name;
            this.email = email;
            this.id = id;

            string validPhone = phone.Substring(0,3);
            if (validPhone == "078" || validPhone == "077" || validPhone == "079")
            {
                this.phone = phone;
            }
            else
            {
                Console.WriteLine("Enter a valid phone number");
            }


        }

        public void getInfo()
        {
            Console.Write("Age :\t\t\t\t");
            Console.WriteLine(age);
            Console.Write("Gender :\t\t\t");
            Console.WriteLine(gender);
            Console.Write("Name :\t\t\t\t");
            Console.WriteLine(name);
            Console.Write("Email :\t\t\t\t");
            Console.WriteLine(email);
            Console.Write("ID :\t\t\t\t");
            Console.WriteLine(id);
            Console.Write("Phone number :\t\t\t");
            Console.WriteLine(phone);
        }
    }
}
