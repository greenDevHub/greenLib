using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace RabbitCode.Samples.MoonTaxi
{
    class Taxi
    {
        public const int WIDTH = 50;
        public const int HEIGHT = 25;

        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }
        public bool Landed { get; set; }
        public bool GuestLoaded { get; set; }

        public float JetLeft { get; set; }
        public float JetRight { get; set; }
        public float JetBottom { get; set; }
    }
}
