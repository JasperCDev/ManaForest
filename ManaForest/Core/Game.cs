using ManaForest.Core.GameObjects;
using ManaForest.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ManaForest.Core
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        public static GraphicsDeviceManager graphics;
        public static RenderTarget2D renderTarget;
        private GameStateManager gameStateManager;
        private InputManager inputManager;
        private SpriteBatch spriteBatch;

        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            // Managers
            gameStateManager = new GameStateManager();
            inputManager = new InputManager();
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            graphics.PreferredBackBufferWidth =  Data.ScreenWidth;
            graphics.PreferredBackBufferHeight = Data.ScreenHeight;
            graphics.ApplyChanges();

            spriteBatch = new SpriteBatch(GraphicsDevice);
            renderTarget = new RenderTarget2D(GraphicsDevice, Data.TARGET_WIDTH, Data.TARGET_HEIGHT);

        }

        protected override void LoadContent()
        {
            gameStateManager.LoadContent(Content);
            inputManager.LoadContent(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Data.LoadingScene)
            {
                this.LoadContent();
                Data.LoadingScene = false;
            }
            gameStateManager.Update(gameTime);
            inputManager.Update(gameTime);
            base.Update(gameTime);
            // reset
            InputManager.clickedThisFrame = false;
        }

        protected override void Draw(GameTime gameTime)
        {
            if (Data.LoadingScene)
            {
                return;
            }
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            gameStateManager.Draw(spriteBatch);
            inputManager.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);

            // Render Target stuff
            GraphicsDevice.SetRenderTarget(null);
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            spriteBatch.Draw(
                texture: renderTarget,
                position: Vector2.Zero,
                sourceRectangle: null,
                color: Color.White,
                rotation: 0f,
                origin: Vector2.Zero,
                scale: 5f,
                effects: SpriteEffects.None,
                layerDepth: 0f
            );
            spriteBatch.End();
        }
    }
}