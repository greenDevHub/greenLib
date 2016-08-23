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

namespace Tower_Crush
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Level level = new Level();
        WaveManager waveManager;
        Player player;
        GUI.Toolbar toolBar;        

        Button cannonButton;        
        Button cryoButton;        
        Button twinCannonButton;
        Button fortCannonButton;
        Button grenadeLauncherButton;
        Button laserButton;

        Button powerStationButton;
        Button metalMineButton;
        Button oilStationButton;
        Button refineryButton;

        Button pauseButton;
        private bool paused = false;
        private bool pausedForGuide = false;

        // Hintergrund
        Texture2D[] background;
        Rectangle backgroundFrame;

        // Hochstuffen
        Button upgradeButton;
        private bool upgradeButtonVisible = false;

        // Verkaufen
        Button sellButton;
        private bool sellButtonVisible = false;
        private bool IsSellButtonVisible
        {
            get 
            {
                sellButtonVisible = upgradeButtonVisible;
                return sellButtonVisible; 
            }
        }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";            

            // Fenstereinstellungen laden
            graphics.PreferredBackBufferWidth = (int)(C.BS * 8) + level.Width * C.BS;
            graphics.PreferredBackBufferHeight = (int)(C.BS * 3) + level.Height * C.BS;
            graphics.ApplyChanges();
            IsMouseVisible = true;
        }

        int fps;
        int fps_lowes;
        int frame_count;
        float fps_reset;
        SpriteFont fps_font;

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

            // Hintergrund
            background = new Texture2D[]
            {
                Content.Load<Texture2D>("Bilder\\Level\\background layer 0"),
                Content.Load<Texture2D>("Bilder\\Level\\background layer 1")
            };
            backgroundFrame = new Rectangle(0, 0, (int)(C.BS * 8) + level.Width * C.BS, (int)(C.BS * 3) + level.Height * C.BS);
            
            // Level
            Texture2D grass = Content.Load<Texture2D>("Bilder\\Level\\grass");
            Texture2D path = Content.Load<Texture2D>("Bilder\\Level\\path");
            Texture2D wrong = Content.Load<Texture2D>("Bilder\\Level\\wrong");
            level.AddTexture(grass);
            level.AddTexture(path);
            level.AddTexture(wrong);


            // Objekte
            Texture2D[,] objectTexture = new Texture2D[,]
            {
                // Türme
                { 
                    Content.Load<Texture2D>("Bilder\\Tower\\Cannon Tower\\cannon tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Cannon Tower\\cannon tower mk1"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Cannon Tower\\cannon tower mk2"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Cannon Tower\\cannon tower mk3"), 
                },
                { 
                    Content.Load<Texture2D>("Bilder\\Tower\\Fort Cannon Tower\\fort cannon tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Fort Cannon Tower\\fort cannon tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Fort Cannon Tower\\fort cannon tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Fort Cannon Tower\\fort cannon tower"), 
                },
                { 
                    Content.Load<Texture2D>("Bilder\\Tower\\Cryo Tower\\cryo tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Cryo Tower\\cryo tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Cryo Tower\\cryo tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Cryo Tower\\cryo tower"), 
                },
                { 
                    Content.Load<Texture2D>("Bilder\\Tower\\Twin Cannon Tower\\twin cannon tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Twin Cannon Tower\\twin cannon tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Twin Cannon Tower\\twin cannon tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Twin Cannon Tower\\twin cannon tower"), 
                },
                { 
                    Content.Load<Texture2D>("Bilder\\Tower\\Grenade Launcher Tower\\grenade launcher tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Grenade Launcher Tower\\grenade launcher tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Grenade Launcher Tower\\grenade launcher tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Grenade Launcher Tower\\grenade launcher tower"), 
                },
                { 
                    Content.Load<Texture2D>("Bilder\\Tower\\Laser Tower\\laser tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Laser Tower\\laser tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Laser Tower\\laser tower"), 
                    Content.Load<Texture2D>("Bilder\\Tower\\Laser Tower\\laser tower"), 
                },
                // Gebäude
                { 
                    Content.Load<Texture2D>("Bilder\\Building\\Power Station\\power station"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Power Station\\power station"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Power Station\\power station"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Power Station\\power station"), 
                },
                { 
                    Content.Load<Texture2D>("Bilder\\Building\\Metal Mine\\metal mine"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Metal Mine\\metal mine"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Metal Mine\\metal mine"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Metal Mine\\metal mine"), 
                },
                { 
                    Content.Load<Texture2D>("Bilder\\Building\\Oil Station\\oil station"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Oil Station\\oil station"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Oil Station\\oil station"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Oil Station\\oil station"), 
                },
                { 
                    Content.Load<Texture2D>("Bilder\\Building\\Refinery\\refinery"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Refinery\\refinery"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Refinery\\refinery"), 
                    Content.Load<Texture2D>("Bilder\\Building\\Refinery\\refinery"), 
                },
            };            
            // Kugeln
            Texture2D[] bulletTexture = new Texture2D[]
            {
                Content.Load<Texture2D>("Bilder\\Bullet\\cannon bullet"),
                Content.Load<Texture2D>("Bilder\\Bullet\\cannon bullet"),
                Content.Load<Texture2D>("Bilder\\Bullet\\cryo bullet"),
                Content.Load<Texture2D>("Bilder\\Bullet\\twin cannon bullet"),
                Content.Load<Texture2D>("Bilder\\Bullet\\cannon bullet"),
                Content.Load<Texture2D>("Bilder\\Bullet\\laser bullet")
            };
            // Reichweiten Kreis
            Texture2D rangeBorderTexture = Content.Load<Texture2D>("Bilder\\GUI\\range border");

            // Headup Display
            Texture2D headupDisplayTexture = Content.Load<Texture2D>("Bilder\\GUI\\headup display");

            Texture2D previewGroundTexture = Content.Load<Texture2D>("Bilder\\GUI\\build ground");

            player = new Player(level, objectTexture, bulletTexture, rangeBorderTexture, headupDisplayTexture, previewGroundTexture);

            // Gegner
            Texture2D[] enemyTexture = new Texture2D[]
            {
                Content.Load<Texture2D>("Bilder\\Enemy\\creeper"),
                Content.Load<Texture2D>("Bilder\\Enemy\\boss"),
                Content.Load<Texture2D>("Bilder\\Enemy\\speeder"),
                Content.Load<Texture2D>("Bilder\\Enemy\\truck"),
                Content.Load<Texture2D>("Bilder\\Enemy\\jeep")
            };
            Texture2D healthTexture = Content.Load<Texture2D>("Bilder\\GUI\\health bar");
            waveManager = new WaveManager(player, level, 15, enemyTexture, healthTexture);

            // GUI
            SpriteFont font = Content.Load<SpriteFont>("Arial");
            if (C.SHOWFPS) fps_font = Content.Load<SpriteFont>("Arial");
            toolBar = new GUI.Toolbar(font, new Vector2(C.BS, (level.Height + 1) * C.BS));

            // Lade Buttons Cannon Tower
            Texture2D cannonNormal = Content.Load<Texture2D>("Bilder\\GUI\\Cannon Tower\\cannon button");
            Texture2D cannonHover = Content.Load<Texture2D>("Bilder\\GUI\\Cannon Tower\\cannon hover");
            Texture2D cannonPressed = Content.Load<Texture2D>("Bilder\\GUI\\Cannon Tower\\cannon pressed");
            // Erstellen Cannon Tower
            cannonButton = new Button(cannonNormal, cannonHover, cannonPressed, player.objectTypeConfigs[0], font, new Vector2((level.Width + 2) * C.BS, (int)(C.BS * 2)));
            cannonButton.Clicked += new EventHandler(cannonButton_Clicked);

            // Lade Buttons Fort Cannon Tower
            Texture2D fortCannonNormal = Content.Load<Texture2D>("Bilder\\GUI\\Fort Cannon Tower\\fort cannon button");
            Texture2D fortCannonHover = Content.Load<Texture2D>("Bilder\\GUI\\Fort Cannon Tower\\fort cannon hover");
            Texture2D fortCannonPressed = Content.Load<Texture2D>("Bilder\\GUI\\Fort Cannon Tower\\fort cannon pressed");
            // Erstellen Cannon Tower
            fortCannonButton = new Button(fortCannonNormal, fortCannonHover, fortCannonPressed, player.objectTypeConfigs[1], font, new Vector2((level.Width + 5) * C.BS, (int)(C.BS * 2)));
            fortCannonButton.Clicked += new EventHandler(fortCannonButton_Clicked);

            // Lade Buttons Cryo Tower
            Texture2D cryoNormal = Content.Load<Texture2D>("Bilder\\GUI\\Cryo Tower\\cryo button");
            Texture2D cryoHover = Content.Load<Texture2D>("Bilder\\GUI\\Cryo Tower\\cryo hover");
            Texture2D cryoPressed = Content.Load<Texture2D>("Bilder\\GUI\\Cryo Tower\\cryo pressed");
            // Erstellen Cannon Tower
            cryoButton = new Button(cryoNormal, cryoHover, cryoPressed, player.objectTypeConfigs[2], font, new Vector2((level.Width + 3) * C.BS, (int)(C.BS * 2)));
            cryoButton.Clicked += new EventHandler(cryoButton_Clicked);

            // Lade Buttons Twin Cannon Tower
            Texture2D twinCannonNormal = Content.Load<Texture2D>("Bilder\\GUI\\Twin Cannon Tower\\twin cannon button");
            Texture2D twinCannonHover = Content.Load<Texture2D>("Bilder\\GUI\\Twin Cannon Tower\\twin cannon hover");
            Texture2D twinCannonPressed = Content.Load<Texture2D>("Bilder\\GUI\\Twin Cannon Tower\\twin cannon pressed");
            // Erstellen Twin Cannon Tower
            twinCannonButton = new Button(twinCannonNormal, twinCannonHover, twinCannonPressed, player.objectTypeConfigs[3], font, new Vector2((level.Width + 4) * C.BS, (int)(C.BS * 2)));
            twinCannonButton.Clicked += new EventHandler(twinCannonButton_Clicked);            

            // Lade Buttons Grenade Launcher Tower
            Texture2D grenadeLauncherNormal = Content.Load<Texture2D>("Bilder\\GUI\\Grenade Launcher Tower\\grenade launcher button");
            Texture2D grenadeLauncherHover = Content.Load<Texture2D>("Bilder\\GUI\\Grenade Launcher Tower\\grenade launcher hover");
            Texture2D grenadeLauncherPressed = Content.Load<Texture2D>("Bilder\\GUI\\Grenade Launcher Tower\\grenade launcher pressed");
            // Erstellen Grenade Launcher Tower
            grenadeLauncherButton = new Button(grenadeLauncherNormal, grenadeLauncherHover, grenadeLauncherPressed, player.objectTypeConfigs[4], font, new Vector2((level.Width + 6) * C.BS, (int)(C.BS * 2)));
            grenadeLauncherButton.Clicked += new EventHandler(grenadeLauncherButton_Clicked);

            // Lade Buttons Laser Tower
            Texture2D laserTowerNormal = Content.Load<Texture2D>("Bilder\\GUI\\Laser Tower\\laser button");
            Texture2D laserTowerHover = Content.Load<Texture2D>("Bilder\\GUI\\Laser Tower\\laser hover");
            Texture2D laserTowerPressed = Content.Load<Texture2D>("Bilder\\GUI\\Laser Tower\\laser pressed");
            // Erstellen Grenade Launcher Tower
            laserButton = new Button(laserTowerNormal, laserTowerHover, laserTowerPressed, player.objectTypeConfigs[5], font, new Vector2((level.Width + 2) * C.BS, (int)(C.BS * 3)));
            laserButton.Clicked += new EventHandler(laserButton_Clicked);


            // Gebäude
            // Lade Buttons Power Station
            Texture2D powerStationNormal = Content.Load<Texture2D>("Bilder\\GUI\\Power Station\\power station button");
            Texture2D powerStationHover = Content.Load<Texture2D>("Bilder\\GUI\\Power Station\\power station hover");
            Texture2D powerStationPressed = Content.Load<Texture2D>("Bilder\\GUI\\Power Station\\power station pressed");
            // Erstellen Power Station
            powerStationButton = new Button(powerStationNormal, powerStationHover, powerStationPressed, null, null, new Vector2((level.Width + 2) * C.BS, (int)(C.BS * 5)));
            powerStationButton.Clicked += new EventHandler(powerStationButton_Clicked);

            // Lade Buttons Metal Mine
            Texture2D metalMineNormal = Content.Load<Texture2D>("Bilder\\GUI\\Metal Mine\\metal mine button");
            Texture2D metalMineHover = Content.Load<Texture2D>("Bilder\\GUI\\Metal Mine\\metal mine hover");
            Texture2D metalMinePressed = Content.Load<Texture2D>("Bilder\\GUI\\Metal Mine\\metal mine pressed");
            // Erstellen Power Station
            metalMineButton = new Button(metalMineNormal, metalMineHover, metalMinePressed, null, null, new Vector2((level.Width + 3) * C.BS, (int)(C.BS * 5)));
            metalMineButton.Clicked += new EventHandler(metalMineButton_Clicked);

            // Lade Buttons Oil Station
            Texture2D oilStationNormal = Content.Load<Texture2D>("Bilder\\GUI\\Oil Station\\oil station button");
            Texture2D oilStationHover = Content.Load<Texture2D>("Bilder\\GUI\\Oil Station\\oil station hover");
            Texture2D oilStationPressed = Content.Load<Texture2D>("Bilder\\GUI\\Oil Station\\oil station pressed");
            // Erstellen Oil Station
            oilStationButton = new Button(oilStationNormal, oilStationHover, oilStationPressed, null, null, new Vector2((level.Width + 4) * C.BS, (int)(C.BS * 5)));
            oilStationButton.Clicked += new EventHandler(oilStationButton_Clicked);

            // Lade Buttons Refinery
            Texture2D refineryNormal = Content.Load<Texture2D>("Bilder\\GUI\\Refinery\\refinery button");
            Texture2D refineryHover = Content.Load<Texture2D>("Bilder\\GUI\\Refinery\\refinery hover");
            Texture2D refineryPressed = Content.Load<Texture2D>("Bilder\\GUI\\Refinery\\refinery pressed");
            // Erstellen Refinery
            refineryButton = new Button(refineryNormal, refineryHover, refineryPressed, null, null, new Vector2((level.Width + 5) * C.BS, (int)(C.BS * 5)));
            refineryButton.Clicked += new EventHandler(refineryButton_Clicked);

            // Upgrade
            // Lade Upgrade Button
            Texture2D upgradeButtonNormal = Content.Load<Texture2D>("Bilder\\GUI\\upgrade button");
            // Erstellt Upgrade Button
            upgradeButton = new Button(upgradeButtonNormal, upgradeButtonNormal, upgradeButtonNormal, null, null, new Vector2((level.Width + 5) * C.BS, (int)(C.BS * 0)));
            upgradeButton.Clicked += new EventHandler(upgradeButton_Clicked);

            // Sell
            // Lade Sell Button
            Texture2D sellButtonNormal = Content.Load<Texture2D>("Bilder\\GUI\\sell button");
            // Erstellt Sell Button
            sellButton = new Button(sellButtonNormal, sellButtonNormal, sellButtonNormal, null, null, new Vector2((level.Width + 4) * C.BS, (int)(C.BS * 0)));
            sellButton.Clicked += new EventHandler(sellButton_Clicked);

            // Pause
            // Lade Pause Button
            Texture2D pauseButtonNormal = Content.Load<Texture2D>("Bilder\\GUI\\pause button");
            // Erstelel Pause Button
            pauseButton = new Button(pauseButtonNormal, pauseButtonNormal, pauseButtonNormal, null, null, new Vector2((level.Width + 6) * C.BS, (int)(C.BS * 0)));
            pauseButton.Clicked += new EventHandler(pauseButton_Clicked);            
        }

        #region "Zusatz"
        private void cannonButton_Clicked(object sender, EventArgs e)
        {
            if (player.objectTypeConfigs[0].IsAvailable)
            player.NewObjectType = "Cannon Tower";
            player.NewObjectIndex = 0;
        }        
        private void cryoButton_Clicked(object sender, EventArgs e)
        {
            if (player.objectTypeConfigs[2].IsAvailable)
            player.NewObjectType= "Cryo Tower";
            player.NewObjectIndex = 2;
        }        
        private void twinCannonButton_Clicked(object sender, EventArgs e)
        {
            if (player.objectTypeConfigs[3].IsAvailable)
            player.NewObjectType = "Twin Cannon Tower";
            player.NewObjectIndex = 3;
        }
        private void fortCannonButton_Clicked(object sender, EventArgs e)
        {
            if (player.objectTypeConfigs[1].IsAvailable)
            player.NewObjectType = "Fort Cannon Tower";
            player.NewObjectIndex = 1;
        }
        private void grenadeLauncherButton_Clicked(object sender, EventArgs e)
        {
            if (player.objectTypeConfigs[4].IsAvailable)
            player.NewObjectType = "Grenade Launcher Tower";
            player.NewObjectIndex = 4;
        }
        private void laserButton_Clicked(object sender, EventArgs e)
        {
            if (player.objectTypeConfigs[5].IsAvailable)
            player.NewObjectType = "Laser Tower";
            player.NewObjectIndex = 5;
        }

        private void powerStationButton_Clicked(object sender, EventArgs e)
        {
            if (player.objectTypeConfigs[6].IsAvailable)
            player.NewObjectType = "Power Station";
            player.NewObjectIndex = 6;
        }        
        private void metalMineButton_Clicked(object sender, EventArgs e)
        {
            if (player.objectTypeConfigs[7].IsAvailable)
            player.NewObjectType = "Metal Mine";
            player.NewObjectIndex = 7;
        }
        private void oilStationButton_Clicked(object sender, EventArgs e)
        {
            if (player.objectTypeConfigs[8].IsAvailable)
            player.NewObjectType = "Oil Station";
            player.NewObjectIndex = 8;
        }
        private void refineryButton_Clicked(object sender, EventArgs e)
        {
            if (player.objectTypeConfigs[9].IsAvailable)
            player.NewObjectType = "Refinery";
            player.NewObjectIndex = 9;
        }

        private void upgradeButton_Clicked(object sender, EventArgs e)
        {
            if (upgradeButtonVisible) player.UpgradeObject();
        }
        private void sellButton_Clicked(object sender, EventArgs e)
        {
            if (IsSellButtonVisible) player.SellObjekt();
        }
        private void pauseButton_Clicked(object sender, EventArgs e)
        {
            if (!paused) BeginPause(true);
            else EndPause(); 
        }

        /// <summary>
        /// Pausiert das Spiel
        /// </summary>
        /// <param name="UserInitiated"></param>
        private void BeginPause(bool UserInitiated)
        {
            paused = true;
            pausedForGuide = !UserInitiated;
        }
        /// <summary>
        /// Das Spiel geht weiter wenn Pausiert
        /// </summary>
        private void EndPause()
        {
            pausedForGuide = false;
            paused = false;
        }
        #endregion

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
            if (!paused)
            {
                // Gegner werden Plaziert
                waveManager.Update(gameTime);

                // Update des Upgrade Buttons bzw. der UI
                if (player.SelectedObject != null) upgradeButton.SetPositionHeadup(ButtonType.UpgradeButton, player.SelectedObject.Position);
                if (player.SelectedObject != null) sellButton.SetPositionHeadup(ButtonType.SellButton, player.SelectedObject.Position);
                upgradeButton.Update(gameTime);
                sellButton.Update(gameTime);

                player.Update(gameTime, waveManager.Enemies);
                upgradeButtonVisible = player.IsObjectSelected;

                // Tower
                cannonButton.Update(gameTime);
                fortCannonButton.Update(gameTime);
                cryoButton.Update(gameTime);
                twinCannonButton.Update(gameTime);
                grenadeLauncherButton.Update(gameTime);
                laserButton.Update(gameTime);

                // Gebäude
                powerStationButton.Update(gameTime);
                oilStationButton.Update(gameTime);
                metalMineButton.Update(gameTime);
                refineryButton.Update(gameTime);
            }

            // Hier die Ereignisse die laufen obwohl das Spiel pausiert ist
            pauseButton.Update(gameTime);

            if (C.SHOWFPS)
            {
                if (fps_reset >= 1)
                {
                    fps = frame_count;
                    if (fps_lowes == 0) fps_lowes = fps;
                    if (fps < fps_lowes) fps_lowes = fps;
                    frame_count = 0;
                    fps_reset = 0;
                }
                fps_reset += (float)gameTime.ElapsedGameTime.TotalSeconds;
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

            // TODO: Add your drawing code here
            spriteBatch.Begin();            
            
            // Hintergrund Leyer 0
            spriteBatch.Draw(background[0], backgroundFrame, Color.White);

            level.Draw(spriteBatch);
            waveManager.Draw(spriteBatch);            

            player.Draw(spriteBatch);

            // Hintergrund Leyer 1
            spriteBatch.Draw(background[1], backgroundFrame, Color.White);
            
            // Tower
            cannonButton.Draw(spriteBatch);            
            cryoButton.Draw(spriteBatch);
            twinCannonButton.Draw(spriteBatch);
            fortCannonButton.Draw(spriteBatch);
            grenadeLauncherButton.Draw(spriteBatch);
            laserButton.Draw(spriteBatch);

            // Gebäude
            powerStationButton.Draw(spriteBatch);
            oilStationButton.Draw(spriteBatch);
            metalMineButton.Draw(spriteBatch);
            refineryButton.Draw(spriteBatch);
            
            player.DrawPreview(spriteBatch); // Voransicht

            // Toolbar
            toolBar.Draw(spriteBatch, player);

            // Anzeigen des Upgrade Buttons bzw. der UI
            if (upgradeButtonVisible) upgradeButton.Draw(spriteBatch);
            if (IsSellButtonVisible) sellButton.Draw(spriteBatch);
            
            // Pausebutton
            pauseButton.Draw(spriteBatch);

            if (C.SHOWFPS)
            {
                frame_count++;
                string text = string.Format("fps : {0}   l fps : {1}", fps, fps_lowes);
                spriteBatch.DrawString(fps_font, text, new Vector2(0, 0), Color.Red);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }                
    }
}
