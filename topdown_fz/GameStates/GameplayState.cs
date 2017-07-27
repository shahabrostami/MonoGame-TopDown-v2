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
        private TileMap map;
        private Camera camera;

        public GameplayState(Game game) : base(game)
        {
            game.Services.AddService(typeof(GameplayState), this);
            tileEngine = new TileEngine(GraphicsDevice.Viewport.Bounds);
            camera = new Camera();
        }

        public void newGame()
        {
            map = new TileMap("farm");
        }

        #region Constructor
        public override void Initialize()
        {
            backgroundRect = Game1.ScreenRectangle;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            map.LoadContent(GameRef.Content);
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            map.Update(gameTime);
            camera.Update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            GameRef.SpriteBatch.Begin(
                                 SpriteSortMode.Deferred,
                                 BlendState.AlphaBlend,
                                 SamplerState.PointClamp,
                                 null,
                                 null,
                                 null,
                                 camera.Transformation);

            map.Draw(GameRef.SpriteBatch, gameTime, camera);

            GameRef.SpriteBatch.End();
            base.Draw(gameTime);
        }
        #endregion
    }
}
