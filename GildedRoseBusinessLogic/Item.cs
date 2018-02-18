namespace GildedRoseBusinessLogic
{
    public abstract class Item
    {
        public readonly int MaxQuality = 50;
        public readonly int MinQuality = 0;

        public virtual string Name { get; set; }
        public virtual int SellIn { get; set; }
        public virtual int Quality { get; set; }
        public virtual bool IsValid { get; set; } = true;

        public abstract void Update();

        public virtual void Invalidate()
        {
            IsValid = false;
            SellIn = 0;
            Quality = 0;
        }

        public override string ToString()
        {
            return IsValid ? $"{Name} {SellIn} {Quality}" : "NO SUCH ITEM";
        }
    }
}
