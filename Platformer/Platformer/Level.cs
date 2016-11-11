﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Platformer
{
    public class Level
    {
        /// <summary>
        /// Starting position of character in the level.
        /// </summary>
        public Vector2 StartPosition { get; set; }

        /// <summary>
        /// List of platforms for the level. These are safe to stand on.
        /// </summary>
        public List<Platform> Platforms { get; set; }

        /// <summary>
        /// List of power-ups for the level.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Background image for the level.
        /// </summary>
        public Texture2D BackgroundImage { get; set; }

        /// <summary>
        /// The sprite representing the goal to reach (exit door) in the level.
        /// </summary>
        public Sprite Door { get; set; }

        public Level(List<Platform> platform, List<Item> items, Texture2D background, Sprite door)
        {
            Platforms = platform;
            BackgroundImage = background;
            Door = door;
            Items = items;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(BackgroundImage, new Rectangle(0, 0, spriteBatch.GraphicsDevice.Viewport.Width, spriteBatch.GraphicsDevice.Viewport.Height), Color.White);
            for (int i = 0; i < Platforms.Count; i++)
            {
                Platforms[i].Draw(spriteBatch);
            }
            Door.Draw(spriteBatch);
        }
    }
}
