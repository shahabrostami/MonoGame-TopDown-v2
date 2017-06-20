using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_fz.GameStates
{
    class GameState : DrawableGameComponent, IGameState
    {
        #region Property
        List<GameComponent> components = new List<GameComponent>();

        #endregion

        #region Constructor
        public GameState(Game game) : base(game)
        {
        }
        #endregion

        #region Methods

        public override void Initialize()
        {

        }
        protected override void LoadContent()
        {

        }

        public override void Draw(GameTime gameTime)
        {
            if (Visible && Enabled)
                foreach (GameComponent component in components)
                    if(component is DrawableGameComponent && ((DrawableGameComponent) component).Visible)
                    {
                        ((DrawableGameComponent)component).Draw(gameTime);
                    }

        }

        public override void Update(GameTime gameTime)
        {

        }
        #endregion

    }
}
