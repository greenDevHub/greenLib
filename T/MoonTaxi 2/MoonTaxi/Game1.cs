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
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace RabbitCode.Samples.MoonTaxi
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        public const int SCREENWIDTH = 640;
        public const int SCREENHEIGHT = 480;
        public const int BLOCKSIZE = 20; // Pixelbreite / Höhe pro Block

        public const float GRAVITY = 9.81f; // Beschleunigung in Pixel pro Sekunde pro Sekunde
        public const float JETPOWER = 30f; // Beschleunigungskraft der Jets in Pixel pro Sekunde pro Sekunde

        public const float MAXLANDINGSPEED = 20f; // Maximale Geschwindigkeit in Pixel/Sekunde für eine sichere Landung

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D taxiTexture;
        Texture2D guestTexture;
        Texture2D goalTexture;
        Texture2D blockTexture;

        Taxi taxi;
        Level level;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferHeight = SCREENHEIGHT;
            graphics.PreferredBackBufferWidth = SCREENWIDTH;

            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            taxi = new Taxi();
            
            Reset();
            
            base.Initialize();
            
        }

        private void Reset()
        {
            level = new Level(@"Levels\level1.txt");
            taxi.Position = level.StartPoint * BLOCKSIZE;
            taxi.Landed = false;
            taxi.Speed = new Vector2();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            taxiTexture = Content.Load<Texture2D>("Taxi");
            guestTexture = Content.Load<Texture2D>("guest");
            goalTexture = Content.Load<Texture2D>("goal");
            blockTexture = Content.Load<Texture2D>("block");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Gerätestatus abfragen
            GamePadState gamePad = GamePad.GetState(PlayerIndex.One);
            KeyboardState keyboard = Keyboard.GetState();

            // Zwischenvariablen für Schub
            float forceX = 0f;
            float forceY = 0f;

            // Tastatur anwenden
            if (keyboard.IsKeyDown(Keys.Left))  forceX += -1f;
            if (keyboard.IsKeyDown(Keys.Right)) forceX += 1f;
            if (keyboard.IsKeyDown(Keys.Up))    forceY += 1f;
            if (keyboard.IsKeyDown(Keys.Down))  forceY += -1f;
            
            // Gamepad anwenden
            forceX += gamePad.ThumbSticks.Left.X;
            forceY += gamePad.ThumbSticks.Left.Y;

            // Limitierung auf den Wertebereich -1 bis 1
            forceX = Math.Min(Math.Max(-1f, forceX), 1f);
            forceY = Math.Min(Math.Max(-1f, forceY), 1f);

            // Geschwindigkeitsänderungen
            float deltaY = 0;
            float deltaX = 0;

            // Abhebesequenz
            if (taxi.Landed)
            {
                if (forceY > 0)
                    taxi.Landed = false;
            }

            // Gravitation wirken
            if (!taxi.Landed)
                deltaY = GRAVITY * (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Antriebsdüsen wirken lassen
            if (!taxi.Landed)
                deltaX += forceX * (float)gameTime.ElapsedGameTime.TotalSeconds * JETPOWER;
            deltaY += -forceY * (float)gameTime.ElapsedGameTime.TotalSeconds * JETPOWER;

            // Geschwindigkeitsänderung auf das Taxi anwenden
            taxi.Speed = new Vector2(taxi.Speed.X + deltaX, taxi.Speed.Y + deltaY);

            // Neue Position des Taxis ermitteln
            taxi.Position += taxi.Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Randkollision
            if (taxi.Position.X < 0)
                Reset();
            if (taxi.Position.X > SCREENWIDTH - Taxi.WIDTH)
                Reset();
            if (taxi.Position.Y < 0)
                Reset();
            if (taxi.Position.Y > SCREENHEIGHT - Taxi.HEIGHT)
                Reset();

            // Block-Kollision
            Rectangle taxiCollision = new Rectangle(
                (int)taxi.Position.X, (int)taxi.Position.Y, 
                Taxi.WIDTH, Taxi.HEIGHT);
            for (int y = 0; y < level.Fields.GetLength(1); y++)
            {
                for (int x = 0; x < level.Fields.GetLength(0); x++)
                {
                    // Skip Non-Blocks
                    if (level.Fields[x, y] != FieldType.Bridge)
                        continue;

                    Rectangle blockCollision = new Rectangle(
                        x * BLOCKSIZE, y * BLOCKSIZE, BLOCKSIZE, BLOCKSIZE);
                    if (blockCollision.Intersects(taxiCollision))
                    {
                        // Auf Landungsbedingungen prüfen
                        if (taxi.Speed.LengthSquared() < MAXLANDINGSPEED * MAXLANDINGSPEED)
                        {
                            // Chance auf Landevorgang
                            float oldPosX = taxi.Position.X - 
                                taxi.Speed.X * (float)gameTime.ElapsedGameTime.TotalSeconds;

                            Rectangle taxiWithoutXCollision = new Rectangle(
                                 (int)oldPosX, (int)taxi.Position.Y,
                                Taxi.WIDTH, Taxi.HEIGHT);

                            if (taxiWithoutXCollision.Intersects(blockCollision) && taxi.Speed.Y >= 0)
                            {
                                // Landeanflug
                                taxiCollision.Y = blockCollision.Y - Taxi.HEIGHT;
                                taxi.Position = new Vector2(taxi.Position.X, blockCollision.Y - Taxi.HEIGHT);
                                taxi.Speed = new Vector2();
                                taxi.Landed = true;
                            }
                            else
                            {
                                // Kollision von der Seite
                                Reset();
                            }
                        }
                        else
                        {
                            // Kollision!
                            Reset();
                        }
                    }
                }
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            // Blocks zeichnen
            for (int y = 0; y < level.Fields.GetLength(1); y++)
            {
                for (int x = 0; x < level.Fields.GetLength(0); x++)
                {
                    switch (level.Fields[x, y])
                    {
                        case FieldType.Bridge:
                            spriteBatch.Draw(
                                blockTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                        case FieldType.Guest:
                            spriteBatch.Draw(
                                guestTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                        case FieldType.Goal:
                            spriteBatch.Draw(
                                goalTexture,
                                new Vector2(x * BLOCKSIZE, y * BLOCKSIZE),
                                Color.White);
                            break;
                    }
                }
            }

            // Taxi zeichnen
            spriteBatch.Draw(taxiTexture, taxi.Position, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
