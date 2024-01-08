using ManaForest.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ManaForest.Core.GameObjects
{
    internal class WateringCan : Component
    {
        Texture2D texture;
        Rectangle rect;
        Color color = Color.White;

        public WateringCan()
        {
            rect = new Rectangle(Data.CANVAS_SIZE, 0, Data.CANVAS_SIZE, Data.CANVAS_SIZE);
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rect, color);
        }

        internal override void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("watering-can");
        }

        internal override void Update(GameTime gameTime)
        {
            bool isSelected = Toolbar.SelectedTool == Toolbar.Tool.WateringCan;
            if (isSelected)
            {
                color = Color.Green;
            }
            else
            {
                color = Color.White;
            }
            if (InputManager.IsClick(rect))
            {
                Toolbar.SelectedTool = Toolbar.Tool.WateringCan;
            }

        }
    }

}
