using GildedRoseBusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Test
{
    [TestClass]
    public class ConjuredItemTests
    {
        [TestMethod]
        public void ConjuredItemQualityDecreasesByTwo()
        {
            var conjuredItem = new ConjuredItem
            {
                SellIn = 10,
                Quality = 10
            };

            var oldQuality = conjuredItem.Quality;

            ManageInventory.ProcessItem(conjuredItem);

            Assert.AreEqual(oldQuality - 2, conjuredItem.Quality);
        }

        [TestMethod]
        public void SellInValueLessThanZeroConjuredItemQualityDegradesTwiceAsFast()
        {
            var conjuredItem = new ConjuredItem
            {
                SellIn = -1,
                Quality = 10
            };

            var oldQuality = conjuredItem.Quality;

            ManageInventory.ProcessItem(conjuredItem);

            Assert.AreEqual(oldQuality - 4, conjuredItem.Quality);
        }
    }
}
