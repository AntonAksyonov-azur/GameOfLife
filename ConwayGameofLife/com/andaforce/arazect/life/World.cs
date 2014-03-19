namespace ConwayGameofLife.com.andaforce.arazect.life
{
    public class World
    {
        private Unit[,] _worldState;
        private int _worldWidth;
        private int _worldsHeight;

        public World(int worldWidth, int worldHeight)
        {
            _worldState = new Unit[worldHeight, worldWidth];
            _worldWidth = worldWidth;
            _worldsHeight = worldHeight;
        }

        public void SetCellAlive(int x, int y)
        {
            _worldState[y, x] = new Unit();
        }

        public void SetCellDead(int x, int y)
        {
            _worldState[y, x] = null;
        }

        public bool IsCellDead(int x, int y)
        {
            return _worldState[y, x] == null;
        }

        public void PerformNextStep()
        {
            bool isCellDead;
            int neighbours;
            for (int x = 0; x < _worldWidth; x++)
            {
                for (int y = 0; y < _worldsHeight; y++)
                {
                    isCellDead = IsCellDead(x, y);
                    neighbours = GetNeighboursCount(x, y);
                    if (isCellDead && neighbours == 3)
                    {
                        SetCellAlive(x, y);
                    }
                    else if (!isCellDead && (neighbours == 2 || neighbours == 3))
                    {
                        // Cell stays alive
                    }
                    else if (!isCellDead && (neighbours < 2 || neighbours > 3))
                    {
                        SetCellDead(x, y);
                    }
                }
            }
        }

        private int GetNeighboursCount(int checkedX, int checkedY)
        {
            Point p;
            int neighboursCount = 0;
            for (int i = 0; i < _directions.Length; i++)
            {
                p = _directions[i];
                int bufX = checkedX + p.X;
                int bugY = checkedY + p.Y;

                if (bufX >= _worldWidth ||
                    bugY >= _worldsHeight ||
                    bufX < 0 ||
                    bugY < 0)
                {
                    continue;
                }

                if (IsCellDead(checkedX + p.X, checkedY + p.Y))
                {
                    neighboursCount += 1;
                }
            }

            return neighboursCount;
        }


        private readonly Point[] _directions =
        {
            new Point {X = 1, Y = 0},
            new Point {X = 1, Y = 1},
            new Point {X = 0, Y = 1},
            new Point {X = -1, Y = 1},
            new Point {X = -1, Y = 0},
            new Point {X = -1, Y = -1},
            new Point {X = 0, Y = -1},
            new Point {X = 1, Y = -1}
        };

        private struct Point
        {
            public int X;
            public int Y;
        }
    }
}