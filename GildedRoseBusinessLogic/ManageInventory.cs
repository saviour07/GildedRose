using System.Collections.Generic;

namespace GildedRoseBusinessLogic
{
    public static class ManageInventory
    {
        public static void ProcessItems(IList<Item> items)
        {
            foreach (var item in items)
            {
                ProcessItem(item);
            }
        }

        public static void ProcessItem(Item item)
        {
            if (item is InvalidItem)
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
