using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush
{
    public enum TextureType
    {
        /// <summary>
        /// Steht für eine Grafik (z.B. wenn ein Objekt aus 
        /// einer ganz normalen einfachen Grafik besteht wie 32x32)
        /// </summary>
        Single,
        /// <summary>
        /// Zu verwenden für Grafiken mit 2 Layern (wie z.B. ein Turm 
        /// wobei der erste Layer der nicht drehbahre Boden ist und
        /// der zweite Layer der drehende Turm an sich)
        /// </summary>
        DoubleLayer,
        /// <summary>
        /// Zu verwenden bei einer Grafik die aus einer AnimationMap besteht
        /// </summary>
        Animated,
        AnimatedDoubleLayer
    }
    public class Sprite
    {
        #region Variablen
        protected Texture2D texture;

        protected Vector2 position;
        protected Vector2 velocity;

        protected Vector2 center;
        protected Vector2 origin;

        protected float rotation;

        protected Vector2 customPicSize = Vector2.Zero;
        #endregion

        public Vector2 Center
        {

            get { return center; }

        }
        public Vector2 Position
        {
            get { return position; }
        }        

        public Sprite(Texture2D tex, Vector2 pos)
        {
            texture = tex;
            
            position = pos;
            velocity = Vector2.Zero;
            
            center = new Vector2(position.X + texture.Width / 
                2, position.Y + texture.Height / 2);
            
            origin = new Vector2(texture.Width / 2, texture.Height / 2);            
        }
        public Sprite(Texture2D tex, Vector2 pos, Vector2 customPicSize)
        {
            texture = tex;

            position = pos;
            velocity = Vector2.Zero;

            center = new Vector2(position.X + customPicSize.X /
                2, position.Y + customPicSize.Y / 2);

            origin = new Vector2(customPicSize.X / 2, customPicSize.Y / 2);

            this.customPicSize = new Vector2(customPicSize.X, customPicSize.Y);
        }

        public virtual void Update(GameTime gameTime)
        {
            if (customPicSize == Vector2.Zero) this.center = new Vector2(position.X + texture.Width / 2,
                position.Y + texture.Height / 2);
            else this.center = new Vector2(position.X + customPicSize.X / 2,
                position.Y + customPicSize.Y / 2);
        }
        
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, center, null, Color.White,
                rotation, origin, 1.0f, SpriteEffects.None, 0);
        }

        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            spriteBatch.Draw(texture, center, null, color, rotation,
                origin, 1.0f, SpriteEffects.None, 0);
        }
    }
}
