namespace CheckoutKata.Entities
{
    public class Checkout
    {
        private List<Item> _items = new List<Item>();

        public IEnumerable<Item> Items => _items.AsReadOnly();

        public decimal Total()
        {
            return 0M;
        }

        public void Scan(Item item)
        {

        }
    }
}