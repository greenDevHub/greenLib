using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush
{
    public class Tower_ : Sprite
    {
        protected int cost; // // Goldkosten
        protected int oilCost; // Ölkosten
        protected int metalCost; // Metallkosten
        protected int coreCost; // Kernkosten
        protected int enegyConsume; // Enegyverbrauch eines Turmes
        protected int damage; // Der Schaden den der Turm macht
        protected float radius; // In welchem Radius der Turm Schüsse abgeben kann
        protected float shootingSpeed; // Gibt an wie schnell der Turm schüsse abfeuern kann
        protected float bulletSpeed; // Gibt an wie schnell die Kugeln des Turms fliegen

        protected int tier = 0; // Stuffe des Turms

        protected bool isSelected = false;

        protected Enemy target;
        protected Enemy oldTarget;
        protected bool hasEnergy;

        protected bool hasSplitDamage = false; // Gibt an ob der Turm Flächenschade anrichten soll oder nicht
        protected int splitDamage; // der Flächenschaden an sich
        protected float slitRadius; // der Radiums in dem der Flächenschenschaden Passiert

        protected float slowSpeedModifier; //Slow (die neue Geschindigkeit des Gegners nach dem Verlangsamen)
        protected float slowModifierDuration; // Maximaldauer des Effekts

        protected bool hasLongBullet = false; // Gibt an ob die Kugel des Turms eine "Lange Kugel" hat also Laserstrahl z.B.

        protected bool hasUnstoppableBullet = false; // Zeigt an das die Kugel auch weiter fliegt wenn sie den Gegner getroffen oder zerstört hat

        protected Rectangle border; // Rahmen um ein Tower

        // Rahmen für den Kreis
        protected Texture2D rangeBorderTexture;
        protected GUI.RangeBorder rangeBorder;

        // Menü für Objekte
        protected Texture2D headupDisplayTexture;
        protected GUI.HeadupDisplay headupDisplay;

        protected Texture2D bulletTexture;        
        protected float bulletTimer; // Vor welcher Zeit die Kugel abgefeuert wurde
        protected List<Bullet> bulletList = new List<Bullet>();

        protected List<Enemy> enemies; // Liste alle Gegner auf dem Spielfeld

        protected Texture2D[] towerTexture; // Texturen aller Turmlevel

        private int frame;

        public Rectangle Border
        {
            set { border = value; }
            get { return border; }
        }
        /// <summary>
        /// Kosten des Turms in Gold
        /// </summary>
        public virtual int Cost
        {
            get { return cost; }
        }
        /// <summary>
        /// Kosten des Turms in Öl
        /// </summary>
        public virtual int OilCost
        {
            get { return oilCost; }
        }
        /// <summary>
        /// Kosten des Turms in Metall
        /// </summary>
        public virtual int MetalCost
        {
            get { return metalCost; }
        }
        /// <summary>
        /// Kosten des Turms in Kernen
        /// </summary>
        public int CoreCost
        {
            get { return coreCost; }
        }
        /// <summary>
        /// Enegerverbrauch eines Turmes
        /// </summary>
        public int EnergyConsume
        {
            get { return enegyConsume; }
        }
        public int Damage
        {
            get { return damage; }
        }
        public float Radius
        {
            get { return radius; }
        }
        /// <summary>
        /// Stuffe des Turms
        /// </summary>
        public int Tier
        {
            set { tier = value; }
            get { return tier; }
        }
        /// <summary>
        /// Gibt an ob der Turm ausgewählt wurde oder nicht
        /// </summary>
        public bool IsSelected
        {
            get { return isSelected; }
            set {isSelected = value;}
        }

        /// <summary>
        /// Gibt an ob der Tower Genug Enegy zu feuern Hat.
        /// Dieser Wert kann gesetzt und wiedergegeben werden.
        /// </summary>
        public virtual bool HasEnergy
        {
            get { return hasEnergy; }
            set { hasEnergy = value; }
        }
        /// <summary>
        /// Gibt an ob ein Turm Flächenschaden hat oder 
        /// eben nicht. 
        /// Dieser wert kann nur zurückgegeben werden
        /// </summary>
        public virtual bool HasSplitDamage
        {
            get { return hasSplitDamage; }
        }
        /// <summary>
        /// Gibt an ob die Kugel des Turms eine "Lange Kugel" 
        /// hat also Laserstrahl z.B.
        /// </summary>
        public virtual bool HasLongBullet
        {
            get { return hasLongBullet; }
        }
        /// <summary>
        /// Zeigt an das die Kugel auch weiter fliegt wenn sie 
        /// den Gegner getroffen oder zerstört hat
        /// </summary>
        public virtual bool HasUnstoppableBullet
        {
            get { return hasUnstoppableBullet; }
        }

        /// <summary>
        /// Verwaltet die Liste alle Gegner auf dem Spielfeld
        /// Dieser Wert kann nur gesetzt werden
        /// </summary>
        public List<Enemy> Enemies
        {
            set { enemies = value; }
        }

        public virtual bool HasTarget
        {
            // Prüft ob der Turm ein Ziel hat
            get { return target != null; }
        }        
        
        // Contructor
        public Tower(Texture2D[] texture, Texture2D bulletTexture, Texture2D rangeBorderTexture, Texture2D headupDisplayTexture, TowerTypeConfig towerTypeConfig, Vector2 position)
            : base(texture[0], position, new Vector2(C.BS, C.BS))
        {
            // Tower Einstellungen
            this.cost = towerTypeConfig.Cost; // Kosten
            this.oilCost = towerTypeConfig.OilCost;
            this.metalCost = towerTypeConfig.MetalCost;
            this.coreCost = towerTypeConfig.CoreCost;
            this.enegyConsume = towerTypeConfig.EnegyConsume;

            this.damage = towerTypeConfig.Damage; // Schaden
            this.radius = towerTypeConfig.Radius;
            this.shootingSpeed = towerTypeConfig.ShootingSpeed;
            this.bulletSpeed = towerTypeConfig.BulletSpeed;

            this.splitDamage = towerTypeConfig.SplitDamage; // Fläschenschaden
            this.slitRadius = towerTypeConfig.SplitRadius;

            this.slowSpeedModifier = towerTypeConfig.SlowSpeedModifier; // Slow
            this.slowModifierDuration = towerTypeConfig.SlowModifierDuration;
            
            // Tower Einstellunge ENDE

            this.bulletTexture = bulletTexture;
            this.rangeBorderTexture = rangeBorderTexture;
            this.headupDisplayTexture = headupDisplayTexture;

            this.border = new Rectangle((int)position.X, (int)position.Y, texture[tier].Width, texture[tier].Height);

            this.towerTexture = texture;
        }

        /// <summary>
        /// Gibt wieder ob ein Ziel in reichweite des Turms ist
        /// </summary>
        /// <param name="position">Position des Ziels</param>
        /// <returns>True or False</returns>
        public bool IsInRange(Vector2 position)
        {
            if (Vector2.Distance(center, position) <= radius) return true;
            return false;
        }
        /// <summary>
        /// Gibt ein Wert wieder ob ein gegner in Reichweite einer Explosion ist
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool IsInExplosion(Vector2 enemyPosition, Vector2 nextEnemyPosition)
        {
            if (Vector2.Distance(enemyPosition, nextEnemyPosition) <= slitRadius) return true;
            return false;
        }
        /// <summary>
        /// Bei Türmen mit Fläschenschaden wird
        /// ein oder mehrere Gegner getroffen die im Explosionsreichweite
        /// der Kugel sind
        /// </summary>
        /// <param name="bullet">die Kugel die den Gegner getroffen hat</param>
        public void HitClosestEnemy(Bullet bullet)
        {
            // Schleife durch die Gegner des Turms
            foreach (Enemy enemy in enemies)
            {
                // Prüfen ob in Explosionsreichweite
                if (IsInExplosion(bullet.target.Center, enemy.Center) && bullet.target != enemy)
                {
                    // Verlätzen des Gegners wenn in Reichweite
                    enemy.CurrentHealth -= this.splitDamage;
                }
            }
        }

        /// <summary>
        /// Gibt das aktuelle Ziel des Turms wieder
        /// </summary>
        public Enemy Target
        {
            get { return target; }
        }

        /// <summary>
        /// Startet die Suche nach dem Gegner der am nächsten
        /// zu betreffenden Turm sich befindet
        /// </summary>
        /// <param name="enemies">Liste der Gegner in der Spielwelt</param>
        public virtual void GetClosestEnemy(List<Enemy> enemies)
        {
            target = null;
            float smallestRange = radius;

            foreach (Enemy enemy in enemies)
            {
                if (Vector2.Distance(center, enemy.Center) < smallestRange)
                {
                    smallestRange = Vector2.Distance(center, enemy.Center);
                    target = enemy;
                }
            }
        }

        /// <summary>
        /// Stellt dir Rotation zum Ziel von einem Turm ein
        /// </summary>
        protected void FaceTarget()
        {
            Vector2 direction = center - target.Center;
            direction.Normalize();

            rotation = (float)Math.Atan2(-direction.X, direction.Y);
        }

        /// <summary>
        /// Verbessert ein Turm
        /// </summary>
        public virtual void UpgradeTower()
        {
            if (Tier < 4)
            {
                damage = (int)(damage * 1.3f);
                radius = (radius * 1.2f);
                shootingSpeed = shootingSpeed * 0.8f;
            }
        }

        /// <summary>
        /// Überschreibt die Update Methode von Sprite.
        /// Ein Turm wird in die Richtung des Gegners ausgerichtet,
        /// der am nächsten zum Betreffenden Turm sich befindet.
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
            frame = gameTime.TotalGameTime.Seconds % 2;
            texture = this.towerTexture[tier]; // Wählt eine andere Grafik aus (bei Verbesserung z.B.)
            rangeBorder.CurrentRadius = radius; // Passt nochmal die Größe der Bereichanzeige an
            base.Update(gameTime);

            bulletTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (target != null)
            {
                FaceTarget();

                if (!IsInRange(target.Center) || target.IsDead)
                {
                    oldTarget = target;
                    target = null;
                    bulletTimer = 0;
                }
            }
        }
        public override virtual void Draw(SpriteBatch spriteBatch)
        {
            foreach (Bullet bullet in bulletList) bullet.Draw(spriteBatch);

            if (IsSelected) rangeBorder.Draw(spriteBatch);
            if (IsSelected) headupDisplay.Draw(spriteBatch);

            // Zeichnen des Untergrundes
            spriteBatch.Draw(texture, center, new Rectangle(0 * C.BS, 0, C.BS, C.BS), Color.White,
                0, origin, 1.0f, SpriteEffects.None, 0);

            // Zeichnen des Turmes
            spriteBatch.Draw(texture, center, new Rectangle(1 * C.BS, 0, C.BS, C.BS), Color.White,
                rotation, origin, 1.0f, SpriteEffects.None, 0);
            //base.Draw(spriteBatch); // Ist rausgenommen weil hier mit Layern gezeichnet wird
        }

    }
}
