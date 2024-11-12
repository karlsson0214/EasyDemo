using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDemo
{
    internal class Crab : Actor
    {
        private float speed = 400f;
        private float rotationSpeed = 180f;
        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                Turn(-rotationSpeed * deltaTime);
            }
            if (keyboardState.IsKeyDown(Keys.Right))
            {
                Turn(rotationSpeed * deltaTime);
            }
            if (keyboardState.IsKeyDown(Keys.Up))
            {
                Move(speed * deltaTime);
            }
            if ( IsTouching(typeof(Worm)))
            {
                RemoveTouching(typeof(Worm));
                World.ShowText("Yummy!",100, 100);
            }

        }
    }
}
