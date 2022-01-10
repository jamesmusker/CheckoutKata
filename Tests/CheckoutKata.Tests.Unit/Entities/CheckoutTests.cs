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

        [Fact]
        public void CanAddMultipleItems()
        {
            var checkout = new Checkout();
            var item1 = new Item("A99", 0.5M);
            var item2 = new Item("B15", 0.3M);

            checkout.Scan(item1);
            checkout.Scan(item2);

            checkout.Items.Count()
                .Should()
                .Be(2);
        }
    }
}