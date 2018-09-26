using System;
using System.Collections.Generic;
using System.Text;

namespace _17605096_Task2_GADE6112
{
    class HealerUnit
    {
        class HealerUnit : Unit
        {
            private int xPos;

            public int XPos
            {
                get { return xPos; }
                set { xPos = value; }
            }

            private int yPos;

            public int YPos
            {
                get { return yPos; }
                set { yPos = value; }
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

            private int heal;

            public int Heal
            {
                get { return heal; }
                set { heal = value; }
            }

            private int healrange;

            public int HealRange
            {
                get { return healrange; }
                set { healrange = value; }
            }

            private string faction;

            public string Faction
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

            public HealerUnit(string name, int x, int y, int health, int heal, int healrange, string faction, string image)
            {
                Name = name;
                xPos = x;
                yPos = y;
                Health = health;
                Speed = speed;
                Heal = heal;
                HealRange = healrange;
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

            public override void INeedHealing(Unit u)
            {
                if (u.GetType() == typeof(HealerUnit))
                {
                    Health = ((HealerUnit)u).Heal;
                }
            }

            public override bool InRange(Unit u)
            {
                if (DistanceTo(u) >= Range)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            private int DistanceTo(Unit u)
            {
                if (u.GetType() == typeof(HealerUnit))
                {
                    HealerUnit m = (HealerUnit)u;
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

            public override bool IsDead()
            {
                throw new NotImplementedException();
            }
        }
}