using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush
{
    public enum EnemyType
    {
        Creeper,
        BigCreeper,
        Speeder,
        Boss,
        Walker,
        Scout,
        Heavy,
        Protector
    }
    public class Enemy : Sprite
    {
        #region Variablen
        protected EnemyType enemyType; // Typ des Gegners
        protected float startHealth;
        protected float currentHealth;

        protected bool alive = true;

        protected float speed = 0.5f;

        protected int bountyGiven;

        // Slow
        private float speedModifier; // Speichert die neue Geschwindigkeit des Gegners wenn er Verlangsamt ist
        private float modifierDuration; // Maximaldauer des Effekts
        private float modifierCurrentTime; // Dauer wie lang bisher der Effekt angehalten hat

        private Queue<Vector2> waypoints = new Queue<Vector2>();

        #region Manipulatoren
        #region Armor
        /// <summary>
        /// Panzerungs an sich
        /// </summary>
        protected float armor;                  // Panzerungs an sich
        /// <summary>
        /// Gibt den Panzerungswert wieder den der Gegner hat
        /// </summary>
        public float Armor
        {
            get { return armor; }
        }
        /// <summary>
        /// Panzerungsmenge Wenn die Verbraucht ist kommt voller Schaden durch
        /// </summary>
        protected float armorValue;             // Panzerungsmenge Wenn die Verbraucht ist kommt voller Schaden durch
        /// <summary>
        /// Gibt den Panzerungswert wieder wenn verbraucht kommt voller Schaden durch
        /// </summary>
        public float ArmorValue
        {
            get { return armorValue; }
            set { armorValue = value; }
        }
        /// <summary>
        /// Der Wert um den die Panzerung Manipuliert werden kann (z.B. durch Forschung)
        /// </summary>
        protected float armorManipulation = 1.0f;      // Der Wert um den die Panzerung Manipuliert werden kann (z.B. durch Forschung)
        /// <summary>
        /// Der Wert um den die Panzerung Manipuliert werden kann (z.B. durch Forschung)
        /// </summary>
        public float ArmorManipulation
        {
            get { return armorManipulation; }
        }
        #endregion

        #region Shield
        /// <summary>
        /// Schild an sich
        /// </summary>
        protected float shield;                // Schild an sich
        /// <summary>
        /// Gibt den Schildwert wieder den der Gegner hat
        /// </summary>
        public float Shield
        {
            get { return shield; }
        }
        /// <summary>
        /// Schildmenge Wenn die Verbraucht ist kommt voller Schaden durch
        /// </summary>
        protected float shieldValue;           // Schildmenge Wenn die Verbraucht ist kommt voller Schaden durch
        /// <summary>
        /// Gibt den Schildwert wieder wenn verbraucht kommt voller Schaden durch
        /// </summary>
        public float ShieldValue
        {
            get { return shieldValue; }
            set { shieldValue = value; }
        }
        /// <summary>
        /// Der Wert um den das Schild Manipuliert werden kann (z.B. durch Forschung)
        /// </summary>
        protected float shieldManipulation = 1.0f;    // Der Wert um den das Schild Manipuliert werden kann (z.B. durch Forschung)
        /// <summary>
        /// Der Wert um den das Schild Manipuliert werden kann (z.B. durch Forschung)
        /// </summary>
        public float ShieldManipulation
        {
            get { return shieldManipulation; }
        }
        #endregion
        #endregion

        #endregion

        /// <summary>
        /// Verändert die Geschwindigkeit eines Gegners
        /// </summary>
        public float SpeedModifier
        {
            get { return speedModifier; }
            set { speedModifier = value; }
        }
        /// <summary>
        /// Bestimmt wie lang ein Gegner bzw. die Veränderung anhalten soll
        /// </summary>
        public float ModifierDuration
        {
            get { return modifierDuration; }
            set
            {
                modifierDuration = value;
                modifierCurrentTime = 0;
            }
        }

        public float CurrentHealth
        {
            get { return currentHealth; }
            set { currentHealth = value; }
        }
        /// <summary>
        /// Gibt den Lebenswert ins % zurück
        /// </summary>
        public float HealthPercentage
        {
            get { return currentHealth / startHealth; }
        }
        public bool IsDead
        {
            get { return !alive; }
        }
        public int BountyGiven
        {
            get { return bountyGiven; }
        }

        // Construktor 1
        public Enemy(Texture2D texture, Vector2 position, float health, int bountyGiven, float speed) : base(texture, position)
        {

            this.startHealth = health;
            this.currentHealth = startHealth;
            this.bountyGiven = bountyGiven;
            this.speed = speed;

        }

        // Construktor 2
        /// <summary>
        /// Erstellt ein Gegner auf dem Spielfeld
        /// </summary>
        /// <param name="texture">Texture des Gegners</param>
        /// <param name="position">Position wo der Gegner erstellt werden soll</param>
        /// <param name="health">HP des Gegners</param>
        /// <param name="bountyGiven">Belohnung für die Tötung dieses Gegners</param>
        /// <param name="speed">Geschwindigkeit des Gegners</param>
        /// <param name="armor">Rüstung des Gegners</param>
        /// <param name="armorValue">Panzerungswert</param>
        /// <param name="armorManipulation">Panzermanipulationswert</param>
        /// <param name="schield">Schild des Gegners</param>
        /// <param name="schieldValue">Schildwert</param>
        /// <param name="schieldManipulation">Schildmanipulationswert</param>
        /// <param name="enemyType">Typ des Gegners</param>
        public Enemy(Texture2D texture, Vector2 position, float health, int bountyGiven, float speed,
            float armor, float armorValue, float armorManipulation,
            float schield, float schieldValue, float schieldManipulation, 
            EnemyType enemyType)
            : base(texture, position)
        {
            this.startHealth = health;
            this.currentHealth = startHealth;
            this.bountyGiven = bountyGiven;
            this.speed = speed;
        }

        // Constructor 3
        public Enemy(Texture2D texture, Vector2 position, int health, float speed, float bountyToHealth)
            : base(texture, position)
        {
            this.currentHealth = health;
            this.startHealth = this.currentHealth;

            this.bountyGiven = (int)(this.currentHealth * bountyToHealth);

            this.speed = speed;
        }


        public void SetWaypoints(Queue<Vector2> waypoints)
        {
            foreach (Vector2 waypoint in waypoints)
                this.waypoints.Enqueue(waypoint);

            this.position = this.waypoints.Dequeue();
        }

        public float DistanceToDestination
        {
            get { return Vector2.Distance(position, waypoints.Peek()); }
        }


        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (currentHealth <= 0)
            {
                alive = false;
            }

            if (waypoints.Count > 0)
            {
                if (DistanceToDestination < speed)
                {
                    position = waypoints.Peek();
                    waypoints.Dequeue();
                }
                else
                {
                    Vector2 direction = waypoints.Peek() - position;
                    direction.Normalize();
                    FaceWayPoint(); // Das "Gesicht" des Gegners muss immer auf seine Laufrichtung Zeigen

                    // Slow Effekt wird hier eingebaut
                    float temporarySpeed = speed; // Speichert die Original Geschwindigkeit des Gegners

                    // Prüft ob der Veränderung ausgelaufen ist (Zeit um)
                    if (modifierCurrentTime > modifierDuration)
                    {
                        // Zurücksetzen der Veränderung
                        speedModifier = 0;
                        modifierCurrentTime = 0;
                    }

                    if (speedModifier != 0 && modifierCurrentTime < modifierDuration)
                    {
                        // Verändern die Geschwindigkeit des Gegners
                        temporarySpeed *= speedModifier;
                        // Timer für die Veränderung wird aktuallisiert
                        modifierCurrentTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
                    }

                    velocity = Vector2.Multiply(direction, temporarySpeed);

                    position += velocity;
                }
            }
            else alive = false;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (alive)
            {
                // Nur auskomentiren wenn der Fabwechsel am Gegner erfolgen soll
                //float healthPercentage = (float)currentHealth / (float)startHealth;
                //Color color = new Color(new Vector3(1 - healthPercentage, 1 - healthPercentage, 1 - healthPercentage));
                base.Draw(spriteBatch, Color.White); // Wenn Transparent dann auf Color:White einstellen
            }
        }

        /// <summary>
        /// Sorgt dafür das die Ausrichtung des Gegners immer in
        /// die Laufrichtung zeigt
        /// </summary>
        protected void FaceWayPoint()
        {
            Sprite nexWaypoint = new Sprite(texture, waypoints.Peek());

            Vector2 direction = center - nexWaypoint.Center;
            direction.Normalize();

            rotation = (float)Math.Atan2(-direction.X, direction.Y);
        }
    }
}
