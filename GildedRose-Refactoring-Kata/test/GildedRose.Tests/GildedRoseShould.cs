using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class GildedRoseShould
    {

        [Fact]
        public void
        decrements_sellIn_and_quality_each_day()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Items[0].SellIn.Should().Be(0);
            Items[0].Quality.Should().Be(0);
        }

        [Fact]
        public void
        decrements_quality_twice_as_fast_when_sellIn_has_passed()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 2 } };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Items[0].Quality.Should().Be(0);
        }

    }
}
