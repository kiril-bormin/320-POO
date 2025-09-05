using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutistes
{
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

        public Para(string name)
        {
            this.name = name;
        }

        public void update()
        {
            if (y > PARA_HEIGHT)
            {
                if (y < Config.SCREEN_HEIGHT / 2)
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
        }

    }
}
