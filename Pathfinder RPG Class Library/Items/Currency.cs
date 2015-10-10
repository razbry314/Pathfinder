using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pathfinder_RPG_Class_Library.Items
{
    /// <summary>
    /// Represents a value in coins. 10cp = 1sp and so on.
    /// </summary>
    class Currency
    {
        /// <summary>
        /// Creates a new Currency value.
        /// </summary>
        /// <param name="Value"></param>
        public Currency(int Value = 0)
        {
            this.Value = Value;
        }

        /// <summary>
        /// The total value, measured in copper.
        /// </summary>
        public int Value { get; set; }
        public int CopperCount { get {return Value - PlatinumCount * 1000 - GoldCount * 100 - SilverCount * 10; }}
        public int SilverCount { get {return (Value - PlatinumCount * 1000 - GoldCount * 100)/10;}}
        public int GoldCount { get {return (Value - PlatinumCount * 1000)/100;}}
        public int PlatinumCount { get {return Value/1000;}}

        /// <summary>
        /// The weight of the value of the money if perfectly reduced so all denominations below platinum are <10. Weight of coins is set privately in this class.
        /// </summary>
        public double CoinWeight { get { return (CopperCount + SilverCount + GoldCount + PlatinumCount) / numberOfCoinsToWeighOnePound; }}
        /// <summary>
        /// The number of coins required to have a weight of one pound.
        /// </summary>
        private static int numberOfCoinsToWeighOnePound = 50;

        /// <summary>
        /// Add a value to this value.
        /// </summary>
        /// <param name="added"></param>
        public void Add(Currency added)
        {
            Value += added.Value;
        }

        /// <summary>
        /// Subtract a value from this value.
        /// </summary>
        /// <param name="subtracted"></param>
        public void Subtract(Currency subtracted)
        {
            Value -= subtracted.Value;
        }

        /// <summary>
        /// Add a value specified by the number of coins to this value.
        /// </summary>
        /// <param name="Copper"></param>
        /// <param name="Silver"></param>
        /// <param name="Gold"></param>
        /// <param name="Platinum"></param>
        public void AddCoins(int Copper = 0, int Silver = 0, int Gold = 0, int Platinum = 0)
        {
            Value += Copper;
            Value += Silver * 10;
            Value += Gold * 100;
            Value += Platinum * 1000;
        }

        /// <summary>
        /// Subtract a value specified by the number of coins from this value.
        /// </summary>
        /// <param name="Copper"></param>
        /// <param name="Silver"></param>
        /// <param name="Gold"></param>
        /// <param name="Platinum"></param>
        public void RemoveCoins(int Copper = 0, int Silver = 0, int Gold = 0, int Platinum = 0)
        {
            Value -= Copper;
            Value -= Silver * 10;
            Value -= Gold * 100;
            Value -= Platinum * 1000;
        }
    }
}
