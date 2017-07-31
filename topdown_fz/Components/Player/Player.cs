using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_fz.Components.Player
{
    class Player : DrawableGameComponent
    {
        #region Field
        private Vector2 position;
        private Game1 gameRef;
        private AnimatedSprite sprite;
        Dictionary<AnimationEnum, Animation> playerAnimations = new Dictionary<AnimationEnum, Animation>();
        // private AnimatedSprite sprite;
        #endregion

        #region Property
        public Vector2 Position { get { return position; } }
        #endregion

        #region Constructor
        public Player(Game game) : base(game)
        {
            gameRef = (Game1) game;
        }
        #endregion

        #region Methods
        public static Player Load(Game game)
        {
            Player player = new Player(game);
            return player;
        }

        public override void Initialize()
        {
            sprite = new AnimatedSprite(playerAnimations);
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
            base.Draw(gameTime);
            // sprite.Draw(gameTime, gameRef.SpriteBatch);
        }

        #endregion
    }
}
