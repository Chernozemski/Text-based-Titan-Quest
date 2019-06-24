using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedTitanQuest.Display
{
    class Menu
    {
        public static bool inOption = false;
        public static void Set()
        {
            int top = 5;
            int left = Console.WindowWidth - 25;

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(left, top++);
            Console.WriteLine("Play Titan Quest");
            Console.SetCursorPosition(left, top++);
            Console.WriteLine("");
            Console.SetCursorPosition(left, top++);
            Console.WriteLine("Options");
            Console.SetCursorPosition(left, top++);
            Console.WriteLine("");
            Console.SetCursorPosition(left, top++); 
            Console.WriteLine("");
            Console.SetCursorPosition(left, top++); 
            Console.WriteLine("");
            Console.SetCursorPosition(left, top++); 
            Console.WriteLine("Exit");
        }
        public static void Logo()
        {
            int top = 1;
            int left = Console.WindowWidth / 3;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(left, top);
            Console.WriteLine("T I T A N S\tQ U E S T");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Borders()
        {
            for (int left = 0; left < Console.WindowWidth; left++)
            {
                Console.SetCursorPosition(left, 3);
                Console.Write("-");

                Console.SetCursorPosition(left, Console.WindowHeight - 3);
                Console.Write("-");
            }
        }
        public static void Options()
        {
            int top = 5;
            int left = Console.WindowWidth - 25;

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(left, top++);
            Console.WriteLine("Music");
            Console.SetCursorPosition(left, top++);
            Console.WriteLine("Main Menu");
            
        }
    }
}
