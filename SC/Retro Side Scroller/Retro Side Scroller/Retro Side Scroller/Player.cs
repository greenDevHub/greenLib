using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Retro_Side_Scroller
{
    class Player
    {
        public Animation playerAnimation;
        public Vector2 position; // Position of the Player relative to the upper left side of the screen
        public bool active; // State of the player
        public int health;
        public int Width
        {
            get { return playerAnimation.frameWidth; }
        }
        public int Height
        {
            get { return playerAnimation.frameHeight; }
        }


        public void Initialize(Animation animation, Vector2 position)
        {
            playerAnimation = animation;
            this.position = position;
            active = true;
            health = 100;
        }

        public void Update(GameTime gameTime)
        {
            playerAnimation.position = position;
            playerAnimation.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            playerAnimation.Draw(spriteBatch);
        }
    }
}
