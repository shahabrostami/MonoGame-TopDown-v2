using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_fz.Components
{
    class Xin : GameComponent
    {
        private static KeyboardState currentKeyboardState;
        private static KeyboardState previousKeyboardState;

        public Xin(Game game) : base(game)
        {
        }

        public static bool KeyReleased(Keys key)
        {
            return previousKeyboardState.IsKeyDown(key) && currentKeyboardState.IsKeyUp(key);
        }

        public static bool KeyPressed(Keys key)
        {
            return currentKeyboardState.IsKeyDown(key);
        }

        public override void Update(GameTime gameTime)
        {
            previousKeyboardState = currentKeyboardState;
            currentKeyboardState = Keyboard.GetState();

            base.Update(gameTime);
        }
    }
}
