using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Parachutistes
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Para> parachutistesInAir = new List<Para>();

            Plane plane = new Plane();

            for (int i = 0; i < 8; i++)
            {
                plane.board(new Para("Bob " + i.ToString()));
            }

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


    

}
