using System;
using System.Threading;

namespace RegulasAttacks
{
    class Utils
    {
        static int sleepTime = 30;
        public static void Write(string message)
        {
            if (message.EndsWith(";One"))
            {
                string newMessage = message.Remove(message.Length - 4);
                foreach (var item in newMessage)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(item);
                    Console.ResetColor();
                    Thread.Sleep(sleepTime);
                }
                Console.WriteLine();
            }
            else if (message.EndsWith(";Two"))
            {
                string newMessage = message.Remove(message.Length - 4);
                foreach (var item in newMessage)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(item);
                    Console.ResetColor();
                    Thread.Sleep(sleepTime);
                }
                Console.WriteLine();
            }
            else
            {
                foreach (var item in message)
                {
                    Console.Write(item);
                    Thread.Sleep(sleepTime);
                }
                Console.WriteLine();
            }
        }
        public static void Write(int num)
        {
            string numString = num.ToString();
            foreach (var item in numString)
            {
                Console.Write(item);
                Thread.Sleep(sleepTime);
            }
            Console.WriteLine();
        }
        public static string Input()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static void Continue()
        {
            Console.ReadLine();
        }
    }
}
