using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush.GUI
{
    public class RangeBorder : Sprite
    {
        protected int width;
        protected int height;

        /// <summary>
        /// Passt die Größe der Reichweite an wenn
        /// z.B. der Turm verbessert wurden ist
        /// </summary>
        public float CurrentRadius
        {
            set
            {
                width = (int)(value * 2);
                height = (int)(value * 2);
            }

        }

        // Constructor
        public RangeBorder(Texture2D texture, float radius, Vector2 position)
            : base(texture, position)
        {
            this.width = (int)(radius * 2);
            this.height = (int)(radius * 2);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(
                (int)(position.X - (width / 2) + (32 / 2)), 
                (int)(position.Y - (height / 2) + (32 / 2)),
                width, height), Color.White);
        }
    }
}
