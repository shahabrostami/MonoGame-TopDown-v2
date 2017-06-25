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
        private MenuComponent menuComponent;
        private Rectangle backgroundRect;
        private Texture2D background;
        private int currentIndex;

        public TitleScreenState(Game game) : base(game)
        {
            game.Services.AddService(typeof(TitleScreenState), this);
        }

        #region Constructor
        public override void Initialize()
        {
            backgroundRect = Game1.ScreenRectangle;
            menuComponent = new MenuComponent(null, null, null, null);
            currentIndex = 0;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            background = content.Load<Texture2D>(@"Backgrounds\title");
            // button = content.Load<Texture2D>(@"UI\introbutton");
            // button_h = content.Load<Texture2D>(@"UI\introbutton_h");
            // button_p = content.Load<Texture2D>(@"UI\introbutton_p");
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

            menuComponent.Draw(GameRef.SpriteBatch, gameTime);

            GameRef.SpriteBatch.End();
            base.Draw(gameTime);
        }
        #endregion
    }
}
