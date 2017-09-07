using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Tower_Crush
{
    public enum ButtonStatus
    {
        Normal,
        MouseOver,
        Pressed
    }
    public enum ButtonType
    {
        UpgradeButton,
        SellButton
    }

    public class Button : Sprite
    {
        // Mausstatus des letzten Frame
        private MouseState previousState;

        // Texturen für den verschiedenen Status der Maus
        private Texture2D hoverTexture;
        private Texture2D pressedTexture;

        private ObjectTypeConfig objectTypeConfig; // Configurations zum Turm der Unter dem Knopf liegt
        private SpriteFont font;

        // Ein Recheck der die Maus überdecken soll
        private Rectangle bounds;

        // Speichert den aktuellen Status der Maus
        private ButtonStatus state = ButtonStatus.Normal;

        // Event für die Knöpfe
        public event EventHandler Clicked;
        // Wird ausgelöst wenn der Knopf gehalten wird
        public event EventHandler OnPress;

        public void SetPositionHeadup(ButtonType buttonType, Vector2 newPosition)
        {
            switch (buttonType)
            {
                case ButtonType.UpgradeButton:
                    {
                        newPosition.Y -= (int)(C.BS + (C.BS / 3.0f));
                        newPosition.X -= (int)(C.BS - (C.BS / 4.5f));
                        this.position = newPosition;
                        this.bounds = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
                        break;
                    }
                case ButtonType.SellButton:
                    {
                        newPosition.Y -= (C.BS + (C.BS / 2));
                        this.position = newPosition;
                        this.bounds = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
                        break;
                    }
            }
        }

        public Button(Texture2D texture, Texture2D hoverTexture, Texture2D pressedTexture, ObjectTypeConfig objectTypeConfig, SpriteFont font, Vector2 position)
            : base(texture, position)
        {
            this.hoverTexture = hoverTexture;
            this.pressedTexture = pressedTexture;

            this.font = font;
            this.objectTypeConfig = objectTypeConfig;

            // Legt die Position und die Größe des Buttons fest
            this.bounds = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }

        public override void  Update(GameTime gameTime)
        {
            // Prüfen ob die Maus sich über dem Knopf befindet
            MouseState mouseState = Mouse.GetState();
            int mouseX = mouseState.X;
            int mouseY = mouseState.Y;
            bool isMouseOver = bounds.Contains(mouseX, mouseY);

            // Nun wird die Auswertung des Mausstatus weiter gegeben
            if (isMouseOver && state != ButtonStatus.Pressed)
            {
                state = ButtonStatus.MouseOver;
            }
            else if (!isMouseOver && state != ButtonStatus.Pressed)
            {
                state = ButtonStatus.Normal;
            }

            // Prüfen ob der Spieler den Knopf noch festhält
            if (mouseState.LeftButton == ButtonState.Pressed &&
                previousState.LeftButton == ButtonState.Released)
            {
                // Aktuallisieren des Maus Status
                if (isMouseOver)
                {
                    state = ButtonStatus.Pressed;

                    if (OnPress != null) OnPress(this, EventArgs.Empty);
                }
            }

            // Prüfen ob der Spieler den Knopf los gelassen hat
            if (mouseState.LeftButton == ButtonState.Released &&
                previousState.LeftButton == ButtonState.Pressed)
            {
                if (isMouseOver)
                {
                    // Aktuallisieren des Maus Status
                    state = ButtonStatus.MouseOver;

                    if (Clicked != null)
                    {
                        // hier wird das Event ausgelöst
                        Clicked(this, EventArgs.Empty);
                    }
                }
                else if (state == ButtonStatus.Pressed)
                {
                    state = ButtonStatus.Normal;
                }
            }
            previousState = mouseState;
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            if (this.objectTypeConfig == null || this.objectTypeConfig.IsAvailable)
            {
                switch (state)
                {
                    case ButtonStatus.Normal:
                        spriteBatch.Draw(texture, bounds, Color.White);
                        break;
                    case ButtonStatus.MouseOver:
                        spriteBatch.Draw(hoverTexture, bounds, Color.White);

                        if (objectTypeConfig == null) break;
                        string text = string.Format("{0} ({1})", objectTypeConfig.Name, objectTypeConfig.Cost);
                        //spriteBatch.DrawString(font, text, new Vector2(bounds.X - 16, bounds.Y - 16), Color.White);
                        spriteBatch.DrawString(font, text, new Vector2((int)(22 * 32), 16), Color.White);

                        break;
                    case ButtonStatus.Pressed:
                        spriteBatch.Draw(pressedTexture, bounds, Color.White);
                        break;
                    default:
                        spriteBatch.Draw(texture, bounds, Color.White);
                        break;
                }
            }
            else
            {
                spriteBatch.Draw(pressedTexture, bounds, Color.White);
            }            
        }

    }
}
