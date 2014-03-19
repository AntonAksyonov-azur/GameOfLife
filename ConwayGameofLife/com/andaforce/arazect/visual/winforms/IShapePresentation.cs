using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ConwayGameofLife.com.andaforce.arazect.visual.winforms
{
    public interface IShapePresentation
    {
        void Draw(Graphics g, Color elementColor, int x, int y, int width);
    }
}
