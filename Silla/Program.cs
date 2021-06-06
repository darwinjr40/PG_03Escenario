using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(600, 600, "GAME OPENTK");
            game.Run(60);//1/60
        }
    }
}
