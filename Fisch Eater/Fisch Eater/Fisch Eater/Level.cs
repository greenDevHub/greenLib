using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.IO;

namespace Fisch_Eater
{
    enum FieldType
    {
        Nothing,
        Bridge,
        Startpoint,
        Guest,
        Goal,
        Brick,
        Plant,
        AppleTree,
        Tree,
        BrickHouse,
        BrickWall,
        BrickTower,
        RedHat,
        Treasurechest
    }

    class Level
    {
        public const int ROWCOUNT = 36;
        public const int COLUMNCOUNT = 64;

        public Level(string filename)
        {
            string[] lines = File.ReadAllLines(filename);

            if (lines.Length != ROWCOUNT)
                throw new InvalidDataException("Falsche Anzahl Zeilen");

            Fields = new FieldType[COLUMNCOUNT, ROWCOUNT];
            bool startPointFound = false;
            bool guestPointFound = false;
            bool goalPointFound = false;
            bool redhatPointFound = false;
            bool treasurechestPointFound = false;

            int row = 0;
            foreach (string line in lines)
            {
                for (int column = 0; column < COLUMNCOUNT; column++)
                {
                    if (line.Length != COLUMNCOUNT)
                        throw new InvalidDataException("Falsche Anzahl Spalten in Reihe " + row);

                    switch (line[column])
                    {
                        case '.': Fields[column, row] = FieldType.Nothing; break;
                        case '#': Fields[column, row] = FieldType.Bridge; break;
                        case 'z': Fields[column, row] = FieldType.Brick; break;
                        case 'p': Fields[column, row] = FieldType.Plant; break;
                        case 'a': Fields[column, row] = FieldType.AppleTree; break;
                        case 'h': Fields[column, row] = FieldType.BrickHouse; break;
                        case 'w': Fields[column, row] = FieldType.BrickWall; break;
                        case 't': Fields[column, row] = FieldType.BrickTower; break;
                        case 'T': Fields[column, row] = FieldType.Tree; break;

                        case 'r':
                            if (startPointFound)
                                throw new InvalidDataException("Mehr als ein Roter Hut vorhanden");

                            Fields[column, row] = FieldType.RedHat;
                            RedHatPoint = new Vector2(column, row);
                            redhatPointFound = true;
                            break;

                        case 'c':
                            if (treasurechestPointFound)
                                throw new InvalidDataException("Mehr als eine Schatz Kiste vorhanden");

                            Fields[column, row] = FieldType.Treasurechest;
                            TreasureChestPoint = new Vector2(column, row);
                            treasurechestPointFound = true;
                            break;

                        case '1':
                            if (startPointFound)
                                throw new InvalidDataException("Mehr als ein Startpunkt vorhanden");

                            Fields[column, row] = FieldType.Startpoint;
                            StartPoint = new Vector2(column, row);
                            startPointFound = true;
                            break;

                        case '2':
                            if (guestPointFound)
                                throw new InvalidDataException("Mehr als ein Wurm vorhanden");

                            Fields[column, row] = FieldType.Guest;
                            GuestPoint = new Vector2(column, row);
                            guestPointFound = true;
                            break;

                        case '3':
                            if (goalPointFound)
                                throw new InvalidDataException("Mehr als ein Zielpunkt vorhanden");

                            Fields[column, row] = FieldType.Goal;
                            GoalPoint = new Vector2(column, row);
                            goalPointFound = true;
                            break;
                    }
                }
                row++;
            }

            if (!startPointFound)
                throw new InvalidDataException("Kein Startpunkt definiert");
            if (!guestPointFound)
                throw new InvalidDataException("Kein Wurmpunkt definiert");
            if (!goalPointFound)
                throw new InvalidDataException("Kein Zielpunkt definiert");
            //Nur Optional an machen!
            if (!redhatPointFound)
                redhatPointFound = false;
                //throw new InvalidDataException("Kein Roter Hut definiert");
            if (!treasurechestPointFound)
                treasurechestPointFound = false;
                //throw new InvalidDataException("Keine Schatzkiste definiert");
        }

        public FieldType[,] Fields { get; private set; }
        public Vector2 StartPoint { get; private set; }
        public Vector2 GuestPoint { get; private set; }
        public Vector2 GoalPoint { get; private set; }
        public Vector2 RedHatPoint { get; private set; }
        public Vector2 TreasureChestPoint { get; private set; }
    }
}
