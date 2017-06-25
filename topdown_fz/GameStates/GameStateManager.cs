using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_fz.GameStates
{
    class GameStateManager : GameComponent
    {
        #region Field
        Stack<GameState> states;
        event EventHandler StateChangeEvent;
        #endregion

        #region Property
        public GameState CurrentState
        {
            get { return states.Peek(); }
        }
        #endregion

        #region Constructor
        public GameStateManager(Game game) : base(game)
        {
            states = new Stack<GameState>();
            Game.Services.AddService(typeof(GameStateManager), this);
        }
        #endregion

        #region Methods
        public void PushState(GameState gameState)
        {
            states.Push(gameState);
            Game.Components.Add(gameState);
            StateChangeEvent += gameState.StateChangeEvent;
        }

        public void PopState()
        {
            if (states.Count <= 0)
                return;

            GameState popState = states.Pop();
            Game.Components.Remove(popState);
            StateChangeEvent -= popState.StateChangeEvent;
        }

        public void ChangeState(GameState gameState)
        {
            while (states.Count > 0)
                PopState();

            PushState(gameState);

            StateChanged();
        }

        public void StateChanged()
        {
            StateChangeEvent(this, null);
        }
        #endregion
    }
}
