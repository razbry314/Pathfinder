using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pathfinder_RPG_Class_Library.Dice
{
    class Die
    {
        /// <summary>
        /// The number of dice you're rolling. The a value in adb+c.
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// The number of sides the dice have. The b value in adb+c.
        /// </summary>
        public int Sides { get; set; }
        /// <summary>
        /// The modifier added to a die roll. The c value in adb+c
        /// </summary>
        public int Modifier { get; set; }
        /// <summary>
        /// The number of low rolls dropped when rolling multiple dice. Really only used when calculating ability scores.
        /// </summary>
        public int DropLowest { get; set; }
        /// <summary>
        /// Rolls the dice with parameters in this instantiated object.
        /// </summary>
        /// <returns></returns>
        public int Roll()
        {
            int result = 0;
            if (DropLowest > 0)
            {
                List<int> results = new List<int>();
                for (int i = 0; i < Quantity; i++)
                {
                    results.Add(StaticRandom.NextInt(Sides));
                }
                results.Sort();
                for (int i = 0; i < DropLowest; i++)
                {
                    results.RemoveAt(results.Count);
                }
                foreach (int roll in results)
                {
                    result += roll;
                }
            }
            else
            {
                for (int i = 0; i < Quantity; i++)
                {
                    result += StaticRandom.NextInt(Sides);
                }
            }
            result += Modifier;
            return result;
        }
    }
}
