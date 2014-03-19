using System.Drawing;

namespace ConwayGameofLife.com.andaforce.arazect.visual.winforms.shapes
{
    public class EllipseShapePresentation : IShapePresentation
    {
        private SolidBrush _brush;

        public EllipseShapePresentation(Color color)
        {
            _brush = new SolidBrush(color);
        }

        public void Draw(Graphics g, Color elementColor, int x, int y, int width)
        {
            _brush.Color = elementColor;
            g.FillEllipse(_brush, x, y, width, width);
        }
    }
}