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
        private int stepSize = 2;
        public List<Creature> creatures = new List<Creature>();
        public List<FloorPlate> floorPlates = new List<FloorPlate>();
        public List<Wall> walls = new List<Wall>();

        public List<Player> players = new List<Player>();

        public GameEnvironment(ContentManager Content)
        {
            this.Content = Content;
        }

        public void add(string type)
        {
            switch (type)
            {
                case "ApeMonster":
                    creatures.Add(new Creature(type));
                    break;
                case "FloorPlate":
                    floorPlates.Add(new FloorPlate(type));
                    break;
                case "WallLeft":
                    walls.Add(new Wall(type));
                    break;
                case "WallRight":
                    walls.Add(new Wall(type));
                    break;
                case "WallFront":
                    walls.Add(new Wall(type));
                    break;
                case "WallBack":
                    walls.Add(new Wall(type));
                    break;
                case "Thing":
                    players.Add(new Player(type));
                    break;
            }
        }
        public void add(string type, int x, int y, int z)
        {
            switch (type)
            {
                case "ApeMonster":
                    creatures.Add(new Creature(type, new Vector3(x * stepSize, y * stepSize, z * stepSize)));
                    
                    break;
                case "FloorPlate":
                    floorPlates.Add(new FloorPlate(type, new Vector3(x * stepSize, y * stepSize, z * stepSize)));
                    break;
                case "WallLeft":
                    walls.Add(new Wall(type, new Vector3(x * stepSize, y * stepSize, z * stepSize)));
                    break;
                case "WallRight":
                    walls.Add(new Wall(type, new Vector3(x * stepSize, y * stepSize, z * stepSize)));
                    break;
                case "WallFront":
                    walls.Add(new Wall(type, new Vector3(x * stepSize, y * stepSize, z * stepSize)));
                    break;
                case "WallBack":
                    walls.Add(new Wall(type, new Vector3(x * stepSize, y * stepSize, z * stepSize)));
                    break;
                case "Thing":
                    players.Add(new Player(type, new Vector3(x * stepSize, y * stepSize, z * stepSize)));
                    break;
            }
        }

        public void loadContent()
        {
            foreach (Creature c in creatures)
                c.model = Content.Load<Model>(c.modelName);
            foreach (FloorPlate f in floorPlates)
                f.model = Content.Load<Model>(f.modelName);
            foreach (Wall w in walls)
                w.model = Content.Load<Model>(w.modelName);
            foreach (Player p in players)
                p.model = Content.Load<Model>(p.modelName);
        }

        public void draw(Matrix wo, Matrix vi, Matrix pr)
        {
            foreach (Creature c in creatures)
                drawModel(c.model, c.Position, wo, vi, pr);
            foreach (FloorPlate f in floorPlates)
                drawModel(f.model, f.Location, wo, vi, pr);
            foreach (Wall w in walls)
                drawModel(w.model, w.Location, wo, vi, pr);
            foreach (Player p in players)
                drawModel(p.model, p.Position, wo, vi, pr);
        }
        
        private void drawModel(Model model, Vector3 lp, Matrix world, Matrix view, Matrix projection)
        {
            foreach (ModelMesh mesh in model.Meshes)
            {
                foreach (BasicEffect effect in mesh.Effects)
                {
                    effect.EnableDefaultLighting();
                    //effect.World = world;
                    effect.World = Matrix.CreateTranslation(lp);
                    effect.View = view;
                    effect.Projection = projection;
                }

                mesh.Draw();
            }
        }
        
    }

    
}
