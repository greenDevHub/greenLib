using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush.EnemyStorage
{
    class Protector : Enemy
    {
        // Constructor
        public Protector(Texture2D texture, Vector2 position, int health, float speed, float bountyToHealth)
            : base(texture, position, health, speed, bountyToHealth)
        {
            this.armor = 8f;
            this.armorValue = 300;
        }

    }
}
