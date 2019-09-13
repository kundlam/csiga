using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 13; j++)
            {
                for (int i = j; i < 80; i++)
                {
                    Console.SetCursorPosition(i-j, j);
                    Console.Write("#");
                    Thread.Sleep(5);
                }
                for (int i = 0; i < 25; i++)
                {
                    Console.SetCursorPosition(80-j, i);
                    Console.Write("#");
                    Thread.Sleep(5);
                }
                for (int i = 80; i >= 1 ; i--)
                {
                    Console.SetCursorPosition(i-1, 24-j);
                    Console.Write("#");
                    Thread.Sleep(5);
                }
                for (int i = 24; i >= 1; i--)
                {
                    Console.SetCursorPosition(0+j, i);
                    Console.Write("#");
                    Thread.Sleep(5);
                }
            }
            Console.ReadKey();
        }
    }
}
