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
        public const float GRAVITY = 9.81f; // Beschleunigung in Pixel pro Sekunde pro Sekunde
        public const float JETPOWER = 30f; // Beschleunigungskraft der Jets in Pixel pro Sekunde pro Sekunde

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D taxiTexture;

        Taxi taxi;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
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
            taxi.Position = new Vector2(100, 100);
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
            // Ger�testatus abfragen
            GamePadState gamePad = GamePad.GetState(PlayerIndex.One);
            KeyboardState keyboard = Keyboard.GetState();

            // Zwischenvariablen f�r Schub
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

            // Geschwindigkeits�nderungen
            float deltaY = 0;
            float deltaX = 0;

            // Gravitation wirken
            deltaY = GRAVITY * (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Antriebsd�sen wirken lassen
            deltaX += forceX * (float)gameTime.ElapsedGameTime.TotalSeconds * JETPOWER;
            deltaY += -forceY * (float)gameTime.ElapsedGameTime.TotalSeconds * JETPOWER;

            // Geschwindigkeits�nderung auf das Taxi anwenden
            taxi.Speed = new Vector2(taxi.Speed.X + deltaX, taxi.Speed.Y + deltaY);

            // Neue Position des Taxis ermitteln
            taxi.Position += taxi.Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;

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
            spriteBatch.Draw(taxiTexture, taxi.Position, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
