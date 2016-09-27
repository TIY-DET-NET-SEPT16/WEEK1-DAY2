using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_DAY2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime today = DateTime.Now;
            //DateTime dueDate = DateTime.Now.AddDays(1).AddHours(1);
            //DateTime sooner = DateTime.Now.AddHours(1);

            //Console.WriteLine(today);
            //Console.WriteLine(dueDate);
            //Console.WriteLine(sooner);

            //int x = 5;
            //string y;

            //Console.WriteLine("Can you guess the number I'm thinking of?");

            //y = Console.ReadLine();
            //int newNum;

            //if (!Int32.TryParse(y, out newNum))
            //{
            //    Console.WriteLine("you didn't enter a number");
            //}
            //else if (x == newNum)
            //{
            //    Console.WriteLine("You guessed correctly!");
            //}
            //else if (x < newNum)
            //{
            //    Console.WriteLine("You were too low!");
            //}
            //else
            //{
            //    Console.WriteLine("You were too high!");
            //}

            int temp = new int();
            temp = 5;

            double[] myArray = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();
        }
    }
}
