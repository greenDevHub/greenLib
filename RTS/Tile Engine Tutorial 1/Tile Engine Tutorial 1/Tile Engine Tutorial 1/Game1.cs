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

namespace Tile_Engine_Tutorial_1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        SpriteFont pericles6;
        Texture2D fogOfWar;
        Texture2D lightAura;

        Texture2D playerTexture;
        Vector2 playerPosition = new Vector2(15, 15);

        TileMap myMap = new TileMap();
        int squaresAcross = 17;
        int squaresDown = 37;

        int baseOffsetX = -32;
        int baseOffsetY = -64;
        float heightRowDepthMod = 0.0000001f;

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

            base.Initialize();
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
            Tile.TileSetTexture = Content.Load<Texture2D>("part4_tileset");
            pericles6 = Content.Load<SpriteFont>("Fonts\\pericles6");
            fogOfWar = Content.Load<Texture2D>("fogofwar");
            playerTexture = Content.Load<Texture2D>("player");
            lightAura = Content.Load<Texture2D>("lightaura");
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.Left))
            {
                Camera.Location.X = MathHelper.Clamp(Camera.Location.X - 2, 0,
                    (myMap.MapWidth - squaresAcross) * Tile.TileStepX);
            }

            if (ks.IsKeyDown(Keys.Right))
            {
                Camera.Location.X = MathHelper.Clamp(Camera.Location.X + 2, 0,
                    (myMap.MapWidth - squaresAcross) * Tile.TileStepX);
            }

            if (ks.IsKeyDown(Keys.Up))
            {
                Camera.Location.Y = MathHelper.Clamp(Camera.Location.Y - 2, 0,
                    (myMap.MapHeight - squaresDown) * Tile.TileStepY);
            }

            if (ks.IsKeyDown(Keys.Down))
            {
                Camera.Location.Y = MathHelper.Clamp(Camera.Location.Y + 2, 0,
                    (myMap.MapHeight - squaresDown) * Tile.TileStepY);
            }

            //KeyboardState ks = Keyboard.GetState();

            //if (ks.IsKeyDown(Keys.Left))
            //    playerPosition.X--;

            //if (ks.IsKeyDown(Keys.Right))
            //    playerPosition.X++;

            //if (ks.IsKeyDown(Keys.Down))
            //    playerPosition.Y++;

            //if (ks.IsKeyDown(Keys.Up))
            //    playerPosition.Y--;

            //UpdateFogOfWar();

            //base.Update(gameTime);
        }

        private void UpdateFogOfWar()
        {
            int playerMapX = (int)playerPosition.X / Tile.TileWidth;
            int playerMapY = (int)playerPosition.Y / Tile.TileHeight;

            for (int y = playerMapY - 3; y <= playerMapY + 3; y++)
                for (int x = playerMapX - 3; x <= playerMapX + 3; x++)
                {
                    if ((x >= 0) && (x < myMap.MapWidth) && (y >= 0) && (y < myMap.MapHeight))
                    {
                        if ((x >= playerMapX - 2) && (y >= playerMapY - 2) &&
                            (x <= playerMapX + 2) && (y <= playerMapY + 2))
                            myMap.Rows[y].Columns[x].Explored = true;
                        else
                            myMap.Rows[y].Columns[x].Explored = false;
                    }
                }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);

            Vector2 firstSquare = new Vector2(Camera.Location.X / Tile.TileStepX, Camera.Location.Y / Tile.TileStepY);
            int firstX = (int)firstSquare.X;
            int firstY = (int)firstSquare.Y;

            Vector2 squareOffset = new Vector2(Camera.Location.X % Tile.TileStepX, Camera.Location.Y % Tile.TileStepY);
            int offsetX = (int)squareOffset.X;
            int offsetY = (int)squareOffset.Y;

            float maxdepth = ((myMap.MapWidth + 1) + ((myMap.MapHeight + 1) * Tile.TileWidth)) * 10;
            float depthOffset;

            for (int y = 0; y < squaresDown; y++)
            {
                int rowOffset = 0;
                if ((firstY + y) % 2 == 1) rowOffset = Tile.OddRowXOffset;

                for (int x = 0; x < squaresAcross; x++)
                {
                    int mapx = (firstX + x);
                    int mapy = (firstY + y);
                    depthOffset = 0.7f - ((mapx + (mapy * Tile.TileWidth)) / maxdepth);
                    // Zeichnet die Untere Grund Ebene
                    foreach (int tileID in myMap.Rows[mapy].Columns[mapx].BaseTiles)
                    {
                        spriteBatch.Draw(Tile.TileSetTexture, new Rectangle(
                            (x * Tile.TileStepX) - offsetX + rowOffset + baseOffsetX,
                            (y * Tile.TileStepY) - offsetY + baseOffsetY,
                            Tile.TileWidth, Tile.TileHeight), Tile.GetSourceRectangle(tileID), Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 1.0f);
                    }
                    // Zeichnet die Obere Ebene
                    int heightRow = 0;
                    foreach (int tileID in myMap.Rows[mapy].Columns[mapx].HeightTiles)
                    {
                        spriteBatch.Draw(
                            Tile.TileSetTexture,
                            new Rectangle(
                                (x * Tile.TileStepX) - offsetX + rowOffset + baseOffsetX,
                                (y * Tile.TileStepY) - offsetY + baseOffsetY - (heightRow * Tile.HeightTileOffset),
                                Tile.TileWidth, Tile.TileHeight),
                            Tile.GetSourceRectangle(tileID),
                            Color.White,
                            0.0f,
                            Vector2.Zero,
                            SpriteEffects.None,
                            depthOffset - ((float)heightRow * heightRowDepthMod));
                        heightRow++;
                    }
                    // Zeichnet die Top ebene
                    foreach (int tileID in myMap.Rows[y + firstY].Columns[x + firstX].TopperTiles)
                    {
                        spriteBatch.Draw(
                            Tile.TileSetTexture,
                            new Rectangle(
                                (x * Tile.TileStepX) - offsetX + rowOffset + baseOffsetX,
                                (y * Tile.TileStepY) - offsetY + baseOffsetY - (heightRow * Tile.HeightTileOffset),
                                Tile.TileWidth, Tile.TileHeight),
                            Tile.GetSourceRectangle(tileID),
                            Color.White,
                            0.0f,
                            Vector2.Zero,
                            SpriteEffects.None,
                            depthOffset - ((float)heightRow * heightRowDepthMod));
                    }
                    // Zeichnen von Texten
                    //spriteBatch.DrawString(pericles6, (x + firstX).ToString() + ", " + (y + firstY).ToString(),
                    //    new Vector2(
                    //        (x * Tile.TileStepX) - offsetX + rowOffset + baseOffsetX + 24,
                    //        (y * Tile.TileStepY) - offsetY + baseOffsetY + 48),
                    //        Color.White, 0f, Vector2.Zero, 1.0f, SpriteEffects.None, 0.0f);                    
                }                
            }

            // Spieler Zeichnen
            spriteBatch.Draw(playerTexture, playerPosition, Color.White);

            // Aura
            //spriteBatch.Draw(lightAura, new Rectangle(
            //    (int)playerPosition.X - (lightAura.Width / 2),
            //    (int)playerPosition.Y - (lightAura.Height / 2),
            //    lightAura.Width, lightAura.Height), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
