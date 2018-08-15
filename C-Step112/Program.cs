using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Step112
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pick a number:");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number:");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            Numbers number = new Numbers();
            number.MathOperation(userInput1,userInput2);

            Console.ReadLine();
        }
       
    }
}
