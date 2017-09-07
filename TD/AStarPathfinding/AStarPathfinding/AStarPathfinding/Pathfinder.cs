using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace AStarPathfinding
{
    /// <summary>
    /// Representiert eine Node in dem gesuchten Platz
    /// </summary>
    public class SearchNode
    {
        /// <summary>
        /// Position auf der Karte
        /// </summary>
        public Point Position;
        /// <summary>
        /// Wenn wahr dann kann dieses Feld betreten werden
        /// </summary>
        public bool Walkable;
        /// <summary>
        /// Hier werden die Felder die um die Node herum liegen
        /// gespeichert (Oben, Unten, Rechts, Links)
        /// </summary>
        public SearchNode[] Neighbors;
    }

    public class Pathfinder
    {
        /// <summary>
        /// Speichert ein Array von allen Felder ab die
        /// Walkable (betretbar) sind
        /// </summary>
        private SearchNode[,] searchNodes;

        /// <summary>
        /// Die Breite des Levels
        /// </summary>
        private int levelWidth;
        /// <summary>
        /// Die Höhe des Levels
        /// </summary>
        private int levelHeight;

        // Constructor
        public Pathfinder(Map map)
        {
            levelWidth = map.Width;
            levelHeight = map.Height;

            InitializeSearchNodes(map);
        }

        private void InitializeSearchNodes(Map map)
        {
            searchNodes = new SearchNode[levelWidth, levelHeight];

            // Für jedes Feld auf unserer Karte,
            // wird ein Suchknoten erstellt
            for (int x = 0; x < levelWidth; x++)
            {
                for (int y = 0; y < levelHeight; y++)
                {
                    // Erstellen eines Suchknoten der dieses Feld representiert
                    SearchNode node = new SearchNode();
                    node.Position = new Point(x, y);

                    // Gegner können nur auf bestimten oberfläschen laufen
                    node.Walkable = map.GetIndex(x, y) == 0;

                    // Wir speichern nur Knoten die man 
                    // auch betreten kann
                    if (node.Walkable)
                    {
                        node.Neighbors = new SearchNode[4];
                        searchNodes[x, y] = node;
                    }
                }
            }

            // Alle Suchknoten werden mit ihren 
            // Nachbarn verbunden
            for (int x = 0; x < levelWidth; x++)
            {
                for (int y = 0; y < levelHeight; y++)
                {
                    SearchNode node = searchNodes[x, y];

                    // Verarbeitung nur von Knoten die
                    // man auch betreten kann
                    if (node == null || node.Walkable == false) continue;

                    // Array von alle Nachbarn die dieser Knoten
                    // hat und nur die die man auch belaufen kann
                    Point[] neighbors = new Point[]
                    {
                        new Point (x,y -1), // Knoten über unserem aktuellen Knoten
                        new Point (x,y +1), // Knoten unter unserem aktuellen Knoten
                        new Point (x -1,y), // Knoten links von unserem aktuellen Knoten
                        new Point (x +1,y), // Knoten rechts von unserem aktuellen Knoten
                    };

                    // Schleife durch alle möglichten Nachbarn
                    for (int i = 0; i < neighbors.Length; i++)
                    {
                        Point position = neighbors[i];

                        // Nochmals sichergehen das dieser "Nachbar" auch
                        // wirklich ein Teil des levels ist

                        if (position.X < 0 || position.X > levelWidth - 1 ||
                            position.Y < 0 || position.Y > levelHeight - 1) continue;

                        SearchNode neighbor = searchNodes[position.X, position.Y];

                        // Es wird nochmal geprüft ob auch wirklich dieser Knoten
                        // der mit unserem verbunden werden soll zu betreten ist
                        if (neighbor == null || neighbor.Walkable == false) continue;

                        // Speichern der Referenz
                        node.Neighbors[i] = neighbor;
                    }
                }
            }

        }
    }
}
