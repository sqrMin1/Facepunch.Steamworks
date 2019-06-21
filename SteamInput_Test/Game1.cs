using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Steamworks;
using Steamworks.Data;
using System;
using System.Linq;

using Color = Microsoft.Xna.Framework.Color;

namespace SteamInput_Test
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        SpriteFont Font;

        bool IsSteamRunning = false;

        Controller CurrentController;

        bool FirePressed = false;
        Vector2 Move = Vector2.Zero;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();

            Exiting += Game1_Exiting;

            try
            {
                SteamClient.Init(838870);

                IsSteamRunning = true;

                CurrentController = SteamInput.Controllers.ToList()[0];

                if (CurrentController != null)
                {
                    var testSet = CurrentController.GetActionSetHandle("TestSet");
                    CurrentController.ActionSet = "TestSet";
                    //var test = CurrentController.GetCurrentActionSetLayer();

                    //var test1 = CurrentController.GetStringForActionOrigin(InputActionOrigin.XBox360_X);
                    //var test2 = CurrentController.GetGlyphForActionOrigin(InputActionOrigin.Switch_RightTrigger_Pull);
                    //var test3 = CurrentController.GetGlyphForXboxOrigin(XboxOrigin.RightTrigger_Pull);
                    
                    //var test = CurrentController.GetDigitalOrigins("TestSet", "Fire");
                }
            }
            catch (Exception e) { e.Message.ToString(); }
        }

        private void Game1_Exiting(object sender, EventArgs e)
        {
            if (IsSteamRunning) SteamClient.Shutdown();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Font = Content.Load<SpriteFont>(@"Font");
        }
        protected override void Update(GameTime gameTime)
        {
            if (IsSteamRunning)
            {
                SteamInput.RunFrame();

                if (CurrentController != null)
                {
                    if (CurrentController.GetDigitalState("Fire").Pressed)
                    {
                        FirePressed = true;
                    }
                    else FirePressed = false;

                    var move = CurrentController.GetAnalogState("Move");
                    Move = new Vector2(move.X, move.Y);
                }

                SteamClient.RunCallbacks();
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.DrawString(Font, $"Fire Pressed: {FirePressed}", new Vector2(200, 200), Color.Yellow);
            spriteBatch.DrawString(Font, $"Move: {Move}", new Vector2(200, 230), Color.Yellow);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
