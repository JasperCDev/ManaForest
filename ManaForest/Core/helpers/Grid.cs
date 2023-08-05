using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManaForest.Core.helpers
{
    public enum CellType
    {
        Empty,
        Occupied
    }
     internal class GridCell : Component
    {
        public CellType type;
        public string id;

        public GridCell(string spaceId, CellType spaceType)
        {
            type = spaceType;
            id = spaceId;
        }

        public void OnCellClick()
        {
            Debug.WriteLine("Tile Cell " + id + " Clicked!");
            type = CellType.Occupied;
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        internal override void LoadContent(ContentManager content)
        {
            throw new NotImplementedException();
        }

        internal override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
    internal class Grid : Component
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

        internal override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        internal override void LoadContent(ContentManager content)
        {
            throw new NotImplementedException();
        }

        internal override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        private void Init()
        {
            var rows = new GridCell[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    string id = i.ToString() + j.ToString();
                    rows[i, j] = new GridCell(id, CellType.Empty);
                }
            }
            this.rows = rows;
        }
    }
}
