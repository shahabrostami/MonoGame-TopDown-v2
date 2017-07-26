using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_fz.MapEngine
{
    class TileEngine
    {
        #region Field
        private static Rectangle viewRectangle;
        private Camera camera;

        private static int tileWidth = 32;
        private static int tileHeight = 32;
        #endregion

        #region Property
        public static Rectangle ViewRectangle
        {
            get { return viewRectangle; }
        }

        public static int TileWidth {
            get { return tileWidth; } 
        }

        public static int TileHeight {
            get { return tileHeight; }
        }
        #endregion

        #region Constructor

        public TileEngine(Rectangle viewportBounds)
        {
            camera = new Camera();
            viewRectangle = viewportBounds;
        }
        #endregion

        #region Method

        public static Point Vector2Cell(Vector2 vector)
        {
            return new Point((int) vector.X / tileWidth, (int) vector.Y / tileHeight);
        }
        #endregion
    }
}
