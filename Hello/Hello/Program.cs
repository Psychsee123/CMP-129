using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello world from String";
            char myChar = 'a';
            int myInt = 5;
            float myFloat = 5f;
            double myDbl = 5;
            bool myBool = false;
            int mynewInt = 0;                     
            
            Console.WriteLine(MyFunc(5, 3.1));
        }

        public static float MyFunc(float a; float b;)
        {
            return a + b;
        }

    }
}
