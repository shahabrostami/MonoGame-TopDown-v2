using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiledSharp;

namespace topdown_fz.MapEngine
{
    class TileSet
    {
        #region Field
        private int tileWidth;
        private int tileHeight;

        private int textureWidth;
        private int tetureHeight;
        #endregion

        #region Property
        #endregion

        #region Constructor
        public TileSet(TmxTileset tmxTileSet)
        {
            this.tileWidth = tmxTileSet.TileWidth;
            this.tileHeight = tmxTileSet.TileHeight;
            this.textureWidth = (int) tmxTileSet.Image.Width;
            this.tetureHeight = (int) tmxTileSet.Image.Height;

        }
        #endregion

        #region Method

        #endregion
    }
}
