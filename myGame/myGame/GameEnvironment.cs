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
    public class GameEnvironment
    {
        private ContentManager Content;
        //private string modelName;
        private List<Creature> floorPlates = new List<Creature>();
        //private uint floorPlateCounter = 1;

        public GameEnvironment(ContentManager Content)
        {
            this.Content = Content;
        }

        public void add()
        {
            //Creature floorPlateCounter;
            floorPlates.Add(new Creature(Content, "FloorPlate"));
        }

        public void loadContent()
        {
            foreach (Creature c in floorPlates)
                //c.loadContent();
                c.model = Content.Load<Model>(c.modelName);
        }

        public void draw(Matrix w, Matrix v, Matrix p)
        {
            foreach (Creature c in floorPlates)
                //c.draw(w, v, p);
                drawModel(c.model, w, v, p);
        }
        
        private void drawModel(Model model, Matrix world, Matrix view, Matrix projection)
        {
            foreach (ModelMesh mesh in model.Meshes)
            {
                foreach (BasicEffect effect in mesh.Effects)
                {
                    effect.EnableDefaultLighting();
                    effect.World = world;
                    effect.View = view;
                    effect.Projection = projection;
                }

                mesh.Draw();
            }
        }
        
    }

    
}
