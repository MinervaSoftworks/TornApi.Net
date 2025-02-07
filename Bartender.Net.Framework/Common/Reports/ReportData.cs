﻿using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Reports;

public class ReportData : BartenderEntity {
    [JsonProperty ("bounties")]
    public virtual required List<string> Bounties { get; set; }

    [JsonProperty ("company_history")]
    public virtual required List<ReportReference> CompanyHistory { get; set; }

    [JsonProperty ("defense")]
    public required int Defense { get; set; }

    [JsonProperty ("dexterity")]
    public required int Dexterity { get; set; }

    [JsonProperty ("enemylist")]
    public virtual List<FriendOrFoeUser> Enemies { get; set; } = new List<FriendOrFoeUser> ();

    [JsonProperty ("faction_history")]
    public virtual required List<ReportReference> FactionHistory { get; set; }

    [JsonProperty ("friendlist")]
    public virtual required List<FriendOrFoeUser> Friends { get; set; }

    public virtual List<int> FriendIDs { get; set; } = new List<int> ();

    [JsonProperty ("invested_amount")]
    public required int InvestedAmount { get; set; }

    [JsonProperty ("invested_completion")]
    public required string InvestedCompletion { get; set; }

    [JsonProperty ("money")]
    public required int Money { get; set; }

    [JsonProperty ("otherlist")]
    public virtual required List<Warrant> Others { get; set; }

    [JsonProperty ("speed")]
    public required int Speed { get; set; }

    [JsonProperty ("strength")]
    public required int Strength { get; set; }

    [JsonProperty ("toplist")]
    public virtual required List<Warrant> Top { get; set; }

    [JsonProperty ("total_battlestats")]
    public required int TotalBattleStats { get; set; }

    [JsonProperty ("truelevel")]
    public required int TrueLevel { get; set; }
}
