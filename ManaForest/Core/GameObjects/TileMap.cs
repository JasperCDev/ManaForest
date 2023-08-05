using ManaForest.Core.helpers;
using ManaForest.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaForest.Core.GameObjects
{
    internal class TileMap : Component
    {
        private Grid grid = new(16, 9);
        private Texture2D tileTexture;
        public TileMap() { }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < grid.rows.GetLength(0); i++)
            {
                for (int j = 0; j < grid.rows.GetLength(1); j++)
                {
                    var tile = grid.rows[i, j];
                    var x = Data.CANVAS_SIZE * i;
                    var y = Data.CANVAS_SIZE * j;
                    Rectangle rect = new(x, y, Data.CANVAS_SIZE, Data.CANVAS_SIZE);
                    Color tileColor = InputManager.MouseRect.Intersects(rect) ? Color.White : Color.Black;
                    spriteBatch.Draw(
                        tileTexture,
                        rect,
                        tileColor
                    );
                }
            }
        }

        internal override void LoadContent(ContentManager content)
        {
            tileTexture = content.Load<Texture2D>("tile");
        }

        internal override void Update(GameTime gameTime)
        {
            return;
        }
    }
}
