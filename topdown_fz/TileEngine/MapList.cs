using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_fz.TileEngine
{
    class Map
    {
        private TileSet tileSet;
        private TileMap tileMap;

        public Map(TileSet tileSet, TileMap tileMap)
        {
            this.tileSet = tileSet;
            this.tileMap = tileMap;
        }
    }
}
