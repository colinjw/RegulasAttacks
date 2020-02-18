using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RegulasAttacks
{
    public class Runner
    {
        static string data = "D:/Create with Code/RegulasAttack/RegulasAttacks/RegulasAttacks/RegAttack.txt";
        static string[] content;
        static string authName = "";
        //static string playerName = "";
        static List<string> startList = new List<string>();
        static List<string> loaderList = new List<string>();

        public static void Run()
        {
            Load();
            StartScreen();
            Running();

            End();
        }
        static void Load()
        {
            content = File.ReadAllLines(data);

            foreach (string line in content)
            {
                if (line.StartsWith("Author:"))
                {
                    string nline = line.Replace("Author:", "");
                    authName = nline;
                }
                else if (line.StartsWith("ts:"))
                {
                    string nline = line.Replace("ts:", "");
                    startList.Add(nline);
                }
                else if (line.StartsWith("GameTitle:"))
                {
                    string nline = line.Replace("GameTitle:", "");
                    Console.Title = nline;
                }
                {
                    loaderList.Add(line);
                }
            }
        }
        static void StartScreen()
        {
            foreach (var item in startList)
            {
                Console.WriteLine(item);
            }
            Utils.ThreeLines();
            Utils.TabIn();
            Utils.Write($"Writen By {authName}.;Fast");
            Utils.ThreeLines();
            Utils.TabIn();
            Utils.Continue();
            Utils.Clear();
        }
        static void Running()
        {
            
            foreach (var item in loaderList)
            {
                Utils.Write(item);
            }
        }
        static void End()
        {
            Utils.Input();
        }
    }
}
