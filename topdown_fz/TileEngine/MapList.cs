using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_fz.TileEngine
{
    class mapConfig
    {
        private TileSet tileSet;
        private TileMap tileMap;

        public MapDescription(TileSet tileSet, TileMap tileMap)
        {
            this.tileSet = tileSet;
            this.tileMap = tileMap;
        }
    }
}
