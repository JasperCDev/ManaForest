using ManaForest.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaForest.Managers
{
    internal class InputManager : Component
    {

        public static MouseState OldMouseState { get; set; }
        public static MouseState MouseState { get; set; } = Mouse.GetState();
        public static Rectangle MouseRect { get; set; }


        private static Rectangle getMouseRect()
        {
            float x = (float)(MouseState.X / 3.75);
            float y = (float)(MouseState.Y / 3.75);

            return new((int)x, (int)y, 1, 1);
        }

        
        internal override void Update(GameTime gameTime)
        {
            OldMouseState = MouseState;
            MouseState = Mouse.GetState();
            MouseRect = getMouseRect();
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            return;
        }

        internal override void LoadContent(ContentManager content)
        {
            return;
        }

    }
}
