using System;
using System.Collections.Generic;

namespace Tile_Engine_Tutorial_1
{
    class MapCell
    {
        public void AddBaseTile(int tileID)
        {
            BaseTiles.Add(tileID);
        }
        public void AddHeightTile(int tileID)
        {
            HeightTiles.Add(tileID);
        }
        public void AddTopperTile(int tileID)
        {
            TopperTiles.Add(tileID);
        }

        public int TileID
        {
            get { return BaseTiles.Count > 0 ? BaseTiles[0] : 0; }
            set
            {
                if (BaseTiles.Count > 0)
                    BaseTiles[0] = value;
                else
                    AddBaseTile(value);
            }
        }

        public MapCell(int tileID)
        {
            Explored = false;
            TileID = tileID;
        }

        public List<int> BaseTiles = new List<int>();
        public List<int> HeightTiles = new List<int>();
        public List<int> TopperTiles = new List<int>();

        public bool Explored { get; set; }
    }
}
