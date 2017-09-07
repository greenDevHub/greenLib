using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Fisch_Eater
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        #region Texturen
        Texture2D fischTexture;
        Texture2D wurmTexture;
        Texture2D kisteTexture;
        Texture2D zielTexture;
        Texture2D ziegelTexture;
        Texture2D pflanzeTexture;
        Texture2D apfelbaumTexture;
        Texture2D baumTexture;
        Texture2D ziegelhausTexture;
        Texture2D ziegelmauerTexture;
        Texture2D ziegelturmTexture;
        Texture2D roterhutTexture;
        Texture2D schatzkisteTexture;
        #endregion


        SpriteFont schrift;


        Fisch fisch;
        Level level;

        public Vector2 oldfischPoint;

        int levelNumber = 1;
        public const int MAXLEVEL = 3;

        public float GRAVITY = 50.81f;
        public const float NOTMAL_GRAVITY_HARD = 100f;
        public const float FALL_GRAVITY_HARD = 1000f;
        public const float NOTMAL_GRAVITY_SOFT = 50.81f;
        public const float NORMAL_JETPOWER_HARD = 90f;
        public const float JUMP_JETPOWER_HARD = 500f;
        public const float JETPOWER_SOFT = 90f;
        public float JETPOWER = JETPOWER_SOFT;        
        public bool MOVETYPE_SOFT = false;

        public const int SCREENWIDTH = 1280;
        public const int SCREENHEIGHT = 720;
        public const int BLOCKSIZE = 20;
        public const float MAXLANDINGSPEED = 20f;
        public const float MAXPICKUPDISTANCE = 20f;
        public const float VIEWDISTANCE = 100;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = SCREENHEIGHT;
            graphics.PreferredBackBufferWidth = SCREENWIDTH; 
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            fisch = new Fisch();

            Reset();

            base.Initialize();
        }

        private void Reset()
        {
            
            level = new Level(@"Levels\level" + levelNumber + ".txt");
            fisch.Position = level.StartPoint * BLOCKSIZE;
            fisch.Speed = new Vector2();
            fisch.Landed = false;
            fisch.WormEaten = false;
            fisch.RedHat = false;
            fisch.Treasurechest = false;
            fisch.Jumpt = false;

            if (!MOVETYPE_SOFT)
            {
                GRAVITY = NOTMAL_GRAVITY_HARD;
                JETPOWER = NORMAL_JETPOWER_HARD;
            }
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            fischTexture = Content.Load<Texture2D>("Bilder\\Wesen\\Squid");
            kisteTexture = Content.Load<Texture2D>("Bilder\\Umgebung\\Kiste");
            wurmTexture = Content.Load<Texture2D>("Bilder\\Wesen\\Wurm");
            zielTexture = Content.Load<Texture2D>("Bilder\\Schalter\\Goal");
            ziegelTexture = Content.Load<Texture2D>("Bilder\\Umgebung\\Ziegel");
            pflanzeTexture = Content.Load<Texture2D>("Bilder\\Umgebung\\Pflanze");
            apfelbaumTexture = Content.Load<Texture2D>("Bilder\\Umgebung\\AppleTree");
            baumTexture = Content.Load<Texture2D>("Bilder\\Umgebung\\Tree");
            ziegelhausTexture = Content.Load<Texture2D>("Bilder\\Umgebung\\BrickHouse");
            ziegelmauerTexture = Content.Load<Texture2D>("Bilder\\Umgebung\\WallBrick");
            ziegelturmTexture = Content.Load<Texture2D>("Bilder\\Umgebung\\BrickTower");
            roterhutTexture = Content.Load<Texture2D>("Bilder\\Powerup\\RedhatFedora");
            schatzkisteTexture = Content.Load<Texture2D>("Bilder\\Powerup\\Treasurechest");

            schrift = Content.Load<SpriteFont>("fischeater_text");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }        

        #region Update
        /// <summary>
        /// Erlaub es die Steuerung abzufangen und auf bestimmte,
        /// Vorfälle zu Reagieren. Unterstüzt wird Tastatur und
        /// Gamepad
        /// </summary>
        /// <param name="forceX">Der Wert der X Achse wird hier befüllt.</param>
        /// <param name="forceY">Der Wert der Y Achse wird hier befüllt.</param>
        private void Steuerung_Update(ref float forceX, ref float forceY)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            // Gerätestatus abfragen
            GamePadState gamePad = GamePad.GetState(PlayerIndex.One);
            KeyboardState keyboard = Keyboard.GetState();

            // Tastatur anwenden
            if (keyboard.IsKeyDown(Keys.Left)) forceX += -1f;
            if (keyboard.IsKeyDown(Keys.Right)) forceX += 1f;
            if (keyboard.IsKeyDown(Keys.Up)) forceY += 1f;
            if (keyboard.IsKeyDown(Keys.Down)) forceY += -1f;

            // Gamepad anwenden
            forceX += gamePad.ThumbSticks.Left.X;
            forceY += gamePad.ThumbSticks.Left.Y;

            // Limitierung auf den Wertebereich -1 bis 1
            forceX = Math.Min(Math.Max(-1f, forceX), 1f);
            forceY = Math.Min(Math.Max(-1f, forceY), 1f); 
        }
        /// <summary>
        /// Erlaub es abzufragen was gefressen oder aufgenommen wird.
        /// Diese Objekte werdenn dann aus dem Spiel ausgeblendet
        /// </summary>
        private void Fressen_Update()
        {
            // Fressbehandlung
            Vector2 fischPoint = fisch.Position +
                new Vector2(Fisch.WIDTH / 2, Fisch.HEIGHT / 2);
            if (fisch.WormEaten)
            {
                Vector2 goalPoint = level.GoalPoint * BLOCKSIZE +
                    new Vector2(BLOCKSIZE / 2, BLOCKSIZE / 2);
                float distGoal = (fischPoint - goalPoint).LengthSquared();
                if (distGoal < MAXPICKUPDISTANCE * MAXPICKUPDISTANCE)
                {
                    // Nahe genug am Ziel - Level neu starten
                    levelNumber++;
                    Reset();
                }
            }
            else
            {
                Vector2 wormPoint = level.GuestPoint * BLOCKSIZE +
                    new Vector2(BLOCKSIZE / 2, BLOCKSIZE / 2);
                float distWorm = (fischPoint - wormPoint).LengthSquared();
                if (distWorm < MAXPICKUPDISTANCE * MAXPICKUPDISTANCE)
                {
                    // Nahe genug am Wurm - Wurm fressen
                    fisch.WormEaten = true;
                }
            }
            if (!fisch.RedHat)
            {
                Vector2 redhatPoint = level.RedHatPoint * BLOCKSIZE +
                    new Vector2(BLOCKSIZE / 2, BLOCKSIZE / 2);
                float distRedHat = (fischPoint - redhatPoint).LengthSquared();
                if (distRedHat < MAXPICKUPDISTANCE * MAXPICKUPDISTANCE)
                {
                    // Nahe genug am Roten Hut - Hut aufnehmen
                    fisch.RedHat = true;
                }
            }
            if (!fisch.Treasurechest)
            {
                Vector2 treasurechestPoint = level.TreasureChestPoint * BLOCKSIZE +
                    new Vector2(BLOCKSIZE / 2, BLOCKSIZE / 2);
                float distTreasureChest = (fischPoint - treasurechestPoint).LengthSquared();
                if (distTreasureChest < MAXPICKUPDISTANCE * MAXPICKUPDISTANCE)
                {
                    // Nahe genug an Schatzkiste - Schatzkiste aufnehmen
                    fisch.Treasurechest = true;
                }
            }
        }
        /// <summary>
        /// Hier wird die Bewegung, Gravitation, Schub gesteuert
        /// </summary>
        /// <param name="forceX">Der Wert der X Achse wird hier verwendet.</param>
        /// <param name="forceY">Der Wert der Y Achse wird hier verwendet.</param>
        /// <param name="deltaX">Der Wert der X Achse wird hier befüllt.</param>
        /// <param name="deltaY">Der Wert der Y Achse wird hier befüllt.</param>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        private void Bewegung_Update(ref float forceX, ref float forceY,
            ref float deltaX, ref float deltaY, ref GameTime gameTime)
        {
            if (!fisch.Jumpt)
            {
                // Gravitation wirken
                if (!fisch.Landed)
                    deltaY = GRAVITY * (float)gameTime.ElapsedGameTime.TotalSeconds;

                // Antriebsdüsen wirken lassen
                deltaX += forceX * (float)gameTime.ElapsedGameTime.TotalSeconds * JETPOWER;
                deltaY += -forceY * (float)gameTime.ElapsedGameTime.TotalSeconds * JETPOWER;

                if (!fisch.Landed)
                {
                    // Geschwindigkeitsänderung auf das fisch anwenden
                    fisch.Speed = new Vector2(fisch.Speed.X + deltaX, fisch.Speed.Y + deltaY);

                    // Neue Position des fischs ermitteln
                    fisch.Position += fisch.Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                else 
                {
                    fisch.Position += new Vector2(fisch.Speed.X + deltaX, fisch.Speed.Y + deltaY);
                }                
            }
            else
            {
                // Gravitation wirken
                if (!fisch.Landed)
                    deltaY = GRAVITY * (float)gameTime.ElapsedGameTime.TotalSeconds;

                // Geschwindigkeitsänderung auf das fisch anwenden
                fisch.Speed = new Vector2(fisch.Speed.X + deltaX, fisch.Speed.Y + deltaY);

                // Neue Position des fischs ermitteln
                fisch.Position += fisch.Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
        }
        /// <summary>
        /// Prüft ob es zu einer Kollision mit Objekten gekommen ist
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        private void Kollision_Update(ref GameTime gameTime)
        {
            // Randkollision
            if (fisch.Position.X < 0)
                Reset();
            if (fisch.Position.X > SCREENWIDTH - Fisch.WIDTH)
                Reset();
            if (fisch.Position.Y < 0)
                Reset();
            if (fisch.Position.Y > SCREENHEIGHT - Fisch.HEIGHT)
                Reset();

            // Block-Kollision
            Rectangle fischCollision = new Rectangle(
                (int)fisch.Position.X, (int)fisch.Position.Y,
                Fisch.WIDTH, Fisch.HEIGHT);
            for (int y = 0; y < level.Fields.GetLength(1); y++)
            {
                for (int x = 0; x < level.Fields.GetLength(0); x++)
                {
                    // Skip Non-Blocks
                    if ((level.Fields[x, y] != FieldType.Bridge) && (level.Fields[x, y] != FieldType.Brick)
                        && (level.Fields[x, y] != FieldType.BrickTower) && (level.Fields[x, y] != FieldType.BrickHouse)
                         && (level.Fields[x, y] != FieldType.BrickWall))
                        continue;

                    Rectangle blockCollision = new Rectangle(
                        x * BLOCKSIZE, y * BLOCKSIZE, BLOCKSIZE, BLOCKSIZE);
                    if (blockCollision.Intersects(fischCollision))
                    {
                        // Chance auf Landevorgang
                        float oldPosX = fisch.Position.X -
                            fisch.Speed.X * (float)gameTime.ElapsedGameTime.TotalSeconds;
                        float oldPosY = fisch.Position.Y -
                            fisch.Speed.Y * (float)gameTime.ElapsedGameTime.TotalSeconds;

                        Rectangle fischWithoutXCollision = new Rectangle(
                                (int)oldPosX, (int)fisch.Position.Y,
                            Fisch.WIDTH, Fisch.HEIGHT);

                        Rectangle fischWithoutYCollision = new Rectangle(
                                (int)fisch.Position.X, (int)oldPosY,
                            Fisch.WIDTH, Fisch.HEIGHT);

                        if (fischWithoutXCollision.Intersects(blockCollision) && fisch.Speed.Y >= 0)
                        {
                            // Landeanflug
                            fischCollision.Y = blockCollision.Y - Fisch.HEIGHT;
                            fisch.Position = new Vector2(fisch.Position.X, blockCollision.Y - Fisch.HEIGHT);
                            fisch.Speed = new Vector2();
                            fisch.Landed = true;
                        }
                        else
                        {
                            // Kollision von der Seite
                            Reset();
                        }
                    }
                }
            } 
        }
        /// <summary>
        /// Wenn Harter Sprung Modus Aktiv ist dann wird hier die
        /// Steuerung für die XY Achsen erledigt.
        /// </summary>
        /// <param name="forceY">Die zu beeinflussende Y Achse</param>
        /// <param name="forceX">Die zu beeinflussende X Achse</param>
        private void HardJump_Update(ref float forceY, ref float forceX)
        {
            Vector2 fischPoint = fisch.Position;

            if ((oldfischPoint.Y != 0) && (!fisch.Landed) )
            {
                float entfernung = (fischPoint - oldfischPoint).LengthSquared();
                if (((fischPoint - oldfischPoint).LengthSquared()) > 3000)
                {
                    fisch.Jumpt = true;
                }
            }

            if (fisch.Jumpt)
            {
                forceY = 0f;
                forceX = 0f;
                GRAVITY = FALL_GRAVITY_HARD;
            }
        }
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Zwischenvariablen für Schub
            float forceX = 0f;
            float forceY = 0f;

            // Steuerung Abfangen
            Steuerung_Update(ref forceX, ref forceY);

            // Geschwindigkeitsänderungen
            float deltaY = 0;
            float deltaX = 0;

            // Abhebesequenz
            if (fisch.Landed)
            {
                if (!MOVETYPE_SOFT)
                {
                    //oldfischPoint = fisch.Position + new Vector2(Fisch.WIDTH / 2, Fisch.HEIGHT / 2) - new Vector2(BLOCKSIZE, BLOCKSIZE * 2);
                    oldfischPoint = fisch.Position;
                    fisch.Jumpt = false;
                    GRAVITY = NOTMAL_GRAVITY_HARD;
                    JETPOWER = NORMAL_JETPOWER_HARD;
                }

                if (forceY > 0)
                {
                    fisch.Landed = false;                    
                }
            }
            if ( (!MOVETYPE_SOFT) && (!fisch.Landed) ) JETPOWER = JUMP_JETPOWER_HARD;

            // Routine zum Fressen oder Aufheben
            Fressen_Update();

            // Harter Sprung Routine
            if (!MOVETYPE_SOFT) HardJump_Update(ref forceY, ref forceX);                    

            // Bewegung und Gravitation sowie Schubsteuerung
            Bewegung_Update(ref forceX, ref forceY, ref deltaX, ref deltaY, ref gameTime);

            // Kollision
            Kollision_Update(ref gameTime);

            base.Update(gameTime);
        }
        #endregion

        #region Draw
        /// <summary>
        /// Zeichnet jedes Objekte auf dem Spielfeld "Blöcke"
        /// </summary>
        /// <param name="fischPoint">Der Punkt an dem sich der Spieler befindet</param>
        /// <param name="wormPoint">Der Punkt an dem sich das Fressobjekt befindet</param>
        private void Blocks_Draw(ref Vector2 fischPoint, ref Vector2 wormPoint)
        {
            // Blocks zeichnen
            for (int y = 0; y < level.Fields.GetLength(1); y++)
            {
                for (int x = 0; x < level.Fields.GetLength(0); x++)
                {
                    switch (level.Fields[x, y])
                    {
                        case FieldType.Bridge:
                            spriteBatch.Draw(
                                kisteTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                        case FieldType.Plant:
                            spriteBatch.Draw(
                                pflanzeTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                        case FieldType.Brick:
                            spriteBatch.Draw(
                                ziegelTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                        case FieldType.BrickHouse:
                            spriteBatch.Draw(
                                ziegelhausTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                        case FieldType.BrickWall:
                            spriteBatch.Draw(
                                ziegelmauerTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                        case FieldType.BrickTower:
                            spriteBatch.Draw(
                                ziegelturmTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                        case FieldType.AppleTree:
                            spriteBatch.Draw(
                                apfelbaumTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                        case FieldType.Tree:
                            spriteBatch.Draw(
                                baumTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                        case FieldType.RedHat:
                            if (!fisch.RedHat)
                            {
                                spriteBatch.Draw(
                                    roterhutTexture,
                                    new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                    Color.White);
                            }
                            break;
                        case FieldType.Treasurechest:
                            if (!fisch.Treasurechest)
                            {
                                spriteBatch.Draw(
                                    schatzkisteTexture,
                                    new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                    Color.White);
                            }
                            break;
                        case FieldType.Guest:
                            if (!fisch.WormEaten)
                            {
                                if (((fischPoint - wormPoint).LengthSquared() / 1000) <= VIEWDISTANCE)
                                {
                                    //Code ohne Animation
                                    spriteBatch.Draw(
                                        wurmTexture,
                                        new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                        Color.White);
                                }
                            }
                            break;
                        case FieldType.Goal:
                            spriteBatch.Draw(
                                zielTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// Zeichnet die Texte und Tutorialanweisungen
        /// </summary>
        /// <param name="fischPoint">Der Punkt an dem sich der Spieler befindet</param>
        /// <param name="wormPoint">Der Punkt an dem sich das Fressobjekt befindet</param>
        private void Text_Draw(ref Vector2 fischPoint, ref Vector2 wormPoint)
        {
            // HUD zeichnen
            spriteBatch.DrawString(schrift, "Level: " + levelNumber, new Vector2(10, 10), Color.White);

            //Kontrolle
            if (!MOVETYPE_SOFT) spriteBatch.DrawString(schrift, "Steuerungsmodi: Hard", new Vector2(1100, 10), Color.Red);
            //spriteBatch.DrawString(schrift, "L PositionX: " + oldfischPoint.X, new Vector2(10, 90), Color.Orange);
            //spriteBatch.DrawString(schrift, "L PositionY: " + oldfischPoint.Y, new Vector2(150, 90), Color.Orange);
            //spriteBatch.DrawString(schrift, "Cx: " + fisch.Position.X, new Vector2(10, 110), Color.Orange);
            //spriteBatch.DrawString(schrift, "Cy: " + fisch.Position.Y, new Vector2(150, 110), Color.Orange);
            //spriteBatch.DrawString(schrift, "Sx: " + fisch.Speed.X, new Vector2(10, 130), Color.Orange);
            //spriteBatch.DrawString(schrift, "Sy: " + fisch.Speed.Y, new Vector2(150, 130), Color.Orange);
            //spriteBatch.DrawString(schrift, "Sprungweite: " + ((fischPoint - oldfischPoint).LengthSquared() / 1000) + "/3",
            //    new Vector2(10, 150), Color.Orange);

            if (!fisch.WormEaten)
            {
                Vector2 speedSize = schrift.MeasureString("Abstand:");
                float fischEntfernung = ((fischPoint - wormPoint).LengthSquared() / 1000);
                spriteBatch.DrawString(schrift, "Abstand:", new Vector2(10, 30), Color.White);
                spriteBatch.DrawString(schrift, fischEntfernung.ToString("0") + " m",
                    new Vector2(speedSize.X + 15, 30), fischEntfernung > VIEWDISTANCE ? Color.Red : Color.Green);
            }

            // Power Ups
            spriteBatch.DrawString(schrift, "PowerUp:", new Vector2(10, 50), Color.White);
            if (fisch.RedHat)
                spriteBatch.DrawString(schrift, "Roter Hut", new Vector2(10, 65), Color.Green);
            if (fisch.Treasurechest)
                spriteBatch.DrawString(schrift, "Schatzkiste", new Vector2(10, 80), Color.Green);
        }
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.FromNonPremultiplied(153,204,255,100));
            Vector2 fischPoint = fisch.Position + new Vector2(Fisch.WIDTH / 2, Fisch.HEIGHT / 2);
            Vector2 wormPoint = level.GuestPoint * BLOCKSIZE + new Vector2(BLOCKSIZE / 2, BLOCKSIZE / 2);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            // Blocks zeichnen
            Blocks_Draw(ref fischPoint, ref wormPoint);

            // Spielfigur Zeichnen
            spriteBatch.Draw(fischTexture, fisch.Position, Color.White);

            // HUD zeichnen
            Text_Draw(ref fischPoint, ref wormPoint);


            spriteBatch.End(); 

            base.Draw(gameTime);
        }
        #endregion
    }
}
