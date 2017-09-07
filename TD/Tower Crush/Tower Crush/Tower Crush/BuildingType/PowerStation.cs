using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush.BuildingType
{
    public class PowerStation : Object
    {
        public override bool HasEnergy
        {
            get
            {
                return false;
            }
            set
            {
                base.HasEnergy = value;
            }
        }
        public PowerStation(Texture2D[] texture, Texture2D bulletTexture, Texture2D rangeBorderTexture, Texture2D headupDisplayTexture, ObjectTypeConfig objectTypeConfig, Vector2 position)
            : base(texture, bulletTexture, rangeBorderTexture, headupDisplayTexture, objectTypeConfig, position)
        {
            this.buildingType = objectTypeConfig.Name;
            this.headupDisplay = new GUI.HeadupDisplay(headupDisplayTexture, position);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
