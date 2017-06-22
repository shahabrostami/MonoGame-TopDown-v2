using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace topdown_fz.GameStates
{
    class TitleScreenState : BaseGameState
    {
        private Texture2D background;
        private Rectangle backgroundRect;

        public TitleScreenState(Game game) : base(game)
        {
            game.Services.AddService(typeof(TitleScreenState), this);
        }

        #region Constructor
        public override void Initialize()
        {
            backgroundRect = Game1.ScreenRectangle;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            background = content.Load<Texture2D>(@"Backgrounds\title");
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            GameRef.SpriteBatch.Begin();

            GameRef.SpriteBatch.Draw(background, backgroundRect, Color.White);

            GameRef.SpriteBatch.End();
            base.Draw(gameTime);
        }
        #endregion
    }
}
