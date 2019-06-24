using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedTitanQuest.Display
{
    class AskInput
    {
        //asks for the name of the character
        public static void Name()
        {
            int top = Console.WindowHeight;
            int left = Console.BufferWidth;
            Console.SetCursorPosition(left/3,top/2);
            Console.Write("Input name : ");
        }
    }
}
