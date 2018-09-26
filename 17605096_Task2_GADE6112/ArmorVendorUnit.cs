using System;
using System.Collections.Generic;
using System.Text;

namespace _17605096_Task2_GADE6112
{
    class ArmorVendorUnit
    {
        class ArmorVendorUnit : Unit
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
            private int replenish;

            public int Replenish
            {
                get { return replenish; }
                set { replenish = value; }
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

            public ArmorVendorUnit(string name, int x, int y, int health, int speed, int replenish, int faction, string image)
            {
                Name = name;
                xPos = x;
                yPos = y;
                Health = health;
                Speed = speed;
                Replenish = replenish;
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
            public override string ToString()
            {
                return "MU : " + xPos + "," + yPos + "," + Health;
            }
        }
    }
}