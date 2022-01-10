namespace CheckoutKata.Entities
{
    public class SpecialOfferItem
        : Item
    {
        public SpecialOfferItem(string sku, decimal unitPrice)
            : base(sku, unitPrice) 
        {
            IsSpecialOffer = true;
        }
    }
}
