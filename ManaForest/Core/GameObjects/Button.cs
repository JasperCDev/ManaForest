using ManaForest.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ManaForest.Core.GameObjects
{
    internal class Button : Component
    {
        private Texture2D texture;
        private Rectangle rect;
        private int x;
        private int y;
        private Color color = Color.White;
        public Button()
        {

        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            Vector2 position = new(
                x,
                y
            );
            spriteBatch.Draw(texture, position, color);
        }

        internal override void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("start button");

        }



        internal override void Update(GameTime gameTime)
        {
            x = (Core.Game.renderTarget.Width / 2) - (texture.Width / 2);
            y = (Core.Game.renderTarget.Height / 2) - (texture.Height / 2);
            rect = new(x, y, texture.Width, texture.Height);

            if (InputManager.IsClick(rect))
            {
                Data.CurrentScene = Data.Scenes.Game;
                Data.LoadingScene = true;
            }
        }
    }
}
