using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedTitanQuest.Display
{
    class Draw
    {
        public static void Player(int left , int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(">");
        } 
    }
}
