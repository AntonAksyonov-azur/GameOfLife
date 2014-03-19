using System.Drawing;

namespace ConwayGameofLife.com.andaforce.arazect.visual.winforms.shapes
{
    public class RectangleShapePresentation : IShapePresentation
    {
        private Brush _brush;

        public RectangleShapePresentation(Color color)
        {
            _brush = new SolidBrush(color);
        }

        public void Draw(Graphics g, int x, int y, int width)
        {
            g.FillRectangle(_brush, x, y, x + width, y + width);
        }
    }
}