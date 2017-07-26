using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiledSharp;

namespace topdown_fz.MapEngine
{
    class TileLayer
    {
        #region Field
        private String layerName;

        private TileSet tileSet;
        private TmxLayer tmxLayer;

        private Camera camera;
        private Point cameraTLPosition;
        private Point cameraBRPosition;


        #endregion

        #region Property
        #endregion

        #region Constructor
        public TileLayer(String layerName, TmxLayer tmxLayer)
        {
            this.layerName = layerName;
            this.tmxLayer = tmxLayer;
        }
        #endregion

        #region Method

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch, TileSet tileSet, GameTime gameTime, Camera camera)
        {
            cameraTLPosition = TileEngine.Vector2Cell(camera.Position);
            cameraBRPosition = TileEngine.Vector2Cell(new Vector2(camera.Position.X + TileEngine.ViewRectangle.Width, camera.Position.Y + TileEngine.ViewRectangle.Height));
            Rectangle dest = new Rectangle(0, 0, TileEngine.TileWidth, TileEngine.TileHeight);

            foreach (TmxLayerTile tile in tmxLayer.Tiles)
            {
                // Is it drawable? (!= 0)
                // Is it in view? (camera range)
                if (tile.Gid == 0 || ((tile.X < cameraTLPosition.X || tile.X > cameraBRPosition.X) && (tile.Y < cameraTLPosition.Y || tile.Y > cameraBRPosition.Y)))
                    break;

                dest.X = tile.X * TileEngine.TileWidth;
                dest.Y = tile.Y * TileEngine.TileHeight;

                spriteBatch.Draw(tileSet.Texture, dest, tileSet.DrawRectangles[tile.Gid], Color.White);
            }
        }
        #endregion
    }
}
