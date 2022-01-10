using CheckoutKata.Entities;
using FluentAssertions;
using System.Linq;
using Xunit;

namespace CheckoutKata.Tests.Unit.Entities
{
    public class CheckoutTests
    {
        [Fact]
        public void CanAddItem()
        {
            var checkout = new Checkout();
            var item = new Item("A99", 0.5M);

            checkout.Scan(item);
            checkout.Items.Count()
                .Should()
                .Be(1);
        }
    }
}
