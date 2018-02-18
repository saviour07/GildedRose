using GildedRoseBusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Test
{
    [TestClass]
    public class InvalidItemTests
    {
        [TestMethod]
        public void InvalidItemIsInvalidatedWhenProcessed()
        {
            var invalidItem = new InvalidItem
            {
                SellIn = 10,
                Quality = 10
            };

            Assert.IsTrue(invalidItem.IsValid);

            ManageInventory.ProcessItem(invalidItem);

            Assert.IsFalse(invalidItem.IsValid);
            Assert.AreEqual(0, invalidItem.SellIn);
            Assert.AreEqual(0, invalidItem.Quality);
        }
    }
}
