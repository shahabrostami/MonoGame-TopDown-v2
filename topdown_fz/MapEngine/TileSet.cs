using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
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
        private String tileName;
        private int tileWidth;
        private int tileHeight;
        private int tilesWide;
        private int tilesHigh;
        private int textureHeight;
        private int textureWidth;

        private Texture2D texture;
        private Rectangle[] drawRectangles;
        #endregion

        #region Property
        [ContentSerializerIgnore]
        public Rectangle[] DrawRectangles
        {
            get { return (Rectangle[])drawRectangles.Clone(); }
        }

        public Texture2D Texture {
            get { return texture; }
        }
        #endregion

        #region Constructor
        public TileSet(TmxTileset tmxTileSet)
        {
            this.tileName = tmxTileSet.Name;
            this.tileWidth = tmxTileSet.TileWidth;
            this.tileHeight = tmxTileSet.TileHeight;
            this.textureWidth = (int)tmxTileSet.Image.Width;
            this.textureHeight = (int)tmxTileSet.Image.Height;
            this.tilesWide = textureWidth / tileWidth;
            this.tilesHigh = textureHeight / tileHeight;

            drawRectangles = new Rectangle[tilesWide * tilesHigh];
            for(int i = 0; i < drawRectangles.Length; i++)
            {
                drawRectangles[i] = new Rectangle(tileWidth * i, tileHeight * i, tileWidth, tileHeight);
            }
        }
        #endregion

        #region Method
        public void LoadContent(ContentManager Content)
        {
            texture = Content.Load<Texture2D>("Map/tilesets/" + tileName);
        }
        #endregion
    }
}
