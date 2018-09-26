using System;
using System.Collections.Generic;
using System.Text;

namespace _17605096_Task2_GADE6112
{
    class RangedClass
    {
        class RangedClass : Unit
        {
            public int xPos//This saves the X position of the Melee Unit
            {
                get { return XPos; }
                set { XPos = value; }
            }

            public int yPos//This saves the Y Position of the Melee Unit
            {
                get { return YPos; }
                set { YPos = value; }
            }

            public int Meleehealth//This would save the health of the melee Unit which is capped at 20
            {
                get { return Health; }
                set { Health = value; }
            }

            public int speed //This is the speed that the Melee Unit is able to attack with
            {
                get { return Speed; }
                set { Speed = value; }
            }

            public int attack//This saves the amount of damage that the unit can inflict to the enemy
            {
                get { return Attack; }
                set { Attack = value; }
            }

            public int projectileRange//This is how close the melee unit has to be in order to attack
            {
                get { return Range; }
                set { Range = value; }
            }

            public int faction//This stores the allaigence of the unit
            {
                get { return Faction; }
                set { Faction = value; }
            }

            public string image // this is the colour of the team
            {
                get { return Image; }
                set { Image = value; }
            }

            public string name
            {
                get { return Name; }
                set { Name = value; }
            }


            public RangedClass(string name, int x, int y, int health, int attack, int speed, int range, int faction, string image)
            {
                Name = name;
                xPos = x;
                yPos = y;
                Health = health;
                Speed = speed;
                Attack = attack;
                Range = range;
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

            public override void Combat(Unit u)
            {
                if (u.GetType() == typeof(RangedClass))
                {
                    Health = ((RangedClass)u).Attack;
                }
                //else if (u.GetType() == typeof(RangedClass))
                //{
                //    Health = ((RangedClass)u).Attack;
                //}
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

            public override Unit Closest(Unit[] units)
            {
                Unit closest = this;
                int closestDistance = 50;
                foreach (Unit u in units)
                {
                    //if(u.GetHashCode() == typeof(MeleeUnit))
                    //{
                    if (((RangedClass)u).Faction != Faction)
                    {
                        if (DistanceTo((RangedClass)u) < closestDistance)
                        {
                            closest = u;
                            closestDistance = DistanceTo((RangedClass)u);
                        }
                    }
                    //}
                    //else if (u.GetHashCode() == typeof(RangedClass))
                    //{
                    //    if (DistanceTo((RangedClass)u) < closestDistance)
                    //    {
                    //        closest = u;
                    //        closestDistance = DistanceTo((RangedClass)u);
                    //    }
                    //}
                }
                return closest;
            }

            public override void Death()
            {

            }

            private int DistanceTo(Unit u)
            {
                if (u.GetType() == typeof(RangedClass))
                {
                    RangedClass m = (RangedClass)u;
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

            public override string toString()
            {
                throw new NotImplementedException();
            }
        }
    }
}
