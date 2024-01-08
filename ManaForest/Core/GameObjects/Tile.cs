using ManaForest.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ManaForest.Core.GameObjects
{
    public enum CellType
    {
        Empty,
        Occupied
    }
    internal class Tile : Component
    {
        private readonly int x;
        private readonly int y;
        private Texture2D texture;
        public CellType type;
        public Rectangle rect;
        private Color tileColor = Color.White;


        public Tile(int x, int y, CellType type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            if (texture == null)
            {
                return;
            }
            spriteBatch.Draw(texture, rect, tileColor);
        }

        internal override void LoadContent(ContentManager content)
        {
            this.texture = content.Load<Texture2D>("tile");
        }

        internal override void Update(GameTime gameTime)
        {
            rect = new Rectangle(x, y, Data.CANVAS_SIZE, Data.CANVAS_SIZE);
        }

        public void Hoe()
        {
            this.tileColor = Color.Brown;
        }

        public void Water()
        {
            this.tileColor = Color.Blue;
        }
    }
}
