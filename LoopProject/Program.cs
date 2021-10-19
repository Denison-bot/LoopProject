using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopProject
{
    class Program
    {
        static int playerPositionX;
        static int playerPositionY;

        //static void DrawScreen()
        //{
        //    Console.Clear();
        //    Console.SetCursorPosition(40, 40);
        //    Console.WriteLine("O");
        //}

        static void DrawScreen()
        {
            Console.Clear();
            Console.SetCursorPosition(20, 20);
            Console.WriteLine("O");
        }


        static void Main(string[] args)
        {

            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(80, 80);

            //Console.SetCursorPosition(20, 20);
            //Console.WriteLine("O");

            DrawScreen();





            Console.ReadKey(true);
        }
    }
}
