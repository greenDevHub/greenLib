using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush.TowerType
{
    public class CannonTower : Object
    {
        public override bool HasEnergy
        {
            get
            {
                return true;
            }
            set
            {
                base.HasEnergy = value;
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
                            return base.Cost;
                        }
                    case 1:
                        {
                            return 70;
                        }
                    case 2:
                        {
                            return 100;
                        }
                    case 3:
                        {
                            return 170;
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
                damage = (int)(damage * 1.3f);
                radius = (radius * 1.2f);
                shootingSpeed = shootingSpeed * 0.8f;
            }
            if (Tier >= 2)
            {
                UsePercingShell = true;
                PercingShellPercent = 0.1f;
            }
            // Hotfix für Double Layer
            textureType = TextureType.Single; // Achtung ist nur wirklich nur Hotfik bis die Grafik hinzugefügt wurden ist wie in #1
        }

        public CannonTower(Texture2D[] texture, Texture2D bulletTexture, Texture2D rangeBorderTexture, Texture2D headupDisplayTexture, ObjectTypeConfig objectTypeConfig, Vector2 position)
            : base(texture, bulletTexture, rangeBorderTexture, headupDisplayTexture, objectTypeConfig, position)
        {
            // Randzeichnung für Reichweite des Turms
            this.rangeBorder = new GUI.RangeBorder(rangeBorderTexture, radius, position);
            this.headupDisplay = new GUI.HeadupDisplay(headupDisplayTexture, position);
        }
        
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // Prüfen wann eine Kugel abgefeuert wird
            if (bulletTimer >= shootingSpeed && target != null)
            {
                // Prüfen ob genug Enegy da ist um zu Feuern
                if (this.HasEnergy)
                {
                    Bullet bullet = new Bullet(bulletTexture, Vector2.Subtract(center, new Vector2(bulletTexture.Width / 2)), rotation, (int)bulletSpeed, damage, target, this);
                    if (UsePercingShell) bullet.ArmorIgnore = PercingShellPercent;
                    bulletList.Add(bullet);
                }
                bulletTimer = 0;                
            }

            // Alle Kugeln im Spiel werden Überprüft und wenn nötig "Umgelenkt zu der neuen Position des Gegners
            for (int i = 0; i < bulletList.Count; i++)
            {
                Bullet bullet = bulletList[i];

                if (!HasUnstoppableBullet) if (bullet.target.IsDead) bullet.Kill(); // Wenn das Ziel auf das die Kugel Abgeschossen wurden ist tot ist ist die Kugel auch tot

                //bullet.SetRotation(rotation); // Diese Funktion ist besser da nun die Kugel nur noch zum eigentlich Ziel umgelenkt wird
                Vector2 direction = center - bullet.target.Center;
                direction.Normalize();
                bullet.SetRotation((float)Math.Atan2(-direction.X, direction.Y));

                bullet.Update(gameTime);

                // Prüfen ob eine Kugel noch in Reichweite des Turms is wenn nicht dann diese Aus dem Spiel entfernen (optional)
                if (!IsInRange(bullet.Center)) bullet.Kill();

                // Falls die Entfernung von Kugel zu Ziel weniger wie 12 ist dann Kugel aus dem Siel enfernen und dem Gegner HP abziehen
                if (bullet.target != null && Vector2.Distance(bullet.Center, bullet.target.Center) < 12)
                {
                    //bullet.target.CurrentHealth -= bullet.Damage;
                    bullet.target.CurrentHealth -= RealDamage(bullet.target);

                    // Nun wird auch Schaden zugefügt bei allen Gegnerm im Umkreis falls Fläschenschaden
                    if (HasSplitDamage) HitClosestEnemy(bullet);

                    if (!HasUnstoppableBullet) bullet.Kill();
                }
                
                // Wenn die Kugel "Tot" ist dann diese aus der BulletList enfernen
                if (bullet.IsDead())
                {
                    bulletList.Remove(bullet);
                    i--;
                }
            }
        }
    }
}
