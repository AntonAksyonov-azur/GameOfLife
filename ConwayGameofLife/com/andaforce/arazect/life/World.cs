using System;

namespace ConwayGameofLife.com.andaforce.arazect.life
{
    public class World
    {
        private int[,] _worldState;
        public int WorldWidth { get; private set; }
        public int WorldHeight { get; private set; }

        public World(int worldWidth, int worldHeight)
        {
            _worldState = new int[worldHeight, worldWidth];
            WorldWidth = worldWidth;
            WorldHeight = worldHeight;
        }

        public void SetCellAlive(int x, int y)
        {
            _worldState[y, x] = 1;
        }

        public void SetCellDead(int x, int y)
        {
            _worldState[y, x] = 0;
        }

        public bool IsCellDead(int x, int y)
        {
            return _worldState[y, x] == 0;
        }

        public void PerformNextStep()
        {
            bool isCellDead;
            int neighbours;
            for (int x = 0; x < WorldWidth; x++)
            {
                for (int y = 0; y < WorldHeight; y++)
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

        public void RandomFilling(int count)
        {
            _worldState = new int[WorldHeight, WorldWidth];

            var rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                SetCellAlive(rnd.Next(0, WorldWidth), rnd.Next(0, WorldHeight));
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

                if (bufX >= WorldWidth ||
                    bugY >= WorldHeight ||
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