using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4
{
    class HighScore
    {
        public static string name;
        public static int turns;
        public HighScore()
        {
            name = Player.name;
            turns = Player.turns;
        }
    }
}
