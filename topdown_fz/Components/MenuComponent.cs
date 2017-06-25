using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_fz.Components
{
    class MenuItem
    {
        String label;
        Rectangle destination;

        public MenuItem(String label)
        {
            this.label = label;
        }
    }

    class MenuComponent
    {
        private List<MenuItem> items;
        private int currentIndex;
        private int numberOfButtons;

        private Texture2D normalTexture;
        private Texture2D highlightTexure;
        private Texture2D pressedTexture;

        private int width;
        private int height;

        public MenuComponent(List<String> labels, Texture2D normal, Texture2D highlight, Texture2D pressed)
        {
            normalTexture = normal;
            highlightTexure = highlight;
            pressedTexture = pressed;

            width = 200;
            height = 30;

            foreach (String label in labels)
            {
                items.Add(new MenuItem(label));
            }
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (MenuItem item in items)
            {

            }
        }
    }
}
