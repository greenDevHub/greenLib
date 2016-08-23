using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Retro_Side_Scroller
{
    class Enemy
    {
        // Animation representing the enemy
        public Animation enemyAnimation;

        // The position of the enemy ship relative to the top left corner of thescreen
        public Vector2 position;

        // The state of the Enemy Ship
        public bool active;

        // The hit points of the enemy, if this goes to zero the enemy dies
        public int health;

        // The amount of damage the enemy inflicts on the player ship
        public int damage;

        // The amount of score the enemy will give to the player
        public int value;

        // Get the width of the enemy ship
        public int Width
        {
            get { return enemyAnimation.frameWidth; }
        }

        // Get the height of the enemy ship
        public int Height
        {
            get { return enemyAnimation.frameHeight; }
        }

        // The speed at which the enemy moves
        float enemyMoveSpeed;

        public void Initialize(Animation animation, Vector2 position)
        {
            // Load the enemy ship texture
            enemyAnimation = animation;

            // Set the position of the enemy
            this.position = position;

            // We initialize the enemy to be active so it will be update in the game
            active = true;


            // Set the health of the enemy
            health = 10;

            // Set the amount of damage the enemy can do
            damage = 10;

            // Set how fast the enemy moves
            enemyMoveSpeed = 6f;


            // Set the score value of the enemy
            value = 100;

        }

        public void Update(GameTime gameTime)
        {
            // The enemy always moves to the left so decrement it's xposition
            position.X -= enemyMoveSpeed;

            // Update the position of the Animation
            enemyAnimation.position = position;

            // Update Animation
            enemyAnimation.Update(gameTime);

            // If the enemy is past the screen or its health reaches 0 then deactivateit
            if (position.X < -Width || health <= 0)
            {
                // By setting the Active flag to false, the game will remove this objet fromthe
                // active game list
                active = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            enemyAnimation.Draw(spriteBatch);
        }

    }
}
