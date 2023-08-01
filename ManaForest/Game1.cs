using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace ManaForest
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public Texture2D cardTexture;
        public Texture2D tileTexture;
        public Board board;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
        }

        protected override void Initialize()
        {
            _graphics.IsFullScreen = false;
            _graphics.PreferredBackBufferWidth = 640;
            _graphics.PreferredBackBufferHeight = 480;
            _graphics.ApplyChanges();
            board = new Board();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            cardTexture = Content.Load<Texture2D>("card");
            tileTexture = Content.Load<Texture2D>("tile");
 
        }

        protected override void Update(GameTime gameTime)
        {
            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            int w = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            int h = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;

            _spriteBatch.Begin();
            for (int i = 0; i < board.grid.GetLength(0); i++)
            {
                for (int j = 0; j < board.grid.GetLength(1); j++)
                {
                    var tile = board.grid[i, j];
                    _spriteBatch.Draw(
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
                        _spriteBatch.Draw(
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
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}