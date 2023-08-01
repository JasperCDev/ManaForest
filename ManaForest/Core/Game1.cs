using ManaForest.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace ManaForest.Core
{
    public class Game1 : Game
    {
        public static GraphicsDeviceManager graphics;
        private GameStateManager gameStateManager;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            gameStateManager = new GameStateManager();
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferWidth = Data.ScreenWidth;
            graphics.PreferredBackBufferHeight = Data.ScreenHeight;
            graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            gameStateManager.LoadContent(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            gameStateManager.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            SpriteBatch spriteBatch = new SpriteBatch(GraphicsDevice);
            GraphicsDevice.Clear(Color.CornflowerBlue);
            gameStateManager.Draw(spriteBatch);
            base.Draw(gameTime);
        }
    }
}