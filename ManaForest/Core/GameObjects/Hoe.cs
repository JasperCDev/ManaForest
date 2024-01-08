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
    internal class Hoe : Component
    {
        Texture2D texture;
        Rectangle rect;
        Color color = Color.White;
        public Hoe() { 
            rect = new Rectangle(0, 0, Data.CANVAS_SIZE, Data.CANVAS_SIZE);
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rect, color);
        }

        internal override void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("hoe");
        }

        internal override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            bool isSelected = Toolbar.SelectedTool == Toolbar.Tool.Hoe;
            if (isSelected)
            {
                color = Color.Green;
            }
            else
            {
                color = Color.White;
            }
            if (InputManager.IsClick(rect))
            {
                Toolbar.SelectedTool = Toolbar.Tool.Hoe;
            }
        }
    }
}
