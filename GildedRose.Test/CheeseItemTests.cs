using GildedRoseBusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Test
{
    [TestClass]
    public class CheeseItemTests
    {
        [TestMethod]
        public void CheeseItemQualityIncreasesAsSellInDecreases()
        {
            var cheeseItem = new CheeseItem
            {
                Name = "AgedBrie",
                SellIn = 10,
                Quality = 10
            };

            var oldQuality = cheeseItem.Quality;

            ManageInventory.ProcessItem(cheeseItem);

            Assert.AreEqual(oldQuality + 1, cheeseItem.Quality);
        }

        [TestMethod]
        public void CheeseItemQualityCannotExceedMaxQuality()
        {
            var cheeseItem = new CheeseItem
            {
                Name = "AgedBrie",
                SellIn = 10,
                Quality = 50
            };

            ManageInventory.ProcessItem(cheeseItem);

            Assert.AreEqual(cheeseItem.MaxQuality, cheeseItem.Quality);
        }
    }
}
