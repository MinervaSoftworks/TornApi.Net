﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Territory;

public class Racket : BartenderEntity {
    [JsonProperty ("changed")]
    public required int Changed { get; set; }

    [JsonProperty ("created")]
    public required int Created { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("reward")]
    public required string Reward { get; set; }
}
