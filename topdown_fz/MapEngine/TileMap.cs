using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiledSharp;
using Microsoft.Xna.Framework.Content;

namespace topdown_fz.MapEngine
{
    class TileMap
    {
        #region Field
        private String mapName;
        private List<TileSet> tileSets;

        private TileLayer groundLayer;
        private TileLayer edgeLayer;
        private TileLayer buildingLayer;
        private TileLayer decorationLayer;

        private int mapWidth;
        private int mapHeight;
        #endregion

        #region Property
        #endregion

        #region Constructor
        public TileMap(String mapName)
        {
            this.mapName = mapName;

            TmxMap map = new TmxMap("Content/Map/TMX/" + mapName + ".tmx");

            tileSets = new List<TileSet>(map.Tilesets.Count);

            foreach (TmxTileset tileSet in map.Tilesets) {
                tileSets.Add(new TileSet(tileSet));
            }

            groundLayer = new TileLayer("ground", map.Layers[0]);
            edgeLayer = new TileLayer("edge", map.Layers[1]);
            buildingLayer = new TileLayer("building", map.Layers[2]);
            decorationLayer = new TileLayer("decoration", map.Layers[3]);

            mapWidth = map.Width;
            mapHeight = map.Height;
        }

        internal string getName()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Method
        public void LoadContent(ContentManager Content)
        {
            foreach (TileSet tileSet in tileSets)
                tileSet.LoadContent(Content);
        }
        public void Update(GameTime gameTime)
        {

        }
        
        public void Draw(SpriteBatch spriteBatch, GameTime gameTime, Camera camera)
        {
            groundLayer.Draw(spriteBatch, tileSets[0], gameTime, camera);
            edgeLayer.Draw(spriteBatch, tileSets[0], gameTime, camera);
            buildingLayer.Draw(spriteBatch, tileSets[0], gameTime, camera);
            decorationLayer.Draw(spriteBatch, tileSets[0], gameTime, camera);
        }
        #endregion

    }
}
