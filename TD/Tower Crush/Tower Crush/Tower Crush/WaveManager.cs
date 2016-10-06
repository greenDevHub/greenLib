using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush
{
    class WaveManager
    {
        Pathfinder pathfinder;

        private int numberOfWaves; // Wie viele Wellen hat das Spiel
        private int currentWave; // Gibt die aktuelle Welle wieder
        private float timeSinceLastWave; // Wie viel Zeit ist vergangen seit der Welle davor

        private Queue<Wave> waves = new Queue<Wave>(); // Eine Queue (liste nur anders rum) für alle Welle die das Spiel haben soll

        private Texture2D[] enemyTexture; // Die Texture die für die Gegner verwendet werden soll

        private bool waveFinished = false; // Ist die aktuelle Welle vorbei bzw. abgeschlossen?

        private Level level; // Die Referenz zu unserem Level

        /// <summary>
        /// Gibt die Welle in der ersten Position der Queue wieder
        /// </summary>
        public Wave CurrentWave // Gibt die Welle in der ersten Position der Queue wieder
        {
            get { return waves.Peek(); }
        }
        /// <summary>
        /// Liste alle aktuellen Gegner in der aktuellen Welle
        /// </summary>
        public List<Enemy> Enemies // Liste alle aktuellen Gegner in der aktuellen Welle
        {
            get { return CurrentWave.Enemies; }
        }
        /// <summary>
        /// Gibt die aktuelle Rundenummer wieder
        /// </summary>
        public int Round // Gibt die aktuelle Rundenummer wieder
        {
            get { return CurrentWave.RoundNumber + 1; }
        }

        private List<EnemyType> EnemyNeedToSpawn
        {
            get
            {
                List<EnemyType> enemyNeedToSpawn = new List<EnemyType>();

                switch (currentWave)
                {
                    case 0:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            return enemyNeedToSpawn;
                        }
                    case 1:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            return enemyNeedToSpawn;
                        }
                    case 2:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            return enemyNeedToSpawn;
                        }
                    case 3:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            return enemyNeedToSpawn;
                        }
                    case 4:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            return enemyNeedToSpawn;
                        }
                    case 5:
                        {                            
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            return enemyNeedToSpawn;
                        }
                    case 6:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            return enemyNeedToSpawn;
                        }
                    case 7:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            return enemyNeedToSpawn;
                        }
                    case 8:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            return enemyNeedToSpawn;
                        }
                    case 9:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Boss);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.Boss);                            
                            return enemyNeedToSpawn;
                        }
                    case 10:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Speeder);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.Creeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.Boss);
                            enemyNeedToSpawn.Add(EnemyType.Boss);
                            return enemyNeedToSpawn;
                        }
                    case 11:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            return enemyNeedToSpawn;
                        }
                    case 12:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            return enemyNeedToSpawn;
                        }
                    case 13:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            return enemyNeedToSpawn;
                        }
                    case 14:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Heavy);
                            enemyNeedToSpawn.Add(EnemyType.Heavy);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Heavy);
                            enemyNeedToSpawn.Add(EnemyType.Heavy);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            return enemyNeedToSpawn;
                        }
                    case 15:
                        {
                            enemyNeedToSpawn.Add(EnemyType.Protector);
                            enemyNeedToSpawn.Add(EnemyType.Protector);
                            enemyNeedToSpawn.Add(EnemyType.Heavy);
                            enemyNeedToSpawn.Add(EnemyType.Heavy);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Walker);
                            enemyNeedToSpawn.Add(EnemyType.Heavy);
                            enemyNeedToSpawn.Add(EnemyType.Heavy);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.Scout);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.BigCreeper);
                            enemyNeedToSpawn.Add(EnemyType.Protector);
                            enemyNeedToSpawn.Add(EnemyType.Protector);
                            enemyNeedToSpawn.Add(EnemyType.Heavy);
                            enemyNeedToSpawn.Add(EnemyType.Heavy);
                            return enemyNeedToSpawn;
                        }
                }

                return enemyNeedToSpawn;
            }
        }

        // Constructor
        public WaveManager(Player player, Level level, int numberOfWaves, Texture2D[] enemyTexture, Texture2D healthTexture)
        {
            this.numberOfWaves = numberOfWaves;
            this.enemyTexture = enemyTexture;


            ///////////////////////////
            // A * Pathfinding System//
            ///////////////////////////
            this.level = level;                        
            pathfinder = new Pathfinder(this.level);
            List<Vector2> path = pathfinder.FindPath(new Point(0, 1), new Point(17, 12));
            foreach (Vector2 point in path)
            {
                Vector2 normalizePoint = new Vector2(point.X + 32, point.Y + 32); // @@

                level.Waypoints.Enqueue(normalizePoint);
                System.Diagnostics.Debug.WriteLine(normalizePoint);
            }



            for (currentWave = 0; currentWave < numberOfWaves; currentWave++)
            {
                // Liste der Gegner mit Namen die in dieser Welle erscheinen Sollen
                List<EnemyType> enemyNeedToSpawn = new List<EnemyType>();

                enemyNeedToSpawn = EnemyNeedToSpawn;

                Wave wave = new Wave(currentWave, enemyNeedToSpawn, player, level, enemyTexture, healthTexture);

                waves.Enqueue(wave);
            }

            StartNextWave();
        }

        private void StartNextWave()
        {
            if (waves.Count > 0) // Wenn es noch Wellen abzuarbeiten gibt
            {
                waves.Peek().Start(); // Startet die nächste Welle

                timeSinceLastWave = 0;
                waveFinished = false;
            }
        }

        public void Update(GameTime gameTime)
        {
            CurrentWave.Update(gameTime); // Welle wird Upgedatet

            if (CurrentWave.RoundOver) // Prüfen ob die Runde vorbei ist
            {
                waveFinished = true;
            }

            if (waveFinished) // Wenn Runde zu Ende
            {
                timeSinceLastWave += (float)gameTime.ElapsedGameTime.TotalSeconds; // Startet den Timer für eine Welle
            }

            if (timeSinceLastWave > 5.0f) // Wenn 30 Secunden vorbei sind
            {
                waves.Dequeue(); // Die Zerstörte Welle wird entfernt
                StartNextWave(); // Start der nächsten Welle
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            CurrentWave.Draw(spriteBatch);
        }
    }
}
