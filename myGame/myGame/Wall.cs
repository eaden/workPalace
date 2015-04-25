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
        private ContentManager Content;
        //private string modelName;
        /*
        public Wall()
        { }
        */
        public Wall(ContentManager Content, string modelName)
        {
            this.Content = Content;
            this.modelName = modelName;
        }
    }
}
