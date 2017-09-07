using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush.TowerType
{
    class FortCannonTower : Object
    {
        // Eine genau Liste alle Richtungen in die der Turm feuern kann
        private Vector2[] directions = new Vector2[8];

        // Listet alle Gegner auf die im Umkreis des Turms sind
        private List<Enemy> targets = new List<Enemy>();

        public override bool HasTarget
        {
            get
            {
                return false;
            }
        }

        public override int Cost
        {
            get
            {
                switch (Tier)
                {
                    case 0:
                        {
                            return 85;
                        }
                    case 1:
                        {
                            return 130;
                        }
                    case 2:
                        {
                            return 200;
                        }
                    case 3:
                        {
                            return 370;
                        }
                    default: return 0;
                }
            }
        }
        public override int MetalCost
        {
            get
            {
                switch (Tier)
                {
                    case 0:
                        {
                            return base.MetalCost;
                        }
                    case 1:
                        {
                            return base.MetalCost;
                        }
                    case 2:
                        {
                            return base.MetalCost;
                        }
                    case 3:
                        {
                            return base.MetalCost;
                        }
                    default: return 0;
                }
            }
        }
        public override int OilCost
        {
            get
            {
                switch (Tier)
                {
                    case 0:
                        {
                            return base.OilCost;
                        }
                    case 1:
                        {
                            return base.OilCost;
                        }
                    case 2:
                        {
                            return base.OilCost;
                        }
                    case 3:
                        {
                            return base.OilCost;
                        }
                    default: return 0;
                }
            }
        }
        /// <summary>
        /// Verbessert ein Turm
        /// </summary>
        public override void UpgradeObject()
        {
            if (Tier < 4)
            {
                damage = (int)(damage * 1.2f);
                radius = (radius * 1.1f);
                shootingSpeed = shootingSpeed * 1.0f;
            }
        }

        // Constructor
        /// <summary>
        /// Erstellt ein Festungs Kannonen Turm und Legt die Schussrichtungen
        /// des Turms fest (fest geschrieben)
        /// </summary>
        /// <param name="texture">Texture des Turms</param>
        /// <param name="bulletTexture">Texture der Kugel des Turms</param>
        /// <param name="position">Position des Turms</param>
        public FortCannonTower(Texture2D[] texture, Texture2D bulletTexture, Texture2D rangeBorderTexture, Texture2D headupDisplayTexture, ObjectTypeConfig objectTypeConfig, Vector2 position)
            : base(texture, bulletTexture, rangeBorderTexture, headupDisplayTexture, objectTypeConfig, position)
        {
            // Randzeichnung für Reichweite des Turms
            this.rangeBorder = new GUI.RangeBorder(rangeBorderTexture, radius, position);

            this.headupDisplay = new GUI.HeadupDisplay(headupDisplayTexture, position);

            // Speichert eine Liste alle Richtungen in die der Turm feuern kann
            directions = new Vector2[]
            {
                new Vector2(-1, -1),    // Nordwesten
                new Vector2(0, -1),     // Norden
                new Vector2(1, -1),     // Nordosten
                new Vector2(-1, 0),     // Westen
                new Vector2(1, 0),      // Osten
                new Vector2(-1, 1),     // Südwesten
                new Vector2(0, 1),     // Süden
                new Vector2(1, 1)       // Sündosten
            };
        }

        public override void GetClosestEnemy(List<Enemy> enemies)
        {
            // suche nach Ziele erneuern
            targets.Clear();

            // Schleife über alle Gegner
            foreach (Enemy enemy in enemies)
            {
                // Prüfen ob der Gegner in Schussreichweite ist
                if (IsInRange(enemy.Center))
                {
                    // Den Gegner zum Ziel machen der in Reichweite ist
                    targets.Add(enemy);
                }
            }
        }
        public override void Update(GameTime gameTime)
        {
            bulletTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Nur feuern wenn auch Gegner in Reichweite sind (min. 1 von 8)
            if (bulletTimer >= shootingSpeed && targets.Count != 0)
            {
                // Prüfen ob genug Enegy da ist um zu Feuern
                if (this.HasEnergy)
                {

                    for (int i = 0; i < directions.Length; i++)
                    {
                        // Erstellen einer Kugel die in Richtung des jeweiligen Gegners anlug nimmt
                        Bullet bullet = new Bullet(bulletTexture, Vector2.Subtract(center, new Vector2(bulletTexture.Width / 2)), directions[i], (int)bulletSpeed, damage);
                        bulletList.Add(bullet);
                    }
                }
                bulletTimer = 0;
            }

            // Schleife die durch alle Kugeln des Turms geht die sich auf dem Spielfeld befinden
            for (int i = 0; i < bulletList.Count; i++)
            {
                Bullet bullet = bulletList[i];
                bullet.Update(gameTime);

                // Enfernen der Kugel wenn sie außerhab der Reichweite ist
                if (!IsInRange(bullet.Center)) bullet.Kill();

                // Schleife durch alle möglichen Ziele des Turms
                for (int ii = 0; ii < targets.Count; ii++)
                {
                    // Wenn diese Kugel ein Ziel trifft was in Reichweite ist
                    if (targets[ii] != null && Vector2.Distance(bullet.Center, targets[ii].Center) < 12)
                    {
                        // Schaden an Gegner weiter geben
                        targets[ii].CurrentHealth -= RealDamage(bullet.target);

                        // Nun wird auch Schaden zugefügt bei allen Gegnerm im Umkreis falls Fläschenschaden
                        if (HasSplitDamage) HitClosestEnemy(bullet);

                        if (!HasUnstoppableBullet) bullet.Kill();

                        // Diese Kugel soll niemanden anders töten deswegen aus Schleife raus
                        break;
                    }
                }

                // Entfernen der Kugel wenn diese Tot ist
                if (bullet.IsDead())
                {
                    bulletList.Remove(bullet);
                    i--;
                }
            }
        }


    }
}
