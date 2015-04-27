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
    public class FloorPlate
    {
        public Model model { get; set; }
        public string modelName { get; set; }
        private Vector3 location = new Vector3(0, 0, 0);

        public FloorPlate(string modelName)
        {
            this.modelName = modelName;
        }

        public FloorPlate(string modelName, Vector3 location)
        {
            this.modelName = modelName;
            this.location = location;
        }

        public Vector3 Location
        {
            get
            {
                return location;
            }
            set
            {
                location = Vector3.Add(location, value);
            }
        }
        /* ***************************************SUUUUPERSPECIALMETHOD
        public void change(ContentManager Content)
        {
            this.model = Content.Load<Model>("WallBack");
        }
        */
    }
}
