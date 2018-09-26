using System;
using System.Collections.Generic;
using System.Text;

namespace _17605096_Task2_GADE6112
{
    class BuilderUnit
    {
        class BuilderUnit : Unit
        {
            private int xPos;

            public int XPos
            {
                get { return xpos; }
                set { xpos = value; }
            }
            private int yPos;

            public int YPos
            {
                get { return ypos; }
                set { ypos = value; }
            }
            private int health;

            public int Health
            {
                get { return health; }
                set { health = value; }
            }
            private int speed;

            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }
            private int build;

            public int Build
            {
                get { return build; }
                set { build = value; }
            }
            private int faction;

            public int Faction
            {
                get { return faction; }
                set { faction = value; }
            }
            private string image;

            public string Image
            {
                get { return image; }
                set { image = value; }
            }
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public BuilderUnit(string name, int x, int y, int health, int speed, int build, int faction, string image)
            {
                Name = name;
                xPos = x;
                yPos = y;
                Health = health;
                Speed = speed;
                Build = build;
                Faction = faction;
                Image = image;
            }
            public override void Move(Direction d)
            {
                switch (d)
                {
                    case Direction.North:
                        {
                            YPos -= Speed;
                            break;
                        }
                    case Direction.East:
                        {
                            XPos += Speed;
                            break;
                        }
                    case Direction.South:
                        {
                            YPos += Speed;
                            break;
                        }
                    case Direction.West:
                        {
                            XPos -= Speed;
                            break;
                        }
                }
            }
            private int DistanceTo(Unit u)
            {
                if (u.GetType() == typeof(BuilderUnit))
                {
                    BuilderUnit m = (BuilderUnit)u;
                    int d = Math.Abs(xPos - m.xPos) + Math.Abs(yPos - m.yPos);
                    return d;
                }
                else
                {
                    return 0;
                }
            }
            public override string ToString()
            {
                return "MU : " + xPos + "," + yPos + "," + Health;
            }

        }
    }
}
