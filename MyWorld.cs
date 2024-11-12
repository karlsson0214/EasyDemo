using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyDemo;
using EasyMonoGame;

namespace EasyStart
{
    internal class MyWorld : World
    {
        //objektvariabler
        //fields
        private Random random = new Random();
        public MyWorld() : base(800, 600)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "sand2";

            Add(new Crab(), "crab", 400, 300);
            Add(new Lobster(), "lobster", 200, 300);
            Add(new Lobster(), "lobster", 600, 300);

            for (int i = 0; i < 10; i++)
            {
                Add(new Worm(), "worm", random.Next(800), random.Next(600));
            }
        }  
    }
}
