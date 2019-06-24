using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextBasedTitanQuest.Select
{
    class Menu
    {
        static int top = 5;
        static int left = Console.WindowWidth - 27;
       public static bool startGame = false;
        public static void GetInput()
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            Display.Draw.Player(left, top);

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && top > 5)
                {
                    top--;
                    Music.Play.Select();
                }
                else if (key.Key == ConsoleKey.DownArrow && top < 11)
                {
                    top++;
                    Music.Play.Select();
                }

                else if (key.Key == ConsoleKey.Enter)
                {
                    switch (top)
                    {
                        case 5:
                            startGame = true;
                            break;
                        case 11:
                           //end game
                            System.Environment.Exit(0);
                            break;
                        case 7:
                            HandleOptions();
                            break;
                    }
                    Music.Play.Select();
                }
            }
        public static void HandleOptions()
        {
            Display.Menu.inOption = true;
            Display.Draw.Player(left, top);

            ConsoleKeyInfo key = new ConsoleKeyInfo();

            key = Console.ReadKey();

            if (key.Key == ConsoleKey.UpArrow && top > 5)
            {
                top--;
                Music.Play.Select();
            }
            else if (key.Key == ConsoleKey.DownArrow && top < 6)
            {
                top++;
                Music.Play.Select();
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                switch (top)
                {
                    case 5:
                        if (Music.Play.isOn == true)
                        {
                            Music.Play.StopMusic();
                            Music.Play.isOn = false;
                            Music.Play.Select();
                        }
                        else if (Music.Play.isOn == false)
                        {
                            Music.Play.Intro();
                            Music.Play.isOn = true;
                            Music.Play.Select();
                        }
                        break;
                    case 6:
                        Display.Menu.Set();
                        Display.Menu.inOption = false;
                        break;
                }
            }
        }
    }
}
