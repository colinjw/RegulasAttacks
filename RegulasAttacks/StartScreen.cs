using System;
using System.Collections.Generic;
using System.Text;

namespace RegulasAttacks
{
    public class StartScreen
    {
        public static void TitleScreen()
        {
            string title = @" 
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


            Console.WriteLine(title);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to start the game");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
