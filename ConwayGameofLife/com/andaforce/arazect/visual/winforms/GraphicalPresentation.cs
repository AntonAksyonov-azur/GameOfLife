using System.Collections.Generic;
using System.Drawing;
using ConwayGameofLife.com.andaforce.arazect.life;
using ConwayGameofLife.com.andaforce.arazect.visual.winforms.shapes;

namespace ConwayGameofLife.com.andaforce.arazect.visual.winforms
{
    public class GraphicalPresentation
    {
        public ShapeType ShapeType { get; private set; }
        public Color Color { get; private set; }
        public int PixelSize { get; private set; }

        private Dictionary<ShapeType, IShapePresentation> _shapesPresentations =
            new Dictionary<ShapeType, IShapePresentation>();

        public GraphicalPresentation(ShapeType shapeType, Color color, int pixelSize)
        {
            ShapeType = shapeType;
            Color = color;
            PixelSize = pixelSize;

            _shapesPresentations.Add(ShapeType.Circle, new EllipseShapePresentation(Color));
            _shapesPresentations.Add(ShapeType.Rectangle, new RectangleShapePresentation(Color));
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
                            x * PixelSize,
                            y * PixelSize,
                            PixelSize);
                    }
                }
            }
        }
    }
}