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
        private GameStateManager stateManager;

        #endregion

        #region Constructor
        public GameState(Game game) : base(game)
        {
            components = new Stack<GameComponent>();
            stateManager = (GameStateManager)Game.Services.GetService(typeof(GameStateManager));
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

        internal void StateChangeEvent(object sender, EventArgs e)
        {
            if (stateManager.CurrentState == this)
            {
                StateEnabled(true);
            } else
                StateEnabled(false);
        }

        private void StateEnabled(Boolean b)
        {
            Enabled = b;
            Visible = b;
            /* foreach (GameComponent component in components)
            {
                component.Enabled = b;
                if (component is DrawableGameComponent)
                    ((DrawableGameComponent)component).Visible = b;
            }
            */
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
