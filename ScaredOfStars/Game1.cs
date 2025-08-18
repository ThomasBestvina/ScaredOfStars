using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ScaredOfStars
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _tilesetTexture;

        private const int TILE_SIZE = 18;
        private const int TILESET_COLUMNS = 16;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            
            _tilesetTexture = Content.Load<Texture2D>("scared-default");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            
            base.Update(gameTime);
        }

        private void DrawTile(int tileIndex, Vector2 position)
        {
            int tileX = (tileIndex % TILESET_COLUMNS) * TILE_SIZE;
            int tileY = (tileIndex / TILESET_COLUMNS) * TILE_SIZE;
            
            Rectangle sourceRectangle = new Rectangle(tileX, tileY, TILE_SIZE, TILE_SIZE);
            
            _spriteBatch.Draw(_tilesetTexture, position, sourceRectangle, Color.White);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            
            _spriteBatch.Begin();

            for (int i = 0; i < 30; i++)
            {
                DrawTile(1+i, new Vector2(100+20*i, 20));
            }

            _spriteBatch.End();
            base.Draw(gameTime);
        }

        
        
    }
}
