namespace CheckoutKata.Entities
{
    public class Checkout
    {
        private List<Item> _items = new List<Item>();
        private List<SpecialOffer> _offers;

        public Checkout()
        {
            _offers = new List<SpecialOffer>()
            {
                new SpecialOffer("A99", 3, 1.30M),
                new SpecialOffer("B15", 2, 0.45M)
            };
        }

        public IEnumerable<Item> Items => _items.AsReadOnly();

        public decimal Total()
        {
            if (Items.Count() == 0)
            {
                return 0M;
            }

            return Items.Sum(i => i.UnitPrice);
        }

        public void Scan(Item item)
        {
            _items.Add(item);
        }
    }
}