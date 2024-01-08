using ManaForest.Core;
using ManaForest.Core.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Linq.Expressions;

namespace ManaForest.Scenes
{
    internal class GameScene : Component
    {
        readonly TileMap tilemap = new();
        private Selector selector = new();
        private Toolbar toolbar = new();
        public GameScene()
        {

        }
        internal override void LoadContent(ContentManager content)
        {
            tilemap.LoadContent(content);
            selector.LoadContent(content);
            toolbar.LoadContent(content);
        }
        internal override void Update(GameTime gameTime)
        {
            tilemap.Update(gameTime);
            selector.Update(gameTime);
            toolbar.Update(gameTime);
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            tilemap.Draw(spriteBatch);
            toolbar.Draw(spriteBatch);
            selector.Draw(spriteBatch);
        }
    }
}
