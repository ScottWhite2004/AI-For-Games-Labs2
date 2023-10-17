using AI_For_Games_Lab.Shapes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.ImGui;
using System.Collections.Generic;


namespace AI_For_Games_Lab
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private ShapeBatcher _shapeBatcher;
        private ImGuiRenderer _guiRenderer;
        private List<Shape> _shapes;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _shapeBatcher = new ShapeBatcher(this);
            _guiRenderer = new ImGuiRenderer(this).Initialize().RebuildFontAtlas();
            _shapes = new List<Shape>();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _shapes.Add(new Circle(new Vector2(100, 100), Color.Red, 30));
            _shapes.Add(new Circle(new Vector2(200, 150), Color.Red, 20));
            _shapes.Add(new Circle(new Vector2(100, 150), Color.Red, 25));
            _shapes.Add(new Shapes.Rectangle(new Vector2(400, 300), Color.Red, 50, 25));
            _shapes.Add(new Shapes.Rectangle(new Vector2(500, 500), Color.Red, 100, 100));
            _shapes.Add(new Shapes.Rectangle(new Vector2(100, 200), Color.Red, 100, 25));
            _shapes.Add(new Triangle(new Vector2(200, 200), Color.Red, new Vector2(300, 300), new Vector2(150, 100)));
            _shapes.Add(new Polygon(new Vector2(300, 300), Color.Red, new List<Vector2> { new Vector2(400, 350), new Vector2(100, 75), new Vector2(250, 200) }));



            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            Vector2 mousePointInShapeSpace = Mouse.GetState().Position.ToVector2().FlipY(GraphicsDevice.Viewport.Height);

            foreach (Shape shape in _shapes)
            {
                if (shape.isInside(mousePointInShapeSpace))
                {
                    shape.Colour = Color.Green;
                }
                else
                {
                    shape.Colour = Color.Red;
                }
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _shapeBatcher.Begin();
            foreach (Shape shape in _shapes)
            {
                _shapeBatcher.Draw(shape);
            }
            _shapeBatcher.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}