using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush.GUI
{
    public class HeadupDisplay : Sprite
    {
        protected int width;
        protected int height;

        // Constructor
        public HeadupDisplay(Texture2D texture, Vector2 position)
            : base(texture, position)
        {
            this.width = (int)texture.Width;
            this.height = (int)texture.Height;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(
                (int)(position.X - (width / 2) + (C.BS / 2)), 
                (int)(position.Y - (height / 2) - C.BS),
                width, height), Color.White);
        }
    }
}
