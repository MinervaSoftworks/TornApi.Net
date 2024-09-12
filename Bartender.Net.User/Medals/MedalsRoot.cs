﻿using Newtonsoft.Json;

namespace Bartender.Net.User.Medals;

public class MedalsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("medals_awarded")]
    public required List<int> MedalsAwarded { get; set; }

    [JsonProperty ("medals_time")]
    public required List<int> MedalsTime { get; set; }
}