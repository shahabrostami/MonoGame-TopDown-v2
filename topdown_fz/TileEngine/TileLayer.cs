using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiledSharp;

namespace topdown_fz.TileEngine
{
    class TileLayer
    {
        #region Field
        private String layerName;
        private TmxLayer tmxLayer;
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
        #endregion
    }
}
