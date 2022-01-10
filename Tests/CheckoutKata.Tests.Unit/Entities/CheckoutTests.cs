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

        [Fact]
        public void TotalIsCorrectWithNoItems()
        {
            var checkout = new Checkout();
            decimal total = checkout.Total();

            total.Should().Be(0M);
        }

        [Fact]
        public void TotalIsCorrectWithSingleItem()
        {
            var checkout = new Checkout();
            var item = new Item("A99", 0.5M);

            checkout.Scan(item);
            decimal total = checkout.Total();
            total.Should().Be(0.5M);
        }

        [Fact]
        public void TotalIsCorrectWithMultipleItems()
        {
            var checkout = new Checkout();
            var item1 = new Item("A99", 0.5M);
            var item2 = new Item("B15", 0.3M);

            checkout.Scan(item1);
            checkout.Scan(item2);

            decimal total = checkout.Total();
            total.Should().Be(0.8M);
        }

        [Fact]
        public void TotalIsCorrectWithMultipleOfSingleItem()
        {
            var checkout = new Checkout();
            var item = new Item("A99", 0.5M);

            checkout.Scan(item);
            checkout.Scan(item);

            decimal total = checkout.Total();
            total.Should().Be(1M);
        }
    }
}