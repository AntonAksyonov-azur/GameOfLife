using System.Drawing;

namespace ConwayGameofLife.com.andaforce.arazect.visual.winforms.shapes
{
    public class RectangleShapePresentation : IShapePresentation
    {
        private SolidBrush _brush;

        public RectangleShapePresentation(Color color)
        {
            _brush = new SolidBrush(color);
        }

        public void Draw(Graphics g, Color elementColor, int x, int y, int width)
        {
            _brush.Color = elementColor;
            g.FillRectangle(_brush, x, y, width, width);
        }
    }
}