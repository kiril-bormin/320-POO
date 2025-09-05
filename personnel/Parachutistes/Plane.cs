using Parachutistes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutistes
{
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
        public List<Para> parachutistes;

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
        public void board(Para para)
        {
            this.parachutistes.Add(para);
        }
        public Para dropParachutist()
        {
            Para parachutist = parachutistes.First();
            parachutistes.Remove(parachutist);
            parachutist.x = x;
            parachutist.y = this.y;
            return parachutist;
        }
    }
}
