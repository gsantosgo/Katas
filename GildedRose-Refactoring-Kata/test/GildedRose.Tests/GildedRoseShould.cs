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
            Item anyItem = ItemBuilder.Create()
                                .WithName("foo")
                                .WithSellIn(1)
                                .WithQuality(1)
                                .Build(); 

            IList<Item> Items = new List<Item> { anyItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Items[0].SellIn.Should().Be(0);
            Items[0].Quality.Should().Be(0);
        }

        [Fact]
        public void
        decrements_quality_twice_as_fast_when_sellIn_has_passed()
        {
            Item anyItem = ItemBuilder.Create()
                            .WithName("foo")
                            .WithSellIn(0)
                            .WithQuality(2)
                            .Build(); 

            IList<Item> Items = new List<Item> { anyItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Items[0].Quality.Should().Be(0);
        }

    }
}
