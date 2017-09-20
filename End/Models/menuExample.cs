using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End.Models
{
    class menuExample
    {
        static void startProgram()
        {
            int userAction = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Buy Airplane");
                Console.WriteLine("2. Sell Airplane");
                Console.WriteLine("3. Buy Helicoptor");
                Console.WriteLine("4. Sell Helicoptor");
                Console.WriteLine("5. Show Aircrafts");
                Console.WriteLine("6. Quit");
                userAction = int.Parse(Console.ReadLine());

                switch (userAction)
                {
                    case 1: //Logic for case 1 
                        break;
                    case 2: //Logice for case 2 
                        break;
                    case 3: //Logic for case 3 

                    //Etc...... 
                    default:
                        break;
                }

            } while (userAction != 6);
        }
    }
}
