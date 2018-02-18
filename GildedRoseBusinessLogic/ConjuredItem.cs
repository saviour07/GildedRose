namespace GildedRoseBusinessLogic
{
    public class ConjuredItem : Item
    {
        public override string Name { get; set; } = "Conjured Item";

        public override void Update()
        {
            SellIn -= 1;

            if (Quality > MaxQuality)
            {
                Quality = Quality;
            }
            else if (Quality > MinQuality)
            {
                var multiplier = SellIn <= 0 ? 2 : 1;
                Quality -= 2 * multiplier;
            }
        }
    }
}
