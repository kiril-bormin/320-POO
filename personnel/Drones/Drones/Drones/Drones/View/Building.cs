using Drones.Helpers;

namespace Drones
{
    public partial class Building
    {
        private bool _form;

        private Pen buildingBrush = new(new SolidBrush(Color.Black), 5);

        public virtual void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(X - 4, Y - 2, 70, 70));
        }
    }
}
