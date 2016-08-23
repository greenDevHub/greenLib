using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Fisch_Eater
{
    class Fisch
    {
        public const int WIDTH = 27;
        public const int HEIGHT = 34;

        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }
        public bool Landed { get; set; }
        public bool WormEaten { get; set; }
        public bool RedHat { get; set; }
        public bool Treasurechest { get; set; }
        public bool Jumpt { get; set; }
    }
}
