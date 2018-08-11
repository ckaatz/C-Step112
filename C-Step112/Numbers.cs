using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Step112
{
    public class Numbers
    { 

        public void MathOperation(int userInput1, int userInput2)
        {
            
            Console.WriteLine("Pick a number:");
            userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number:");
            userInput2 = Convert.ToInt32(Console.ReadLine());
            int mathOperation = userInput1 + 5;
            Console.WriteLine(userInput2);
            return;
        }

        

    }
}
