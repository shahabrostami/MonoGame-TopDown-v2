using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topdown_fz.Components
{
    class MenuItem
    {
        #region Fields
        public String label;
        public Rectangle textureDestination;
        public Vector2 labelDestination;
        public int index;
        public static int totalItems = 0;
        #endregion

        #region Constructor
        public MenuItem(String label, Rectangle textureDestination, Vector2 labelDestination)
        {
            this.label = label;
            this.textureDestination = textureDestination;
            this.labelDestination = labelDestination;
            index = totalItems;
            totalItems++;
        }
        #endregion

    }

    class MenuComponent
    {
        #region Fields
        private List<MenuItem> items;
        private int currentIndex = 0;

        private Texture2D normalTexture;
        private Texture2D highlightTexture;
        private Texture2D pressedTexture;
        private SpriteFont font;

        private int width;
        private int height;

        private readonly int spacing = 10;
        #endregion

        #region Constructor
        public MenuComponent(List<String> labels, SpriteFont spriteFont, Texture2D normal, Texture2D highlight, Texture2D pressed, int positionX, int positionY)
        {
            normalTexture = normal;
            highlightTexture = highlight;
            pressedTexture = pressed;
            font = spriteFont;

            width = normal.Width;
            height = normal.Height;

            int x = positionX - width/2;
            int y = positionY;

            items = new List<MenuItem>(labels.Count);
            foreach (String label in labels)
            {
                Vector2 fontSize = font.MeasureString(label);
                items.Add(new MenuItem(
                    label, 
                    new Rectangle(x, y, width, height), 
                    new Vector2(x + width / 2 -fontSize.X / 2, y + height / 2 - fontSize.Y / 2)));
                y += spacing + height;
            }
        }
        #endregion

        #region Methods
        public void Update(GameTime gameTime)
        {
            if (Xin.KeyReleased(Keys.S))
                currentIndex++;
            else if (Xin.KeyReleased(Keys.W))
                currentIndex--;

            if (currentIndex == items.Count)
                currentIndex = 0;
            else if (currentIndex == -1)
                currentIndex = items.Count - 1;

        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (MenuItem item in items)
            {
                if(item.index == currentIndex)
                    spriteBatch.Draw(highlightTexture, item.textureDestination, Color.White);
                else
                    spriteBatch.Draw(normalTexture, item.textureDestination, Color.White);

                spriteBatch.DrawString(font, item.label, item.labelDestination, Color.White);
            }
        }
        #endregion
    }
}
