using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Factory : Building
    {
        private double _consumption;

        private Pen buildingBrush = new(new SolidBrush(Color.Black), 5);
        public Factory(int x, int y, double consumption) : base(x, y)
        {
            Console.WriteLine("Factory constructor");
            _consumption = consumption;
        }
        public override void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(X - 4, Y - 2, 70, 70));
            drawingSpace.Graphics.DrawString("Consumation : " + _consumption.ToString(), TextHelpers.drawFont, TextHelpers.writingBrush, X - 5, Y - 25);
        }
    }
}
