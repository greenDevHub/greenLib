using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tower_Crush
{
    public class Level
    {
        //int[,] map = new int[,]
        //{
        //{0,0,1,0,0,0,0,0,},
        //{0,0,1,1,0,0,0,0,},
        //{0,0,0,1,1,0,0,0,},
        //{0,0,0,0,1,0,0,0,},
        //{0,0,0,1,1,0,0,0,},
        //{0,0,1,1,0,0,0,0,},
        //{0,0,1,0,0,0,0,0,},
        //{0,0,1,1,1,1,1,1,},
        //};        

        //int[,] map = new int[,]
        //{
        //{0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //{0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,},
        //{0,0,0,0,1,0,0,0,0,0,0,0,1,1,1,0,},
        //{0,1,1,1,1,0,0,0,0,0,1,1,1,0,1,0,},
        //{0,1,0,0,0,0,0,0,0,0,1,0,0,0,1,0,},
        //{1,1,0,0,0,0,0,0,0,0,1,0,0,0,1,1,},
        //{1,0,0,0,0,0,1,1,1,0,1,0,0,0,0,0,},
        //{1,1,1,1,1,1,1,0,1,1,1,0,0,0,0,0,},
        //};

        //int[,] map = new int[,]
        //{
        //    {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,0,0,0,1,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,0,1,1,1,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,1,1,1,0,0,0,0,0,0,0,},
        //    {0,0,0,1,1,0,0,0,0,0,0,0,1,1,1,0,0,0,1,0,0,0,0,0,0,0,},
        //    {0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,},
        //    {0,0,0,1,1,1,1,1,1,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,},
        //    {0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,1,1,1,1,1,1,1,1,},
        //    {0,0,0,0,0,0,1,1,1,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        //};

        int[,] map = new int[,]
        {
            {0,0,0,0,0,0,0,0,2,2,2,2,2,2,2,2,2,2,2,2,},
            {1,1,1,0,0,0,0,0,0,2,2,2,2,2,2,2,2,2,2,2,},
            {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,},
            {0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,2,2,},
            {0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,2,},
            {0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
            {0,0,0,0,0,1,0,0,0,0,0,1,1,1,1,1,0,0,0,0,},
            {0,0,0,1,1,1,0,0,0,0,0,1,0,0,0,1,0,0,0,0,},
            {0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,1,1,1,0,0,},
            {0,0,1,1,0,0,0,0,0,0,0,1,1,1,0,0,0,1,0,0,},
            {0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,},
            {0,0,1,1,1,1,1,1,0,0,0,0,0,1,0,0,0,1,0,0,},
            {0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,1,1,1,},
            {0,0,0,0,0,0,1,1,0,0,0,1,1,1,0,0,0,0,0,0,},
            {0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,},
            {0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,},
            {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
        };


        public List<Texture2D> tileTextures = new List<Texture2D>();
        private Queue<Vector2> waypoints = new Queue<Vector2>();

        public void AddTexture(Texture2D texture)
        {
            tileTextures.Add(texture);
        }

        public int Width
        {
            get { return map.GetLength(1); }
        }

        public int Height
        {
            get { return map.GetLength(0); }
        }

        public void Draw(SpriteBatch batch)
        {            
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    int textureIndex = map[y, x];
                    if (textureIndex == -1) continue;
                    
                    Texture2D texture = tileTextures[textureIndex];
                    batch.Draw(texture, new Rectangle((1 + x) * 32, (1 + y) * 32, 32, 32), Color.White); // @@
                }
            }
        }
        
        public Level()
        {
        }

        public Queue<Vector2> Waypoints
        {
            get { return waypoints; }
            set { waypoints = value; }
        }

        /// <summary>
        /// Gibt eine einzelne Kachel wieder die sich auf dem Spielfeld
        /// befindet und auch die Information was es für eine Kachel ist
        /// z.B.: 0 für Gras 1 für Weg usw.
        /// </summary>
        /// <param name="cellX">X Position einer Maus</param>
        /// <param name="cellY">Y Position einer Maus</param>
        /// <returns>Index der Betroffenen Zelle auf der Spielfeld wenn
        /// außerhalb vom Spielfeld ist der Index 0</returns>
        public int GetIndex(int cellX, int cellY)
        {
            if (cellX < 0 || cellX > Width - 1 || cellY < 0 || cellY > Height - 1) return 0;
            return map[cellY, cellX];
        }

        /// <summary>
        /// Gibt eine einzelne Kachel wieder die sich auf dem Spielfeld
        /// befindet und auch die Information was es für eine Kachel ist
        /// z.B.: 0 für Gras 1 für Weg usw.
        /// Dazu werden die beiden Werde um 1 Plus gerechnet wegen dem Rand
        /// oben und links!!!
        /// </summary>
        /// <param name="cellX">X Position einer Maus</param>
        /// <param name="cellY">Y Position einer Maus</param>
        /// <returns>Index der Betroffenen Zelle auf der Spielfeld wenn
        /// außerhalb vom Spielfeld ist der Index 0</returns>
        public int GetIndexWithBorder(int cellX, int cellY)
        {
            // Werte müssen aufgerechnet werden Aufgrund von Rand oben unten links!
            cellX--;
            cellY--;

            if (cellX < 0 || cellX > Width - 1 || cellY < 0 || cellY > Height - 1) return -1;
            return map[cellY, cellX];
        }
    }
}
