﻿using Bartender.Net.Faction.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Temporary;

public class TemporaryRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("temporary")]
    public required List<FactionLoanable> Loanables { get; set; }
}
