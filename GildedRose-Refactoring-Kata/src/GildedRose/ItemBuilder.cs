using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GildedRose
{
    public class ItemBuilder
    {
        private readonly Item _item;

        public static ItemBuilder Create()
        {
            return new ItemBuilder();
        }

        private ItemBuilder()
        {
            _item = new Item(); 
        }

        public ItemBuilder WithName(string name) 
        {
            _item.Name = name;
            return this; 
        }

        public ItemBuilder WithSellIn(int sellIn)
        {
            _item.SellIn = sellIn;
            return this;
        }

        public ItemBuilder WithQuality(int quality)
        {
            _item.Quality = quality;
            return this;
        }

        public Item Build()
        {
            return _item; 
        }
    }
}
