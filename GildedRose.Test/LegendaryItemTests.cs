using GildedRoseBusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Test
{
    [TestClass]
    public class LegendaryItemTests
    {
        [TestMethod]
        public void LegendaryItemsQualityDoesNotDegrade()
        {
            var legendaryItem = new LegendaryItem
            {
                Name = "Sulfuras",
                SellIn = 10,
                Quality = 10
            };

            var oldQuality = legendaryItem.Quality;

            ManageInventory.ProcessItem(legendaryItem);

            Assert.AreEqual(oldQuality, legendaryItem.Quality);
        }

        [TestMethod]
        public void LegendaryItemsSellInDoesNotDecrease()
        {
            var legendaryItem = new LegendaryItem
            {
                Name = "Sulfuras",
                SellIn = 10,
                Quality = 10
            };

            var oldSellIn = legendaryItem.SellIn;

            ManageInventory.ProcessItem(legendaryItem);

            Assert.AreEqual(oldSellIn, legendaryItem.SellIn);
        }
    }
}
