using System;
using System.Collections.Generic;
using System.Text;

namespace _17605096_Task2_GADE6112
{
    abstract class Building
        {
            protected int X;
            protected int Y;
            protected int Health;
            protected int Faction;
            protected string Image;

            abstract public bool death();
            abstract public void construct();

        public string tostring()
        {
            return "X: " + X + "    Y: " + Y + "    Health: " + Health + "  Faction: " + Faction;
        }

        

        }
    }
}
