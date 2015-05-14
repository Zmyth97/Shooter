using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter.Model
{
    public class KodyBeam
    {
        public Texture2D Texture;
        public Vector2 Position;
        public bool Active;
        public int Damage;
        private Viewport viewport;
        public int Width
        {
            get { return Texture.Width; }
        }
        public int Height
        {
            get { return Texture.Height; }
        }
        private float KodyBeamMoveSpeed;

        public KodyBeam()
        {
        }

        public void Initialize(Viewport viewport, Texture2D texture, Vector2 position)
        {
            Texture = texture;
            Position = position;
            this.viewport = viewport;

            Active = true;

            Damage = 20;

            KodyBeamMoveSpeed = 20f;
        }

        public void Update()
        {
            // Projectiles always move to the right
            Position.X += KodyBeamMoveSpeed;

            // Deactivate the bullet if it goes out of screen
            if (Position.X + Texture.Width / 2 > viewport.Width)
                Active = false;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f,
            new Vector2(Width / 2, Height / 2), .5f, SpriteEffects.None, 0f);
        }
    }
}
