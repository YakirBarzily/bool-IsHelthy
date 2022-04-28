using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bool_IsHelthy
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int cal;
            int fat;
            int count = 0;
            int maxCal = 0;
            string nameOfmax = "";
            Console.WriteLine("please enter the name of your product");
            name = Console.ReadLine();
            while (name != "Stop") 
            {
                Console.WriteLine("please enter calories");
                cal = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter fat");
                fat = int.Parse(Console.ReadLine());
                Box c = new Box(name, cal, fat);
                if (c.IsHelthy())
                      count++;
                if( c.GetCal () > maxCal)
                {
                    maxCal = c.GetCal();
                    nameOfmax = c.GetCal();
                }
                Console.WriteLine("please enter name of produck");
                name = Console.ReadLine();
            }
            Console.WriteLine("Number of produck that not bad for health " + count);
            Console.WriteLine(nameOfmax + " has maximum calories");

        }
    }
}
