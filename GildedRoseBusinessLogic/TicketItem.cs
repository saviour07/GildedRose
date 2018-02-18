namespace GildedRoseBusinessLogic
{
    public class TicketItem : Item
    {
        public override string Name { get; set; } = "Ticket Item";

        public override void Update()
        {
            SellIn -= 1;

            if (SellIn <= 0)
            {
                Quality = 0;
            }
            else if (Quality < MaxQuality)
            {
                if (SellIn <= 5)
                {
                    Quality += 3;
                }
                else if (SellIn <= 10)
                {
                    Quality += 2;
                }
                else
                {
                    Quality += 1;
                }
            }
        }
    }
}
