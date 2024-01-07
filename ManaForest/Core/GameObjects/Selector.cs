using ManaForest.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Diagnostics;
using MonoGame.Extended;
using System.Net.NetworkInformation;

namespace ManaForest.Core.GameObjects
{
    internal class Selector : Component
    {
        Rectangle rect;
        private const int SELECTOR_SIZE = 4;
        public Selector() {
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.DrawRectangle(rect, Color.Red, 1);
        }

        internal override void LoadContent(ContentManager content)
        {
            throw new NotImplementedException();
        }

        internal override void Update(GameTime gameTime)
        {
            
            int x = InputManager.MouseRect.X - (InputManager.MouseRect.X % Data.CANVAS_SIZE);
            int y = InputManager.MouseRect.Y - (InputManager.MouseRect.Y % Data.CANVAS_SIZE);
            int maxX = Data.TARGET_WIDTH - (SELECTOR_SIZE * Data.CANVAS_SIZE);
            int maxY = Data.TARGET_HEIGHT - (SELECTOR_SIZE * Data.CANVAS_SIZE);
            if (x < 0) {
                x = 0;
            }
            if (y < 0) {
                y = 0;
            }
            if (x > maxX) { 
                x = maxX;
            }
            if (y > maxY)
            {
                y = maxY;
            }
            rect = new(x, y, Data.CANVAS_SIZE * SELECTOR_SIZE, Data.CANVAS_SIZE * SELECTOR_SIZE);
            if (InputManager.IsClick())
            {
                Delegates.hoeTiles?.Invoke(rect);
            }
        }
    }
}
