namespace CheckoutKata.Entities
{
    public class Item
    {
        public Item(string sku, decimal unitPrice)
        {
            SKU = sku;
            UnitPrice = unitPrice;

            IsSpecialOffer = false;
        }

        public string SKU { get; private set; }
        public decimal UnitPrice { get; private set; }
        public bool IsSpecialOffer { get; protected set; }
    }
}