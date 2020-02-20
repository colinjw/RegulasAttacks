using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RegulasAttacks
{
    public class Runner
    {
        static string startScreen = @"
.______       _______   _______  __    __   __          ___           _______.
|   _  \     |   ____| /  _____||  |  |  | |  |        /   \         /       |
|  |_)  |    |  |__   |  |  __  |  |  |  | |  |       /  ^  \       |   (----`
|      /     |   __|  |  | |_ | |  |  |  | |  |      /  /_\  \       \   \    
|  |\  \----.|  |____ |  |__| | |  `--'  | |  `----./  _____  \  .----)   |   
| _| `._____||_______| \______|  \______/  |_______/__/     \__\ |_______/    
                                                                      
     ___   .___________.___________.    ___       ______  __  ___  __   __  
    /   \  |           |           |   /   \     /      ||  |/  / |  | |  | 
   /  ^  \ `---|  |----`---|  |----`  /  ^  \   |  ,----'|  '  /  |  | |  | 
  /  /_\  \    |  |        |  |      /  /_\  \  |  |     |    <   |  | |  | 
 /  _____  \   |  |        |  |     /  _____  \ |  `----.|  .  \  |__| |__| 
/__/     \__\  |__|        |__|    /__/     \__\ \______||__|\__\ (__) (__)";
        static string authName = "Colin Wyllie";
        static string playerName;
        static string[] choice1 = { "You must make a choice of A, B, or C", "You picked A", "You picked B", "You picked C"};
        static string[] intro = {"Intro Line One.","Intro Line Two.","Intro Line Three last line of the intro."};
        static bool s1 = false;
        static string[] senario1 = {"Senario One line one.", "Senario One line two", "Senario One line three"};
        static bool s2 = false;
        static string[] senario2 = {"Senario Two line one.", "Senario Two line two.", "Senario Two line three"};
        static bool s3 = false;
        static string[] senario3 = {"Senario Three line one", "Senario Three line two", "Senario Three line three"};
        public static void Run()
        {
            StartScreen();
            Intro();
           // ChoiceOne();
            OutOne();
            End();
        }
        static void StartScreen()
        {
            Console.WriteLine(startScreen);
            Utils.ThreeLines();
            Utils.Write($"Written By {authName}.;Fast");
            Utils.ThreeLines();
            Utils.Continue();
            Utils.Clear();
        }
        static void Intro()
        {
            foreach (var item in intro)
            {
                for (int i = 0; i < intro.Length; i++)
                {
                    Utils.Write(intro[i]);
                }
            }
        }
        static void OutOne()
        {

            if (s1 == true)
            {
                for (int i = 0; i <senario1.Length ; i++)
                {
                    Utils.Write(senario1[i]);
                }
            }
            if (s2 == true)
            {
                for (int i = 0; i < senario2.Length; i++)
                {
                    Utils.Write(senario2[i]);
                }
            }
            if (s3 == true)
            {
                for (int i = 0; i < senario3.Length; i++)
                {
                    Utils.Write(senario3[i]);
                }
            }
        }
        static void Choice(string String)
        {
            Utils.Write(String[0]);
            string theChoice = Utils.Input();
            switch (theChoice)
            {
                case "A":
                    Utils.Write(String[1]);
                    break;
                case "B":
                    Utils.Write(String[2]);
                    break;
                case "C":
                    Utils.Write(String[3]);
                    break;
                default:
                    break;
            }
        }
        static void End()
        {
            Utils.Input();
        }
    }
}
