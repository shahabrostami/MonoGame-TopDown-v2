using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using topdown_fz.Components;

namespace topdown_fz.GameStates
{
    class TitleScreenState : BaseGameState
    {
        private Texture2D background, button, button_h, button_p;
        private Rectangle backgroundRect, buttonRectStart, buttonRectLoad, buttonRectExit;
        private int currentIndex;

        private static readonly int noOfButtons = 3;

        public TitleScreenState(Game game) : base(game)
        {
            game.Services.AddService(typeof(TitleScreenState), this);
        }

        #region Constructor
        public override void Initialize()
        {
            backgroundRect = Game1.ScreenRectangle;
            buttonRectStart = new Rectangle(backgroundRect.Width / 2 - 100, backgroundRect.Height - 200, 200, 30);
            buttonRectLoad = new Rectangle(backgroundRect.Width / 2 - 100, backgroundRect.Height - 150, 200, 30);
            buttonRectExit = new Rectangle(backgroundRect.Width / 2 - 100, backgroundRect.Height - 100, 200, 30);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            background = content.Load<Texture2D>(@"Backgrounds\title");
            button = content.Load<Texture2D>(@"UI\introbutton");
            button_h = content.Load<Texture2D>(@"UI\introbutton_h");
            button_p = content.Load<Texture2D>(@"UI\introbutton_p");
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            if (Xin.KeyReleased(Keys.S))
                currentIndex++;
            else if (Xin.KeyReleased(Keys.W))
                currentIndex--;

            if (currentIndex ==  noOfButtons)
                currentIndex = 0;
            else if (currentIndex == -1)
                currentIndex = noOfButtons - 1;

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            GameRef.SpriteBatch.Begin();

            GameRef.SpriteBatch.Draw(background, backgroundRect, Color.White);

            if (currentIndex == 0)
                GameRef.SpriteBatch.Draw(button, buttonRectStart, Color.White);
            else
                GameRef.SpriteBatch.Draw(button_h, buttonRectStart, Color.White);

            if (currentIndex == 1)
                GameRef.SpriteBatch.Draw(button, buttonRectLoad, Color.White);
            else
                GameRef.SpriteBatch.Draw(button_h, buttonRectLoad, Color.White);

            if (currentIndex == 2)
                GameRef.SpriteBatch.Draw(button, buttonRectExit, Color.White);
            else
                GameRef.SpriteBatch.Draw(button_h, buttonRectExit, Color.White);

            GameRef.SpriteBatch.End();
            base.Draw(gameTime);
        }
        #endregion
    }
}
