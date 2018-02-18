namespace GildedRoseBusinessLogic
{
    public class CheeseItem : Item
    {
        public override string Name { get; set; } = "Cheese Item";

        public override void Update()
        {
            SellIn -= 1;

            if (Quality < MaxQuality)
            {
                Quality += 1;
            }
        }
    }
}
