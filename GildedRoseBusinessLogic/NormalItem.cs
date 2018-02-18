namespace GildedRoseBusinessLogic
{
    public class NormalItem : Item
    {
        public override string Name { get; set; } = "Normal Item";

        public override void Update()
        {
            SellIn -= 1;

            if (Quality > MaxQuality)
            {
                Quality = MaxQuality;
            }
            else if (Quality > MinQuality)
            {
                var multiplier = SellIn <= 0 ? 2 : 1;
                Quality -= 1 * multiplier;
            }
        }
    }
}
