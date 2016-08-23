using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush.GUI
{
    class Toolbar
    {
        private SpriteFont font; // Hier wird unsere Schrift gespeichert

        private Vector2 position; // Position der Toolbar
        private Vector2 textPosition; // Position des Textes auf der Toolbar

        // Constructor
        public Toolbar(SpriteFont font, Vector2 position)
        {
            this.font = font;

            this.position = position;
            textPosition = new Vector2(300, position.Y + 1);
        }
        public void Draw(SpriteBatch spriteBatch, Player player)
        {
            string text = string.Format("Gold : {0} Leben : {1} Energy : {2}\r\n Oel : {3} Metall : {4} Kerne : {5} Welle : {6}",
                player.Money, player.Lives, player.Energy - player.EnergyDemand,
                player.Oil, player.Metal, player.Core, player.WaveFinished);
            spriteBatch.DrawString(font, text, textPosition, Color.White);
        }
    }
}
