using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaForest.Core.GameObjects
{
    internal class Toolbar : Component
    {
        Hoe hoe;
        WateringCan wateringCan;
        Rectangle rect;
        public enum Tool
        {
            Hoe,
            WateringCan,
        }
        public static Tool SelectedTool = Tool.Hoe;
        public Toolbar()
        {
            hoe = new Hoe();
            wateringCan = new WateringCan();
            rect = new Rectangle(0, 0, Data.CANVAS_SIZE * 4, Data.CANVAS_SIZE);
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            hoe.Draw(spriteBatch);
            wateringCan.Draw(spriteBatch);
            spriteBatch.DrawRectangle(rect, Color.Blue, 1);
        }

        internal override void LoadContent(ContentManager content)
        {
            hoe.LoadContent(content);
            wateringCan.LoadContent(content);
        }

        internal override void Update(GameTime gameTime)
        {
            hoe.Update(gameTime);
            wateringCan.Update(gameTime);
        }
    }
}
