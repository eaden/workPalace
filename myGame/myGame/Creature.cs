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
    public class Creature
    {
        public Model model { get; set; }
        public string modelName { get; set; }
        //public Vector3 position { get; set; }
        private Vector3 position = new Vector3(0, 0, 0);

        //private Vector3 location = new Vector3(0, 0, 0);
        public Creature(string modelName)
        {
            this.modelName = modelName;
        }
        public Creature(string modelName, Vector3 position)
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
        
        
        /*
        public void loadContent()
        {
            model = Content.Load<Model>(modelName);
            //model = Content.Load<Model>("FloorPlate");
        }

        public void draw(Matrix w, Matrix v, Matrix p)
        {
            drawModel(model, w, v, p);
        }


        public static void ladeMethode()
        {
            //Model model1 = new Model();
        }

        public void ladeMethode2()
        {
         
        }
        */
        /*
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
        */
    }
}
