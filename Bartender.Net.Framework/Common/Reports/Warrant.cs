﻿using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Reports;

public class Warrant : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("user_id")]
    public required int UserID { get; set; }

    [JsonProperty ("warrant")]
    public required int Amount { get; set; }
}
