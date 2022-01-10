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
            var offer = (from o in _offers
                        where o.SKU == item.SKU
                        select o).FirstOrDefault();

            int itemCount = Items.Count(i => i.SKU == item.SKU && !i.IsSpecialOffer) + 1;
            if (itemCount >= offer?.Quantity)
            {
                _items.RemoveAll(i => i.SKU == offer.SKU && !i.IsSpecialOffer);
                _items.Add(new SpecialOfferItem(item.SKU, offer.UnitPrice));
            }
            else
            {
                _items.Add(item);
            }
        }
    }
}