using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextBasedTitanQuest.Display
{
    static class Banner
    {
        static int left = Console.WindowWidth / 3;
        static int top = Console.WindowHeight / 3;
        public static void IntroScreen()
        {
            MainTitle();
            Thread.Sleep(3000);
        }
        private static void MainTitle()
        {
            Console.SetCursorPosition(left, top + 1);
            Console.WriteLine("T I T A N S    Q U E S T");
            Console.SetCursorPosition(left, top + 3);
            Console.WriteLine("     A T L A N T I C");
        }
    }
}
