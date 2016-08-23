using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush
{
    public class Building_ : Sprite
    {
        protected int cost; // Goldkosten
        protected int oilCost; // Ölkosten
        protected int metalCost; // Metallkosten
        protected int coreCost; // Kernkosten
        protected int powerProduction; // Wie viel Enegie vom Gebäude hergestellt wird
        protected int enegyConsume; // Wie viel Enegie vom Gebäude verbraucht wird

        protected int productionUnit; // Wie viel Hergestellt wird
        protected int productionTime; // Wie lang gebraucht wird um Herzustellen
        protected float productionLastTime; // Wann wurde zum letzten mal etwas Hergestellt
        protected int productionUnitStack; // Lager der Rohstoffe die vom Spieler abgeholt werden kannt
        protected int transferValue; // Der tatsächlichte Wert der vom Spieler abgeholt wird

        protected bool hasEnergy; // Benötigt das Gebäude auch Energie

        protected bool isSelected = false;
        protected Rectangle[] border; // Zeichnet ein Rechteck um das Gebäude um es zu anklicken zu können

        protected string buildingType; // Typ des Gebäudes

        protected Vector2[] buildingBlueprint; // Eine Art Blaupause für das Gebäude damit wird platz reserviert für Größere Gebäude (mehr als 32x32)

        // Menü für Objekte
        protected Texture2D headupDisplayTexture;
        protected GUI.HeadupDisplay headupDisplay;

        /// <summary>
        /// Gibt alle "Kästen" des Gebäudes wieder
        /// </summary>
        public Rectangle[] Border
        {
            set { border = value; }
            get { return border; }
        }

        /// <summary>
        /// Die Kosten des Gebäudes in Gold
        /// </summary>
        public int Cost
        {
            get { return cost; }
        }
        /// <summary>
        /// Kosten des Gebäudes in Öl
        /// </summary>
        public int OilCost
        {
            get { return oilCost; }
        }
        /// <summary>
        /// Kosten des Gebäudes in Metall
        /// </summary>
        public int MetalCost
        {
            get { return metalCost; }
        }
        /// <summary>
        /// Kosten des Gebäudes in Kernen
        /// </summary>
        public int CoreCost
        {
            get { return coreCost; }
        }
        /// <summary>
        /// Stellt den Wert dar den dieses Gebeute an Engergie Produziert.
        /// Diesen Wert kann man nur wiedergeben
        /// </summary>
        public int PowerProduction
        {
            get { return powerProduction; }
        }
        /// <summary>
        /// Stellt den Wert dar den dieses Gebäude verbraucht an Energie.
        /// Dieser Wert kann nur wiedergegeben werden
        /// </summary>
        public int EnegyConsume
        {
            get { return enegyConsume; }
        }
        /// <summary>
        /// Zeit an wie viel ein Gebäude in einer Zeiteinheit
        /// herstellen kann.
        /// Dieser Wert kann nur wiedergegeben werden
        /// </summary>
        public int ProductionUnit
        {
            get { return productionUnit; }
        }
        /// <summary>
        /// Zeigt an wie lang ein Gebäude braucht 
        /// um eine Einheit herzustellen.
        /// Dieser Wert kann nur wiedergegeben werden
        /// </summary>
        public int ProductionTime
        {
            get { return productionTime; }
        }
        /// <summary>
        /// Gibt an ob das Gebäude genug Energie zum herstellen
        /// hat.
        /// Dieser Wert kann gesetzt und wiedergegeben werden.
        /// </summary>
        public virtual bool HasEnergy
        {
            get { return hasEnergy; }
            set { hasEnergy = value; }
        }
        /// <summary>
        /// Stellt den Wert dar den das Gebäude produziert hat.
        /// Dieser kann dann vom Spieler abgeholt werden muss
        /// dabei aber auf 0 zurückgestellt bzw. die abgeholte 
        /// Menge davom abgezogen werden
        /// </summary>
        public int ProductionUnitStack
        {
            get { return productionUnitStack; }
        }
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
        /// <summary>
        /// Gibt den Typ des Gebäudes wieder.
        /// Dieser Wert kann nur zurückgegeben werden
        /// </summary>
        public string BuildingType
        {
            get { return buildingType; }
        }
        /// <summary>
        /// Gibt alle Felder wieder die noch durch das Gebäude reserviert 
        /// werden für Gebäude die Größer sind als (32x32)
        /// </summary>
        public virtual Vector2[] BuildingBlueprint
        {
            get { return buildingBlueprint; }
        }
        /// <summary>
        /// Gibt wieder ob ein Gebäude ein "Großes Gebäude" ist.
        /// </summary>
        public virtual bool IsLargeBuilding
        {
            get
            {
                if (buildingBlueprint != null) return true;
                return false;
            }
        }
        /// <summary>
        /// Gibt an ob das Gebäude ausgewählt wurde oder nicht
        /// </summary>
        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }


        /// <summary>
        /// In dieser Funktion wird ein Wert zurückgegeben 
        /// von den Rohstoffe die an den Spieler übergeben 
        /// werden können vom Lager des Gebäudes. Dazu muss
        /// aber im Vorfeld unbedingt ein Transferwert
        /// also ein Abholwert dem Gebäude zugewiesen werden.
        /// Gibt nur werte zurück.
        /// </summary>
        public int GetProductionStack
        {
            get 
            {
                // Prüfen ob was auf dem Lager des Gebäudes liegt
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

        /// <summary>
        /// Füllt die "buildingBlueprint" mit Werten die dazu notwendigt sind
        /// um Größere Gebäude zu erschaffen.
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

                buildingBlueprint = oldIndexBluePrint;
            }
        }

        // Constructor
        public Building_(Texture2D texture, Vector2 position, ObjectTypeConfig nulll, Texture2D headupDisplayTexture)
            : base(texture, position)
        {
            this.cost = buildingTypeConfig.Cost;
            this.oilCost = buildingTypeConfig.OilCost;
            this.metalCost = buildingTypeConfig.MetalCost;
            this.coreCost = buildingTypeConfig.CoreCost;
            this.enegyConsume = buildingTypeConfig.EnegyConsume;

            this.powerProduction = buildingTypeConfig.PowerProduction;
            this.productionUnit = buildingTypeConfig.ProductionUnit;
            this.productionTime = buildingTypeConfig.ProductionTime;

            this.headupDisplayTexture = headupDisplayTexture;

            FillBluePrint(buildingTypeConfig.BuildingBlueprint);

            // Erstellen vom Rechtecken die man anklicken kann später um dieses Gebäude auswählen zu können
            if (buildingBlueprint == null) this.border = new Rectangle[1];
            else this.border = new Rectangle[(int)(buildingBlueprint.GetLength(0) + 1)];
            
            int i = 0;
            this.border[i] = new Rectangle((int)position.X, (int)position.Y, C.BS, C.BS);
            // Nur ausführen wenn überhaupt eine Blaupause vorliegt
            if (buildingBlueprint != null)
            {
                foreach (Vector2 pos in buildingBlueprint)
                {
                    i++;
                    this.border[i] = new Rectangle((int)pos.X, (int)pos.Y, C.BS, C.BS);
                }
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
            base.Update(gameTime);

            productionLastTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (IsSelected) headupDisplay.Draw(spriteBatch);
            base.Draw(spriteBatch);            
        }

    }
}
