using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter.Model
{
    public class Player
    {
        public Vector2 Position;
        public Animation PlayerAnimation;
        private Texture2D playerTexture;
        private bool active;
        private int health;


        //Region Getters and Setters
        public Texture2D PlayerTexture
        {
            get { return playerTexture; }
            set { playerTexture = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Width
        {
            get { return PlayerAnimation.FrameWidth; }
        }

        public int Height
        {
            get { return PlayerAnimation.FrameHeight; }
        }
        //End Region

        public void Initialize(Animation animation, Vector2 position)
        {
            this.PlayerAnimation = animation;

            // Set the starting position of the player around the middle of the screen and to the back
            Position = position;

            // Set the player to be active
            this.active = true;

            // Set the player health
            this.health = 100;
        }

        public void Update(GameTime gameTime)
        {
            PlayerAnimation.Position = Position;
            PlayerAnimation.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            PlayerAnimation.Draw(spriteBatch);
        }
    }
}
