using System;
using System.Collections.Generic;
using System.Text;

namespace _17605096_Task2_GADE6112
{
    class DefenseTowerBuilding
    {
        class DefenseTowerBuilding : Building
        {
            private string xPos;
            public int XPos//This saves the X position of the Melee Unit
            {
                get { return XPos; }
                set { XPos = value; }
            }

            private int yPos
            public int YPos//This saves the Y Position of the Melee Unit
            {
                get { return YPos; }
                set { YPos = value; }
            }

            private int health
            public int Health//This would save the health of the melee Unit which is capped at 20
            {
                get { return Health; }
                set { Health = value; }
            }

            private int attack;
            public int Attack//This saves the amount of damage that the unit can inflict to the enemy
            {
                get { return Attack; }
                set { Attack = value; }
            }

            private int range;
            public int Range//This is how close the melee unit has to be in order to attack
            {
                get { return Range; }
                set { Range = value; }
            }

            private int faction;
            public int Faction//This stores the allaigence of the unit
            {
                get { return Faction; }
                set { Faction = value; }
            }

            private string image;
            public string Image // this is the colour of the team
            {
                get { return Image; }
                set { Image = value; }
            }

            private string name;
            public string Name
            {
                get { return Name; }
                set { Name = value; }
            }
        }
    }
}
