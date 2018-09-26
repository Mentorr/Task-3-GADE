using System;
using System.Collections.Generic;
using System.Text;

namespace _17605096_Task2_GADE6112
{
    class ResourceBuilding
    {
        class ResourceBuilding : Building
        {
            private int x;

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            private int y;

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            private int health;

            public int Health
            {
                get { return health; }
                set { health = value; }
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

            public override string ToString()
            {
                return base.ToString();
            }

            public override bool death()
            {
                throw new NotImplementedException();
            }

            private string resType;
            private int respertick;
            private int resremain;

            public void resourcehandle(int x, int y, int health, int faction, string image)
            {
                X = x;
                Y = y;
                Health = health;
                Faction = faction;
                Image = image;
                resremain = resremain + respertick;
            }

            public override void construct()
            {
                throw new NotImplementedException();
            }

            public override string tostring()
            {
                throw new NotImplementedException();
            }
        }
    }
}
