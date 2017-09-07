using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush.BuildingType
{
    public class Refinery : Object
    {
        public Refinery(Texture2D[] texture, Texture2D bulletTexture, Texture2D rangeBorderTexture, Texture2D headupDisplayTexture, ObjectTypeConfig objectTypeConfig, Vector2 position)
            : base(texture, bulletTexture, rangeBorderTexture, headupDisplayTexture, objectTypeConfig, position)
        {
            this.buildingType = objectTypeConfig.Name;
            this.headupDisplay = new GUI.HeadupDisplay(headupDisplayTexture, position);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // Prüfen ob Produziert werden kann
            if (productionLastTime > productionTime)
            {
                // Prüfen ob genug Enegy da ist um zu Feuern
                if (this.HasEnergy)
                {
                    // Produzierte Einheit auf das Lager des Gebäudes gut schreiben
                    productionUnitStack += productionUnit;

                    // Timer Zurückstellen nur wenn auch was Hergestellt wurde
                    productionLastTime = 0;
                }                
            }
        }
    }
}
