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
    public class Player
    {
        public Model model { get; set; }
        public string modelName { get; set; }
        private Vector3 position = new Vector3(0, 0, 0);
        private int stepSize = 2;

        public Player(string modelName)
        {
            this.modelName = modelName;
        }
        public Player(string modelName, Vector3 position)
        {
            this.modelName = modelName;
            this.position = position;
        }

        public Vector3 Position
        {
            get
            {
                return position;
            }
            set
            {
                position = Vector3.Add(position, value);
            }
        }

        public void moveOneStep(string direction)
        {
            switch(direction)
            {
                case "Left":
                    
                    Vector3 saveValue = this.Position;
                    while (this.Position.X > (saveValue.X - 1.0f))
                        Position = new Vector3(-0.04f, 0, 0);
                    Position = Vector3.Add(saveValue, new Vector3(-1, 0, 0));
                     
                    break;
                case "Right":
                    break;
                case "Up":

                    break;
                case "Down":

                    break;
            }
        }



    }
}
