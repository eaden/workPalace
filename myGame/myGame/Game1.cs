using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace myGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //my own declares *******************************************
        private Model model;
        Creature c;
        Creature c1;
        Creature c2;

        private GameEnvironment underworld;
        //private 

        private Matrix world = Matrix.CreateTranslation(new Vector3(0, 0, 0));
        private Matrix view = Matrix.CreateLookAt(new Vector3(0, 6, 8), new Vector3(0, 0, 0), Vector3.UnitY);
        private Matrix projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45), 800f / 480f, 0.1f, 100f);

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //Creature.ladeMethode();
            
            //c.ladeMethode2();
            //Model model1;
            

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            //my own content **********************************************

            /*
            c = new Creature(Content, "ApeMonster");

            c.loadContent();

            c1 = new Creature(Content, "FloorPlate");

            c1.loadContent();

            c2 = new Creature(Content, "WallLeft");

            c2.loadContent();
            */
            underworld = new GameEnvironment(Content);
            underworld.add();
            underworld.loadContent();


            model = Content.Load<Model>("ApeMonster");

            Vector3 v1= new Vector3(0, 0, 0);
            Console.WriteLine(v1.X);
            //Vector3.Add(v1, (0,0,0));
            v1.X = 5;
            Console.WriteLine(v1.X);
            Console.WriteLine("fine");
            
            //model1 = Content.Load<Model>("ApeMonster");
        }
        
        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            //my own draw-stuff *********************************************************
            //DrawModel(model, world, view, projection);
            
            /*
            c.draw(world, view, projection);
            
            c1.draw(world, view, projection);
            world = Matrix.CreateTranslation(new Vector3(0, 0, 0));
            c2.draw(world, view, projection);
            world = Matrix.CreateTranslation(new Vector3(0, 0, 0));
            */

            underworld.draw(world, view, projection);

            base.Draw(gameTime);
        }


        // KOMISCHE METHODE. SCHNELL AUSBAUEN *******************************************
        private void DrawModel(Model model, Matrix world, Matrix view, Matrix projection)
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
