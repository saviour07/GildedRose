using GildedRoseBusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Test
{
    [TestClass]
    public class NormalItemTests
    {
        [TestMethod]
        public void ItemQualityCannotExceedMaxValue()
        {
            var normalItem = new NormalItem
            {
                SellIn = 10,
                Quality = 100
            };

            ManageInventory.ProcessItem(normalItem);

            Assert.AreEqual(normalItem.MaxQuality, normalItem.Quality);
        }

        [TestMethod]
        public void ItemQualityCannotDecreaseBelowMinValue()
        {
            var normalItem = new NormalItem
            {
                SellIn = 10,
                Quality = 0
            };

            ManageInventory.ProcessItem(normalItem);

            Assert.AreEqual(normalItem.MinQuality, normalItem.Quality);
        }

        [TestMethod]
        public void NormalItemQualityDecreasesByOne()
        {
            var normalItem = new NormalItem
            {
                SellIn = 10,
                Quality = 10
            };

            var oldQuality = normalItem.Quality;

            ManageInventory.ProcessItem(normalItem);

            Assert.AreEqual(oldQuality - 1, normalItem.Quality);
        }

        [TestMethod]
        public void SellInValueLessThanZeroNormalItemQualityDegradesTwiceAsFast()
        {
            var normalItem = new NormalItem
            {
                SellIn = -1,
                Quality = 10
            };

            var oldQuality = normalItem.Quality;

            ManageInventory.ProcessItem(normalItem);

            Assert.AreEqual(oldQuality - 2, normalItem.Quality);
        }
    }
}
