using Pathfinder_RPG_Class_Library.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_RPG_Class_Library.Classes
{
    class Fighter : CharacterClass
    {
        public Fighter()
        {
            Name = "Fighter";
            Role = "Fighters excel at combat—defeating their enemies, controlling the flow of battle, and surviving such sorties themselves. While their specific weapons and methods grant them a wide variety of tactics, few can match fighters for sheer battle prowess.";

            HitDie = new Die() { Quantity = 1, Sides = 10 };

        }
    }
}
