using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pathfinder_RPG_Class_Library.Items
{
    //Should an inventory be an item? Like, I as a player could have an inventory... that contains my backpack... that contains a canteen... that contains water.
    //If an inventory is an item, should it have a Money? Like, I don't wanna forget all my cash in my bandolier and wonder where all my wealth went.
    //I could keep a reference to a parent inventory inside this one and any time the Money changes in the child inventory it gets moved to the parent.

    /// <summary>
    /// An inventory. A collection of items.
    /// </summary>
    class Inventory
    {
        /// <summary>
        /// The items contained in this inventory.
        /// </summary>
        public List<Item> Items { get; set; }
        /// <summary>
        /// The money contained in this inventory.
        /// </summary>
        public Currency Money { get; set; }
        /// <summary>
        /// The weight this inventory can carry.
        /// </summary>
        public double WeightCapacity { get; set; }

        /// <summary>
        /// Removes the item's buyValue from the money and adds the item to the list of items.
        /// </summary>
        /// <param name="item"></param>
        public void BuyItem(Item item)
        {
            //If the inventory can afford it...
            if (Money.Value > item.BuyValue.Value)
            {
                Money.Subtract(item.BuyValue);
                Items.Add(item);
            }
        }
        /// <summary>
        /// Removes the item from the inventory and adds the items sellvalue to the inventory's money.
        /// </summary>
        /// <param name="item"></param>
        public void SellItem(Item item)
        {
            //If the inventory contains that item...
            if (Items.Contains(item))
            {
                Money.Add(item.SellValue);
                Items.Remove(item);
            }
        }


    }
}
