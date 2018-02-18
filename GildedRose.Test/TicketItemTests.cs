using GildedRoseBusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Test
{
    [TestClass]
    public class TicketItemTests
    {
        [TestMethod]
        public void TicketItemQualityIncreasesByOneWhenSellInDecreasesAndIsAboveTen()
        {
            var ticketItem = new TicketItem
            {
                Name = "BackstagePass",
                SellIn = 20,
                Quality = 10
            };

            var oldQuality = ticketItem.Quality;

            ManageInventory.ProcessItem(ticketItem);

            Assert.AreEqual(oldQuality + 1, ticketItem.Quality);
        }

        [TestMethod]
        public void TicketItemQualityIncreasesByTwoWhenSellInIsTenOrLess()
        {
            var ticketItem = new TicketItem
            {
                Name = "BackstagePass",
                SellIn = 10,
                Quality = 10
            };

            var oldQuality = ticketItem.Quality;

            ManageInventory.ProcessItem(ticketItem);

            Assert.AreEqual(oldQuality + 2, ticketItem.Quality);
        }

        [TestMethod]
        public void TicketItemQualityIncreasesByThreeWhenSellInIsFiveDaysOrLess()
        {
            var ticketItem = new TicketItem
            {
                Name = "BackstagePass",
                SellIn = 5,
                Quality = 10
            };

            var oldQuality = ticketItem.Quality;

            ManageInventory.ProcessItem(ticketItem);

            Assert.AreEqual(oldQuality + 3, ticketItem.Quality);
        }

        [TestMethod]
        public void TicketItemQualityDecreasesToZeroWhenSellInIsZero()
        {
            var ticketItem = new TicketItem
            {
                Name = "BackstagePass",
                SellIn = 0,
                Quality = 10
            };

            ManageInventory.ProcessItem(ticketItem);

            Assert.AreEqual(0, ticketItem.Quality);
        }
    }
}
