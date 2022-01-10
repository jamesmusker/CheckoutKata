namespace CheckoutKata.Entities
{
    public class Item
    {
        public Item(string sku, decimal unitPrice)
        {
            SKU = sku;
            UnitPrice = unitPrice;
        }

        public string SKU { get; private set; }
        public decimal UnitPrice { get; private set; }
    }
}