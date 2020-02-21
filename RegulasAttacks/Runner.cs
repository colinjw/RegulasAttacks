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
        static List<string> titleScreen = new List<string>();
        static List<string> introList = new List<string>();
        static List<string> senarioList = new List<string>();
        static List<string> outList = new List<string>();
        static List<string> endList = new List<string>();
        static string auth;
        static string choice;
        static bool MakingChoice = false;
        static bool getPlayerName = false;
        public static void Run()
        {
            Load();
            StartScreen();
            Intro();
            End();
        }
        private static void Load()
        {
            content = File.ReadAllLines(data);
            foreach (string item in content)
            {
                if (item.Contains("Author:"))
                {
                    auth = item.Replace("Author:", "");
                }
                if (item.Contains("GameTitle:"))
                {
                    Console.Title = item.Replace("GameTitle:", "");
                }
                if (item.Contains("ts:"))
                {
                    titleScreen.Add(item.Replace("ts:", ""));
                }
                if (item.Contains("in:"))
                {
                    introList.Add(item.Replace("in:", ""));
                }
                if (item.Contains("s*:"))
                {
                    senarioList.Add(item);
                }
                if (item.Contains("out*:"))
                {
                    outList.Add(item);
                }
                if (item.Contains("End*:"))
                {
                    endList.Add(item);
                }
            }
        }
        static void StartScreen()
        {
            foreach (string item in titleScreen)
            {
                Utils.Write(item);
            }
            Utils.ThreeLines();
            Utils.Write($"Created by {auth}");
            Utils.ThreeLines();
            Utils.Continue();
            Utils.Clear();
        }
        static void Intro()
        {
            foreach (string item in introList)
            {
                string newLine = item;
                if (item.Contains("{get: PlayerName}"))
                {
                    newLine = item.Replace("{get: PlayerName}", "");
                    getPlayerName = true;
                    
                }
                if (item.Contains("{PlayerName}"))
                {
                    newLine = item.Replace("{PlayerName}", auth);
                }
                if (item.Contains("{Choice:"))
                {
                    //in:Ask player A (coin), B (Sword), or C (luck)? {Choice: A:out1(getItem: Coin), B:out2(getItem: Sword), C:out3(getStat: luck + 10)}
                    MakingChoice = true;
                    int startIndex = item.IndexOf('{');
                    int endIndex = item.IndexOf('}');
                    choice = item.Remove(0, startIndex);
                    newLine = item.Remove(startIndex, (endIndex - startIndex + 1));
                }
                Utils.Write(newLine);
                if (MakingChoice)
                {
                    Utils.Write(MakeChoice(choice));
                    MakingChoice = false;

                }
                if (getPlayerName)
                {
                    GetPlayerName();
                    getPlayerName = false;
                }
            }
        }
        static void GetPlayerName()
        {
            auth = Utils.Input();
        }
        static string MakeChoice(string choice)
        {
            string choiceMade = choice;
            /*string userPicked = Utils.Input();
            switch (userPicked)
            {
                case "A":
                    choiceMade = choice.
                default:
                    break;
            }
            */
            return choiceMade;
        }
        static void End()
        {
            Utils.Continue();
        }
    }
}
