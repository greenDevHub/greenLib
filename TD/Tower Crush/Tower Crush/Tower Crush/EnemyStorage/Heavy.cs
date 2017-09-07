using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush.EnemyStorage
{
    class Heavy : Enemy
    {
        // Constructor
        public Heavy(Texture2D texture, Vector2 position, int health, float speed, float bountyToHealth)
            : base(texture, position, health, speed, bountyToHealth)
        {
            this.armor = 4f;
            this.armorValue = 300;
        }

    }
}
