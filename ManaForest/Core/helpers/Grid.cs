using System.Diagnostics;


namespace ManaForest.Core.helpers
{
    public enum CellType
    {
        Empty,
        Occupied
    }
    internal class GridCell
    {
        public CellType type;
        public string id;

        public GridCell(string spaceId, CellType spaceType)
        {
            type = spaceType;
            id = spaceId;
        }
    }
    internal class Grid
    {
        private readonly int width;
        private readonly int height;
        public GridCell[,] rows;
        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
            Init();
        }

        private void Init()
        {
            var rows = new GridCell[width, height];
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    string id = i.ToString() + j.ToString();
                    rows[i, j] = new GridCell(id, CellType.Empty);
                }
            }
            this.rows = rows;
        }
    }
}
