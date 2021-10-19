using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopProject
{
    class Program
    {
        static int x = 20;
        static int y = 20;
        static bool gameOver;
        static char input;
        static void Main(string[] args)
        {
          
          Console.SetWindowSize(40, 40);
          Console.SetBufferSize(80, 80);                                 
            while (gameOver == false)
            {
                PlayerUpdate();
                PlayerDraw(x, y);
                BoundCheck();
                QuitCheck();
            }
            Console.ReadKey(true);
        }            

        static void PlayerDraw(int x, int y)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("O");
        }
        static void PlayerUpdate()
        {
            ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
            input = readKeyInput.KeyChar;

            if (input == 'w')
            {
                y--;
            }
            else if (input == 's')
            {
                y++;
            }
            else if (input == 'a')
            {
                x--;
            }
            else if (input == 'd')
            {
                x++;
            }
        }
        static void BoundCheck()
        {
            if (x > 40)
            {
                x = 40;
            }
            if (y > 40)
            {
                y = 40;
            }
            if (x < 1)
            {
                x = 1;
            }
            if (y < 1)
            {
                y = 1;
            }
        }
        static void QuitCheck()
        {
            ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
            input = readKeyInput.KeyChar;
            if (input == 'q')
            {
                gameOver = true;
            }
        }
    }
}
