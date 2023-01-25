using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCalculator
{
    class ProductCalculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the fourth number:");
            int num4 = Convert.ToInt32(Console.ReadLine());

            int product = num1 * num2 * num3 * num4;

            Console.WriteLine("The product of the four numbers is: " + product);

            Console.ReadKey();
        }
    }
}

/*
Author: Yanzhi Wang 
Purpose: This class will take four integer inputs from the user and display the product of those numbers
Restrictions: None
*/

/*
Purpose: The Main method obtains four int values from the user and displays the product
Restrictions: None
*/

