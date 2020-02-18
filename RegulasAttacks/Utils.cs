using System;
using System.Threading;

namespace RegulasAttacks
{
    class Utils
    {
        static int sleepTime = 30;
        public static void Write(string message)
        {
            if (message.Contains(";Fast"))
            {
                message = message.Replace(";Fast", "");
                sleepTime = 0;
            }
            if (message.Contains(";Slow"))
            {
                message = message.Replace(";Slow", "");
                sleepTime = 70;
            }
            if (message.Contains(";Red"))
            {
                message = message.Replace(";Red", "");
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (message.Contains(";Green"))
            {
                message = message.Replace(";Green", "");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            foreach (var item in message)
            {
                Console.Write(item);
                Thread.Sleep(sleepTime);
            }
            Console.WriteLine();
            Console.ResetColor();
            sleepTime = 30;
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
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
        public static void ThreeLines()
        {
            Console.WriteLine("\n\n\n");
        }
        public static void TabIn()
        {
            Console.Write("             ");
        }
    }
}
