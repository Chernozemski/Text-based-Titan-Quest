using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedTitanQuest.OpenFile;
using TextBasedTitanQuest.Display;
using System.Threading;
using TextBasedTitanQuest.Music;

namespace TextBasedTitanQuest
{
    class Start
    {
        static void Main(string[] args)
        {
            Color.Set();
            Play.Intro();
            Banner.IntroScreen();
            Console.Clear();

            if (!Character.HasBeenCreated())
            {
                AskInput.Name();
                Character.Create(Console.ReadLine());
            }

            while (!Select.Menu.startGame)
            {
                Menu.Logo();
                Menu.Borders();
                Menu.Set();
                Select.Menu.GetInput();
                while (Display.Menu.inOption)
                {
                    Console.Clear();
                    Menu.Logo();
                    Menu.Borders();
                    Display.Menu.Options();
                    Select.Menu.HandleOptions();
                    Color.Set();
                }
                Console.Clear();
                Color.Set();
            }

            Character.LoadStats();

            while (true)
            {
                Menu.Logo();
                Game.Monster.Monster.Update();
                Game.Player.Player.Battle();
                Game.Player.Player.Recover();
                Character.Update();
                Console.Clear();
                Thread.Sleep(60);
                Color.Set();
            }
        }
    }
}
