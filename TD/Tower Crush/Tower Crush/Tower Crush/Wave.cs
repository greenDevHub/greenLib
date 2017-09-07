using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush
{
    class Wave
    {
        private int numOfEnemies; // Anzahl der gegener die auftauchen
        private int waveNumber; // Welche Welle ist das?
        private float spawnTimer = 0; // Wann soll genau eine Welle das Spielfeld betreten
        private int enemiesSpawned = 0; // Wie viele der Gegner schon in dieser Welle gestartet sind

        private bool enemyAtEnd; // Hat ein Gegner das Ende erreicht?
        private bool spawningEnemies; //sind wir gerade dabei Gegner auf das Spielfeld zu bringen
        private Level level; // Eine Referenz zu dem Level
        private Texture2D[] enemyTexture; // Eine Texture für die Gegner dieser Welle
        public List<Enemy> enemies = new List<Enemy>(); // Die Liste der Gegner
        private List<EnemyType> enemyNeedToSpawn = new List<EnemyType>(); // Liste der Gegner mit Namen die in dieser Welle erscheinen Sollen

        private Player player; // Referenz zu Spielerklasse

        private Texture2D healthTexture; // Grafik in der das Leben angezeigt wird

        public bool RoundOver
        {
            get
            {
                // Gegner in der Liste 0 UND Gegner sind nicht mehr am bertreten des Spielfeldes (0) gleich anzahl der Gegner auf dem Spielfeld
                return enemies.Count == 0 && enemiesSpawned == numOfEnemies;
            }
        }
        public int RoundNumber
        {
            get { return waveNumber; }
        }
        public bool EnemyAtEnd
        {
            get { return enemyAtEnd; }
            set { enemyAtEnd = value; }
        }

        public List<Enemy> Enemies
        {
            get { return enemies; }
        }

        // Constructor
        /// <summary>
        /// Erstellen einer Gegnerwelle
        /// </summary>
        /// <param name="waveNumber">Nummer der Welle</param>
        /// <param name="numOfEnemies">Anzahl der Gegner in der Welle</param>
        /// <param name="level">das Level auf dem die Gegner plaziert werden</param>
        /// <param name="enemyTexture">Texture der Gegner in dieser Welle</param>
        public Wave(int waveNumber, int numOfEnemies, Player player, Level level, Texture2D[] enemyTexture, Texture2D healthTexture)
        {
            this.waveNumber = waveNumber;
            this.numOfEnemies = numOfEnemies;

            this.player = player; //Referenz zu SPieler
            this.level = level;

            this.enemyTexture = enemyTexture;

            this.healthTexture = healthTexture; // Grafik für Lebensanzeige
        }

        // Construktor 2
        public Wave(int waveNumber, List<EnemyType> enemyNeedToSpawn, Player player, Level level, Texture2D[] enemyTexture, Texture2D healthTexture)
        {
            this.waveNumber = waveNumber;
            this.numOfEnemies = enemyNeedToSpawn.Count();

            this.player = player; //Referenz zu SPieler
            this.level = level;

            this.enemyTexture = enemyTexture;

            this.healthTexture = healthTexture; // Grafik für Lebensanzeige

            this.enemyNeedToSpawn = enemyNeedToSpawn;
        }

        private Enemy AddRightEnemy
        {
            get
            {
                if (enemyNeedToSpawn.Count() > 0)
                {
                    switch (enemyNeedToSpawn[0])
                    {
                        case EnemyType.Creeper:
                            {
                                Enemy enemy = new EnemyStorage.Creeper(enemyTexture[3], level.Waypoints.Peek(), 45, 0.5f, 0.2f);
                                enemyNeedToSpawn.Remove(enemyNeedToSpawn[0]);
                                return enemy;
                            }
                        case EnemyType.Speeder:
                            {
                                Enemy enemy = new EnemyStorage.Speeder(enemyTexture[4], level.Waypoints.Peek(), 16, 1.2f, 0.2f);
                                enemyNeedToSpawn.Remove(enemyNeedToSpawn[0]);
                                return enemy;
                            }
                        case EnemyType.Boss:
                            {
                                Enemy enemy = new EnemyStorage.Boss(enemyTexture[1], level.Waypoints.Peek(), 150, 0.4f, 0.1f);
                                enemyNeedToSpawn.Remove(enemyNeedToSpawn[0]);
                                return enemy;
                            }
                        case EnemyType.BigCreeper:
                            {
                                Enemy enemy = new EnemyStorage.BigCreeper(enemyTexture[0], level.Waypoints.Peek(), 150, 0.45f, 0.15f);
                                enemyNeedToSpawn.Remove(enemyNeedToSpawn[0]);
                                return enemy;
                            }
                        case EnemyType.Walker:
                            {
                                Enemy enemy = new EnemyStorage.Walker(enemyTexture[0], level.Waypoints.Peek(), 230, 0.7f, 0.17f);
                                enemyNeedToSpawn.Remove(enemyNeedToSpawn[0]);
                                return enemy;
                            }
                        case EnemyType.Scout:
                            {
                                Enemy enemy = new EnemyStorage.Scout(enemyTexture[0], level.Waypoints.Peek(), 150, 1f, 0.15f);
                                enemyNeedToSpawn.Remove(enemyNeedToSpawn[0]);
                                return enemy;
                            }
                        case EnemyType.Heavy:
                            {
                                Enemy enemy = new EnemyStorage.Heavy(enemyTexture[2], level.Waypoints.Peek(), 550, 0.6f, 0.1f);
                                enemyNeedToSpawn.Remove(enemyNeedToSpawn[0]);
                                return enemy;
                            }
                        case EnemyType.Protector:
                            {
                                Enemy enemy = new EnemyStorage.Protector(enemyTexture[0], level.Waypoints.Peek(), 1000, 0.6f, 0.1f);
                                enemyNeedToSpawn.Remove(enemyNeedToSpawn[0]);
                                return enemy;
                            }
                    }
                }

                return null;
            }
        }

        /// <summary>
        /// Fügt ein Gegner zu der Liste der Gegner in einer Welle hinzu
        /// </summary>
        private void AddEnemy(GameTime gameTime)
        {
            // Spawnen der Gegner
            if (spawningEnemies)
            {
                spawnTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (spawnTimer > 1f) // Hier in der 2 Noch ein Goßes Problem da sonst alle Gegner zur gleichen Zeit Spawnen
                {
                    Enemy enemy = AddRightEnemy;

                    enemy.SetWaypoints(level.Waypoints);
                    enemies.Add(enemy);
                    enemiesSpawned++;

                    spawnTimer = 0;
                }
            }
            //Enemy enemy = new Enemy(enemyTexture, level.Waypoints.Peek(), 25 + (waveNumber * 3), 5, 0.5f + (waveNumber / 100) );            
        }

        /// <summary>
        /// Startet eine Welle
        /// </summary>
        public void Start()
        {
            spawningEnemies = true;
            player.WaveFinished += 1;
        }

        /// <summary>
        /// Updatet eine Welle sowie erstellt dabei neue Gegner auf 
        /// der Map aus der Welle. Hier wird auch gleich geprüft ob
        /// Gegner am Ende angekommen sind oder einfach getötet werden
        /// dann werden diese aus dem Spiel enfernt.
        /// </summary>
        /// <param name="gameTime">GameTime</param>
        public void Update(GameTime gameTime)
        {
            if (enemiesSpawned == numOfEnemies) spawningEnemies = false; // Wir haben genug Gegner Erzeugt

            // Spawnen der Gegner
            AddEnemy(gameTime);

            for (int i = 0; i < enemies.Count; i++)
            {
                Enemy enemy = enemies[i];
                enemy.Update(gameTime);
                if (enemy.IsDead) // Gegner wurde als Tot gekennzeichnet hat aber noch HP bedeutet er ist am Ende angekommen
                {
                    if (enemy.CurrentHealth > 0) // Gegner ist am Ende angekommen 
                    {
                        enemyAtEnd = true;
                        player.Lives -= 1;
                    }
                    else
                    {
                        player.Money += enemy.BountyGiven;
                    }
                    enemies.Remove(enemy);
                    i--;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.Draw(spriteBatch);

                // Brechnung der Position auf der X Achse falls Lebensanzeige gleiner ist als 32x32
                float xPosition = 0;
                if (healthTexture.Width != 32 && healthTexture.Width < enemyTexture[0].Width)
                {
                    xPosition = enemy.Position.X + ((enemyTexture[0].Width - healthTexture.Width) / 2);
                }
                else xPosition = enemy.Position.X;

                // Zeichnen der Lebensanzeige (Hintergrund)
                Rectangle healthRectangle = new Rectangle((int)xPosition, (int)enemy.Position.Y -4,
                    healthTexture.Width, healthTexture.Height);
                //spriteBatch.Draw(healthTexture, healthRectangle, Color.Gray);

                // Zeichnen vom Übrigen Leben des Gegners
                float healthPercentage = enemy.HealthPercentage;
                float visibleWidth = (float)healthTexture.Width * healthPercentage;

                healthRectangle = new Rectangle((int)xPosition, (int)enemy.Position.Y - 4,
                    (int)(visibleWidth), healthTexture.Height);

                // Festlegen der Farbe für die Lebensanzeige
                float red = (healthPercentage < 0.5 ? 1 : 1 - (2 * healthPercentage - 1));
                float green = (healthPercentage > 0.5 ? 1 : (2 * healthPercentage));

                Color healthColor = new Color(red, green, 0);
                spriteBatch.Draw(healthTexture, healthRectangle, healthColor);
            }
        }
    }
}
