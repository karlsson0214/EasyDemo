using EasyMonoGame;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDemo
{
    internal class Lobster : Actor
    {
        private float speed = 200f;
        private Random random = new Random();
        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            Move(speed * deltaTime);
            if (IsAtEdge())
            {
                Turn(random.Next(180));
            }

        }
    }
}
