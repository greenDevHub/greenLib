using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Tower_Crush
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



        /// <summary>
        /// Eine Referenz zu den Knoten welche übertragen
        /// wurden zu der "Open List". Diese wird verwendet
        /// um den Pfad zu finden von Ziel zurück zum Start
        /// </summary>
        public SearchNode Parent;
        /// <summary>
        /// Ermöglicht eine schnelle Erkennung
        /// ob ein Knoten in der "Open List" 
        /// sich befindet
        /// </summary>
        public bool InOpenList;
        /// <summary>
        /// Ermöglicht eine schnelle Erkennung
        /// ob ein Knoten in der "Closed List" 
        /// sich befindet
        /// </summary>
        public bool InClosedList;

        /// <summary>
        /// Die ungefähre Entfernung vom Start Knoten
        /// zu dem Ziel wenn der Pfad druch diesen Knoten geht (F)
        /// </summary>
        public float DistanceToGoal;
        /// <summary>
        /// Die Enfernung die zurückgelegt wurde
        /// vom dem Punkt wo der "Gegner" zum 
        /// ersten mal aufgetaucht ist "Gespawnt"
        /// </summary>
        public float DistanceTraveled;
        
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

        /// <summary>
        /// Speichert die Knoten die für die Suche auch
        /// wirklich noch verfügbar sind
        /// </summary>
        private List<SearchNode> openList = new List<SearchNode>();
        /// <summary>
        /// Speichert die Knoten die schon "bereist" wurden
        /// </summary>
        private List<SearchNode> closedList = new List<SearchNode>();

        /// <summary>
        /// Gibt die berechnete Entfernung zwischen
        /// 2 Punkten wieder (H)
        /// </summary>
        /// <param name="point1">Punkt 1</param>
        /// <param name="point2">Punkt 2</param>
        /// <returns></returns>
        private float Heuristic(Point point1, Point point2)
        {
            return Math.Abs(point1.X - point2.X) +
                Math.Abs(point1.Y - point2.Y);
        }

        /// <summary>
        /// Resetet den Status des Suchknoten
        /// </summary>
        private void ResetSearchNodes()
        {
            openList.Clear();
            closedList.Clear();

            for (int x = 0; x < levelWidth; x++)
            {
                for (int y = 0; y < levelHeight; y++)
                {
                    SearchNode node = searchNodes[x, y];

                    if (node == null) continue;

                    node.InOpenList = false;
                    node.InClosedList = false;

                    node.DistanceTraveled = float.MaxValue;
                    node.DistanceToGoal = float.MaxValue;
                }
            }

        }

        /// <summary>
        /// Gibt den Knoten wieder mit der kürzesten Enfernung zum Ziel
        /// </summary>
        /// <returns>Das nächste Feld was die kürzeste Enfernung zum Ziel hat</returns>
        private SearchNode FindBestNode()
        {
            SearchNode currentTile = openList[0];

            float smallestDistanceToGoal = float.MaxValue;

            // Findet den Knoten mit der kürzesten 
            // Enfernung zum Ziel
            for (int i = 0; i < openList.Count; i++)
            {
                if (openList[i].DistanceToGoal < smallestDistanceToGoal)
                {
                    currentTile = openList[i];
                    smallestDistanceToGoal = currentTile.DistanceToGoal;
                }
            }

            return currentTile;
        }

        /// <summary>
        /// Verwendet "Parent" Feld vom Suchknoten um eine
        /// Route zu finden vom Startknoten zum Endknoten
        /// </summary>
        /// <param name="startNode">Startknoten</param>
        /// <param name="endNode">Endknoten</param>
        /// <returns></returns>
        private List<Vector2> FindFinalPath(SearchNode startNode, SearchNode endNode)
        {
            closedList.Add(endNode);

            SearchNode parentTile = endNode.Parent;

            // Verfolgung zurück durch den Knoten unter
            // Verwendung des "Parent" Feldes um den besten Weg zu finden
            while (parentTile != startNode)
            {
                closedList.Add(parentTile);
                parentTile = parentTile.Parent;
            }

            List<Vector2> finalPath = new List<Vector2>();

            // Umkehrung des Weges um es auf die Größe der Welt
            // umzuwaldeln
            for (int i = closedList.Count - 1; i >= 0; i--)
            {
                finalPath.Add(new Vector2(closedList[i].Position.X * 32,
                    closedList[i].Position.Y * 32));
            }

            return finalPath;
        }

        /// <summary>
        /// Findet den optimalen Pfad von einem punkt zu dem anderem
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        public List<Vector2> FindPath(Point startPoint, Point endPoint)
        {
            // Gesucht wird nur wenn die beiden Punkte unterschiedlich sind
            if (startPoint == endPoint) return new List<Vector2>();

            //////////////////////////////////////////////////////////////////////////////////////
            // Schritt 1 :  Bereiningung von Open / Closed List und Reseten von jeden Knoten’s F// 
            //              und G "values" für den Fall das diese noch vom letzten              //
            //              mal gesetzt sind wo ein Pfad gesucht wurde                          //
            //////////////////////////////////////////////////////////////////////////////////////

            ResetSearchNodes();

            // Speichern der Referenz zu start und end Knoten
            SearchNode startNode = searchNodes[startPoint.X, startPoint.Y];
            SearchNode endNode = searchNodes[endPoint.X, endPoint.Y];

            //////////////////////////////////////////////////////////////////////////////////////
            // Schritt 2 :  Setzt den Wert des Start Knotes G und F Wert zu der geschätzten     //
            //              Enfernung zwischen des Start Knotes und Ziel Knotes (hier kommt     //
            //              Funktion H zum tragen) und fügt es in die "OpenList" hinzu          //
            //////////////////////////////////////////////////////////////////////////////////////

            startNode.InOpenList = true;

            startNode.DistanceToGoal = Heuristic(startPoint, endPoint);
            startNode.DistanceTraveled = 0;

            openList.Add(startNode);

            //////////////////////////////////////////////////////////////////////////////////////
            // Schritt 3 :  Solang es Knoten gibt in der "OpenList" auf die Geschaut werden muss//
            //////////////////////////////////////////////////////////////////////////////////////
            while (openList.Count > 0)
            {
                /////////////////////////////////////////////////////////////////
                // a) : Eine Schleife durch die "OpenList" um den Knoten zu    //
                //      finden mit den kleinsten F wert.                       //
                /////////////////////////////////////////////////////////////////
                SearchNode currentNode = FindBestNode();

                /////////////////////////////////////////////////////////////////
                // b) : Wenn die "OpenList" leer ist oder keine Knoten gefunden//
                //      kein Pfad kann gefunden werden Algorithm abrechen      //
                /////////////////////////////////////////////////////////////////
                if (currentNode == null) break;

                /////////////////////////////////////////////////////////////////
                // c) : Wenn der Aktive Knoten der Zielknoten ist muss der Pfad//
                //      als finaler Pfad wiedergegeben werden                  //
                /////////////////////////////////////////////////////////////////
                if (currentNode == endNode)
                {
                    return FindFinalPath(startNode, endNode);
                }

                /////////////////////////////////////////////////////////////////
                // d) : Ansonsten für jeden aktiven Knoten des "Nachbarn" gehen//
                /////////////////////////////////////////////////////////////////
                for (int i = 0; i < currentNode.Neighbors.Length; i++)
                {
                    SearchNode neighbor = currentNode.Neighbors[i];

                    /////////////////////////////////////////////////////////
                    // i) : Sicher gehen das der Nachbarknoten             //
                    //      druchgangen werden kann                        //
                    /////////////////////////////////////////////////////////
                    if (neighbor == null || neighbor.Walkable == false) continue;

                    /////////////////////////////////////////////////////////
                    // ii) : Berechnung eines neuen G Wertes für den       //
                    //       "Nachbar" Knoten                              //
                    /////////////////////////////////////////////////////////
                    float distanceTraveled = currentNode.DistanceTraveled + 1;
                    // Schätzen der Enferung des Knoten zu dem End Knoten
                    float heuristic = Heuristic(neighbor.Position, endPoint);

                    /////////////////////////////////////////////////////////
                    // iii) : Wenn der Nachbarknoten nicht in den beiden   //
                    //        Listen ist "OpenList" und "ClosedList" :     //
                    /////////////////////////////////////////////////////////
                    if (neighbor.InOpenList == false && neighbor.InClosedList == false)
                    {
                        // (1) Setze des Nachbarknotens G Wert zu dem G Wert
                        // der gerade berechnet wurden ist
                        neighbor.DistanceTraveled = distanceTraveled;

                        // (2) Setzen des Nachbarknotens F Wert zu den neuen
                        // Werft von G (Die geschätze Enfernung zwischen
                        // Nachbarknoten und Zielknoten)
                        neighbor.DistanceToGoal = distanceTraveled + heuristic;

                        // (3) Setzen des Nachbarknotens "Parent" Eigenschaft
                        // zu Punkt von des aktiven Knotens
                        neighbor.Parent = currentNode;

                        // (4) Hinzufügen des Nachbarknotes zu der "OpenList"
                        neighbor.InOpenList = true;
                        openList.Add(neighbor);
                    }
                    /////////////////////////////////////////////////////////
                    // iv) :  Wenn der Nachbarknoten nicht in den beiden   //
                    //        Listen ist "OpenList" und "ClosedList" ELSE  //
                    /////////////////////////////////////////////////////////
                    else if (neighbor.InOpenList || neighbor.InClosedList)
                    {
                        // (1) Ist der G Wert kleiner als der des Nachbar-
                        // knotens G Wert (es wird das selbe gemacht als
                        // wenn der Knoten nicht in der "OpenList" sich
                        // befindet außer das der Knoten zu der "OpenList"
                        // hinzugefügt wird
                        if (neighbor.DistanceTraveled > distanceTraveled)
                        {
                            neighbor.DistanceTraveled = distanceTraveled;
                            neighbor.DistanceToGoal = distanceTraveled + heuristic;

                            neighbor.Parent = currentNode;
                        }
                    }
                }
                /////////////////////////////////////////////////////////////////
                // e) : Enfernen des Aktiven Knoten von "OpenList" und hinzu-  //
                //      fügen zu der "ClosedList"                              //
                /////////////////////////////////////////////////////////////////
                openList.Remove(currentNode);
                currentNode.InClosedList = true;
            }

            // Kein Pfad konnte gefunden werden
            return new List<Vector2>();
        }

        // Constructor
        public Pathfinder(Level level)
        {
            levelWidth = level.Width;
            levelHeight = level.Height;

            InitializeSearchNodes(level);
        }

        private void InitializeSearchNodes(Level level)
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
                    node.Walkable = level.GetIndex(x, y) == 1;

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
