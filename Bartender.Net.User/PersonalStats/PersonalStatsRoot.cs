﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.PersonalStats;

public class PersonalStatsRoot {
    [JsonProperty ("personalstats")]
    public required PersonalStatsEntry PersonalStats { get; set; }
}