using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace topdown_fz.GameStates
{
    class BaseGameState : GameState
    {
        #region Field
        protected Game1 GameRef;
        #endregion

        public BaseGameState(Game game) : base(game)
        {
            GameRef = (Game1)game;
        }

        #region Constructor
        public override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        #endregion
    }
}
