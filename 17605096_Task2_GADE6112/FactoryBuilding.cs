using System;
using System.Collections.Generic;
using System.Text;

namespace _17605096_Task2_GADE6112
{
    class FactoryBuilding
    {
        class FactoryBuilding : Building
        {
            private int x;                          //x,y,health,faction,image

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

            private int toproduce;
            private int ttp; //time to produce (derived from ttk, meaning time to kill)
            private int spawnx;
            private int spawny;

            public void spawn()
            {
                spawnx = X;
                spawny = Y; //unit will spawn outside of the factory
                int totttp; //total time to produce
                totttp = ttp * toproduce;

                for (int i = 1; i < totttp; i++)
                {
                    System.Timers.Timer aTimer = new System.Timers.Timer();
                    aTimer.Elapsed += ATimer_Elapsed;
                    aTimer.Interval = totttp*1000;
                    aTimer.Enabled = true;
                }

            }

            private void ATimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
            {
                Unit Soldier;
            }
        }
    }
}
