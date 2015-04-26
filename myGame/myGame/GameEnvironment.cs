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
        private List<Creature> creatures = new List<Creature>();
        private List<FloorPlate> floorPlates = new List<FloorPlate>();
        private List<Wall> walls = new List<Wall>();

        public GameEnvironment(ContentManager Content)
        {
            this.Content = Content;
        }

        public void add(string typ)
        {
            switch(typ)
            {
                case "ApeMonster":
                    creatures.Add(new Creature(Content, typ));
                    break;
                case "FloorPlate":
                    floorPlates.Add(new FloorPlate(Content, typ));
                    break;
                case "WallLeft":
                    walls.Add(new Wall(Content, typ));
                    break;
            }
            this.loadContent();
        }

        public void loadContent()
        {
            foreach (Creature c in creatures)
                c.model = Content.Load<Model>(c.modelName);
            foreach (FloorPlate f in floorPlates)
                f.model = Content.Load<Model>(f.modelName);
            foreach (Wall w in walls)
                w.model = Content.Load<Model>(w.modelName);
        }

        public void draw(Matrix wo, Matrix vi, Matrix pr)
        {
            foreach (Creature c in creatures)
                drawModel(c.model, wo, vi, pr);
            foreach (FloorPlate f in floorPlates)
                drawModel(f.model, wo, vi, pr);
            foreach (Wall w in walls)
                drawModel(w.model, wo, vi, pr);
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
