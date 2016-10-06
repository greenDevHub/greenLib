using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush.EnemyStorage
{
    class Boss : Enemy
    {
        // Constructor
        public Boss(Texture2D texture, Vector2 position, int health, float speed, float bountyToHealth)
            : base(texture, position, health, speed, bountyToHealth)
        {
            this.armor = 6f;
            this.armorValue = 800;
        }

    }
}
