﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    class Barrier
    { 
        public Coord coord { get; set; }
    }
     class car : Barrier
    {
        public float speed { get; set; }
    }
    class Boost : Barrier
    {
        public int jump { get; set; }
    }
}
