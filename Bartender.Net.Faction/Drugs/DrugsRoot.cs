﻿using Bartender.Net.Faction.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Drugs;

public class DrugsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("caches")]
    public required List<FactionArmoryItem> Items { get; set; }
}
