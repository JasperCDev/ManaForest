using ManaForest.Core;
using ManaForest.Core.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ManaForest.Scenes
{
    internal class GameScene : Component
    {
        readonly TileMap tilemap = new();
        public GameScene()
        {

        }
        internal override void LoadContent(ContentManager content)
        {
            tilemap.LoadContent(content);
        }
        internal override void Update(GameTime gameTime)
        {
            tilemap.Update(gameTime);
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            tilemap.Draw(spriteBatch);
        }
    }
}
