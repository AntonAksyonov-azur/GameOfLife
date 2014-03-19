using System.Collections.Generic;
using System.Drawing;
using ConwayGameofLife.com.andaforce.arazect.data;
using ConwayGameofLife.com.andaforce.arazect.life;
using ConwayGameofLife.com.andaforce.arazect.visual.winforms.shapes;

namespace ConwayGameofLife.com.andaforce.arazect.visual.winforms
{
    public class GraphicalPresentation
    {
        public ShapeType ShapeType { get; private set; }
        public Color ElementColor { get; private set; }
        public int PixelSize { get; private set; }

        private Dictionary<ShapeType, IShapePresentation> _shapesPresentations =
            new Dictionary<ShapeType, IShapePresentation>();

        private Pen _gridPen;

        public GraphicalPresentation(
            ShapeType shapeType, Color elementColor, Color gridColor, int pixelSize)
        {
            ShapeType = shapeType;
            ElementColor = elementColor;
            PixelSize = pixelSize;

            _shapesPresentations.Add(ShapeType.Circle, new EllipseShapePresentation(ElementColor));
            _shapesPresentations.Add(ShapeType.Rectangle, new RectangleShapePresentation(ElementColor));

            _gridPen = new Pen(gridColor);
        }

        public void DrawGrid(Graphics g, World world)
        {
            var maxX = world.WorldWidth * PixelSize;
            var maxY = world.WorldHeight * PixelSize;

            for (int x = 0; x < world.WorldWidth; x++)
            {
                g.DrawLine(_gridPen, x * PixelSize, 0, x * PixelSize, maxY);
            }

            for (int y = 0; y < world.WorldHeight; y++)
            {
                g.DrawLine(_gridPen, 0, y * PixelSize, maxX, y * PixelSize);
            }
        }

        public void DrawWorld(Graphics g, World world)
        {
            var shapePresentation = _shapesPresentations[ShapeType];
            for (int x = 0; x < world.WorldWidth; x++)
            {
                for (int y = 0; y < world.WorldHeight; y++)
                {
                    if (!world.IsCellDead(x, y))
                    {
                        shapePresentation.Draw(
                            g,
                            ElementColor,
                            x * PixelSize,
                            y * PixelSize,
                            PixelSize);
                    }
                }
            }
        }

        public GenericPoint<int> ScreenToWorldPoint(int screenX, int screenY)
        {
            return 
                new GenericPoint<int> {X = screenX / PixelSize, Y = screenY / PixelSize};
        }

        #region Setters

        public void SetElementColor(Color color)
        {
            ElementColor = color;
        }

        public void SetGridColor(Color color)
        {
            _gridPen.Color = color;
        }

        public void SetPixelSize(int pixelSize)
        {
            PixelSize = pixelSize;
        }

        public void SetShapeType(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }


        #endregion
    }
}