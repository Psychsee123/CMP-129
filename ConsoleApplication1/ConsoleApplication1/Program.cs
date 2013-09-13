using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Yoyo
{

    public class Yoyo
    {
        int x = 5;
        int y = 5;
        int numTimes = 10;
        int maxLength = 10;
        int currentLength = 0;
        bool isGoingDown = true;
        bool isGoingUp = true;

        public Yoyo(int xPos, int yPos, int numTimes)
        {
            x = xPos;
            y = yPos;
            this.numTimes = numTimes;

        }

        public void update()
        {
            if (isGoingDown)
            {
                currentLength++;
                if (currentLength == maxLength)
                {
                    isGoingDown = true;
                }
            }
            if (isGoingUp)
            {
                currentLength--;
                if (currentLength == maxLength)
                {
                    isGoingUp = true;
                }
            }


        }
        public void Draw()
        {

        
                for (int i = 0; i < maxLength; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write("|");
                    Console.SetCursorPosition(x, y + i + 1);
                    Console.Write("0");
                    Thread.Sleep(100);
                }

                for (int i = maxLength; i >= 0; i--)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write("|");
                    Console.SetCursorPosition(x, y + i + 1);
                    Console.Write("0");
                    Console.SetCursorPosition(x, y + i + 2);
                    Console.Write(" ");
                    Thread.Sleep(100);
                }
                Thread.Sleep(300);
            



        }

    }


    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}