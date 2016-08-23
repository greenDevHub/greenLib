using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush
{
    public enum ObjectType
    {
        Tower,
        Building
    }
    public class Object : Sprite
    {
        // Cunstructor
        /// <summary>
        /// Erstellt ein Objekt der einem Turm gleicht. 
        /// Dabei kann das Objekt aus mehr als nur einem "Layer" bestehen.
        /// </summary>
        public Object(Texture2D[] texture, Texture2D bulletTexture, Texture2D rangeBorderTexture, Texture2D headupDisplayTexture, ObjectTypeConfig objectTypeConfig, Vector2 position)
            : base(texture[0], position, new Vector2(C.BS, C.BS))
        {
            #region Übergabe Parameter weitergeben
            this.objectType = objectTypeConfig.GetObjectType;
            this.cost = objectTypeConfig.Cost; // Kosten
            this.oilCost = objectTypeConfig.OilCost;
            this.metalCost = objectTypeConfig.MetalCost;
            this.coreCost = objectTypeConfig.CoreCost;
            this.enegyConsume = objectTypeConfig.EnegyConsume;

            this.textureType = objectTypeConfig.textureType;

            this.headupDisplayTexture = headupDisplayTexture;
            this.objectTexture = texture;

            switch (objectType)
            {
                case ObjectType.Tower:
                    {
                        this.damage = objectTypeConfig.Damage; // Schaden
                        this.radius = objectTypeConfig.Radius;
                        this.shootingSpeed = objectTypeConfig.ShootingSpeed;
                        this.bulletSpeed = objectTypeConfig.BulletSpeed;

                        this.splitDamage = objectTypeConfig.SplitDamage; // Fläschenschaden
                        this.splitRadius = objectTypeConfig.SplitRadius;

                        this.slowSpeedModifier = objectTypeConfig.SlowSpeedModifier; // Slow
                        this.slowModifierDuration = objectTypeConfig.SlowModifierDuration;

                        // Schadensmanipulatoren
                        this.armorDamagePercent = objectTypeConfig.ArmorDamagePercent;
                        this.armorPenetration = objectTypeConfig.ArmorPenetration;
                        this.shieldDamagePercent = objectTypeConfig.ShieldDamagePercent;
                        this.shieldPenetration = objectTypeConfig.ShieldPenetration;

                        this.bulletTexture = bulletTexture;
                        this.rangeBorderTexture = rangeBorderTexture;
                        break;
                    }
                case ObjectType.Building:
                    {
                        this.powerProduction = objectTypeConfig.PowerProduction;
                        this.productionUnit = objectTypeConfig.ProductionUnit;
                        this.productionTime = objectTypeConfig.ProductionTime;
                        break;
                    }
                default: break;
            }            
            #endregion

            FillBluePrint(objectTypeConfig.ObjectBlueprint);

            // Zeichnen des Rahmen zum anklicken
            if (objectBlueprint == null) this.border = new Rectangle[1];
            else this.border = new Rectangle[(int)(objectBlueprint.GetLength(0) + 1)];
            int i = 0;
            this.border[i] = new Rectangle((int)position.X, (int)position.Y, C.BS, C.BS);
            // Nur ausführen wenn überhaupt eine Blaupause vorliegt
            if (objectBlueprint != null)
            {
                foreach (Vector2 pos in objectBlueprint)
                {
                    i++;
                    this.border[i] = new Rectangle((int)pos.X, (int)pos.Y, C.BS, C.BS);
                }
            }
        }

        #region Variablen & Eigenschaften
        #region Kosten
        protected int cost; // // Goldkosten
        /// <summary>
        /// Kosten des Objekts in Gold
        /// </summary>
        public virtual int Cost
        {
            get { return cost; }
        }
        protected int oilCost; // Ölkosten
        /// <summary>
        /// Kosten des Objeks in Öl
        /// </summary>
        public virtual int OilCost
        {
            get { return oilCost; }
        }
        protected int metalCost; // Metallkosten
        /// <summary>
        /// Kosten des Objekts in Metall
        /// </summary>
        public virtual int MetalCost
        {
            get { return metalCost; }
        }
        protected int coreCost; // Kernkosten
        /// <summary>
        /// Kosten des Objekts in Kernen
        /// </summary>
        public int CoreCost
        {
            get { return coreCost; }
        }
        protected int enegyConsume; // Enegyverbrauch
        /// <summary>
        /// Enegerverbrauch eines Objektes
        /// </summary>
        public int EnergyConsume
        {
            get { return enegyConsume; }
        }
        #endregion

        #region Allgemeine Spezifikationen

        protected ObjectType objectType; // Gibt an von welchem Typ das Objekt ist
        /// <summary>
        /// Gibt an von welchem Typ das Objekt ist
        /// </summary>
        public ObjectType GetObjectType
        {
            get { return objectType; }
        }
        protected int tier = 0; // Gibt die Stuffe eines Objekts an
        /// <summary>
        /// Gibt die Stuffe eines Objekts an
        /// </summary>
        public int Tier
        {
            set { tier = value; }
            get { return tier; }
        }
        protected bool isSelected = false; // Gibt an ob das Objekt ausgewählt wurde oder nicht
        /// <summary>
        /// Gibt an ob das Objekt ausgewählt wurde oder nicht
        /// </summary>
        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }

        // Verweise
        protected GUI.HeadupDisplay headupDisplay;
        protected GUI.RangeBorder rangeBorder;

        protected Rectangle[] border; // Rahmen um ein Objekt (um es z.B. anklicken zu können)
        /// <summary>
        /// Rahmen um ein Objekt (um es z.B. anklicken zu können)
        /// </summary>
        public Rectangle[] Border
        {
            set { border = value; }
            get { return border; }
        }

        protected bool hasEnergy; // Gibt an ob das Objekt braucht zum Arbeiten
        /// <summary>
        /// Gibt an ob das Objekt braucht zum Arbeiten
        /// </summary>
        public virtual bool HasEnergy
        {
            get { return hasEnergy; }
            set { hasEnergy = value; }
        }

        protected Vector2[] objectBlueprint; // Eine Art Blaupause für das Object damit wird platz reserviert für Größere Gebäude (mehr als 32x32)
        /// <summary>
        /// Gibt alle Felder wieder die noch durch das Objekt reserviert 
        /// werden für Ojekte die Größer sind als (32x32)
        /// </summary>
        public virtual Vector2[] ObjectBlueprint
        {
            get { return objectBlueprint; }
        }
        /// <summary>
        /// Gibt wieder ob ein Objekt ein "Großes Objekt" ist.
        /// </summary>
        public virtual bool IsLargeObjekt
        {
            get
            {
                if (objectBlueprint != null) return true;
                return false;
            }
        }

        protected TextureType textureType; // Gibt an von welchem Typ die Grafik des Objektes ist
        private int frame; // welches Frame man gerade hat

        #endregion

        #region Texturen

        protected Texture2D rangeBorderTexture;
        protected Texture2D headupDisplayTexture;
        protected Texture2D bulletTexture;

        protected Texture2D[] objectTexture; // Texturen aller Objektlevel

        #endregion

        #region Turm Spezifikation

        protected int damage; // Der Schaden den das Objekt macht
        /// <summary>
        /// Schaden des Objekts
        /// </summary>
        public int Damage
        {
            get { return damage; }
        }

        protected float radius; // In welchem Radius das Objekt Schüsse abgeben kann
        /// <summary>
        /// Reichweite des Objekts
        /// </summary>
        public float Radius
        {
            get { return radius; }
        }

        protected float shootingSpeed; // Gibt an wie schnell das Objekt Schüsse abfeuern kann
        protected float bulletSpeed; // Gibt an wie schnell die Kugeln des Objekts fliegen
        protected float bulletTimer; // Vor welcher Zeit die Kugel abgefeuert wurde
        protected List<Bullet> bulletList = new List<Bullet>(); // Liste alle Kugeln des Objekts

        protected Enemy target; // Gibt das aktuelle Ziel des Objekts wieder
        /// <summary>
        /// Gibt das aktuelle Ziel des Objekts wieder
        /// </summary>
        public Enemy Target
        {
            get { return target; }
        }
        /// <summary>
        /// Gibt an ob das Objekt gerade ein Ziel besitzt
        /// </summary>
        public virtual bool HasTarget
        {
            get { return target != null; }
        }        

        protected Enemy oldTarget; // Gibt das alte Ziel des Objekts wieder        

        protected List<Enemy> enemies; // Liste alle Gegner auf dem Spielfeld
        /// <summary>
        /// Verwaltet die Liste alle Gegner auf dem Spielfeld
        /// Dieser Wert kann nur gesetzt werden
        /// </summary>
        public List<Enemy> Enemies
        {
            set { enemies = value; }
        }

        protected bool hasSplitDamage = false; // Gibt an ob das Objekt Flächenschade anrichten soll oder nicht
        /// <summary>
        /// Gibt an ob ein Turm Flächenschaden hat oder 
        /// eben nicht. 
        /// Dieser wert kann nur zurückgegeben werden
        /// </summary>
        public virtual bool HasSplitDamage
        {
            get { return hasSplitDamage; }
        }

        protected int splitDamage; // der Flächenschaden an sich
        protected float splitRadius; // der Radiums in dem der Flächenschenschaden Passiert

        protected float slowSpeedModifier; // Gibt an wie schnell sich ein Objekt bewegeben soll wenn es von diesem Effekt getroffen wurde
        protected float slowModifierDuration; // Maximaldauer des Effekts

        protected bool hasLongBullet = false; // Gibt an ob die Kugel des Objects eine "Lange Kugel" hat also Laserstrahl z.B.
        /// <summary>
        /// Gibt an ob die Kugel des Objects eine "Lange Kugel" hat also Laserstrahl z.B.
        /// </summary>
        public virtual bool HasLongBullet
        {
            get { return hasLongBullet; }
        }

        protected bool hasUnstoppableBullet = false; // Zeigt an das die Kugel auch weiter fliegt wenn sie den Gegner getroffen oder zerstört hat
        /// <summary>
        /// Zeigt an das die Kugel auch weiter fliegt wenn sie 
        /// den Gegner getroffen oder zerstört hat
        /// </summary>
        public virtual bool HasUnstoppableBullet
        {
            get { return hasUnstoppableBullet; }
        }

        protected float armorDamagePercent; // Gibt an wie viel Schaden anteilig angerichtet wird (Rüstung)
        protected float armorPenetration; // Gibt an wie viel Durschlag eine Waffe an Rüstung hat (Rüstung)
        protected float shieldDamagePercent; // Gibt an wie viel Schaden anteilig angerichtet wird (Schild)
        protected float shieldPenetration; // Gibt an wie viel Durschlag eine Waffe an Schild hat  (Schild)
        /// <summary>
        /// Gibt den Schaden wieder den der Turm auch wirklich anrichtet
        /// </summary>
        /// <param name="enemy">Der Gegner auf dem der Schaden
        /// angerichtet wird bzw. werden soll</param>
        /// <returns></returns>
        public float RealDamage(Enemy enemy)
        {
            // Festtellung des Gegners
            bool hasArmor = enemy.Armor > 0 && enemy.ArmorValue > 0;
            bool hasShield = enemy.Shield > 0 && enemy.ShieldValue > 0;

            float damageValue = damage;
            float armorDamageValue = 0;
            float shieldDamageValue = 0;

            // Berechnung des Schadens Panzer
            if (hasArmor)
            {
                // Schaden am Panzer = (Schaden * Schaden am Panzer in Prozent) * (Durschlag am Panzer * Schadens Panzer Manipulator)
                armorDamageValue = (damageValue * armorDamagePercent) * (armorPenetration * enemy.ArmorManipulation);
                enemy.ArmorValue -= armorDamageValue;
                damageValue -= enemy.Armor;
            }
            // Berechnung des Schadens Schild
            if (hasShield)
            {
                shieldDamageValue = (damageValue * shieldDamagePercent) * (shieldPenetration * enemy.ShieldManipulation);
                enemy.ShieldValue -= shieldDamageValue;
                damageValue -= enemy.Shield;
            }            

            if (damageValue <= 0) return 0;
            else return damageValue;
        }

        #endregion

        #region Gebäude Spezifikation

        protected int powerProduction; // Gibt an wie viel Energie vom Objekt hergestellt wird
        /// <summary>
        /// Gibt an wie viel Energie vom Objekt hergestellt wird
        /// </summary>
        public int PowerProduction
        {
            get { return powerProduction; }
        }

        protected int productionUnit; // Gibt an wie viel Energie hergestellt wird von einem Objekt
        /// <summary>
        /// Gibt an wie viel Energie hergestellt wird von einem Objekt
        /// </summary>
        public int ProductionUnit
        {
            get { return productionUnit; }
        }

        protected int productionTime; // Gibt an wie lang ein Objekt braucht um eine "Einheit" herzustellen
        /// <summary>
        /// Gibt an wie lang ein Objekt braucht um eine "Einheit" herzustellen
        /// </summary>
        public int ProductionTime
        {
            get { return productionTime; }
        }

        protected float productionLastTime; // Wann wurde zum letzten mal etwas Hergestellt

        protected int productionUnitStack; // Lager der Rohstoffe die vom Spieler abgeholt werden kannt
        /// <summary>
        /// Stellt den Wert dar den das Objekt produziert hat.
        /// Dieser kann dann vom Spieler abgeholt werden muss
        /// dabei aber auf 0 zurückgestellt bzw. die abgeholte 
        /// Menge davom abgezogen werden
        /// </summary>
        public int ProductionUnitStack
        {
            get { return productionUnitStack; }
        }

        protected int transferValue; // Der tatsächlichte Wert der vom Spieler abgeholt wird
        /// <summary>
        /// Der tatsächlichte Wert der vom Spieler abgeholt wird.
        /// Bsp. Der Arbeiter kann nur 1 tonne abholen auf dem 
        /// Lager des Gebäudes sind 3 tonnen das bedeutet
        /// nachdem er dort gewesen ist sind nur noch 2 dar.
        /// Dieser Wert kann nur gesetzt werden.
        /// </summary>
        public int TransferValue
        {
            set { transferValue = value; }
        }

        protected string buildingType; // Typ des Gebäudes
        /// <summary>
        /// Gibt den Typ des Gebäudes wieder.
        /// </summary>
        public string BuildingType
        {
            get { return buildingType; }
        }

        #endregion

        #endregion

        #region Funktionen zu Ojekttype Tower
        /// <summary>
        /// Gibt wieder ob ein Ziel in reichweite des Objekts ist
        /// </summary>
        /// <param name="position">Position des Ziels</param>
        /// <returns>True or False</returns>
        public bool IsInRange(Vector2 position)
        {
            if (Vector2.Distance(center, position) <= radius) return true;
            return false;
        }
        /// <summary>
        /// Gibt ein Wert wieder ob ein Gegner in Reichweite einer Explosion ist
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool IsInExplosion(Vector2 enemyPosition, Vector2 nextEnemyPosition)
        {
            if (Vector2.Distance(enemyPosition, nextEnemyPosition) <= splitRadius) return true;
            return false;
        }
        /// <summary>
        /// Bei Objekten mit Fläschenschaden wird
        /// ein oder mehrere Gegner getroffen die im Explosionsreichweite
        /// der Kugel sind
        /// </summary>
        /// <param name="bullet">die Kugel die den Gegner getroffen hat</param>
        public void HitClosestEnemy(Bullet bullet)
        {
            // Schleife durch die Gegner des Objekts
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
        /// Startet die Suche nach dem Gegner der am nächsten
        /// zum Objekt sich befindet
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
        /// Stellt dir Rotation zum Ziel von einem Objekt ein
        /// </summary>
        protected void FaceTarget()
        {
            Vector2 direction = center - target.Center;
            direction.Normalize();

            rotation = (float)Math.Atan2(-direction.X, direction.Y);
        }
        #endregion

        #region Funktionen zu Objekttype Building

        /// <summary>
        /// In dieser Funktion wird ein Wert zurückgegeben 
        /// von den Rohstoffe die an den Spieler übergeben 
        /// werden können vom Lager des Objektes. Dazu muss
        /// aber im Vorfeld unbedingt ein Transferwert
        /// also ein Abholwert dem Objekt zugewiesen werden.
        /// </summary>
        public int GetProductionStack
        {
            get
            {
                // Prüfen ob was auf dem Lager des Objektes liegt
                if (productionUnitStack > 0)
                {
                    // Ist der Lagerwert größer wie der Abholwert
                    if (productionUnitStack > transferValue)
                    {
                        productionUnitStack -= transferValue;
                        return transferValue; // Dann Abholwert zurück geben
                    }
                    else
                    {
                        transferValue = productionUnitStack;
                        productionUnitStack = 0;
                        return transferValue; // Dann ganzen Lagerbestand Zurück geben
                    }
                }
                return 0;
            }
        }

        #endregion

        /// <summary>
        /// Verbessert ein Objekt
        /// </summary>
        public virtual void UpgradeObject()
        {
            if (Tier < 4)
            {
                switch (objectType)
                {
                    case ObjectType.Tower:
                        {
                            damage = (int)(damage * 1.3f);
                            radius = (radius * 1.2f);
                            shootingSpeed = shootingSpeed * 0.8f;
                            break;
                        }
                }                
            }
        }
        /// <summary>
        /// Füllt die "objectBlueprint" mit Werten die dazu notwendigt sind
        /// um Größere Objekte zu erschaffen.
        /// </summary>
        /// <param name="indexBluePrint"></param>
        private void FillBluePrint(Vector2[] indexBluePrint)
        {
            if (indexBluePrint != null)
            {
                int i = 0;
                Vector2[] oldIndexBluePrint = new Vector2[indexBluePrint.GetLength(0)];

                foreach (Vector2 index in indexBluePrint)
                {
                    oldIndexBluePrint[i] = new Vector2((int)position.X + (index.X * C.BS),
                        (int)position.Y + (index.Y * C.BS));
                    i++;
                }

                objectBlueprint = oldIndexBluePrint;
            }
        }
        /// <summary>
        /// Zeichnet ein Objekt nach seinem Typ
        /// </summary>
        /// <param name="spriteBatch"></param>
        private void DrawOutTextureType(SpriteBatch spriteBatch)
        {
            switch (textureType)
            {
                case TextureType.Single:
                    {
                        base.Draw(spriteBatch);
                        break;
                    }
                case TextureType.DoubleLayer:
                    {
                        spriteBatch.Draw(texture, center, new Rectangle(0 * C.BS, 0, C.BS, C.BS), Color.White, 0, origin, 1.0f, SpriteEffects.None, 0); // Layer 0
                        spriteBatch.Draw(texture, center, new Rectangle(1 * C.BS, 0, C.BS, C.BS), Color.White, rotation, origin, 1.0f, SpriteEffects.None, 0); // Layer 1
                        break;
                    }
            }
        }

        public override void Update(GameTime gameTime)
        {
            if (texture != this.objectTexture[tier]) texture = this.objectTexture[tier]; // Wählt eine andere Grafik aus (bei Verbesserung z.B.)
            if (objectType == ObjectType.Tower) rangeBorder.CurrentRadius = radius; // Passt nochmal die Größe der Bereichanzeige an
            base.Update(gameTime);

            switch (objectType)
            {
                case ObjectType.Tower:
                    {
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

                        break;
                    }
                case ObjectType.Building:
                    {
                        productionLastTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
                        break;
                    }
                default: break;
            }            
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (IsSelected) headupDisplay.Draw(spriteBatch);

            switch (objectType)
            {
                case ObjectType.Tower:
                    {
                        foreach (Bullet bullet in bulletList) bullet.Draw(spriteBatch);
                        if (IsSelected) rangeBorder.Draw(spriteBatch);
                        break;
                    }
                case ObjectType.Building:
                    {                        
                        break;
                    }
                default: break;
            }
            DrawOutTextureType(spriteBatch);
        }
    }
}
