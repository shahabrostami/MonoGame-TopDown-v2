﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_fz.TileEngine
{
    class TileEngine
    {
        #region Field
        private TileMap currentMap;
        private Camera camera;
        #endregion

        #region Property
        #endregion

        #region Constructor

        public TileEngine(Viewport viewport)
        {
            camera = new Camera(viewport);
        }
        #endregion

        #region Method

        public void changeMap(String mapName)
        {
            TileSet newTileSet = new TileSet();
            currentMap = new TileMap(mapName);
        }
        #endregion
    }
}