﻿using Newtonsoft.Json;

namespace Bartender.Net.Models.Market;

public class PointListing {
    [JsonIgnore]
    public  int ID { get; set; }

    [JsonProperty ("cost")]
    public required int Cost { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("total_cost")]
    public required int TotalCost { get; set; }
}
