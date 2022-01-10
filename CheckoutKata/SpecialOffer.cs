namespace CheckoutKata
{
    public class SpecialOffer
    {
        public SpecialOffer(string sku, int quantity, decimal unitPrice)
        {
            SKU = sku;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public string SKU { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
    }
}