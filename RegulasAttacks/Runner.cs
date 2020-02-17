using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RegulasAttacks
{
    public class Runner
    {
        static string data = "C:/cwscripts/C#/RegulasAttacks/RegulasAttacks/RegAttack.txt";
        static string[] content;
        static List<string> vs = new List<string>();

        public static void Run()
        {
            //StartScreen.TitleScreen();
            Start();
            End();
        }
        public static void Start()
        {

            content = File.ReadAllLines(data);
            foreach (string line in content)
            {
                if (line.StartsWith("1."))
                {
                    string newLine = line.Remove(0, 2);
                    Utils.Write(newLine);
                }
                else if (line.StartsWith("2."))
                {
                    string newLine = line.Remove(0, 2);
                    Utils.Write(newLine);
                }
                else if (line.StartsWith("3."))
                {
                    string newLine = line.Remove(0, 2);
                    Utils.Write(newLine);
                }
                else if (line.StartsWith("Choice:"))
                {
                    vs.Add(line);
                }
                else if (line.StartsWith("ChoiceRun:"))
                {

                }
            }
        }
        public static void End()
        {
            Utils.Input();
        }
    }
}
