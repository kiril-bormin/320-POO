using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Parachutistes
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int x = 0;
            ConsoleKeyInfo keyPressed;
            List<Para> parachutistesInAir = new List<Para>();

            Plane plane = new Plane();

            for (int i = 0; i < 8; i++)
            {
                plane.board(new Para("Bob " + i.ToString()));
            }

            while (true)
            {
                Console.CursorVisible = false;
                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            Para jumper = plane.dropParachutist();
                            parachutistesInAir.Add(jumper);
                            break;
                        default:
                            break;
                    }
                }
                // Modifier le modèle 
                plane.update();
                foreach (Para para in parachutistesInAir)
                {
                    para.update();
                }

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();
                foreach (Para para in parachutistesInAir)
                {
                    para.draw();
                }
                // Temporiser
                Thread.Sleep(100);
            }
        }
    }


    

}
