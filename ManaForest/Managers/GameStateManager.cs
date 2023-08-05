using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ManaForest.Core;
using Microsoft.Xna.Framework.Content;
using ManaForest.Scenes;
using System;
using System.Diagnostics;

namespace ManaForest.Managers
{
    internal class GameStateManager : Component
    {
        private readonly GameScene gameScene = new();
        private readonly MainMenuScene mainMenuScene = new();
        public GameStateManager()
        {
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {
            switch (Data.CurrentScene)
            {
                case Data.Scenes.MainMenu:
                    mainMenuScene.Draw(spriteBatch);
                    return;
                case Data.Scenes.Game:
                    gameScene.Draw(spriteBatch);
                    return;
            }
        }

        internal override void LoadContent(ContentManager content)
        {
            Debug.WriteLine($"hey this is load content for {Data.CurrentScene}");
            switch (Data.CurrentScene)
            {
                case Data.Scenes.MainMenu:
                    mainMenuScene.LoadContent(content);
                    return;
                case Data.Scenes.Game:
                    gameScene.LoadContent(content);
                    return;
            }
        }

        internal override void Update(GameTime gameTime)
        {
            switch (Data.CurrentScene)
            {
                case Data.Scenes.MainMenu:
                    mainMenuScene.Update(gameTime);
                    return;
                case Data.Scenes.Game:
                    gameScene.Update(gameTime);
                    return;
            }
        }
    }
}
