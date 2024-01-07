using ManaForest.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ManaForest.Managers
{
    internal class InputManager : Component
    {

        public static MouseState OldMouseState { get; private set; }
        public static MouseState MouseState { get; private set; } = Mouse.GetState();
        public static Rectangle MouseRect { get; private set; }

        private static Rectangle GetMouseRect()
        {
            float x = MouseState.X / 5;
            float y = MouseState.Y / 5;

            return new((int)x, (int)y, 1, 1);
        }

        
        internal override void Update(GameTime gameTime)
        {
            OldMouseState = MouseState;
            MouseState = Mouse.GetState();
            MouseRect = GetMouseRect();
        }

        public static bool IsClick(Rectangle rect)
        {
            bool isIntersecting = MouseRect.Intersects(rect);
            bool wasPressed = OldMouseState.LeftButton == ButtonState.Pressed;
            bool wasReleased = MouseState.LeftButton == ButtonState.Released;
            return isIntersecting && wasPressed && wasReleased;
        }
        public static bool IsClick()
        {
            bool wasPressed = OldMouseState.LeftButton == ButtonState.Pressed;
            bool wasReleased = MouseState.LeftButton == ButtonState.Released;
            return wasPressed && wasReleased;
        }

        public static bool IsHover(Rectangle rect)
        {
            return MouseRect.Intersects(rect);
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
