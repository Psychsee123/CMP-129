using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers_1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 1;
            float even;
            float odd;
            




            while(num1 < 101)
            {
                
                if (num1 >= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (num1 >= 11)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (num1 >= 21)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                if (num1 >= 31)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (num1 >= 41)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (num1 >= 51)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                if (num1 >= 61)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (num1 >= 71)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                if (num1 >= 81)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (num1 >= 91)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }              
                Console.WriteLine(num1);
                num1++;
            } //end of while loop




            
            while (num2 <= 100)
            {
                
                Console.ForegroundColor = ConsoleColor.Blue;
                 if(isOdd(num2))
                {
                    Console.WriteLine(num2);
                }
                num2++;
                Console.ForegroundColor = ConsoleColor.Green;
                if (isEven(num2))
                {
                    Console.WriteLine(num2);
                }

                num2++;
                                                        
               
            }

        } //end of main class

            public static bool isOdd(int value) 
            {                            
                return value % 2 != 0;
            }
         

            public static bool isEven(int value)
            {
                return value % 2 == 0;
            }

    }
}
