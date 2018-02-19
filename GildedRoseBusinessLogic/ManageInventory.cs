using System;
using System.Collections.Generic;

namespace GildedRoseBusinessLogic
{
    public static class ManageInventory
    {
        private static readonly List<Type> ValidItems = new List<Type>
        {
            typeof(CheeseItem),
            typeof(ConjuredItem),
            typeof(LegendaryItem),
            typeof(NormalItem),
            typeof(TicketItem)
        };

        public static void ProcessItems(IList<Item> items)
        {
            foreach (var item in items)
            {
                ProcessItem(item);
            }
        }

        public static void ProcessItem(Item item)
        {
            if (!ValidItems.Contains(item.GetType()))
            {
                item.Invalidate();
            }
            else
            {
                item.Update();
            }
        }
    }
}
