using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using topdown_fz.Components;
using topdown_fz.MapEngine;

namespace topdown_fz.GameStates
{
    class GameplayState : BaseGameState
    {
        private Rectangle backgroundRect;
        private TileEngine tileEngine;

        public GameplayState(Game game) : base(game)
        {
            game.Services.AddService(typeof(GameplayState), this);
            tileEngine = new TileEngine(GraphicsDevice.Viewport.Bounds);
            tileEngine.changeMap("farm");
        }

        #region Constructor
        public override void Initialize()
        {
            backgroundRect = Game1.ScreenRectangle;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            GameRef.SpriteBatch.Begin();

            // GameRef.SpriteBatch.Draw(background, backgroundRect, Color.White);

            GameRef.SpriteBatch.End();
            base.Draw(gameTime);
        }
        #endregion
    }
}
