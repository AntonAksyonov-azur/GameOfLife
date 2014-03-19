using System.Drawing;

namespace ConwayGameofLife.com.andaforce.arazect.visual.winforms.shapes
{
    public class EllipseShapePresentation : IShapePresentation
    {
        private Brush _brush;

        public EllipseShapePresentation(Color color)
        {
            _brush = new SolidBrush(color);
        }

        public void Draw(Graphics g, int x, int y, int width)
        {
            g.FillEllipse(_brush, x, y, x + width, y + width);
        }
    }
}