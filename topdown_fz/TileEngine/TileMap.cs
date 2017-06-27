using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiledSharp;

namespace topdown_fz.TileEngine
{
    class TileMap
    {
        #region Field
        private String mapName;

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

            TmxMap map = new TmxMap("Maps/TileMap/" + mapName + ".tmx");

            groundLayer = new TileLayer("ground", map.Layers[0]);
            edgeLayer = new TileLayer("edge", map.Layers[1]);
            buildingLayer = new TileLayer("building", map.Layers[2]);
            decorationLayer = new TileLayer("decoration", map.Layers[3]);

            mapWidth = map.Width;
            mapHeight = map.Height;
        }
        #endregion

        #region Method
        #endregion

    }
}
