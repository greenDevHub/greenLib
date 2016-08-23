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

namespace Moon_Taxi
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D taxiTexture;

        Taxi taxi;

        public const float GRAVITY = 9.81f;
        public const float JETPOWER = 30f;

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
            // TODO: Add your initialization logic here

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

            // TODO: use this.Content to load your game content here
            taxiTexture = Content.Load<Texture2D>("Fisch");
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
            //Bewegung
            // Gerätestatus abfragen
            GamePadState gamePad = GamePad.GetState(PlayerIndex.One);
            KeyboardState keyboard = Keyboard.GetState();

            // Zwischenvariablen für Schub
            float forceX = 0f;
            float forceY = 0f;

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

            // Geschwindigkeitsänderungen
            float deltaY = 0;
            float deltaX = 0;

            // Gravitation wirken
            deltaY = GRAVITY * (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Antriebsdüsen wirken lassen
            deltaX += forceX * (float)gameTime.ElapsedGameTime.TotalSeconds * JETPOWER;
            deltaY += -forceY *
                (float)gameTime.ElapsedGameTime.TotalSeconds * JETPOWER;
            
            // Geschwindigkeitsänderung auf das Taxi anwenden
            taxi.Speed = new Vector2(taxi.Speed.X + deltaX, taxi.Speed.Y + deltaY);

            // Neue Position des Taxis ermitteln
            taxi.Position += taxi.Speed * (float)gameTime.ElapsedGameTime.TotalSeconds; 

            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.AliceBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(taxiTexture, taxi.Position, Color.White);
            spriteBatch.End(); 

            base.Draw(gameTime);
        }
    }
}
