using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace myGame
{
    class Wall
    {
        public Model model { get; set; }
        public string modelName { get; set; }
        public string direction { get; set; }

        public Wall(string modelName)
        {
            this.modelName = modelName;
            switch(modelName)
            {
                case "WallLeft":
                    this.direction = "left";
                    break;
                case "WallRight":
                    this.direction = "right";
                    break;
                case "WallFront":
                    this.direction = "front";
                    break;
                case "WallBack":
                    this.direction = "back";
                    break;
            }
        }
    }
}
