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
        #region Property
        List<GameState> states;
        GameState currentState;
        #endregion

        #region Constructor
        public GameStateManager(Game game) : base(game)
        {
            states = new List<GameState>();
            Game.Services.AddService(typeof(GameStateManager), this);
        }
        #endregion

        #region Methods
        public void pushState(GameState gameState)
        {

        }

        public void popState(GameState gameState)
        {

        }
        #endregion


    }
}
