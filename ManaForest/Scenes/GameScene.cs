using ManaForest.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ManaForest.Scenes
{
    internal class GameScene : Component
    {
        public Texture2D cardTexture;
        public Texture2D tileTexture;
        public Board board;
        public GameScene() {
            board = new Board();
        }

        internal override void LoadContent(ContentManager content)
        {
            cardTexture = content.Load<Texture2D>("card");
            tileTexture = content.Load<Texture2D>("tile");
        }

        internal override void Update(GameTime gameTime)
        {
            return;
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            for (int i = 0; i < board.grid.GetLength(0); i++)
            {
                for (int j = 0; j < board.grid.GetLength(1); j++)
                {
                    var tile = board.grid[i, j];
                    spriteBatch.Draw(
                        tileTexture,
                        new Vector2(32 * i, 32 * j),
                        null,
                        Color.White,
                        0f,
                        new Vector2(0, 0),
                        new Vector2((float)3.125, (float)3.125),
                        SpriteEffects.None,
                        0f
                    );
                    if (tile.type != SpaceType.Empty)
                    {
                        spriteBatch.Draw(
                            cardTexture,
                            new Vector2(100 * i, 100 * j),
                            null,
                            Color.White,
                            0f,
                            new Vector2(0, 0),
                            new Vector2((float)3.125, (float)3.125),
                            SpriteEffects.None,
                            0f
                        );
                    }
                }
            }
            spriteBatch.End();
        }
    }
}
