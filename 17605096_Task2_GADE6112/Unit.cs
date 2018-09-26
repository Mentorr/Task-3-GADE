using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _17605096_Task2_GADE6112
{

        public enum Direction { North, East, South, West };
        [Serializable]
        public abstract class Unit
        {
            protected int XPos;
            protected int YPos;
            protected int xPosMove;
            protected int yPosMove;
            protected int Health;
            protected int Speed;
            protected int Attack;
            protected int Range;
            protected int Faction;
            protected string Image;
            protected string Name;

            abstract public void Move(Direction direction);
            abstract public void Combat(Unit u);
            abstract public bool InRange(Unit u);
            abstract public Unit Closest(Unit[] units);
            abstract public bool IsDead();

            public string toString()
        {
            return "X: " + XPos + "   Y: " + YPos + "   Health: " + Health + "   Speed: " + Speed + "   Attack: " + Attack + "   Range: " + Range + "   Faction: " + Faction;
        }

        public void save()
        {

        }


        }
    }
}
