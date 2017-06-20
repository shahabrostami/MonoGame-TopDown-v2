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
        Stack<GameComponent> components;

        #endregion

        #region Constructor
        public GameState(Game game) : base(game)
        {
            components = new Stack<GameComponent>();
        }
        #endregion

        #region Methods

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
            if (Visible && Enabled)
                foreach (GameComponent component in components)
                    if(component is DrawableGameComponent && ((DrawableGameComponent) component).Visible)
                        ((DrawableGameComponent)component).Draw(gameTime);

            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            if(Enabled)
                foreach (GameComponent component in components)
                    if(component.Enabled)
                        component.Update(gameTime);
            base.Update(gameTime);
        }
        #endregion

    }
}
