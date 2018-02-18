using GildedRoseBusinessLogic;
using System;
using System.Collections.Generic;

namespace GildedRoseApp
{
    public class GildedRoseInventory
    {
        public static void Main(string[] args)
        {
            var items = GenerateItems();

            Console.WriteLine("Input List");
            Console.WriteLine("==========================================");
            PrintItems(items);
            Console.WriteLine("==========================================");

            ManageInventory.ProcessItems(items);

            Console.WriteLine("Output List");
            Console.WriteLine("==========================================");
            PrintItems(items);
            Console.WriteLine("==========================================");

            Console.WriteLine();
            Console.WriteLine("Completed...");
            Console.ReadLine();
        }

        private static IList<Item> GenerateItems()
        {
            var items = new List<Item>
            {
                {
                    new CheeseItem
                    {
                        Name = "Aged Brie",
                        SellIn = 1,
                        Quality = 1
                    }
                },
                {
                    new TicketItem
                    {
                        Name = "Backstage Pass",
                        SellIn = -1,
                        Quality = 2
                    }
                },
                {
                    new TicketItem
                    {
                        Name = "Backstage Pass",
                        SellIn = 9,
                        Quality = 2
                    }
                },
                {
                    new LegendaryItem
                    {
                        Name = "Sulfuras",
                        SellIn = 2,
                        Quality = 2
                    }
                },
                {
                    new NormalItem
                    {
                        SellIn = -1,
                        Quality = 55
                    }
                },
                {
                    new NormalItem
                    {
                        SellIn = 2,
                        Quality = 2
                    }
                },
                {
                    new InvalidItem
                    {
                        SellIn = 2,
                        Quality = 2
                    }
                },
                {
                    new ConjuredItem
                    {
                        SellIn = 2,
                        Quality = 2
                    }
                },
                {
                    new ConjuredItem
                    {
                        SellIn = -1,
                        Quality = 5
                    }
                }
            };
            return items;
        }

        private static void PrintItems(IList<Item> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
