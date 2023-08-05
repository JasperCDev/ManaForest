using ManaForest.Core;
using ManaForest.Core.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaForest.Scenes
{
    internal class MainMenuScene : Component
    {
        private Button startButton = new Button();
        public MainMenuScene() { 
            
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            startButton.Draw(spriteBatch);
        }

        internal override void LoadContent(ContentManager content)
        {
            startButton.LoadContent(content);
        }

        internal override void Update(GameTime gameTime)
        {
            startButton.Update(gameTime);
        }
    }
}
