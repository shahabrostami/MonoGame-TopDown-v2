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
        private List<String> labels;

        public TitleScreenState(Game game) : base(game)
        {
            game.Services.AddService(typeof(TitleScreenState), this);
        }

        #region Constructor
        public override void Initialize()
        {
            backgroundRect = Game1.ScreenRectangle;

            labels = new List<String>() { "NEW", "CONTINUE", "EXIT" };
            base.Initialize();
        }

        protected override void LoadContent()
        {
            background = content.Load<Texture2D>(@"Backgrounds\title");

            Texture2D button = content.Load<Texture2D>(@"UI\Buttons\introbutton");
            Texture2D button_h = content.Load<Texture2D>(@"UI\Buttons\introbutton_h");
            Texture2D button_p = content.Load<Texture2D>(@"UI\Buttons\introbutton_p");
            SpriteFont font = content.Load<SpriteFont>(@"UI\Fonts\Goeslim");
            menuComponent = new MenuComponent(labels, font, button, button_h, button_p, backgroundRect.Width/2, backgroundRect.Height - 200);
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            menuComponent.Update(gameTime);
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
