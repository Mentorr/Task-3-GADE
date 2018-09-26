using System;
using System.Collections.Generic;
using System.Text;

namespace _17605096_Task2_GADE6112
{
        public class Map
        {
            private Unit[] units;
            Random r = new Random();

            public Unit[] Units
            {
                get { return units; }
                set { units = value; }
            }

            //numUnits is number of units in total for all teams and all unit types.
            public Map(int maxX, int maxY, int numUnits)
            {
                units = new Unit[numUnits];
                for (int i = 0; i < numUnits; i++)
                {
                    if (i % 2 == 0)
                    {
                        MeleeUnit m = new MeleeUnit(r.Next(0, maxX), r.Next(0, maxY), r.Next(5, 10) * 10, r.Next(5, 20), 1, 1, i % 2, "M");
                        Units[i] = m;
                    }
                }
            }



        }
    }

