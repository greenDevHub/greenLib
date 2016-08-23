using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Tower_Crush
{
    public class ObjectTypeConfig
    {
        public enum ObjectSizeType
        {
            NormalObject,
            LargeObject
        };
        public ObjectSizeType objectSizeType;
        public TextureType textureType; // Gibt an von welchem Typ die Grafik des Objektes ist

        public int Cost; // Goldkosten
        public int OilCost; // Ölkosten
        public int MetalCost; // Metallkosten
        public int CoreCost; // Kernkosten
        public int EnegyConsume; // Enegyverbrauch

        public int PowerProduction; // Wie viel Enegie vom Gebäude hergestellt wird
        public int ProductionUnit; // Wie viel Hergestellt wird
        public int ProductionTime; // Wie lang gebraucht wird um Herzustellen

        public Vector2[] ObjectBlueprint; // eine Blaupause des Objekts mit Indexwerten

        public int Damage; // Der Schaden den das Objekt macht
        public float Radius; // In welchem Radius das Objekt Schüsse abgeben kann
        public float ShootingSpeed; // Gibt an wie schnell das Objekt Schüsse abfeuern kann
        public float BulletSpeed; // Gibt an wie schnell die Kugeln des Objekts fliegen

        public int SplitDamage; // der Flächenschaden an sich
        public float SplitRadius; // der Radiums in dem der Flächenschenschaden Passiert

        public float SlowSpeedModifier; // Gibt an wie schnell sich ein Objekt bewegeben soll wenn es von diesem Effekt getroffen wurde
        public float SlowModifierDuration; // Slow (wie lang die Verlangsamung anhalten wird bzw. anhält)

        public float ArmorDamagePercent; // Gibt an wie viel Schaden anteilig angerichtet wird (Rüstung)
        public float ArmorPenetration; // Gibt an wie viel Durschlag eine Waffe an Rüstung hat (Rüstung)

        public float ShieldDamagePercent; // Gibt an wie viel Schaden anteilig angerichtet wird (Schild)
        public float ShieldPenetration; // Gibt an wie viel Durschlag eine Waffe an Schild hat  (Schild)

        public string Name; // Name des Objekts

        private ObjectType objectType;
        /// <summary>
        /// Gibt an von welchem Typ das Objekt ist
        /// </summary>
        public ObjectType GetObjectType
        {
            get { return objectType; }
        }

        private bool isAvailable;
        /// <summary>
        /// Gibt wieder ob man Bereits das Objekt bauen kann
        /// </summary>
        public bool IsAvailable
        {
            get { return isAvailable; }
        }
        /// <summary>
        /// Diese Prozedur prüft ob der Spieler die Vorrausetzungen mit bringt um
        /// das Ensprechende Objekt Kaufen zu können
        /// </summary>
        /// <param name="player"></param>
        public void SetIsAvailable(Player player)
        {
            if (this.Cost > player.Money || this.OilCost > player.Oil
                || this.MetalCost > player.Metal || this.CoreCost > player.Core
                || this.EnegyConsume > (int)(player.Energy - player.EnergyDemand)) isAvailable = false;
            else isAvailable = true;
        }

        /// <summary>
        /// Gibt die Reichweite eines Objekts als Durschmesser wieder
        /// </summary>
        public int Range
        {
            get { return (int)(Radius * 2); }
        }

        // Constructor Turm
        /// <summary>
        /// Erstellt für ein Turm eine Cofiguration diese ist dazu da um
        /// die Einzelnen Türme mit Werte wie Schaden, Reichen usw. zu
        /// bestücken.
        /// </summary>
        /// <param name="name">Name des Turms</param>
        /// <param name="textureType">Typ der Grafik</param>
        /// <param name="cost">Kosten in Gold</param>
        /// <param name="oilCost">Kosten in Öl</param>
        /// <param name="metalCost">Kosten in Metall</param>
        /// <param name="coreCost">Kosten in Kernen</param>
        /// <param name="enegyConsume">Verbrauch an Enegie</param>
        /// <param name="damage">Schade</param>
        /// <param name="radius">Reichweite</param>
        /// <param name="shootingSpeed">Schussrate</param>
        /// <param name="bulletSpeed">Geschwindigkeit der Kugel</param>
        /// <param name="splitDamage">Fläschenschaden</param>
        /// <param name="splitRadius">Radius in dem Fläschenschaden gemacht wird</param>
        /// <param name="slowSpeedModifier">Um wie viel Prozent verlangsamt wird</param>
        /// <param name="slowModifierDuration">Wie lang ein Ziel verlangsamt werden soll</param>
        /// <param name="armorDamagePercent">Gibt an wie viel Schaden anteilig angerichtet wird (Rüstung)</param>
        /// <param name="armorPenetration">Gibt an wie viel Durschlag eine Waffe an Rüstung hat (Rüstung)</param>
        /// <param name="shieldDamagePercent">Gibt an wie viel Schaden anteilig angerichtet wird (Schild)</param>
        /// <param name="shieldPenetration">Gibt an wie viel Durschlag eine Waffe an Schild hat  (Schild)</param>
        public ObjectTypeConfig(string name, TextureType textureType, int cost, int oilCost, int metalCost, int coreCost, int enegyConsume, int damage,
            float radius, float shootingSpeed, float bulletSpeed, int splitDamage, float splitRadius,
            float slowSpeedModifier, float slowModifierDuration, 
            float armorDamagePercent, float armorPenetration,
            float shieldDamagePercent, float shieldPenetration)
        {
            this.objectType = ObjectType.Tower;
            this.Name = name;
            this.textureType = textureType;

            this.Cost = cost;
            this.OilCost = oilCost;
            this.MetalCost = metalCost;
            this.CoreCost = coreCost;
            this.EnegyConsume = enegyConsume;

            this.Damage = damage;
            this.Radius = radius;
            this.ShootingSpeed = shootingSpeed;
            this.BulletSpeed = bulletSpeed;

            this.SplitDamage = splitDamage;
            this.SplitRadius = splitRadius;

            this.SlowSpeedModifier = slowSpeedModifier;
            this.SlowModifierDuration = slowModifierDuration;

            this.ArmorDamagePercent = armorDamagePercent;
            this.ArmorPenetration = armorPenetration;

            this.ShieldDamagePercent = shieldDamagePercent;
            this.ShieldPenetration = shieldPenetration;
        }

        // Constructor Gebäude
        /// <summary>
        /// Erstellt für ein Gebäude eine Configuration diese ist dazu da um
        /// die Einzelnen Gebäude mit Werten wie Kosten, Energieverbrauch usw. 
        /// zu bestücken.
        /// </summary>
        /// <param name="buildingSizeType">Typ des Gebäudes</param>
        /// <param name="name">Name</param>
        /// <param name="textureType">Typ der Grafik</param>
        /// <param name="cost">Goldkosten</param>
        /// <param name="oilCost">Ölkosten</param>
        /// <param name="metalCost">Metallkosten</param>
        /// <param name="coreCost">Kernkosten</param>
        /// <param name="enegyConsume">Enegyverbrauch eines Begäudes</param>
        /// <param name="powerProduction">Wie viel Enegie vom Gebäude hergestellt wird</param>
        /// <param name="productionUnit">Wie viel Hergestellt wird</param>
        /// <param name="productionTime">Wie lang gebraucht wird um Herzustellen</param>
        /// <param name="buildingBlueprint">eine Blaupause des Gebäudes mit Indexwerten</param>
        public ObjectTypeConfig(ObjectSizeType objectSizeType, string name, TextureType textureType, int cost, int oilCost, int metalCost, int coreCost, int enegyConsume,
            int powerProduction, int productionUnit, int productionTime,
            Vector2[] buildingBlueprint)
        {
            this.objectType = ObjectType.Building;
            this.objectSizeType = objectSizeType;
            this.Name = name;
            this.textureType = textureType;

            this.Cost = cost;
            this.OilCost = oilCost;
            this.MetalCost = metalCost;
            this.CoreCost = coreCost;
            this.EnegyConsume = enegyConsume;

            this.PowerProduction = powerProduction;
            this.ProductionUnit = productionUnit;
            this.ProductionTime = productionTime;

            this.ObjectBlueprint = buildingBlueprint;
        }
    }
    public class Player
    {
        private int money = 9000;
        private int lives = 30;
        private int oil = 500;
        private int core = 100;
        private int energy = 100;
        private int energyDemand = 0; // Energiebedarf des Spielers
        private int metal = 500;
        private int worker = 0;
        private int waveFinished = 0; // Anzahl der geschaften Wellen

        private List<Object> objects = new List<Object>();
        public List<ObjectTypeConfig> objectTypeConfigs = new List<ObjectTypeConfig>(); // Liste aller möglichen Objekte

        private int newObjectIndex; // Bildindex des Objekts das Plaziert werden soll

        private MouseState mouseState; // Speichert den aktuellen Mauszustand in dem Frame
        private MouseState oldState; // Speichert den Mauszustand für den Frame davor

        private Texture2D[,] objectTexture;
        private Texture2D[] bulletTexture;
        private Texture2D rangeBorderTexture;
        private Texture2D headupDisplayTexture;
        private Texture2D previewGroundTexture;

        private Object selectedObject;

        private Level level;

        /// <summary>
        /// Hier wird eine Liste mit alle Türmen und ihren Configurationen
        /// erstellt diese können zb.: Schade, Kosten usw sein.
        /// </summary>
        private void createTowerTypes()
        {
            ObjectTypeConfig cannonTower = new ObjectTypeConfig("Cannon", TextureType.DoubleLayer, 15, 0, 0, 0, 0, 4, 80f, 0.75f, 6f, 0, 0f, 0f, 0f, 1.0f, 1.5f, 0f, 0f);
            objectTypeConfigs.Add(cannonTower);

            ObjectTypeConfig fortCannonTower = new ObjectTypeConfig("Fort Cannon", TextureType.Single, 50, 0, 0, 0, 6, 12, 55f, 1.0f, 6f, 0, 0f, 0f, 0f, 1.0f, 0.8f, 0f, 0f);
            objectTypeConfigs.Add(fortCannonTower);

            ObjectTypeConfig cryoTower = new ObjectTypeConfig("Cryo Cannon", TextureType.Single, 30, 0, 0, 0, 12, 4, 90f, 1.5f, 4f, 0, 0f, 0.3f, 1.5f, 1.0f, 0f, 0f, 0f);
            objectTypeConfigs.Add(cryoTower);

            ObjectTypeConfig twinCannonTower = new ObjectTypeConfig("Twin Cannon", TextureType.Single, 65, 3, 5, 0, 4, 8, 90f, 0.55f, 6f, 0, 0, 0f, 0f, 1.0f, 1.5f, 0f, 0f);
            objectTypeConfigs.Add(twinCannonTower);

            ObjectTypeConfig grenadeLauncherTower = new ObjectTypeConfig("Grenade Launcher", TextureType.Single, 90, 5, 6, 0, 8, 20, 140f, 2.0f, 3f, 15, 30f, 0f, 0f, 1.0f, 2f, 0f, 0f);
            objectTypeConfigs.Add(grenadeLauncherTower);

            ObjectTypeConfig laserTower = new ObjectTypeConfig("Laser", TextureType.Single, 150, 2, 12, 0, 10, 32, 160f, 3.0f, 15f, 0, 0f, 0f, 0f, 0f, 0f, 1.0f, 2f);
            objectTypeConfigs.Add(laserTower);
        }
        /// <summary>
        /// Hier wird eine Liste mit allen Gebäuden und ihren Configurationen
        /// erstellt diese können z.B.: Kosten, Produktion usw. sein
        /// </summary>
        private void createBuildingTypes()
        {
            ObjectTypeConfig powerStation = new ObjectTypeConfig(ObjectTypeConfig.ObjectSizeType.NormalObject, "Power Station", TextureType.Single, 120, 0, 0, 0, 0, 20, 0, 0, null);
            objectTypeConfigs.Add(powerStation);

            ObjectTypeConfig metallMine = new ObjectTypeConfig(ObjectTypeConfig.ObjectSizeType.NormalObject, "Metall Mine", TextureType.Single,  150, 0, 0, 0, 8, 0, 2, 20, null);
            objectTypeConfigs.Add(metallMine);

            ObjectTypeConfig oilStation = new ObjectTypeConfig(ObjectTypeConfig.ObjectSizeType.NormalObject, "Oil Station", TextureType.Single, 90, 0, 0, 0, 5, 0, 1, 20, null);
            objectTypeConfigs.Add(oilStation);

            Vector2[] buildingBlueprint = new Vector2[]
            {
                new Vector2(0, 1),
                new Vector2(1, 1),
                new Vector2(2, 1)
            };
            ObjectTypeConfig refinery = new ObjectTypeConfig(ObjectTypeConfig.ObjectSizeType.LargeObject, "Refinery", TextureType.Single, 200, 10, 12, 0, 20, 0, 5, 15, buildingBlueprint);
            objectTypeConfigs.Add(refinery);
        }

        /// <summary>
        /// Gibt den Geldwert wieder den ein Spieler hat.
        /// </summary>
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        /// <summary>
        /// Gibt die Leben wieder die ein Spieler noch hat
        /// </summary>
        public int Lives
        {
            get { return lives; }
            set { lives = value; }
        }
        /// <summary>
        /// Oil dient als Ressource im Spiel man kann diesen Wert 
        /// setzen oder wiedergeben
        /// </summary>
        public int Oil
        {
            get { return oil; }
            set { oil = value; }
        }
        /// <summary>
        /// Teile sind Dinge die Besondere Gegner fallen lassen 
        /// mit diesen kann man Forschen um sie auf diese Gegner 
        /// besser einstellen zu können. Diesen Wert kann man 
        /// setzen und wiedergeben
        /// </summary>
        public int Core
        {
            get { return core; }
            set { core = value; }
        }
        /// <summary>
        /// Die Energy stellt die Grundversorgung für Türme dar 
        /// ist der Bedarf der Türme Görßer wie die 
        /// Energyproduktion schalten sich alle Türme ab.
        /// Diesen Wert kann man setzen und wiedergeben
        /// </summary>
        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }
        /// <summary>
        /// Hier wird der aktuelle Energiebedraf eines Spielers 
        /// gesetzt oder wiedergegeben.
        /// </summary>
        public int EnergyDemand
        {
            get { return energyDemand; }
            set { energyDemand = value; }
        }
        /// <summary>
        /// Metall ist die Grundresource in der Spielwelt ohne 
        /// die keine Upgrades oder das Bauen neuer Türme ab 
        /// einen bestimmten Tiere nicht möglich ist. Dieser
        /// Wert kann gesetzt oder wiedergegeben werden
        /// </summary>
        public int Metal
        {
            get { return metal; }
            set { metal = value; }
        }
        /// <summary>
        /// Arbeiter sind Personen die notwendig sind um in 
        /// der Spielwelt Kacheln frei zu machen. Ohne 
        /// Arbeiter können solche Arbeiten nicht durchgeführt 
        /// werden. Arbeiter Müssen durch Gold eingekauft werden.
        /// Werden bei Verwendung verbraucht. Dieser Wert kann
        /// gesetzt und wiedergegeben werden
        /// </summary>
        public int Worker
        {
            get { return worker; }
            set { worker = value; }
        }
        /// <summary>
        /// Stellt den Wert dar der Anzeigt wie viel
        /// Welle der Spieler bereits geschaft hat.
        /// Dieser Wert an gesetzt oder zurückgegeben werden
        /// </summary>
        public int WaveFinished
        {
            get { return waveFinished; }
            set { waveFinished = value; }
        }
        /// <summary>
        /// Bildindex des Objekts das Plaziert werden soll
        /// </summary>
        public int NewObjectIndex
        {
            set { newObjectIndex = value; }
        }

        /// <summary>
        /// Gibt wieder ob gerade ein Objekt ausgewählt ist
        /// </summary>
        public bool IsObjectSelected
        {
            get 
            {
                if (selectedObject != null) return true;
                else return false;

            }
        }
        /// <summary>
        /// Gibt das gerade vom Spieler ausgewählte Objekt wieder
        /// </summary>
        public Object SelectedObject
        {
            get { return selectedObject; }
        }

        // Objektverwaltung
        private string newObjectType;
        /// <summary>
        /// Der Spieler will ein Objekt bauen
        /// </summary>
        public string NewObjectType
        {
            set { newObjectType = value; }
        }
        /// <summary>
        /// Zeichnet eine Voransicht
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void DrawPreview(SpriteBatch spriteBatch)
        {
            // Zeichnen der Voransicht
            if (string.IsNullOrEmpty(newObjectType) == false)
            {
                int cellX = (int)(mouseState.X / 32);
                int cellY = (int)(mouseState.Y / 32);

                int tileX = cellX * 32;
                int tileY = cellY * 32;

                bool isBigTexture = false;
                bool isClear = true;
                int frame = 1;

                isClear = IsCellClear();
                frame = Convert.ToInt32(isClear);

                // feststellen ob es sich hierbei eine Große Grafik handel (z.B. für große Gebäude oder Türme)
                if (objectTexture[newObjectIndex, 0].Width > (int)(1 + C.BS)) isBigTexture = true;
                else isBigTexture = false;

                Texture2D previewTexture = objectTexture[newObjectIndex, 0]; // festlegen der aktuellen Grafik
                spriteBatch.Draw(previewGroundTexture, new Vector2(tileX, tileY), new Rectangle(frame * C.BS, 0, C.BS, C.BS), Color.White); // Zeichnen des Untergrunds
                if (objectTypeConfigs[newObjectIndex].ObjectBlueprint != null)
                {
                    foreach (Vector2 posGround in objectTypeConfigs[newObjectIndex].ObjectBlueprint)
                    {
                        spriteBatch.Draw(previewGroundTexture, new Vector2((int)((posGround.X + cellX) * C.BS), (int)((posGround.Y + cellY) * C.BS)),
                            new Rectangle(frame * C.BS, 0, C.BS, C.BS), Color.White); // Zeichnen des Zusatzuntergrund
                    }
                }

                // Zeichnen der Reichweite
                Texture2D previewRangeTexture = rangeBorderTexture;
                spriteBatch.Draw(previewRangeTexture, new Rectangle(
                    (int)(tileX - objectTypeConfigs[newObjectIndex].Radius + (32 / 2)),
                    (int)(tileY - objectTypeConfigs[newObjectIndex].Radius + (32 / 2)),
                    objectTypeConfigs[newObjectIndex].Range,
                    objectTypeConfigs[newObjectIndex].Range),
                    Color.White);

                if (objectTypeConfigs[newObjectIndex].ObjectBlueprint == null && isBigTexture)
                {
                    spriteBatch.Draw(previewTexture, new Rectangle(tileX, tileY, C.BS, C.BS), new Rectangle(1 * C.BS, 0, C.BS, C.BS), Color.White); // Zeichnen des Objektes
                    
                }
                else spriteBatch.Draw(previewTexture, new Rectangle(tileX, tileY, previewTexture.Width, previewTexture.Height), Color.White); // Zeichnen des Objektes                
            }
        }
        /// <summary>
        /// Verbessert ein Objekt in seiner Stufe
        /// </summary>
        public void UpgradeObject()
        {
            if (selectedObject != null)
            {
                if (selectedObject.Tier < 3)
                {
                    if (selectedObject.Cost <= money
                        && selectedObject.OilCost <= oil && selectedObject.MetalCost <= metal
                        && selectedObject.CoreCost <= core)
                    {
                        selectedObject.UpgradeObject();

                        money -= selectedObject.Cost;
                        oil -= selectedObject.OilCost;
                        metal -= selectedObject.MetalCost;
                        core -= selectedObject.CoreCost;

                        selectedObject.Tier++; // Tower ist erst nun geupgradet
                    }
                }
            }
        }
        /// <summary>
        /// Verkauft ein Objekt
        /// </summary>
        public void SellObjekt()
        {
            if (selectedObject != null)
            {
                // Geld für den Verkauf dem Spieler gutschreiben
                this.money += (int)(selectedObject.Cost * 0.7f);
                this.oil += (int)(selectedObject.OilCost * 0.7f);
                this.metal += (int)(selectedObject.MetalCost * 0.7f);
                this.core += (int)(selectedObject.CoreCost * 0.7f);

                objects.Remove(selectedObject);
                selectedObject = null;
            }
        }
        /// <summary>
        /// Erstellt ein Eindeminsionalen Array für die Objekte
        /// </summary>
        private Texture2D[] WrapObjectTexture
        {
            get
            {
                Texture2D[] tempTexture = new Texture2D[objectTexture.GetLength(1)];

                for (int i = newObjectIndex; i == newObjectIndex; i++)
                {
                    for (int ii = 0; ii < objectTexture.GetLength(1); ii++)
                    {
                        tempTexture[ii] = objectTexture[i, ii];
                    }
                }
                return tempTexture;
            }
        }
        /// <summary>
        /// Erstellt ein neuen Tower solbald auf ein Knopf geklickt wurde
        /// und Prüft ob der Spieler es auch wirklich bauen kann
        /// </summary>
        public void AddObject()
        {
            Object objectToAdd = null;

            switch (newObjectType)
            {
                // Türme
                case "Cannon Tower":
                    {
                        objectToAdd = new TowerType.CannonTower(WrapObjectTexture, bulletTexture[newObjectIndex], rangeBorderTexture, headupDisplayTexture, objectTypeConfigs[newObjectIndex], new Vector2(tileX, tileY));
                        break;
                    }
                case "Fort Cannon Tower":
                    {
                        objectToAdd = new TowerType.FortCannonTower(WrapObjectTexture, bulletTexture[newObjectIndex], rangeBorderTexture, headupDisplayTexture, objectTypeConfigs[newObjectIndex], new Vector2(tileX, tileY));
                        break;
                    }
                case "Cryo Tower":
                    {
                        objectToAdd = new TowerType.CryoTower(WrapObjectTexture, bulletTexture[newObjectIndex], rangeBorderTexture, headupDisplayTexture, objectTypeConfigs[newObjectIndex], new Vector2(tileX, tileY));
                        break;
                    }
                case "Twin Cannon Tower":
                    {
                        objectToAdd = new TowerType.TwinCannonTower(WrapObjectTexture, bulletTexture[newObjectIndex], rangeBorderTexture, headupDisplayTexture, objectTypeConfigs[newObjectIndex], new Vector2(tileX, tileY));
                        break;
                    }
                case "Grenade Launcher Tower":
                    {
                        objectToAdd = new TowerType.GrenadeLauncherTower(WrapObjectTexture, bulletTexture[newObjectIndex], rangeBorderTexture, headupDisplayTexture, objectTypeConfigs[newObjectIndex], new Vector2(tileX, tileY));
                        break;
                    }
                case "Laser Tower":
                    {
                        objectToAdd = new TowerType.LaserTower(WrapObjectTexture, bulletTexture[newObjectIndex], rangeBorderTexture, headupDisplayTexture, objectTypeConfigs[newObjectIndex], new Vector2(tileX, tileY));
                        break;
                    }
                // Gebäude
                case "Power Station":
                    {
                        objectToAdd = new BuildingType.PowerStation(WrapObjectTexture, null, rangeBorderTexture, headupDisplayTexture, objectTypeConfigs[newObjectIndex], new Vector2(tileX, tileY));
                        break;
                    }
                case "Metal Mine":
                    {
                        objectToAdd = new BuildingType.MetalMine(WrapObjectTexture, null, rangeBorderTexture, headupDisplayTexture, objectTypeConfigs[newObjectIndex], new Vector2(tileX, tileY));
                        break;
                    }
                case "Oil Station":
                    {
                        objectToAdd = new BuildingType.OilStation(WrapObjectTexture, null, rangeBorderTexture, headupDisplayTexture, objectTypeConfigs[newObjectIndex], new Vector2(tileX, tileY));
                        break;
                    }
                case "Refinery":
                    {
                        objectToAdd = new BuildingType.Refinery(WrapObjectTexture, null, rangeBorderTexture, headupDisplayTexture, objectTypeConfigs[newObjectIndex], new Vector2(tileX, tileY));
                        break;
                    }
            }

            // Der Turm wird nur gebaut wenn dort Platz ist und wenn der Spieler es auch sich leisten kann
            if (IsCellClear() && objectToAdd.Cost <= money
                && objectToAdd.OilCost <= oil && objectToAdd.MetalCost <= metal
                && objectToAdd.CoreCost <= core)
            {
                objects.Add(objectToAdd);
                money -= objectToAdd.Cost;
                oil -= objectToAdd.OilCost;
                metal -= objectToAdd.MetalCost;
                core -= objectToAdd.CoreCost;
                energyDemand += objectToAdd.EnergyConsume;

                // newTowerType feld wird zurückgesetzt
                newObjectType = string.Empty;
            }
            else newObjectType = string.Empty;
        }
        
        public Player(Level level)
        {
            this.level = level;
        }

        private int cellX;
        private int cellY;
        private int tileX;
        private int tileY;

        /// <summary>
        /// Behandlung der Mous Position von Umwandlung dieser sowie
        /// die Plazierung neuer Türme bei Mauseingabe
        /// </summary>
        /// <param name="gameTime">GameTime</param>
        /// <param name="enemies">Eine Liste alle Gegner auf der Karte</param>
        public void Update(GameTime gameTime, List<Enemy> enemies)
        {
            mouseState = Mouse.GetState();

            cellX = (int)(mouseState.X / 32); // Wandelt die Position der Maus von
            cellY = (int)(mouseState.Y / 32); // einem Array zu der Levelgröße / Angabe

            tileX = cellX * 32; // Umwandlung von Array zu Levelgröße
            tileY = cellY * 32; // Umwandlung von Array zu Levelgröße

            // Plazierung der Türme auf dem Spielfeld
            if (mouseState.LeftButton == ButtonState.Released && oldState.LeftButton == ButtonState.Pressed)
            {
                if (!string.IsNullOrEmpty(newObjectType)) AddObject();

                #region Prüfen auf Anklicken (Selectieren von Objekten)
                // Es wurde auf ein Objekt auf dem Spielfeld geklickt
                if (string.IsNullOrEmpty(newObjectType))
                {
                    // BUILDING
                    if (selectedObject != null) //Prüfen ob ein Gebäude bereits in der Auswahl ist
                    {
                        foreach (Rectangle box in selectedObject.Border)
                        {
                            if (!box.Contains(mouseState.X, mouseState.Y)) // Prüfen ob der neue Click sich noch auf diesem Gebäude befindet
                            {
                                selectedObject.IsSelected = false;
                                selectedObject = null;
                                break;
                            }
                        }
                    }

                    foreach (Object obj in objects)
                    {
                        if (obj == selectedObject) continue;

                        foreach (Rectangle box in obj.Border)
                        {
                            if (box.Contains(mouseState.X, mouseState.Y)) // Falls der Klick auf einem Gebäude ist dieses Auswählen
                            {
                                selectedObject = obj;
                                obj.IsSelected = true;
                                break;
                            }
                        }
                    }
                }
                #endregion
            }

            // Behandlung der Türme zum Gegner
            foreach (Object obj in objects)
            {
                if (obj.GetObjectType != ObjectType.Tower) continue;
                obj.Enemies = enemies; // Liste alle verfügbaren Gegner wird an den Turm Übergeben (für Fläschenschaden zb)
                if (obj.HasTarget == false) obj.GetClosestEnemy(enemies);
                obj.HasEnergy = true;
                if (energyDemand > energy) obj.HasEnergy = false;
                obj.Update(gameTime);
            }

            #region Produktion
            // Update der Gebäude
            foreach (Object obj in objects)
            {
                if (obj.GetObjectType != ObjectType.Building) continue;
                obj.HasEnergy = true;
                if (energyDemand > energy) obj.HasEnergy = false;
                obj.Update(gameTime);                
                
                switch (obj.BuildingType)
                {
                    case "Oil Station":
                        {                            
                            obj.TransferValue = int.MaxValue;
                            oil += obj.GetProductionStack;
                            break;
                        }
                    case "Metal Mine":
                        {
                            obj.TransferValue = int.MaxValue;
                            metal += obj.GetProductionStack;
                            break;
                        }
                }
            }
            #endregion

            oldState = mouseState; // HIer wird der alte Status der Mous überschrieben

            // Prüfen welche objekte gebaut werden können
            foreach (ObjectTypeConfig conf in objectTypeConfigs) conf.SetIsAvailable(this);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Object obj in objects) obj.Draw(spriteBatch);
        }

        /// <summary>
        /// Wird verwendet um zu Prüfen ob ein Spieler bei einem Klick
        /// auf das Spielfeld geklickt hat und welche Eigenschaften dieses
        /// hat (auf Spielfeld, Feld frei usw.)
        /// </summary>
        /// <returns>OK oder nicht OK</returns>
        private bool IsCellClear()
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // HAUPTPRÜFUNG (bei dieser wird nach standart Verfahren geprüft z.B.: für nochmale Bauprojekte 32x32) //
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // bool inBounds = cellX >= 0 && cellY >= 0 && cellX < level.Width && cellY < level.Height; // nochmal sicher gehen das der Turm auch wirklich sich auf dem Spielfeld befindet
            bool allRight = true;
            bool inBounds = true; // braucht man nicht da die Funktion das selber macht level.GetIndexWithBorder

            bool spaceClearObject = true;
            bool onPath = false;

            int tileValue = 0;
            
            foreach (Object obj in objects) // Nochmal nachsehen ob auf dem Feld auch wirkich kein Objekt sich bereits befindet
            {
                spaceClearObject = (obj.Position != new Vector2(tileX, tileY));

                // Prüfung für Große gebäude
                if (obj.IsLargeObjekt)
                {
                    foreach (Vector2 pos in obj.ObjectBlueprint)
                    {
                        if (!spaceClearObject) continue;
                        spaceClearObject = (pos != new Vector2(tileX, tileY));
                        if (!spaceClearObject) break;
                    }
                }

                if (!spaceClearObject) break;
            }

            tileValue = level.GetIndexWithBorder(cellX,cellY);
            if (tileValue == -1 || tileValue == 1 || tileValue == 2) onPath = true;
            else onPath = false;

            allRight = inBounds && spaceClearObject && !onPath; // Gibt OK falls wirklich beide Angaben (Feld frei, Auf dem Spielfeld) auf Wahr sind

            /////////////////////////////////////////////////////////////////////////////////
            // UNTERPRÜFUNG (falls z.B.: etwas gebaut wird das mehr als ein Feld einnimmt) //
            /////////////////////////////////////////////////////////////////////////////////
            bool subAllRight = true;
            if (newObjectType != "") // nur ausführen wenn ein neues Gebäude gebaut wird
            {
                if (objectTypeConfigs[newObjectIndex].ObjectBlueprint != null) // nur ausführen wenn das Gebäude ein "Großes" Gebäude werden soll
                {
                    foreach (Vector2 bluePrintPos in objectTypeConfigs[newObjectIndex].ObjectBlueprint)
                    {
                        bool subSpaceClearObject = true;
                        bool subOnPath = false;

                        int subTileValue = 0;

                        int subTileX = (int)( tileX + (C.BS * bluePrintPos.X) );
                        int subTileY = (int)( tileY + (C.BS * bluePrintPos.Y) );

                        foreach (Object obj in objects) // Nochmal nachsehen ob auf dem Feld auch wirkich kein Gebäude sich bereits befindet
                        {
                            subSpaceClearObject = (obj.Position != new Vector2(subTileX, subTileY));

                            // Prüfung für Große gebäude
                            if (obj.IsLargeObjekt)
                            {
                                foreach (Vector2 pos in obj.ObjectBlueprint)
                                {
                                    if (!subSpaceClearObject) continue;
                                    subSpaceClearObject = (pos != new Vector2(subTileX, subTileY));
                                    if (!subSpaceClearObject) break;
                                }
                            }

                            if (!subSpaceClearObject) break;
                        }

                        int subCellX = (int)((mouseState.X + (C.BS * bluePrintPos.X)) / C.BS);
                        int subCellY = (int)((mouseState.Y + (C.BS * bluePrintPos.Y)) / C.BS);

                        subTileValue = level.GetIndexWithBorder(subCellX, subCellY);
                        if (subTileValue == -1 || subTileValue == 1 || subTileValue == 2) subOnPath = true;
                        else onPath = false;

                        subAllRight = subSpaceClearObject && !subOnPath;
                        if (!subAllRight) break;
                    }
                }
            }


            return allRight && subAllRight;
        }

        // Constructor
        /// <summary>
        /// Speichert das Level und die Turmtexture eines Spielers
        /// </summary>
        /// <param name="level">Level</param>
        /// <param name="towerTexture">Texture eines Turms</param>
        /// <param name="bulletTexture">Texture einer Kugel dieses Turms</param>
        public Player(Level level, Texture2D[,] objectTexture, Texture2D[] bulletTexture, Texture2D rangeBorderTexture, Texture2D headupDisplayTexture, Texture2D previewGroundTexture)
        {
            this.level = level;
            this.objectTexture = objectTexture;
            this.bulletTexture = bulletTexture;
            this.rangeBorderTexture = rangeBorderTexture;
            this.headupDisplayTexture = headupDisplayTexture;

            this.previewGroundTexture = previewGroundTexture;

            createTowerTypes();
            createBuildingTypes();
        }
    }
}
