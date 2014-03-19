using System;

namespace ConwayGameofLife.com.andaforce.arazect.life
{
    public class World
    {
        private int[,] _currentWorldState;
        private int[,] _futureWorldState;
        public int WorldWidth { get; private set; }
        public int WorldHeight { get; private set; }

        public World(int worldWidth, int worldHeight)
        {
            _currentWorldState = new int[worldHeight, worldWidth];
            _futureWorldState = new int[worldHeight, worldWidth];

            WorldWidth = worldWidth;
            WorldHeight = worldHeight;
        }

        #region Present

        public void SetCellAlive(int x, int y)
        {
            _currentWorldState[y, x] = 1;
        }

        public void SetCellDead(int x, int y)
        {
            _currentWorldState[y, x] = 0;
        }

        public bool IsCellDead(int x, int y)
        {
            return _currentWorldState[y, x] == 0;
        }

        #endregion

        #region Future

        private void ClearFuture()
        {
            _futureWorldState = new int[WorldWidth, WorldWidth];
        }

        private void SetFutureCellAlive(int x, int y)
        {
            _futureWorldState[y, x] = 1;
        }

        private void SetFutureCellDead(int x, int y)
        {
            _futureWorldState[y, x] = 0;
        }

        private void ApplyFuture()
        {
            Clear();

            for (int x = 0; x < WorldWidth; x++)
            {
                for (int y = 0; y < WorldHeight; y++)
                {
                    _currentWorldState[y, x] = _futureWorldState[y, x];
                }
            }
        }

        #endregion

        public void PerformNextStep()
        {
            ClearFuture();

            bool isCellDead;
            int neighboursCount;

            for (int x = 0; x < WorldWidth; x++)
            {
                for (int y = 0; y < WorldHeight; y++)
                {
                    isCellDead = IsCellDead(x, y);
                    neighboursCount = GetNeighboursCount(x, y);
                    if (isCellDead && neighboursCount == 3)
                    {
                        SetFutureCellAlive(x, y);
                    }
                    else if (!isCellDead && (neighboursCount == 2 || neighboursCount == 3))
                    {
                        SetFutureCellAlive(x, y);
                    }
                    else if (!isCellDead && (neighboursCount < 2 || neighboursCount > 3))
                    {
                        SetFutureCellDead(x, y);
                    }
                }
            }

            ApplyFuture();
        }

        public void RandomFilling(int count, int newWidth = 0, int newHeight = 0)
        {
            Clear(newWidth, newHeight);

            var rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                SetCellAlive(rnd.Next(0, WorldWidth), rnd.Next(0, WorldHeight));
            }
        }

        public void Clear(int newWidth = 0, int newHeight = 0)
        {
            if (newWidth > 0)
            {
                WorldWidth = newWidth;
            }

            if (newHeight > 0)
            {
                WorldHeight = newHeight;
            }

            _currentWorldState = new int[WorldHeight, WorldWidth];
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