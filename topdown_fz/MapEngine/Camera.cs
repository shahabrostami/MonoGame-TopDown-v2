using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_fz.MapEngine
{
    class Camera
    {
        private readonly Viewport viewport;

        private Vector2 position;
        private float Rotation;
        private float Zoom;
        private Vector2 Origin;

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Matrix? Transformation
        {
            get { return getViewMatrix(); }
        }

        public Camera()
        {
            Rotation = 0;
            Zoom = 1;
            Origin = new Vector2(viewport.Width / 2f, viewport.Height / 2f);
            Position = Vector2.Zero;
        }
        
        public void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.PageUp))
            {
                position.Y -= 5.0F;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.PageDown))
            {
                position.Y += 5.0F;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.End))
            {
                position.X += 5.0F;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Home))
            {
                position.X -= 5.0F;
            }

            position.X -= Origin.X;
            position.Y -= Origin.Y;
        }

        public Matrix getViewMatrix()
        {
            return
                Matrix.CreateTranslation(new Vector3(-Position, 0.0f)) *
                Matrix.CreateTranslation(new Vector3(-Origin, 0.0f)) *
                Matrix.CreateRotationZ(Rotation) *
                Matrix.CreateScale(Zoom, Zoom, 1) *
                Matrix.CreateTranslation(new Vector3(Origin, 0.0f));
        }
    }
}
