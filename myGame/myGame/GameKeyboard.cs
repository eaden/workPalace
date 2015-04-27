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
    public class GameKeyboard
    {
        private KeyboardState newState;
        private KeyboardState oldState;

        public void update(ContentManager Content, GameEnvironment underworld)
        {
            this.newState = Keyboard.GetState();

            // handle the input
            if (oldState.IsKeyUp(Keys.Left) && newState.IsKeyDown(Keys.Left))
            {
                //underworld.floorPlates[0].change(Content);
            }

            oldState = newState;  // set the new state as the old state for next time
        }

        public void update(GameEnvironment underworld)
        {
            this.newState = Keyboard.GetState();

            if (oldState.IsKeyUp(Keys.Left) && newState.IsKeyDown(Keys.Left))
            {
                underworld.players[0].moveOneStep("Left");
                //underworld.players[0].Position = new Vector3(-1.0f, 0, 0);
            }
            else if (oldState.IsKeyUp(Keys.Right) && newState.IsKeyDown(Keys.Right))
            {
                underworld.players[0].moveOneStep("Right");
                //underworld.players[0].Position = new Vector3( 1.00f, 0, 0);
            }
            else if (oldState.IsKeyUp(Keys.Down) && newState.IsKeyDown(Keys.Down))
            {
                underworld.players[0].moveOneStep("Up");
            }
            else if (oldState.IsKeyUp(Keys.Up) && newState.IsKeyDown(Keys.Up))
            {
                underworld.players[0].moveOneStep("Down");
            }

            oldState = newState;  // set the new state as the old state for next time

            /*
            // handle the input
            if (oldState.IsKeyUp(Keys.Left) && newState.IsKeyDown(Keys.Left))
            {
                
            }

            oldState = newState;  // set the new state as the old state for next time
             * */
            /*
            if (newState.IsKeyDown(Keys.Left))
            {
                underworld.players[0].Position = new Vector3(-0.04f, 0, 0);
            }
            */
        }
    }
}
