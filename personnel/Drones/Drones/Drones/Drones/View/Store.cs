using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Store : Building
    {
        private string _OpeningHours;

        private Pen buildingBrush = new(new SolidBrush(Color.Black), 5);
        public Store(int x, int y, string openinghours) : base(x, y)
        {
            Console.WriteLine("Factory constructor");
            _OpeningHours = openinghours;
        }
        public override void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(X - 4, Y - 2, 70, 70));
            drawingSpace.Graphics.DrawString("Consumation : " + _OpeningHours.ToString(), TextHelpers.drawFont, TextHelpers.writingBrush, X - 5, Y - 25);
        }
    }
}