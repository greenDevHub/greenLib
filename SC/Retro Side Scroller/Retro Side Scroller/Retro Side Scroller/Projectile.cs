using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Retro_Side_Scroller
{
    class Projectile
    {

        // Image representing the Projectile
        public Texture2D texture;

        // Position of the Projectile relative to the upper left side of the screen
        public Vector2 position;

        // State of the Projectile
        public bool active;

        // The amount of damage the projectile can inflict to an enemy
        public int damage;

        // Represents the viewable boundary of the game
        Viewport viewport;

        // Get the width of the projectile ship
        public int Width
        {
            get { return texture.Width; }
        }

        // Get the height of the projectile ship
        public int Height
        {
            get { return texture.Height; }
        }

        // Determines how fast the projectile moves
        float projectileMoveSpeed;


        public void Initialize(Viewport viewport, Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
            this.viewport = viewport;

            active = true;

            damage = 2;

            projectileMoveSpeed = 20f;
        }
        public void Update()
        {
            // Projectiles always move to the right
            position.X += projectileMoveSpeed;

            // Deactivate the bullet if it goes out of screen
            if (position.X + texture.Width / 2 > viewport.Width)
                active = false;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, null, Color.White, 0f,
            new Vector2(Width / 2, Height / 2), 1f, SpriteEffects.None, 0f);
        }
    }
}
