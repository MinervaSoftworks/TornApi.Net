﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class JobPointsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("jobpoints")]
    public required JobPointsCollection Points { get; set; }
}
