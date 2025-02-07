﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Market.ItemMarket;

public class ItemMarketRoot : BartenderEntity {
    [JsonProperty ("itemmarket")]
    public virtual required List<ItemListing> Items { get; set; }
}