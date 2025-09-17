using Drones.Helpers;

namespace Drones
{
    public partial class Building
    {
        private Pen buildingBrush = new(new SolidBrush(Color.Black), 3);

        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(X - 4, Y - 2, DEPTH, HEIGHT));
        }
    }
}
