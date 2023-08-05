using ManaForest.Core;
using ManaForest.Core.helpers;
using ManaForest.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;

namespace ManaForest.Scenes
{
    internal class GameScene : Component
    {
        public Texture2D cardTexture;
        public Texture2D tileTexture;
        public Grid grid;
        public GameScene()
        {
            grid = new Grid(
                width: 16,
                height: 9
            );
        }

        internal override void LoadContent(ContentManager content)
        {
            cardTexture = content.Load<Texture2D>("card");
            tileTexture = content.Load<Texture2D>("card");
        }

        internal override void Update(GameTime gameTime)
        {
            return;
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < grid.rows.GetLength(0); i++)
            {
                for (int j = 0; j < grid.rows.GetLength(1); j++)
                {
                    var tile = grid.rows[i, j];
                    var x = 32 * i;
                    var y = 32 * j;
                    Rectangle rect = new(x, y, 32, 32);
                    Color tileColor = InputManager.MouseRect.Intersects(rect) ? Color.White : Color.Black;
                    spriteBatch.Draw(
                        tileTexture,
                        rect,
                        tileColor
                    );
                }
            }
        }
    }
}
