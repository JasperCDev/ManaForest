using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Diagnostics;

namespace ManaForest.Core.GameObjects
{
    internal class TileMap : Component
    {
        private readonly Tile[,] tiles;
        public TileMap() {
            tiles = InitTiles();
            Delegates.hoeTiles = HandleHoeTiles;
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    var tile = tiles[i, j];
                    tile.Draw(spriteBatch);
                }
            }
        }

        private void HandleHoeTiles(Rectangle selector)
        {
            Debug.WriteLine("HandleHoeTiles");
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    Tile tile = tiles[i, j];
                    if (tile.rect.Intersects(selector))
                    {
                        tile.Hoe();
                    }
                }
            }
        }

        private static Tile[,] InitTiles()
        {
            int columns = Data.TARGET_WIDTH / Data.CANVAS_SIZE;
            int rows = Data.TARGET_HEIGHT / Data.CANVAS_SIZE;
            var tiles = new Tile[columns, rows];
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    tiles[i, j] = new Tile(i * Data.CANVAS_SIZE, j * Data.CANVAS_SIZE, CellType.Empty);
                }
            }
            return tiles;
        }

        internal override void LoadContent(ContentManager content)
        {
            foreach (var tile in tiles)
            {
                tile.LoadContent(content);
            }
        }

        internal override void Update(GameTime gameTime)
        {
            foreach (var tile in tiles)
            {
                tile.Update(gameTime);
            }
        }
    }
}
