using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End.Models
{
    public static class Statics
    {

        // a static method
        public static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }


        #region overload
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static void Divide()
        {
            Console.WriteLine("Enter a number from one to ten");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number from one to ten");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
        #endregion

        #region statics assignment
        //write a static method that lets a user input a string and choose how they would like to trim it
        //Check that their ending number is not longer than the string they input 

        public static void StringTrimmer()
        {
            int start = 0;
            int end = 0;

            Console.WriteLine("Input a string you would like trimmed");
            string userString = Console.ReadLine();

            Console.WriteLine($"Enter a starting point between 0 and {userString.Length}");
            start = Convert.ToInt32(Console.ReadLine());

            if (start > userString.Length)
            {
                do
                {
                    Console.WriteLine($"Start point was too large. Start point must be less than {userString.Length}\n Enter a new Start Point between 0 and {userString.Length}: ");
                    start = Convert.ToInt32(Console.ReadLine());

                } while (start > userString.Length);
            }

            Console.WriteLine($"Enter an ending point between {start} and {userString.Length}");

            end = Convert.ToInt32(Console.ReadLine());

            if (end > userString.Length || end < start)
            {
                do
                {
                    if (end > userString.Length)
                    {
                        Console.WriteLine($"Your end point was too large. End Point must be between 0 and {userString.Length}\n Enter a new endpoint: ");
                    }
                   else if (end < start)
                    {
                        Console.WriteLine($"Your end point was too Small. End Point must be greater than {end}\n Enter a new endpoint: ");
                    }

                    end = Convert.ToInt32(Console.ReadLine());

                } while (end > userString.Length || end < start);
            }

            Console.WriteLine($"Your new string is: {userString.Remove(start, end)}");
        }
        #endregion
    }
}
