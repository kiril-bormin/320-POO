using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            while (true)
            {
                Console.CursorVisible = false;
                // Modifier le modèle (ce qui *est*)
                plane.update();

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();

                // Temporiser
                Thread.Sleep(100);
            }
        }
    }
    static class Config
    {
        public const int SCREEN_HEIGHT = 40;
        public const int SCREEN_WIDTH = 150;
    }
    class Plane
    {
        private string[] view =
        {
       @" _                         ",
       @"| \                        ",
       @"|  \       ______          ",
       @"--- \_____/  |_|_\____  |  ",
       @"  \_______ --------- __>-} ",
       @"        \_____|_____/   |  "
   };
        private int x = 0;
        private int y = 5;

        public void update()
        {
            x++;
        }
        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(view[i]);
            }
        }
    }
    class Para
    {
        //Attributs
        private const int PARA_HEIGHT = 6;

        private string[] viewNoParachute =
        {
            @"     ",
            @"     ",
            @"     ",
            @"  o  ",
            @" /░\ ",
            @" / \ ",
        };
        private string[] viewWithParachute =
        {
            @" ___ ",
            @"/|||\",
            @"\   /",
            @" \o/ ",
            @"  ░  ",
            @" / \ ",
        };

        public string name;
        public int x;
        public int y;
        public bool parachuteIsOpen;

        public Para (string name)
        {
            this.name = name;
        }

        internal void update()
        {
            if(y > PARA_HEIGHT) 
            {
                if (y < 20)
                {
                    parachuteIsOpen = true;
                }
            }
        }
        public void draw()
        {
            string[] view = parachuteIsOpen ? viewWithParachute : viewNoParachute;
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, Config.SCREEN_HEIGHT - this.y + i);
                Console.Write(view[i]);
            }
            Console.SetCursorPosition(x, Config.SCREEN_HEIGHT - this.y - 1);
            Console.Write(this.name);
        }

    }

}
