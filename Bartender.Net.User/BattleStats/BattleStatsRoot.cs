﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.BattleStats;

public class BattleStatsRoot : BartenderEntity {
    [JsonProperty ("strength")]
    public required long Strength { get; set; }

    [JsonProperty ("speed")]
    public required long Speed { get; set; }

    [JsonProperty ("dexterity")]
    public required long Dexterity { get; set; }

    [JsonProperty ("defense")]
    public required long Defense { get; set; }

    [JsonProperty ("total")]
    public required long Total { get; set; }

    [JsonProperty ("strength_modifier")]
    public required int StrengthModifier { get; set; }

    [JsonProperty ("defense_modifier")]
    public required int DefenseModifier { get; set; }

    [JsonProperty ("speed_modifier")]
    public required int SpeedModifier { get; set; }

    [JsonProperty ("dexterity_modifier")]
    public required int DexterityModifier { get; set; }

    [JsonProperty ("strength_info")]
    public required List<string> StrengthInfo { get; set; }

    [JsonProperty ("defense_info")]
    public required List<string> DefenseInfo { get; set; }

    [JsonProperty ("speed_info")]
    public required List<string> SpeedInfo { get; set; }

    [JsonProperty ("dexterity_info")]
    public required List<string> DexterityInfo { get; set; }
}
