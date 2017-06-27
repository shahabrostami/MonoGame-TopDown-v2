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
        #endregion

        #region Property
        #endregion

        #region Constructor

        public TileEngine(int tileWidth, int tileHeight)
        {
        }
        #endregion

        #region Method

        public void changeMap(String mapName)
        {
            currentMap = new TileMap(mapName);
        }
        #endregion
    }
}
