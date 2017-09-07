using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Tower_Crush
{
    public class Bullet : Sprite
    {
        public Enemy target; // Das Ziel auf das die Kugel Programmiert wurde
        public Object tower; // Der Turm von dem die Kugel erstellt wurde
        private int damage;
        private int age;

        private int speed;

        private bool longBullet = false; // Gibt ab ob die Kugel "langgezogen" werden soll laserstrahl und so

        private float armorIgnoreValue = 1.0f; // Gibt an wie viel von der Rüstung aus der Schadensberechnung ausgeschlossen wird

        /// <summary>
        /// Gibt den Schaden einer Kugel an
        /// </summary>
        public int Damage
        {
            get { return damage; }
        }
        /// <summary>
        /// Gibt an ob eine Kugel "verstorben" ist also nicht mehr 
        /// im Spiel sich befindet. Das passiert wenn das Alter der Kugel
        /// überschritten wird.
        /// </summary>
        /// <returns></returns>
        public bool IsDead()
        {
            return age > 100;
        }
        /// <summary>
        /// Macht die Kugel zu einer "langen" Kugel z.B. 
        /// für Laserstrahlen
        /// </summary>
        public bool IsLongBullet
        {
            set { longBullet = value; }
        }

        public float ArmorIgnore
        {
            get { return armorIgnoreValue; }
            set { armorIgnoreValue = value; }
        }

        // Constructor
        /// <summary>
        /// Erstell eine Kugel auf dem Spielfeld
        /// </summary>
        /// <param name="texture">Texture der Kugel</param>
        /// <param name="position">Position der Kugel</param>
        /// <param name="rotation">Rotation der Kugel</param>
        /// <param name="speed">Geschwindigkeit der Kugel</param>
        /// <param name="damage">Schaden der Kugel am Gegner</param>
        public Bullet(Texture2D texture, Vector2 position, float rotation, int speed, int damage, Enemy target, Object tower)
            : base(texture, position)
        {
            this.rotation = rotation;
            this.damage = damage;

            this.target = target;
            this.tower = tower;

            this.speed = speed;
        }
        // Constructor 2
        /// <summary>
        /// Erstell eine Kugel auf dem Spielfeld
        /// </summary>
        /// <param name="texture">Texture der Kugel</param>
        /// <param name="position">Position der Kugel</param>
        /// <param name="velocity">Potenzial</param>
        /// <param name="speed">Geschwindigkeit der Kugel</param>
        /// <param name="damage">Schaden der Kugel am Gegner</param>
        public Bullet(Texture2D texture, Vector2 positon, Vector2 velocity, int speed, int damage)
            : base(texture, positon)
        {
            this.rotation = rotation;
            this.damage = damage;

            this.speed = speed;

            this.velocity = velocity * speed;
        }

        public void Kill()
        {
            this.age = 200;
        }

        public override void Update(GameTime gameTime)
        {
            age++;
            position += velocity;

            base.Update(gameTime);
        }

        /// <summary>
        /// Stellt die Rotaion einer Kugel ein so das sie immer
        /// auf den Gegner bzw auf ihr Ziel zeigt
        /// </summary>
        /// <param name="value">value</param>
        public void SetRotation(float value)
        {
            rotation = value;
            velocity = Vector2.Transform(new Vector2(0, -speed), Matrix.CreateRotationZ(rotation));
        }

        /// <summary>
        /// Zeichnet eine Linie die als ein Laserstrahl wirken soll
        /// </summary>
        /// <param name="startPos">Position des Turms</param>
        /// <param name="endPos">Position des Gegners oder der Kugel</param>
        /// <param name="thin">Wie "dick" ist der Laserstrahl</param>
        /// <param name="color">Welche Farbe hat er</param>
        /// <param name="spriteBatch"></param>
        private void DrawLine(Vector2 startPos, Vector2 endPos, int thin, Color color, SpriteBatch spriteBatch)
        {
            float angel = (float)Math.Atan2(startPos.Y - endPos.Y, startPos.X - endPos.X);
            float distance = Vector2.Distance(startPos, endPos);

            distance -= 16;

            spriteBatch.Draw(texture, new Rectangle((int)endPos.X, (int)endPos.Y, (int)distance, thin), null, color, angel, Vector2.Zero, SpriteEffects.None, 0);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (longBullet) DrawLine(tower.Center, this.Center, 4, Color.White, spriteBatch);
            else base.Draw(spriteBatch);
        }
    }
}
